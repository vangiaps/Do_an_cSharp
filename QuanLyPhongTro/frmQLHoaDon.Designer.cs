namespace QuanLyPhongTro
{
    partial class frmQLHoaDon
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewHoaDon = new DataGridView();
            panel1 = new Panel();
            lableq = new Label();
            label5 = new Label();
            btnChiTiet = new Button();
            txtTrangThai = new TextBox();
            txtTongTien = new TextBox();
            lable = new Label();
            txtNgayThanhToan = new TextBox();
            label3 = new Label();
            txtSoPhong = new TextBox();
            label2 = new Label();
            txtTimKiem = new TextBox();
            panel3 = new Panel();
            btnLoad = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 617);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewHoaDon);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(958, 576);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tất cả";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHoaDon
            // 
            dataGridViewHoaDon.AllowUserToAddRows = false;
            dataGridViewHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHoaDon.BackgroundColor = SystemColors.Control;
            dataGridViewHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoaDon.Dock = DockStyle.Fill;
            dataGridViewHoaDon.Location = new Point(3, 245);
            dataGridViewHoaDon.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            dataGridViewHoaDon.RowHeadersWidth = 51;
            dataGridViewHoaDon.Size = new Size(952, 327);
            dataGridViewHoaDon.TabIndex = 1;
            dataGridViewHoaDon.CellClick += dataGridViewHoaDon_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(lableq);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnChiTiet);
            panel1.Controls.Add(txtTrangThai);
            panel1.Controls.Add(txtTongTien);
            panel1.Controls.Add(lable);
            panel1.Controls.Add(txtNgayThanhToan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSoPhong);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 241);
            panel1.TabIndex = 0;
            // 
            // lableq
            // 
            lableq.Anchor = AnchorStyles.Right;
            lableq.AutoSize = true;
            lableq.Location = new Point(555, 146);
            lableq.Name = "lableq";
            lableq.Size = new Size(150, 20);
            lableq.TabIndex = 12;
            lableq.Text = "Trạng thái thanh toán";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(385, 146);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Tổng tiền";
            // 
            // btnChiTiet
            // 
            btnChiTiet.Location = new Point(111, 129);
            btnChiTiet.Margin = new Padding(3, 4, 3, 4);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(104, 44);
            btnChiTiet.TabIndex = 10;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Anchor = AnchorStyles.Right;
            txtTrangThai.Location = new Point(711, 143);
            txtTrangThai.Margin = new Padding(3, 4, 3, 4);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(228, 27);
            txtTrangThai.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTongTien.Location = new Point(463, 143);
            txtTongTien.Margin = new Padding(3, 4, 3, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(66, 27);
            txtTongTien.TabIndex = 7;
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Right;
            lable.AutoSize = true;
            lable.Location = new Point(555, 75);
            lable.Name = "lable";
            lable.Size = new Size(119, 20);
            lable.TabIndex = 6;
            lable.Text = "Ngày thanh toán";
            // 
            // txtNgayThanhToan
            // 
            txtNgayThanhToan.Anchor = AnchorStyles.Right;
            txtNgayThanhToan.Location = new Point(689, 72);
            txtNgayThanhToan.Margin = new Padding(3, 4, 3, 4);
            txtNgayThanhToan.Name = "txtNgayThanhToan";
            txtNgayThanhToan.Size = new Size(250, 27);
            txtNgayThanhToan.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(387, 75);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Phòng số";
            // 
            // txtSoPhong
            // 
            txtSoPhong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoPhong.Location = new Point(463, 75);
            txtSoPhong.Margin = new Padding(3, 4, 3, 4);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(66, 27);
            txtSoPhong.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 75);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(99, 72);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(272, 27);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 192);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 49);
            panel3.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(14, 4);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 31);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.Location = new Point(828, 11);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Location = new Point(707, 11);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Location = new Point(586, 12);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 45);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(958, 576);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đã thanh toán";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 617);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQLHoaDon";
            Text = "frmQLHoaDon";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private TabPage tabPage2;
        private DataGridView dataGridViewHoaDon;
        private Panel panel3;
        private Button btnLoad;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private TextBox txtNgayThanhToan;
        private Label label3;
        private TextBox txtSoPhong;
        private Label lableq;
        private Label label5;
        private Button btnChiTiet;
        private TextBox txtTrangThai;
        private TextBox txtTongTien;
        private Label lable;
    }
}