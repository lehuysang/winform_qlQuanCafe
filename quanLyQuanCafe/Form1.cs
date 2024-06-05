using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyQuanCafe
{
    public partial class Form1 : Form
    {
        string chuoiKetNoi = "Data Source=LAPTOP-VSJT7638;Initial Catalog=QLCafe;Integrated Security=True;";
        SqlConnection conn = null;

        Button button_check = null;
        List<Button> list_buttons = new List<Button>();

        Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            numericSoLuong.Value = 1;
            Button button_check = new Button();
            buttons = new Button[] { ban1, ban2, ban3, ban4, ban5, ban6, ban7, ban8, ban9 };
        }

        private void load_dulieu()
        {
            try
            {
                conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_dulieu();

            LoadComBoBox(cbbLoai, "select MaLoai, TenLoai from LoaiMonAN", "TenLoai", "MaLoai");
            cbbLoai.SelectedIndexChanged += cbbLoai_SelectedIndexChanged;
            cbbLoai_SelectedIndexChanged(cbbLoai, EventArgs.Empty);
        }

        private void LoadComBoBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt  = new DataTable();
            da.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbLoai.SelectedValue != null)
            {
                string MaLoai_cbb = cbbLoai.SelectedValue.ToString();
                string sql_MonAn = $"select MaMonAn,TenMonAn from MonAn where MaLoai = '{MaLoai_cbb}'";
                LoadComBoBox(cbbMonAn, sql_MonAn, "TenMonAn", "MaMonAn");
            }
        }

        private void hienthi_monan(Button button)
        {
            if (list_buttons.Contains(button))
            {
                var sql_hienthi = $@"
                SELECT ma.TenMonAn, ma.DonGia, hdct.SoLuong, hdct.TongTien 
                FROM MonAn ma
                JOIN HoaDonChiTiet hdct ON ma.MaMonAn = hdct.MaMonAn
                JOIN HoaDon hd ON hdct.MaHoaDon = hd.MaHoaDon
                WHERE hdct.SoBan = '{button.Name}' AND hd.TrangThai = N'chưa thanh toán'";

                var da = new SqlDataAdapter(sql_hienthi, conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                decimal tongTien = 0;
                for(int i = dt.Rows.Count - 1; i>=0  ; i--)
                {
                    tongTien = Convert.ToDecimal(dt.Rows[i]["TongTien"]);
                    btnTongTien.Text = tongTien.ToString();
                    return;
                }
                
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void ban1_Click(object sender, EventArgs e)
        {
            button_check = ban1;
            hienthi_monan(ban1);
        }

        private void ban2_Click(object sender, EventArgs e)
        {
            button_check = ban2;
            hienthi_monan(ban2);
        }

        private void ban3_Click(object sender, EventArgs e)
        {
            button_check = ban3;
            hienthi_monan(ban3);
        }

        private void ban4_Click(object sender, EventArgs e)
        {
            button_check = ban4;
            hienthi_monan(ban4);
        }

        private void ban5_Click(object sender, EventArgs e)
        {
            button_check = ban5;
            hienthi_monan(ban5);
        }

        private void ban6_Click(object sender, EventArgs e)
        {
            button_check = ban6;
            hienthi_monan(ban6);
        }

        private void ban7_Click(object sender, EventArgs e)
        {
            button_check = ban7;
            hienthi_monan(ban7);
        }

        private void ban8_Click(object sender, EventArgs e)
        {
            button_check = ban8;
            hienthi_monan(ban8);
        }

        private void ban9_Click(object sender, EventArgs e)
        {
            button_check = ban9;
            hienthi_monan(ban9);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (button_check != null)
            {
                var maHoaDon = 0;
                if (!list_buttons.Contains(button_check))
                {
                    button_check.BackColor = Color.Gray;
                    button_check.Text = button_check.Text.Replace("Trống", "Có người");
                    list_buttons.Add(button_check);

                    var sql_maHoaDon = "SELECT ISNULL(MAX(MaHoaDon), 0) + 1 FROM HoaDon";
                    using (var cm_maHoaDon = new SqlCommand(sql_maHoaDon, conn))
                    {
                        maHoaDon = (int)cm_maHoaDon.ExecuteScalar();
                        var sql_insertHoaDon = $"INSERT INTO HoaDon VALUES ('{maHoaDon}', N'chưa thanh toán','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')";

                        var cmd_insertHoaDon = new SqlCommand(sql_insertHoaDon, conn);
                        cmd_insertHoaDon.ExecuteNonQuery();
                    }
                }
                else
                {
                    var sql_maHoaDon2 = $"SELECT hdct.MaHoaDon FROM HoaDonChiTiet hdct JOIN HoaDon hd ON hdct.MaHoaDon = hd.MaHoaDon WHERE hdct.SoBan = '{button_check.Name}' AND hd.TrangThai = N'chưa thanh toán'";
                    using (var cm_maHoaDon2 = new SqlCommand(sql_maHoaDon2, conn))
                    {
                        using (var reader_maHoaDon2 = cm_maHoaDon2.ExecuteReader())
                        {
                            if (reader_maHoaDon2.Read())
                            {
                                maHoaDon = Convert.ToInt32(reader_maHoaDon2["MaHoaDon"]);
                            }
                        }
                    }
                }

                var maMonAn = cbbMonAn.SelectedValue.ToString();
                var soLuong = (int)numericSoLuong.Value;
                var sql_dongia = $"SELECT DonGia FROM MonAn WHERE MaMonAn = '{maMonAn}'";
                using (var cm_dongia = new SqlCommand(sql_dongia, conn))
                {
                    using (var reader_dongia = cm_dongia.ExecuteReader())
                    {
                        if (reader_dongia.Read())
                        {
                            var dongia = Convert.ToDouble(reader_dongia["DonGia"]);
                            var thanhtien = dongia * soLuong;
                            reader_dongia.Close();

                            var tongtien = 0.0;
                            var sql_tongtien = $"select isnull(max(TongTien),0) from HoaDonChiTiet where MaHoaDon = '{maHoaDon}'";
                            using (var cm_tongtien = new SqlCommand(sql_tongtien, conn))
                            {
                                var result = cm_tongtien.ExecuteScalar();
                                if (result != DBNull.Value)
                                {
                                    tongtien = Convert.ToDouble(result);
                                }
                                tongtien += thanhtien;
                            }

                            var sql_insertHoaDonChiTiet = $"INSERT INTO HoaDonChiTiet VALUES('{maHoaDon}', '{button_check.Name}', '{maMonAn}', '{soLuong}', '{thanhtien}', '{tongtien}')";
                            var cm_insertHoaDonChiTiet = new SqlCommand(sql_insertHoaDonChiTiet, conn);
                            cm_insertHoaDonChiTiet.ExecuteNonQuery();
                            hienthi_monan(button_check);
                            chuyenBan(cbbChuyenBan);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa bàn nào được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            for(int i = list_buttons.Count - 1; i >= 0; i--)
            {
                if (list_buttons[i] == button_check)
                {
                    button_check.BackColor = Color.Cyan;
                    button_check.Text = button_check.Text.Replace("Có người", "Trống");
                    list_buttons.Remove(list_buttons[i]);

                    var sql_updateHoaDon = $"UPDATE HoaDon SET TrangThai = N'đã thanh toán', datecheckout = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}' WHERE HoaDon.MaHoaDon IN (SELECT MaHoaDon FROM HoaDonChiTiet WHERE SoBan = '{button_check.Name}') AND TrangThai = N'chưa thanh toán'";
                    var cm_updateHoaDon = new SqlCommand(sql_updateHoaDon, conn);
                    cm_updateHoaDon.ExecuteNonQuery();
                    dataGridView1.DataSource = null;
                    chuyenBan(cbbChuyenBan);
                    return;
                }
            }

            MessageBox.Show("Bạn chưa chọn bàn để thanh toán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void chuyenBan(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            comboBox.Items.Clear();
            foreach (Button button in buttons)
            {
                if (!list_buttons.Contains(button))
                {
                    comboBox.Items.Add(button.Name);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (button_check == null || cbbChuyenBan.SelectedIndex == -1 || !list_buttons.Contains(button_check))
            {
                MessageBox.Show("Bạn chưa chọn bàn chuyển hoặc được chuyển", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            button_check.BackColor = Color.Cyan;
            string str = cbbChuyenBan.SelectedItem.ToString();
            foreach(Button button in buttons)
            {
                if(button.Name == str)
                {
                    button.BackColor = Color.Gray;
                    button.Text = button.Text.Replace("Trống", "Có người");
                    list_buttons.Add(button);

                    var update_soBan = $"UPDATE HoaDonChiTiet SET SoBan = '{button.Name}' WHERE SoBan = '{button_check.Name}' AND MaHoaDon IN (SELECT MaHoaDon FROM HoaDon WHERE TrangThai = N'chưa thanh toán')";
                    var cm_updateSoBan = new SqlCommand(update_soBan, conn);
                    cm_updateSoBan.ExecuteNonQuery();
                    for (int i = list_buttons.Count - 1; i >= 0; i--)
                    {
                        if (list_buttons[i] == button_check)
                        {
                            button_check.BackColor = Color.Cyan;
                            button_check.Text = button_check.Text.Replace("Có người", "Trống");
                            list_buttons.Remove(list_buttons[i]);
                        }
                    }
                }
            }

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // test
            // haha
        }
    }
}

