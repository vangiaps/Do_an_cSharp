using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyPhongTro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Menu.Width = 70;
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 350)
            {
                Menu.Width = 70;
            }
            else
            {
                Menu.Width = 350;
            }
        }

        public void btQlPhongTro_Click(object sender, EventArgs e)
        {
            frmQLPhong qLPhong = new frmQLPhong();
            qLPhong.TopLevel = false;
            qLPhong.FormBorderStyle = FormBorderStyle.None;
            qLPhong.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(qLPhong);
            qLPhong.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQLKhachThue_Click(object sender, EventArgs e)
        {
            frmQLKhachThue qLKhachThue = new frmQLKhachThue();
            qLKhachThue.TopLevel = false;
            qLKhachThue.FormBorderStyle = FormBorderStyle.None;
            qLKhachThue.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(qLKhachThue);
            qLKhachThue.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao baoCao = new frmBaoCao();
            baoCao.TopLevel = false;
            baoCao.FormBorderStyle = FormBorderStyle.None;
            baoCao.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(baoCao);
            baoCao.Show();

            baoCao.frmBaoCao_Load(sender, e);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmQLHoaDon hoaDon = new frmQLHoaDon();
            hoaDon.TopLevel = false;
            hoaDon.FormBorderStyle = FormBorderStyle.None;
            hoaDon.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(hoaDon);
            hoaDon.Show();
            
        }
    }
}
