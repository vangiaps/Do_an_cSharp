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
    public partial class frmChiTietHoaDon : Form
    {
        Database DB = new Database();
        private string soPhong;
        public frmChiTietHoaDon(string? soPhong)
        {
            InitializeComponent();
            this.soPhong = soPhong;
            loadThongTin();
            this.soPhong = soPhong;
        }

        private void labSoPhong_Click(object sender, EventArgs e)
        {

        }
        private void loadThongTin()
        {
            //string query = "select "
        }

    }
}
