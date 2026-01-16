namespace A.GiaoDien
{
    partial class NhapDiem
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbKetQuaHocTap = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketluan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.btChinhSua_QLD = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btXacNhan_QLD = new System.Windows.Forms.Button();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.brCuoi = new System.Windows.Forms.Button();
            this.btSau = new System.Windows.Forms.Button();
            this.btTruoc = new System.Windows.Forms.Button();
            this.btDau = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKetQuaHocTap)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbKetQuaHocTap);
            this.groupBox6.Location = new System.Drawing.Point(20, 365);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(935, 352);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kết Quả Học Tập Trong Kỳ.";
            // 
            // tbKetQuaHocTap
            // 
            this.tbKetQuaHocTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbKetQuaHocTap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbKetQuaHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbKetQuaHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.ketluan});
            this.tbKetQuaHocTap.Location = new System.Drawing.Point(9, 24);
            this.tbKetQuaHocTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKetQuaHocTap.Name = "tbKetQuaHocTap";
            this.tbKetQuaHocTap.RowHeadersWidth = 82;
            this.tbKetQuaHocTap.Size = new System.Drawing.Size(917, 320);
            this.tbKetQuaHocTap.TabIndex = 0;
            this.tbKetQuaHocTap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbKetQuaHocTap_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "STT";
            this.Column8.HeaderText = "STT";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaHocKy";
            this.Column9.HeaderText = "Mã Học Kỳ";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaMonHoc";
            this.Column10.HeaderText = "Mã Môn Học";
            this.Column10.MinimumWidth = 10;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TenMonHoc";
            this.Column11.HeaderText = "Tên Môn Học";
            this.Column11.MinimumWidth = 10;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SoTinChi";
            this.Column12.HeaderText = "Số Tín Chỉ";
            this.Column12.MinimumWidth = 10;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DiemQuaTrinh";
            this.Column13.HeaderText = "Điểm Quá Trình";
            this.Column13.MinimumWidth = 10;
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "DiemThi";
            this.Column14.HeaderText = "Điểm Thi";
            this.Column14.MinimumWidth = 10;
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Diem Tong Ket";
            this.Column15.HeaderText = "Điểm Tổng Kết";
            this.Column15.MinimumWidth = 10;
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Diem Chu";
            this.Column16.HeaderText = "Điểm Chữ";
            this.Column16.MinimumWidth = 10;
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Diem Tich Luy";
            this.Column17.HeaderText = "Điểm Tích Lũy";
            this.Column17.MinimumWidth = 10;
            this.Column17.Name = "Column17";
            // 
            // ketluan
            // 
            this.ketluan.DataPropertyName = "KetLuan";
            this.ketluan.HeaderText = "Kết Luận";
            this.ketluan.MinimumWidth = 10;
            this.ketluan.Name = "ketluan";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btXoa);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtDiemThi);
            this.groupBox4.Controls.Add(this.btChinhSua_QLD);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btXacNhan_QLD);
            this.groupBox4.Controls.Add(this.txtDiemQuaTrinh);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(20, 196);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(927, 116);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điểm Quá Trình Và Điểm Thi.";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btXoa.Image = global::A.GiaoDien.Properties.Resources.deletered32;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(615, 56);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(145, 52);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(861, 32);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "Enter";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(653, 24);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(199, 22);
            this.txtDiemThi.TabIndex = 2;
            this.txtDiemThi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterDiemThi);
            // 
            // btChinhSua_QLD
            // 
            this.btChinhSua_QLD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChinhSua_QLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btChinhSua_QLD.Image = global::A.GiaoDien.Properties.Resources.pencil_22;
            this.btChinhSua_QLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChinhSua_QLD.Location = new System.Drawing.Point(389, 56);
            this.btChinhSua_QLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChinhSua_QLD.Name = "btChinhSua_QLD";
            this.btChinhSua_QLD.Size = new System.Drawing.Size(161, 52);
            this.btChinhSua_QLD.TabIndex = 4;
            this.btChinhSua_QLD.Text = "Chỉnh Sửa";
            this.btChinhSua_QLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChinhSua_QLD.UseVisualStyleBackColor = true;
            this.btChinhSua_QLD.Click += new System.EventHandler(this.btChinhSua_QLD_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(512, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Điểm Thi(*):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btXacNhan_QLD
            // 
            this.btXacNhan_QLD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan_QLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btXacNhan_QLD.Image = global::A.GiaoDien.Properties.Resources.camera_test;
            this.btXacNhan_QLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXacNhan_QLD.Location = new System.Drawing.Point(187, 56);
            this.btXacNhan_QLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXacNhan_QLD.Name = "btXacNhan_QLD";
            this.btXacNhan_QLD.Size = new System.Drawing.Size(155, 52);
            this.btXacNhan_QLD.TabIndex = 3;
            this.btXacNhan_QLD.Text = "Xác Nhận";
            this.btXacNhan_QLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXacNhan_QLD.UseVisualStyleBackColor = true;
            this.btXacNhan_QLD.Click += new System.EventHandler(this.btXacNhan_QLD_Click);
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(157, 26);
            this.txtDiemQuaTrinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(199, 22);
            this.txtDiemQuaTrinh.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Điểm Quá Trình(*):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cbHocKy);
            this.groupBox3.Controls.Add(this.cbMonHoc);
            this.groupBox3.Controls.Add(this.txtTenSinhVien);
            this.groupBox3.Controls.Add(this.txtMaSinhVien);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(20, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(935, 120);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điền Và Chọn Những Thông Tin Cần Thiết.";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(861, 85);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "Enter";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(159, 72);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(199, 24);
            this.cbHocKy.TabIndex = 3;
            this.cbHocKy.SelectedValueChanged += new System.EventHandler(this.ChonKyHocDeXemDiemCuaSinhVien);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(653, 77);
            this.cbMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(199, 24);
            this.cbMonHoc.TabIndex = 4;
            this.cbMonHoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TimKiemMonHoc);
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSinhVien.ForeColor = System.Drawing.Color.Green;
            this.txtTenSinhVien.Location = new System.Drawing.Point(653, 27);
            this.txtTenSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(199, 23);
            this.txtTenSinhVien.TabIndex = 2;
            this.txtTenSinhVien.TextChanged += new System.EventHandler(this.txtTenSinhVien_TextChanged);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(157, 26);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(199, 22);
            this.txtMaSinhVien.TabIndex = 1;
            this.txtMaSinhVien.TextChanged += new System.EventHandler(this.txtMaSinhVien_TextChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(16, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Học Kỳ(*):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(507, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Môn Học(*):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Sinh Viên(*):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(511, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Sinh Viên:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(291, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(414, 42);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quản Lý Điểm Sinh Viên";
            // 
            // brCuoi
            // 
            this.brCuoi.Image = global::A.GiaoDien.Properties.Resources.Cuoi;
            this.brCuoi.Location = new System.Drawing.Point(652, 315);
            this.brCuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brCuoi.Name = "brCuoi";
            this.brCuoi.Size = new System.Drawing.Size(67, 48);
            this.brCuoi.TabIndex = 4;
            this.brCuoi.Text = ".";
            this.brCuoi.UseVisualStyleBackColor = true;
            this.brCuoi.Click += new System.EventHandler(this.brCuoi_Click);
            // 
            // btSau
            // 
            this.btSau.Image = global::A.GiaoDien.Properties.Resources.Tiep;
            this.btSau.Location = new System.Drawing.Point(531, 315);
            this.btSau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSau.Name = "btSau";
            this.btSau.Size = new System.Drawing.Size(67, 48);
            this.btSau.TabIndex = 3;
            this.btSau.Text = ".";
            this.btSau.UseVisualStyleBackColor = true;
            this.btSau.Click += new System.EventHandler(this.btSau_Click);
            // 
            // btTruoc
            // 
            this.btTruoc.Image = global::A.GiaoDien.Properties.Resources.Sau;
            this.btTruoc.Location = new System.Drawing.Point(409, 315);
            this.btTruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTruoc.Name = "btTruoc";
            this.btTruoc.Size = new System.Drawing.Size(67, 48);
            this.btTruoc.TabIndex = 2;
            this.btTruoc.Text = ".";
            this.btTruoc.UseVisualStyleBackColor = true;
            this.btTruoc.Click += new System.EventHandler(this.btTruoc_Click);
            // 
            // btDau
            // 
            this.btDau.Image = global::A.GiaoDien.Properties.Resources.Dau;
            this.btDau.Location = new System.Drawing.Point(295, 315);
            this.btDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDau.Name = "btDau";
            this.btDau.Size = new System.Drawing.Size(67, 48);
            this.btDau.TabIndex = 1;
            this.btDau.Text = ".";
            this.btDau.UseVisualStyleBackColor = true;
            this.btDau.Click += new System.EventHandler(this.btDau_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 730);
            this.Controls.Add(this.brCuoi);
            this.Controls.Add(this.btSau);
            this.Controls.Add(this.btTruoc);
            this.Controls.Add(this.btDau);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbKetQuaHocTap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brCuoi;
        private System.Windows.Forms.Button btSau;
        private System.Windows.Forms.Button btTruoc;
        private System.Windows.Forms.Button btDau;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView tbKetQuaHocTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketluan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Button btChinhSua_QLD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btXacNhan_QLD;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btXoa;
    }
}