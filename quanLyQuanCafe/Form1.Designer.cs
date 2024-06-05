namespace quanLyQuanCafe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ban9 = new System.Windows.Forms.Button();
            this.ban8 = new System.Windows.Forms.Button();
            this.ban7 = new System.Windows.Forms.Button();
            this.ban6 = new System.Windows.Forms.Button();
            this.ban5 = new System.Windows.Forms.Button();
            this.ban4 = new System.Windows.Forms.Button();
            this.ban3 = new System.Windows.Forms.Button();
            this.ban2 = new System.Windows.Forms.Button();
            this.ban1 = new System.Windows.Forms.Button();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.cbbMonAn = new System.Windows.Forms.ComboBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbChuyenBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTongTien = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // chiToolStripMenuItem
            // 
            this.chiToolStripMenuItem.Name = "chiToolStripMenuItem";
            this.chiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chiToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.ban9);
            this.panel1.Controls.Add(this.ban8);
            this.panel1.Controls.Add(this.ban7);
            this.panel1.Controls.Add(this.ban6);
            this.panel1.Controls.Add(this.ban5);
            this.panel1.Controls.Add(this.ban4);
            this.panel1.Controls.Add(this.ban3);
            this.panel1.Controls.Add(this.ban2);
            this.panel1.Controls.Add(this.ban1);
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 340);
            this.panel1.TabIndex = 1;
            // 
            // ban9
            // 
            this.ban9.BackColor = System.Drawing.Color.Cyan;
            this.ban9.Location = new System.Drawing.Point(189, 167);
            this.ban9.Name = "ban9";
            this.ban9.Size = new System.Drawing.Size(87, 76);
            this.ban9.TabIndex = 8;
            this.ban9.Text = "Bàn 9\r\nTrống";
            this.ban9.UseVisualStyleBackColor = false;
            this.ban9.Click += new System.EventHandler(this.ban9_Click);
            // 
            // ban8
            // 
            this.ban8.BackColor = System.Drawing.Color.Cyan;
            this.ban8.Location = new System.Drawing.Point(96, 167);
            this.ban8.Name = "ban8";
            this.ban8.Size = new System.Drawing.Size(87, 76);
            this.ban8.TabIndex = 7;
            this.ban8.Text = "Bàn 8\r\nTrống";
            this.ban8.UseVisualStyleBackColor = false;
            this.ban8.Click += new System.EventHandler(this.ban8_Click);
            // 
            // ban7
            // 
            this.ban7.BackColor = System.Drawing.Color.Cyan;
            this.ban7.Location = new System.Drawing.Point(3, 167);
            this.ban7.Name = "ban7";
            this.ban7.Size = new System.Drawing.Size(87, 76);
            this.ban7.TabIndex = 6;
            this.ban7.Text = "Bàn 7\r\nTrống";
            this.ban7.UseVisualStyleBackColor = false;
            this.ban7.Click += new System.EventHandler(this.ban7_Click);
            // 
            // ban6
            // 
            this.ban6.BackColor = System.Drawing.Color.Cyan;
            this.ban6.Location = new System.Drawing.Point(189, 85);
            this.ban6.Name = "ban6";
            this.ban6.Size = new System.Drawing.Size(87, 76);
            this.ban6.TabIndex = 5;
            this.ban6.Text = "Bàn 6\r\nTrống";
            this.ban6.UseVisualStyleBackColor = false;
            this.ban6.Click += new System.EventHandler(this.ban6_Click);
            // 
            // ban5
            // 
            this.ban5.BackColor = System.Drawing.Color.Cyan;
            this.ban5.Location = new System.Drawing.Point(96, 85);
            this.ban5.Name = "ban5";
            this.ban5.Size = new System.Drawing.Size(87, 76);
            this.ban5.TabIndex = 4;
            this.ban5.Text = "Bàn 5\r\nTrống";
            this.ban5.UseVisualStyleBackColor = false;
            this.ban5.Click += new System.EventHandler(this.ban5_Click);
            // 
            // ban4
            // 
            this.ban4.BackColor = System.Drawing.Color.Cyan;
            this.ban4.Location = new System.Drawing.Point(3, 85);
            this.ban4.Name = "ban4";
            this.ban4.Size = new System.Drawing.Size(87, 76);
            this.ban4.TabIndex = 3;
            this.ban4.Text = "Bàn 4\r\nTrống\r\n";
            this.ban4.UseVisualStyleBackColor = false;
            this.ban4.Click += new System.EventHandler(this.ban4_Click);
            // 
            // ban3
            // 
            this.ban3.BackColor = System.Drawing.Color.Cyan;
            this.ban3.Location = new System.Drawing.Point(189, 3);
            this.ban3.Name = "ban3";
            this.ban3.Size = new System.Drawing.Size(87, 76);
            this.ban3.TabIndex = 2;
            this.ban3.Text = "Bàn 3\r\nTrống";
            this.ban3.UseVisualStyleBackColor = false;
            this.ban3.Click += new System.EventHandler(this.ban3_Click);
            // 
            // ban2
            // 
            this.ban2.BackColor = System.Drawing.Color.Cyan;
            this.ban2.Location = new System.Drawing.Point(96, 3);
            this.ban2.Name = "ban2";
            this.ban2.Size = new System.Drawing.Size(87, 76);
            this.ban2.TabIndex = 1;
            this.ban2.Text = "Bàn 2\r\nTrống";
            this.ban2.UseVisualStyleBackColor = false;
            this.ban2.Click += new System.EventHandler(this.ban2_Click);
            // 
            // ban1
            // 
            this.ban1.BackColor = System.Drawing.Color.Cyan;
            this.ban1.Location = new System.Drawing.Point(3, 3);
            this.ban1.Name = "ban1";
            this.ban1.Size = new System.Drawing.Size(87, 76);
            this.ban1.TabIndex = 0;
            this.ban1.Text = "Bàn 1\r\nTrống";
            this.ban1.UseVisualStyleBackColor = false;
            this.ban1.Click += new System.EventHandler(this.ban1_Click);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(291, 37);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(244, 24);
            this.cbbLoai.TabIndex = 2;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // cbbMonAn
            // 
            this.cbbMonAn.FormattingEnabled = true;
            this.cbbMonAn.Location = new System.Drawing.Point(291, 66);
            this.cbbMonAn.Name = "cbbMonAn";
            this.cbbMonAn.Size = new System.Drawing.Size(244, 24);
            this.cbbMonAn.TabIndex = 3;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThemMon.Location = new System.Drawing.Point(541, 37);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(71, 53);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(618, 54);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(55, 22);
            this.numericSoLuong.TabIndex = 6;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThanhToan.Location = new System.Drawing.Point(700, 208);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(97, 60);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn,
            this.DonGia,
            this.SoLuong,
            this.TongTien});
            this.dataGridView1.Location = new System.Drawing.Point(293, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(401, 275);
            this.dataGridView1.TabIndex = 9;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(700, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chuyển bàn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbChuyenBan
            // 
            this.cbbChuyenBan.FormattingEnabled = true;
            this.cbbChuyenBan.Location = new System.Drawing.Point(700, 170);
            this.cbbChuyenBan.Name = "cbbChuyenBan";
            this.cbbChuyenBan.Size = new System.Drawing.Size(97, 24);
            this.cbbChuyenBan.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng tiền";
            // 
            // btnTongTien
            // 
            this.btnTongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTongTien.Location = new System.Drawing.Point(703, 338);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.ReadOnly = true;
            this.btnTongTien.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.btnTongTien.Size = new System.Drawing.Size(93, 22);
            this.btnTongTien.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChuyenBan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.numericSoLuong);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.cbbMonAn);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ban8;
        private System.Windows.Forms.Button ban7;
        private System.Windows.Forms.Button ban6;
        private System.Windows.Forms.Button ban5;
        private System.Windows.Forms.Button ban4;
        private System.Windows.Forms.Button ban3;
        private System.Windows.Forms.Button ban2;
        private System.Windows.Forms.Button ban1;
        private System.Windows.Forms.Button ban9;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.ComboBox cbbMonAn;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbChuyenBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}

