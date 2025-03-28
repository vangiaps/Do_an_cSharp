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
        public frmQLHoaDon()
        {
            InitializeComponent();
            loadHoaDon();
        }
        private void loadHoaDon()
        {
            string query = "SELECT * FROM HoaDon";
            DataTable data = DB.ExecuteQuery(query);
            dataGridViewHoaDon.DataSource = data;
        }
    }

}
