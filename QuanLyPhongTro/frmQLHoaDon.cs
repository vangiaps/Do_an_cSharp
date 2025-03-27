using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    public partial class frmQLHoaDon : Form
    {
        Database db = new Database();
        public frmQLHoaDon()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData(string soPhong = "")
        {
            string query = "SELECT \r\n  p.SoPhong ,\r\n    h.SoTien, \r\n    h.NgayThanhToan,\r\n d.TrangThaiThanhToan\r\nFROM HoaDon h\r\nJOIN Phong p ON h.MaPhong = p.MaPhong\r\n LEFT JOIN DienNuoc d ON p.MaPhong = d.MaPhong";
            DataTable dt = db.ExecuteQuery(query);
            dataGridViewHoaDon.DataSource = dt;
            
        }
        private void searchData(string soPhong)
        {
            string query = @"
        SELECT 
            p.SoPhong, 
            h.SoTien, 
            h.NgayThanhToan
        FROM HoaDon h
        JOIN Phong p ON h.MaPhong = p.MaPhong
        WHERE p.SoPhong LIKE @SoPhong"; // Dùng tham số để tránh lỗi SQL Injection

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@SoPhong", "%" + soPhong + "%" }
    };

            DataTable dt = db.ExecuteQuery(query, parameters); // Gọi truy vấn với tham số
            dataGridViewHoaDon.DataSource = dt; // Hiển thị dữ liệu lọc trên DataGridView
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string soPhong = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(soPhong))
            {
                searchData(soPhong);
            }
            else
            {
                loadData(); // Nếu ô tìm kiếm trống, load lại toàn bộ dữ liệu
            }
        }
    }
}
