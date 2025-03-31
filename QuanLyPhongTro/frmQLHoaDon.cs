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
        Database DB = new Database();
        private string? soPhong;

        public frmQLHoaDon()
        {
            InitializeComponent();
            loadHoaDon();
        }
        private void loadHoaDon()
        {
            string query = "SELECT h.SoPhong, p.NgayThanhToan, p.SoTien, d.TrangThaiThanhToan FROM HoaDon p JOIN Phong h ON h.MaPhong=p.MaPhong LEFT JOIN DienNuoc d ON d.MaPhong=p.MaPhong";
            DataTable data = DB.ExecuteQuery(query);
            dataGridViewHoaDon.DataSource = data;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.DataSource != null)
            {
                DataTable dt = dataGridViewHoaDon.DataSource as DataTable;
                if (dt != null)
                {
                    string filter = txtTimKiem.Text.Trim();
                    if (int.TryParse(filter, out _)) // Chỉ lọc nếu nhập số
                    {
                        dt.DefaultView.RowFilter = string.Format("Convert(SoPhong, 'System.String') LIKE '%{0}%'", filter);
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = ""; // Không lọc nếu không nhập số
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadHoaDon();
            txtTimKiem.Text = "";
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề
            {
                DataGridViewRow row = dataGridViewHoaDon.Rows[e.RowIndex];

                // Gán dữ liệu lên TextBox
                txtSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
                txtNgayThanhToan.Text = row.Cells["NgayThanhToan"].Value.ToString();
                txtTongTien.Text = row.Cells["SoTien"].Value.ToString();
                bool check = Convert.ToBoolean(row.Cells["TrangThaiThanhToan"].Value);
                if (check == true)
                {
                    txtTrangThai.Text = "Đã thanh toán";
                }
                else
                {
                    txtTrangThai.Text = "Chưa thanh toán";
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            string sophong = txtSoPhong.Text.Trim();

            if (!string.IsNullOrEmpty(sophong))
            {
                //string soPhong = dataGridViewHoaDon.SelectedRows[0].Cells["SoPhong"].Value.ToString();
                frmChiTietHoaDon frm = new frmChiTietHoaDon(soPhong);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


