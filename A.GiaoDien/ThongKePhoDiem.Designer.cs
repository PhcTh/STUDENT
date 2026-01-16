namespace A.GiaoDien
{
    partial class ThongKePhoDiem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tbPhoDiem = new System.Windows.Forms.DataGridView();
            this.chartPhoDiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhoDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhoDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(522, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ PHỔ ĐIỂM MÔN HỌC";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(199, 153);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(455, 44);
            this.cbMonHoc.TabIndex = 1;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(859, 155);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(496, 44);
            this.cbHocKy.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Red;
            this.btnThongKe.Location = new System.Drawing.Point(1431, 152);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(166, 50);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tbPhoDiem
            // 
            this.tbPhoDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbPhoDiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbPhoDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhoDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPhoDiem.Location = new System.Drawing.Point(73, 255);
            this.tbPhoDiem.Name = "tbPhoDiem";
            this.tbPhoDiem.RowHeadersWidth = 82;
            this.tbPhoDiem.RowTemplate.Height = 33;
            this.tbPhoDiem.Size = new System.Drawing.Size(1000, 553);
            this.tbPhoDiem.TabIndex = 4;
            // 
            // chartPhoDiem
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPhoDiem.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPhoDiem.Legends.Add(legend1);
            this.chartPhoDiem.Location = new System.Drawing.Point(1136, 274);
            this.chartPhoDiem.Name = "chartPhoDiem";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPhoDiem.Series.Add(series1);
            this.chartPhoDiem.Size = new System.Drawing.Size(610, 515);
            this.chartPhoDiem.TabIndex = 5;
            this.chartPhoDiem.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(719, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Học Kỳ:";
            // 
            // ThongKePhoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 887);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartPhoDiem);
            this.Controls.Add(this.tbPhoDiem);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.label1);
            this.Name = "ThongKePhoDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKePhoDiem";
            this.Load += new System.EventHandler(this.ThongKePhoDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPhoDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhoDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView tbPhoDiem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhoDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}