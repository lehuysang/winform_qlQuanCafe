using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace quanLyQuanCafe
{
    public partial class Form2 : Form
    {
        string chuoiKetNoi = "Data Source=LAPTOP-VSJT7638;Initial Catalog=QLCafe;Integrated Security=True;";
        SqlConnection conn = null;
        DateTime DateCheckIn, DateCheckOut;

        public Form2()
        {
            InitializeComponent();

            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            load_dulieu();
            DateCheckIn = DateTime.Now.Date;
            DateCheckOut = DateTime.Now.Date.AddDays(1);
            hienthi1();
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


        // Các sự kiện của tabPages 1
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateCheckIn = dateTimePicker1.Value;
            hienthi1();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateCheckOut = dateTimePicker2.Value;
            hienthi1();
        }

        private void hienthi1()
        {
            var sql_select = $"SELECT hd.MaHoaDon, hdct.SoBan, MAX(hdct.TongTien) AS TongTien, hd.datecheckin, hd.datecheckout " +
                             $"FROM HoaDon hd JOIN HoaDonChiTiet hdct ON hdct.MaHoaDon = hd.MaHoaDon " +
                             $"WHERE hd.datecheckin >= '{DateCheckIn}' AND hd.datecheckout <= '{DateCheckOut}' " +
                             $"GROUP BY hd.MaHoaDon, hdct.SoBan, hd.datecheckin, hd.datecheckout ORDER BY hd.MaHoaDon ASC";
            SqlDataAdapter da = new SqlDataAdapter(sql_select, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Xem chi tiết")
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int gui_maHoaDon;
                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out gui_maHoaDon))
                    {
                        XemChiTiet xemchitiet = new XemChiTiet(gui_maHoaDon);
                        this.Hide();
                        xemchitiet.ShowDialog();
                        this.Show(); // Hiện lại form sau khi xem chi tiết
                    }
                    else
                    {
                        // Xử lý trường hợp giá trị cột không hợp lệ
                        MessageBox.Show("Giá trị cột không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Các sự kiện của tabPages2 
        int rowIndex2;
        private void hienthi2()
        {
            var sql_hienthi = "SELECT MaLoai, TenLoai FROM LoaiMonAn ORDER BY MaLoai ASC";
            var da = new SqlDataAdapter(sql_hienthi, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex2 = e.RowIndex;

            DataGridViewRow upLoad = dataGridView2.Rows[rowIndex2];
            textBox1.Text = upLoad.Cells[0].Value.ToString();
            textBox2.Text = upLoad.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sql_insert = $"insert into LoaiMonAn values('{textBox1.Text}', '{textBox2.Text}')";
            var cm_insert = new SqlCommand(sql_insert, conn);
            cm_insert.ExecuteNonQuery();
            hienthi2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sql_update = $"update LoaiMonAn set MaLoai = '{textBox1.Text}', TenLoai = '{textBox2.Text}'  where MaLoai = '{dataGridView2.Rows[rowIndex2].Cells[0].Value.ToString()}'";
            var cm_update = new SqlCommand( sql_update, conn);
            cm_update.ExecuteNonQuery();
            hienthi2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sql_update = $"delete LoaiMonAn where MaLoai = '{dataGridView2.Rows[rowIndex2].Cells[0].Value.ToString()}'";
            var cm_update = new SqlCommand(sql_update, conn);
            cm_update.ExecuteNonQuery();
            hienthi2(); 
        }


        // Các sự kiện của  tabPages3
        private void hienthi3()
        {
            var sql_hienthi = "select ma.MaMonAn, lma.TenLoai as lma3, ma.TenMonAn, ma.DonGia From MonAn ma, LoaiMonAn lma where ma.MaLoai = lma.MaLoai";
            var da = new SqlDataAdapter(sql_hienthi, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var sql_hienthi = $"select ma.MaMonAn, lma.TenLoai as lma3, ma.TenMonAn, ma.DonGia From MonAn ma, LoaiMonAn lma where ma.MaLoai = lma.MaLoai and ma.TenMonAn like '%{textBox6.Text}%'";
            var da = new SqlDataAdapter(sql_hienthi, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        int rowIndex3;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex3 = e.RowIndex;
            DataGridViewRow upLoad = dataGridView3.Rows[rowIndex3];

            textBox3.Text = upLoad.Cells[0].Value.ToString();
            textBox4.Text = upLoad.Cells[2].Value.ToString();
            textBox5.Text = upLoad.Cells[3].Value.ToString();
            comboBox1.Text = upLoad.Cells[1].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sql_insert = $"insert into MonAn values('{textBox3.Text}', '{comboBox1.SelectedValue}', '{textBox4.Text}', '{textBox5.Text}')";
            var cm_insert = new SqlCommand(sql_insert, conn);
            cm_insert.ExecuteNonQuery();
            hienthi3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sql_update = $"update MonAn set MaMonAn = '{textBox3.Text}', MaLoai = '{comboBox1.SelectedValue}', TenMonAn = '{textBox4.Text}', DonGia = '{textBox5.Text}' where MaMonAn = '{dataGridView3.Rows[rowIndex3].Cells[0].Value?.ToString()}'";
            var cm_update = new SqlCommand( sql_update, conn);
            cm_update.ExecuteNonQuery();
            hienthi3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView3.SelectedRows)
            {
                var sql_update = $"delete MonAn where MaMonAn = '{row.Cells[0].Value}'";
                var cm_update = new SqlCommand(sql_update, conn);
                cm_update.ExecuteNonQuery();
                hienthi3();
            }
        }

        // Sự kiện tabControl
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl1.SelectedIndex;

            if (selectedIndex == 0)
            {
                hienthi1();
            }
            else if (selectedIndex == 1)
            {
                textBox1.Focus();
                hienthi2();
            }
            else if (selectedIndex == 2)
            {
                var query = "select MaLoai, TenLoai from LoaiMonAN";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "TenLoai";
                comboBox1.ValueMember = "MaLoai";
                hienthi3();
            }
        }
    }
}
