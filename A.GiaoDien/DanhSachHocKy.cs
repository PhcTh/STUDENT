using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using D.ThongTin;
using B.ThaoTac;

namespace A.GiaoDien
{
    public partial class DanhSachHocKy : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //HỌC KỲ
        HocKy_B cls_HocKy = new HocKy_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaHocKy = null;
        private string quyenHienTai = "";
        public DanhSachHocKy(string quyen)
        {
            InitializeComponent();
            this.quyenHienTai = quyen;
        }
        private void PhanQuyen()
        {
            // Chỉ có Admin mới có đầy đủ các quyền
            if (this.quyenHienTai == "Admin")
            {
                btThem.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
            else // Các quyền khác chỉ được xem và tìm kiếm
            {
                btThem.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
        }
        //SAU KHI KHỞI TẠO.
        private void DanhSachHocKy_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            try
            {
                tbDanhSachHocKy.DataSource = cls_HocKy.DanhSachThongTinHocKy();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(HocKy_ThongTin HocKy)
        {
            this.MaHocKy = HocKy.MaHocKy;
            if (!this.MaHocKy.Equals(""))
            {
                try
                {
                    tbDanhSachHocKy.DataSource = cls_HocKy.DanhSachThongTinHocKy();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemHocKy()
        {
            ChucNang = "F9";
            HocKy_ThongTin HocKy = new HocKy_ThongTin();
            A.GiaoDien.QuanLyHocKy QLHK = new A.GiaoDien.QuanLyHocKy(ChucNang, HocKy);
            QLHK.DuLieu = new QuanLyHocKy.DuLieuTruyenVe(LayDuLieu);
            QLHK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemHocKy();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaHocKy()
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (tbDanhSachHocKy.CurrentRow == null || tbDanhSachHocKy.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn chưa chọn học kỳ nào để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dòng đang được chọn một cách an toàn
                DataGridViewRow selectedRow = tbDanhSachHocKy.CurrentRow;

                ChucNang = "F10";
                HocKy_ThongTin HocKy = new HocKy_ThongTin();

                // Lấy dữ liệu bằng TÊN CỘT
                HocKy.MaHocKy = selectedRow.Cells["Column1"].Value.ToString(); //mã học kì
                HocKy.TenHocKy = selectedRow.Cells["Column2"].Value.ToString();

                // Mở form sửa
                A.GiaoDien.QuanLyHocKy QLHK = new A.GiaoDien.QuanLyHocKy(ChucNang, HocKy);
                QLHK.DuLieu = new QuanLyHocKy.DuLieuTruyenVe(LayDuLieu);
                QLHK.ShowDialog(this);

                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy thông tin học kỳ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //KÍCH VÀO BẢNG
        private void tbDanhSachHocKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaHocKy();
        }
        //XÓA HỌC KỲ
        private void XoaHocKy()
        {
            // Dùng CurrentRow để kiểm tra, thay cho biến cờ
            if (tbDanhSachHocKy.CurrentRow == null || tbDanhSachHocKy.CurrentRow.IsNewRow)
            {
                // Sửa lại thông báo cho chính xác
                MessageBox.Show("Bạn hãy chọn học kỳ muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = tbDanhSachHocKy.CurrentRow;
            HocKy_ThongTin HocKy = new HocKy_ThongTin();

            // Lấy dữ liệu bằng TÊN CỘT
            HocKy.MaHocKy = selectedRow.Cells["Column1"].Value.ToString();

            // Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có thật sự muốn xóa học kỳ có mã " + HocKy.MaHocKy + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cls_HocKy.XoaHocKy(HocKy);
                    // Tải lại dữ liệu sau khi xóa thành công
                    tbDanhSachHocKy.DataSource = cls_HocKy.DanhSachThongTinHocKy();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này. Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        private void btXoa_Click(object sender, EventArgs e)
        {
            XoaHocKy();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                HocKy_ThongTin HK = new HocKy_ThongTin();
                HK.MaHocKy = txtTimKiem.Text;
                tbDanhSachHocKy.DataSource = cls_HocKy.TimKiemHocKy(HK);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemHocKy();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaHocKy();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaHocKy();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
            txtTimKiem.Focus();
        }

        private void KichDupChuot(object sender, MouseEventArgs e)
        {
            if (this.quyenHienTai == "Admin")
            {
                SuaHocKy();
                txtTimKiem.Focus();
            }

        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            HocKy_ThongTin HK = new HocKy_ThongTin();
            HK.MaHocKy = txtTimKiem.Text;
            BaoCao.BaoCao.DuLieu = cls_HocKy.TimKiemHocKy(HK);
            BaoCao.BaoCao.Kieu = "TimKiemHocKy";
            BaoCao.BaoCao BC = new BaoCao.BaoCao();
            BC.ShowDialog();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
