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
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataGridViewHoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtNgayMoi = new TextBox();
            label4 = new Label();
            txtNgayCu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtTongTien = new TextBox();
            txtSoPhong = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridViewHoaDon);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 255);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1220, 469);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(815, 7);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 31);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(698, 7);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(477, 9);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(215, 27);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Danh sách hóa đơn";
            // 
            // dataGridViewHoaDon
            // 
            dataGridViewHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoaDon.Dock = DockStyle.Bottom;
            dataGridViewHoaDon.Location = new Point(3, 46);
            dataGridViewHoaDon.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            dataGridViewHoaDon.RowHeadersWidth = 51;
            dataGridViewHoaDon.Size = new Size(1214, 419);
            dataGridViewHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtNgayMoi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNgayCu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtSoPhong);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1220, 247);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(914, 50);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 12);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 2;
            label7.Text = "Chưa thanh toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 12);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 1;
            label6.Text = "Đã thanh toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 14);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Tất cả";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(749, 169);
            button4.Name = "button4";
            button4.Size = new Size(110, 35);
            button4.TabIndex = 10;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(749, 72);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 9;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(590, 173);
            button2.Name = "button2";
            button2.Size = new Size(110, 35);
            button2.TabIndex = 8;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(590, 72);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 7;
            button1.Text = "Chi tiết";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtNgayMoi
            // 
            txtNgayMoi.Location = new Point(317, 118);
            txtNgayMoi.Name = "txtNgayMoi";
            txtNgayMoi.Size = new Size(146, 27);
            txtNgayMoi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 125);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày cập nhật:";
            // 
            // txtNgayCu
            // 
            txtNgayCu.Location = new Point(161, 118);
            txtNgayCu.Name = "txtNgayCu";
            txtNgayCu.Size = new Size(133, 27);
            txtNgayCu.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 173);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Tổng tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 83);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Phòng số:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(162, 166);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 1;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(162, 72);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(199, 27);
            txtSoPhong.TabIndex = 0;
            // 
            // frmQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 724);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQLHoaDon";
            Text = "frmQLHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewHoaDon;
        private Button btnLoad;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtTongTien;
        private TextBox txtSoPhong;
        private TextBox txtNgayMoi;
        private Label label4;
        private TextBox txtNgayCu;
        private GroupBox groupBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}