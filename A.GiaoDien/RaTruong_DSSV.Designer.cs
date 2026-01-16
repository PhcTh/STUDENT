namespace A.GiaoDien
{
    partial class RaTruong_DSSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaTruong_DSSV));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btDSSV_RaTruong = new System.Windows.Forms.ToolStripButton();
            this.btDSSV_NhanBang = new System.Windows.Forms.ToolStripButton();
            this.btDSSV_KhongNhanBang = new System.Windows.Forms.ToolStripButton();
            this.btInBaoCao = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cbHeDaoTao = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btDSSV_RaTruong,
            this.btDSSV_NhanBang,
            this.btDSSV_KhongNhanBang,
            this.btInBaoCao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1143, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btDSSV_RaTruong
            // 
            this.btDSSV_RaTruong.Image = ((System.Drawing.Image)(resources.GetObject("btDSSV_RaTruong.Image")));
            this.btDSSV_RaTruong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDSSV_RaTruong.Name = "btDSSV_RaTruong";
            this.btDSSV_RaTruong.Size = new System.Drawing.Size(153, 36);
            this.btDSSV_RaTruong.Text = "DSSV Ra Trường";
            this.btDSSV_RaTruong.Click += new System.EventHandler(this.btDSSV_RaTruong_Click);
            // 
            // btDSSV_NhanBang
            // 
            this.btDSSV_NhanBang.Image = ((System.Drawing.Image)(resources.GetObject("btDSSV_NhanBang.Image")));
            this.btDSSV_NhanBang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDSSV_NhanBang.Name = "btDSSV_NhanBang";
            this.btDSSV_NhanBang.Size = new System.Drawing.Size(198, 36);
            this.btDSSV_NhanBang.Text = "DSSV Được Nhận Bằng";
            this.btDSSV_NhanBang.Click += new System.EventHandler(this.btDSSV_NhanBang_Click);
            // 
            // btDSSV_KhongNhanBang
            // 
            this.btDSSV_KhongNhanBang.Image = ((System.Drawing.Image)(resources.GetObject("btDSSV_KhongNhanBang.Image")));
            this.btDSSV_KhongNhanBang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDSSV_KhongNhanBang.Name = "btDSSV_KhongNhanBang";
            this.btDSSV_KhongNhanBang.Size = new System.Drawing.Size(245, 36);
            this.btDSSV_KhongNhanBang.Text = "DSSV Không Được Nhận Bằng";
            this.btDSSV_KhongNhanBang.Click += new System.EventHandler(this.btDSSV_KhongNhanBang_Click);
            // 
            // btInBaoCao
            // 
            this.btInBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btInBaoCao.Image")));
            this.btInBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInBaoCao.Name = "btInBaoCao";
            this.btInBaoCao.Size = new System.Drawing.Size(117, 36);
            this.btInBaoCao.Text = "In Báo Cáo";
            this.btInBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInBaoCao.Click += new System.EventHandler(this.btInBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDanhSachSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1143, 665);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên.";
            // 
            // tbDanhSachSinhVien
            // 
            this.tbDanhSachSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbDanhSachSinhVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.tbDanhSachSinhVien.Location = new System.Drawing.Point(8, 24);
            this.tbDanhSachSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDanhSachSinhVien.Name = "tbDanhSachSinhVien";
            this.tbDanhSachSinhVien.RowHeadersVisible = false;
            this.tbDanhSachSinhVien.RowHeadersWidth = 82;
            this.tbDanhSachSinhVien.Size = new System.Drawing.Size(1127, 653);
            this.tbDanhSachSinhVien.TabIndex = 0;
            this.tbDanhSachSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbDanhSachSinhVien_CellContentClick);
            this.tbDanhSachSinhVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbDanhSachSinhVien_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSinhVien";
            this.Column1.HeaderText = "Mã Sinh Viên";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSinhVien";
            this.Column2.HeaderText = "Tên Sinh Viên";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenLop";
            this.Column4.HeaderText = "Tên Lớp";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaKhoaHoc";
            this.Column5.HeaderText = "Mã Khóa Học";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenHe";
            this.Column6.HeaderText = "Tên Hệ";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNganh";
            this.Column7.HeaderText = "Tên Ngành";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenKhoa";
            this.Column8.HeaderText = "Tên Khoa";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(336, 40);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(88, 24);
            this.cbKhoaHoc.TabIndex = 2;
            // 
            // cbHeDaoTao
            // 
            this.cbHeDaoTao.FormattingEnabled = true;
            this.cbHeDaoTao.Location = new System.Drawing.Point(609, 43);
            this.cbHeDaoTao.Name = "cbHeDaoTao";
            this.cbHeDaoTao.Size = new System.Drawing.Size(94, 24);
            this.cbHeDaoTao.TabIndex = 3;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(906, 40);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(93, 24);
            this.cbLop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn theo Khóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn theo Hệ ĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn theo Lớp ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RaTruong_DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbHeDaoTao);
            this.Controls.Add(this.cbKhoaHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RaTruong_DSSV";
            this.Text = "RaTruong_DSSV";
            this.Load += new System.EventHandler(this.RaTruong_DSSV_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btDSSV_RaTruong;
        private System.Windows.Forms.ToolStripButton btDSSV_NhanBang;
        private System.Windows.Forms.ToolStripButton btDSSV_KhongNhanBang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbDanhSachSinhVien;
        private System.Windows.Forms.ToolStripButton btInBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.ComboBox cbHeDaoTao;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}