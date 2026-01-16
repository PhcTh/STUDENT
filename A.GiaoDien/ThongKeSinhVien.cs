using System;
using System.Data;
using System.Windows.Forms;
using B.ThaoTac;
using System.Windows.Forms.DataVisualization.Charting;

namespace A.GiaoDien
{
    public partial class ThongKeSinhVien : Form
    {
        // Khai báo lớp nghiệp vụ
        SinhVien_B cls_SinhVien_B = new SinhVien_B();

        public ThongKeSinhVien()
        {
            InitializeComponent();
        }

        private void ThongKeSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Gọi đến lớp B để lấy dữ liệu thống kê
                DataTable dt = cls_SinhVien_B.ThongKeSinhVienTheoKhoa();
                // 2. Gán dữ liệu cho DataGridView
                tbThongKe.DataSource = dt;
                // Tùy chỉnh tên cột cho đẹp hơn
                tbThongKe.Columns["Tenkhoa"].HeaderText = "Tên Khoa";
                tbThongKe.Columns["MaKhoaHoc"].HeaderText = "Khóa Học";
                tbThongKe.Columns["SoLuongSinhVien"].HeaderText = "Số Lượng Sinh Viên";
                // 3. Vẽ biểu đồ từ dữ liệu đã lấy
                VeBieuDo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu thống kê. Lỗi: " + ex.Message);
            }
        }

        // Phương thức để vẽ biểu đồ
        private void VeBieuDo(DataTable dt)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();
            chartThongKe.Titles.Add("Biểu đồ Thống kê Sinh viên theo Khóa học");

            Series series = new Series
            {
                Name = "SoLuongSinhVien",
                IsVisibleInLegend = true, // Hiện chú giải
                ChartType = SeriesChartType.Pie
            };

            chartThongKe.Series.Add(series);

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string khoahoc = row["MaKhoaHoc"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuongSinhVien"]);
                series.Points.AddXY(khoahoc, soLuong);
            }
            // hiển thị % trên biểu đồ và tên khóa học
            series.Label = "#PERCENT{P0}";
            series.LegendText = "#VALX";
        }

        private void tbThongKe_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (tbThongKe.CurrentRow != null && !tbThongKe.CurrentRow.IsNewRow)
            {
                try
                {
                    // Lấy mã khóa học từ dòng được kích đúp
                    string maKhoaHocDuocChon = tbThongKe.CurrentRow.Cells["MaKhoaHoc"].Value.ToString();
                    // Mở form DanhSachSinhVien với hàm khởi tạo mới để lọc
                    DanhSachSinhVien frm = new DanhSachSinhVien();
                    frm.MaKhoaHocFilter = maKhoaHocDuocChon;
                    frm.Text = "Danh sách Sinh viên Khóa " + maKhoaHocDuocChon;
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu đang hiển thị trên DataGridView
            DataTable dt = (DataTable)tbThongKe.DataSource;

            // Gán dữ liệu và loại báo cáo cho form BaoCao
            A.GiaoDien.BaoCao.BaoCao.DuLieu = dt;
            A.GiaoDien.BaoCao.BaoCao.Kieu = "ThongKeSinhVien"; // Đặt đúng loại báo cáo

            // Mở form báo cáo
            A.GiaoDien.BaoCao.BaoCao frmBaoCao = new A.GiaoDien.BaoCao.BaoCao();
            frmBaoCao.ShowDialog();
        }
    }
}