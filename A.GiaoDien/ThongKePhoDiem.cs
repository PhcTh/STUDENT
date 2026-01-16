using System;
using System.Data;
using System.Windows.Forms;
using B.ThaoTac;
using D.ThongTin;
using System.Windows.Forms.DataVisualization.Charting;

namespace A.GiaoDien
{
    public partial class ThongKePhoDiem : Form
    {
        // Khai báo các lớp nghiệp vụ cần dùng
        MonHoc_B cls_MonHoc_B = new MonHoc_B();
        HocKy_B cls_HocKy_B = new HocKy_B();
        BangDiem_B cls_BangDiem_B = new BangDiem_B();

        public ThongKePhoDiem()
        {
            InitializeComponent();
        }
        private void ThongKePhoDiem_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu cho 2 ComboBox
            try
            {
                cbHocKy.DataSource = cls_HocKy_B.DanhSachHocKy();
                cbHocKy.DisplayMember = "TenHocKy";
                cbHocKy.ValueMember = "MaHocKy";

                cbMonHoc.DataSource = cls_MonHoc_B.DanhSachMonHoc();
                cbMonHoc.DisplayMember = "TenMonHoc";
                cbMonHoc.ValueMember = "MaMonHoc";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách môn học hoặc học kỳ. Lỗi: " + ex.Message);
            }
        }

        // Sự kiện khi nhấn nút "Thống Kê"
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedValue == null || cbHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Môn học và Học kỳ.");
                return;
            }

            try
            {
                // 1. Chuẩn bị dữ liệu đầu vào
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaMonHoc = cbMonHoc.SelectedValue.ToString();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();

                // 2. Lấy dữ liệu thống kê
                DataTable dt = cls_BangDiem_B.ThongKePhoDiemMonHoc(BD);

                // 3. Hiển thị lên DataGridView
                tbPhoDiem.DataSource = dt;
                if (tbPhoDiem.Columns["DiemChu"] != null)
                {
                    tbPhoDiem.Columns["DiemChu"].HeaderText = "Điểm Chữ";
                }
                if (tbPhoDiem.Columns["SoLuongSinhVien"] != null)
                {
                    tbPhoDiem.Columns["SoLuongSinhVien"].HeaderText = "Số Lượng Sinh Viên";
                }
                // 4. Vẽ biểu đồ
                VeBieuDo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thống kê. Lỗi: " + ex.Message);
            }
        }

        // Phương thức để vẽ biểu đồ
        private void VeBieuDo(DataTable dt)
        {
            chartPhoDiem.Series.Clear();
            chartPhoDiem.Titles.Clear();
            chartPhoDiem.Titles.Add("Phổ điểm môn " + cbMonHoc.Text);

            Series series = new Series
            {
                Name = "PhoDiem",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            chartPhoDiem.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                string diemChu = row["DiemChu"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuongSinhVien"]);
                series.Points.AddXY(diemChu, soLuong);
            }

            series.Label = "#PERCENT{P0}";
            series.LegendText = "#VALX (#VALY)"; // Hiển thị cả tên và số lượng trong chú giải
        }
    }
}