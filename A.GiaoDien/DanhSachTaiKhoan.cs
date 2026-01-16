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
    public partial class DanhSachTaiKhoan : Form
    {
        //KHAI BÁO DÙNG CHUNG
        DangNhap_B cls_DangNhap = new DangNhap_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string TaiKhoan = null;
        public DanhSachTaiKhoan()
        {
            InitializeComponent();
        }
        //SAU KHI KOWIR TẠO
        private void DanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                tbDanhSachTaiKhoan.DataSource = cls_DangNhap.DanhSachTaiKhoan();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(DangNhap_ThongTin DN)
        {
            this.TaiKhoan = DN.TaiKhoan;
            if (!this.TaiKhoan.Equals(""))
            {
                try
                {
                    tbDanhSachTaiKhoan.DataSource = cls_DangNhap.DanhSachTaiKhoan();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemTaiKhoan()
        {
            ChucNang = "F9";
            DangNhap_ThongTin DangNhap = new DangNhap_ThongTin();
            A.GiaoDien.QuanLyTaiKhoan QLTK = new A.GiaoDien.QuanLyTaiKhoan(ChucNang, DangNhap);
            QLTK.DuLieu = new QuanLyTaiKhoan.DuLieuTruyenVe(LayDuLieu);
            QLTK.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaTaiKhoan()
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (tbDanhSachTaiKhoan.CurrentRow == null || tbDanhSachTaiKhoan.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản nào để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dòng đang được chọn một cách an toàn
                DataGridViewRow selectedRow = tbDanhSachTaiKhoan.CurrentRow;

                ChucNang = "F10";
                DangNhap_ThongTin DangNhap = new DangNhap_ThongTin();

                // Lấy dữ liệu bằng TÊN CỘT
                DangNhap.TaiKhoan = selectedRow.Cells["Column1"].Value.ToString();
                DangNhap.Quyen = selectedRow.Cells["Column2"].Value.ToString();

                // Mở form sửa
                A.GiaoDien.QuanLyTaiKhoan QLTK = new A.GiaoDien.QuanLyTaiKhoan(ChucNang, DangNhap);
                QLTK.DuLieu = new QuanLyTaiKhoan.DuLieuTruyenVe(LayDuLieu);
                QLTK.ShowDialog(this);

                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy thông tin tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //KÍCH SỬA
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaTaiKhoan();
        }
        //KÍCH VÀO BẢNG
        private void tbDanhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA TÀI KHOẢN
        private void XoaTaiKhoan()
        {
            // Dùng CurrentRow để kiểm tra
            if (tbDanhSachTaiKhoan.CurrentRow == null || tbDanhSachTaiKhoan.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn hãy chọn tài khoản muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = tbDanhSachTaiKhoan.CurrentRow;
            DangNhap_ThongTin DangNhap = new DangNhap_ThongTin();

            // Lấy dữ liệu bằng TÊN CỘT
            DangNhap.TaiKhoan = selectedRow.Cells["Column1"].Value.ToString();

            // Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản " + DangNhap.TaiKhoan + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cls_DangNhap.XoaTaiKhoan(DangNhap);
                    // Tải lại dữ liệu sau khi xóa thành công
                    tbDanhSachTaiKhoan.DataSource = cls_DangNhap.DanhSachTaiKhoan();
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
            XoaTaiKhoan();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                DangNhap_ThongTin DN = new DangNhap_ThongTin();
                DN.TaiKhoan = txtTimKiem.Text;
                tbDanhSachTaiKhoan.DataSource = cls_DangNhap.TimKiemTaiKhoan(DN);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemTaiKhoan();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaTaiKhoan();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaTaiKhoan();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
            txtTimKiem.Focus();
        }

        private void KichDup(object sender, MouseEventArgs e)
        {
            SuaTaiKhoan();
            txtTimKiem.Focus();
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            DangNhap_ThongTin DN = new DangNhap_ThongTin();
            DN.TaiKhoan = txtTimKiem.Text;
            BaoCao.BaoCao.DuLieu = cls_DangNhap.TimKiemTaiKhoan(DN);
            BaoCao.BaoCao.Kieu = "TimKiemTaiKhoan";
            BaoCao.BaoCao BC = new BaoCao.BaoCao();
            BC.ShowDialog();
        }
    }
}
