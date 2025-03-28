using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmBaoCao : Form
    {
        Database db = new Database();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        public void frmBaoCao_Load(object sender, EventArgs e)
        {
            LoadData();
            tabDoanhThu_Click(sender, e);
            txtTongSoPhong_TextChanged(sender, e);
            txtSoPhongThue_TextChanged(sender, e);
            txtSoPhongTrong_TextChanged(sender, e);
        }

        private void LoadData()
        {
            string query = "SELECT p.SoPhong AS 'Số phòng', p.LoaiPhong, p.SoKhachToiDa, p.SoKhachHienTai, p.TrangThai, p.Tang, h.NgayBatDau, h.NgayKetThuc FROM Phong p LEFT JOIN HopDong h ON p.MaPhong = h.MaPhong";
            //dataGridViewThuePhong.DataSource = db.ExecuteQuery(query);
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewThuePhongHT.DataSource = dt;
        }

        private void tabDoanhThu_Click(object sender, EventArgs e)
        {
            string query = "DECLARE @Nam INT = 2023;\r\nDECLARE @Thang INT = NULL;\r\nSELECT \r\n    h.Thang, \r\n    h.Nam, \r\n    SUM(h.SoTien) AS TongTienThanhToan\r\nFROM HoaDon h\r\nWHERE (h.Nam = @Nam AND (@Thang IS NULL OR h.Thang = @Thang))\r\nGROUP BY h.Thang, h.Nam\r\nORDER BY h.Nam DESC, h.Thang DESC\r\n";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewDoanhThu.DataSource = dt;
        }

        private void txtTongSoPhong_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Phong";
            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                txtTongSoPhong.Text = dt.Rows[0][0].ToString();
            }

        }

        private void txtSoPhongThue_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Phong WHERE SoKhachHienTai != 0";
            DataTable dt = db.ExecuteQuery(query);

            txtSoPhongThue.Text = dt.Rows[0][0].ToString();
        }

        private void txtSoPhongTrong_TextChanged(object sender, EventArgs e)
        {
            txtSoPhongTrong.Text = (int.Parse(txtTongSoPhong.Text) - int.Parse(txtSoPhongThue.Text)).ToString();
        }

        private void btnXemTongPhong_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXemPhongThue_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.SoPhong, p.LoaiPhong, p.SoKhachToiDa, p.SoKhachHienTai, p.TrangThai, p.Tang, h.NgayBatDau, h.NgayKetThuc FROM Phong p LEFT JOIN HopDong h ON p.MaPhong = h.MaPhong WHERE p.SoKhachHienTai != 0";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewThuePhongHT.DataSource = dt;
        }

        private void btnXemPhongTrong_Click(object sender, EventArgs e)
        {
            string query = "SELECT SoPhong, LoaiPhong, SoKhachToiDa, SoKhachHienTai, TrangThai, Tang FROM Phong WHERE SoKhachHienTai = 0";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewThuePhongHT.DataSource = dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string SoPhong = txtSearch.Text;
            string query = "SELECT p.SoPhong, p.LoaiPhong, p.SoKhachToiDa, p.SoKhachHienTai, p.TrangThai, p.Tang, h.NgayBatDau, h.NgayKetThuc FROM Phong p LEFT JOIN HopDong h ON p.MaPhong = h.MaPhong WHERE p.SoPhong = @SoPhong";
            DataTable dt = db.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@SoPhong", SoPhong) });
            dataGridViewThuePhongHT.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnTimKiem_Click(sender, e);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
