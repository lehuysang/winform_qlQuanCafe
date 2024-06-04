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
    public partial class XemChiTiet : Form
    {
        string chuoiKetNoi = "Data Source=LAPTOP-VSJT7638;Initial Catalog=QLCafe;Integrated Security=True;";
        SqlConnection conn = null;

        private int maHoaDon;
        public XemChiTiet()
        {
            InitializeComponent();

        }
        public XemChiTiet(int mahoadon)
        {
            InitializeComponent();
            this.maHoaDon = mahoadon;
        }
        private void XemChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message);
                return;
            }

            var sql_xemchitiet = $"select hd.MaHoaDon, hd.datecheckin, hd.datecheckout, hdct.SoBan, ma.TenMonAn, hdct.SoLuong, hdct.ThanhTien, hdct.TongTien from HoaDon hd, HoaDonChiTiet hdct, MonAn ma  where hd.MaHoaDon = hdct.MaHoaDon and hdct.MaMonAn = ma.MaMonAn and hd.MaHoaDon = '{maHoaDon}'";
            var da = new SqlDataAdapter(sql_xemchitiet, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

