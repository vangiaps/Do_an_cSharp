namespace QuanLyPhongTro
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Menu = new Panel();
            btnLogout = new Button();
            btnBaoCao = new Button();
            btnHoaDon = new Button();
            btnQLHopDong = new Button();
            btnQLKhachThue = new Button();
            btQlPhongTro = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSlide = new PictureBox();
            panel2 = new Panel();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.DarkGray;
            Menu.Controls.Add(btnLogout);
            Menu.Controls.Add(btnBaoCao);
            Menu.Controls.Add(btnHoaDon);
            Menu.Controls.Add(btnQLHopDong);
            Menu.Controls.Add(btnQLKhachThue);
            Menu.Controls.Add(btQlPhongTro);
            Menu.Controls.Add(pictureBox1);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(350, 1024);
            Menu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(0, 746);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(70, 0, 0, 0);
            btnLogout.Size = new Size(350, 113);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Thoát";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Cursor = Cursors.Hand;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCao.ForeColor = SystemColors.ActiveCaptionText;
            btnBaoCao.Location = new Point(0, 591);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(70, 0, 0, 0);
            btnBaoCao.Size = new Size(350, 113);
            btnBaoCao.TabIndex = 5;
            btnBaoCao.Text = "Báo cáo thống kê";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Cursor = Cursors.Hand;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDon.ForeColor = SystemColors.ActiveCaptionText;
            btnHoaDon.Location = new Point(0, 467);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(70, 0, 0, 0);
            btnHoaDon.Size = new Size(350, 113);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "Hóa đơn/ Tính tiền";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnQLHopDong
            // 
            btnQLHopDong.Cursor = Cursors.Hand;
            btnQLHopDong.FlatAppearance.BorderSize = 0;
            btnQLHopDong.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnQLHopDong.FlatStyle = FlatStyle.Flat;
            btnQLHopDong.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQLHopDong.ForeColor = SystemColors.ActiveCaptionText;
            btnQLHopDong.Location = new Point(0, 344);
            btnQLHopDong.Name = "btnQLHopDong";
            btnQLHopDong.Padding = new Padding(70, 0, 0, 0);
            btnQLHopDong.Size = new Size(350, 113);
            btnQLHopDong.TabIndex = 3;
            btnQLHopDong.Text = "Quản lý hợp đồng";
            btnQLHopDong.TextAlign = ContentAlignment.MiddleLeft;
            btnQLHopDong.UseVisualStyleBackColor = true;
            // 
            // btnQLKhachThue
            // 
            btnQLKhachThue.Cursor = Cursors.Hand;
            btnQLKhachThue.FlatAppearance.BorderSize = 0;
            btnQLKhachThue.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnQLKhachThue.FlatStyle = FlatStyle.Flat;
            btnQLKhachThue.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQLKhachThue.ForeColor = SystemColors.ActiveCaptionText;
            btnQLKhachThue.Location = new Point(0, 238);
            btnQLKhachThue.Name = "btnQLKhachThue";
            btnQLKhachThue.Padding = new Padding(70, 0, 0, 0);
            btnQLKhachThue.Size = new Size(350, 113);
            btnQLKhachThue.TabIndex = 2;
            btnQLKhachThue.Text = "Quản khách thuê";
            btnQLKhachThue.TextAlign = ContentAlignment.MiddleLeft;
            btnQLKhachThue.UseVisualStyleBackColor = true;
            btnQLKhachThue.Click += btnQLKhachThue_Click;
            // 
            // btQlPhongTro
            // 
            btQlPhongTro.Cursor = Cursors.Hand;
            btQlPhongTro.FlatAppearance.BorderSize = 0;
            btQlPhongTro.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btQlPhongTro.FlatStyle = FlatStyle.Flat;
            btQlPhongTro.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btQlPhongTro.ForeColor = SystemColors.ActiveCaptionText;
            btQlPhongTro.Location = new Point(0, 138);
            btQlPhongTro.Name = "btQlPhongTro";
            btQlPhongTro.Padding = new Padding(70, 0, 0, 0);
            btQlPhongTro.Size = new Size(350, 113);
            btQlPhongTro.TabIndex = 1;
            btQlPhongTro.Text = "Quản lý phòng";
            btQlPhongTro.TextAlign = ContentAlignment.MiddleLeft;
            btQlPhongTro.UseVisualStyleBackColor = true;
            btQlPhongTro.Click += btQlPhongTro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnSlide);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(350, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1548, 60);
            panel1.TabIndex = 1;
            // 
            // btnSlide
            // 
            btnSlide.Cursor = Cursors.Hand;
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(6, 9);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(45, 45);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 0;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(350, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 964);
            panel2.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmMain";
            Text = "frmMain";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Menu;
        private Panel panel1;
        private PictureBox btnSlide;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btQlPhongTro;
        private Button btnBaoCao;
        private Button btnHoaDon;
        private Button btnQLHopDong;
        private Button btnQLKhachThue;
        private Button btnLogout;
    }
}