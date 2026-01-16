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
    public partial class DanhSachMonHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //MÔN HỌC
        MonHoc_B cls_MonHoc = new MonHoc_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaMonHoc = null;
        private string quyenHienTai = "";
        public DanhSachMonHoc(string quyenHienTai)
        {
            InitializeComponent();
            this.quyenHienTai = quyenHienTai;

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
        //SAU KHI KHỞI TẠO
        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            try
            {
                tbDanhSachMonHoc.DataSource = cls_MonHoc.DanhSachMonHocToanTruong();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(MonHoc_ThongTin MonHoc)
        {
            this.MaMonHoc = MonHoc.MaMonHoc;
            if (!this.MaMonHoc.Equals(""))
            {
                try
                {
                    tbDanhSachMonHoc.DataSource = cls_MonHoc.DanhSachMonHocToanTruong();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemMonHoc()
        {
            ChucNang = "F9";
            MonHoc_ThongTin MonHoc = new MonHoc_ThongTin();
            A.GiaoDien.MonHoc MH = new A.GiaoDien.MonHoc(ChucNang, MonHoc);
            MH.DuLieu = new MonHoc.DuLieuTruyenVe(LayDuLieu);
            MH.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemMonHoc();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaMonHoc()
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (tbDanhSachMonHoc.CurrentRow == null || tbDanhSachMonHoc.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn chưa chọn môn học nào để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dòng đang được chọn một cách an toàn
                DataGridViewRow selectedRow = tbDanhSachMonHoc.CurrentRow;

                ChucNang = "F10";
                MonHoc_ThongTin MonHoc = new MonHoc_ThongTin();

                // Lấy dữ liệu bằng TÊN CỘT
                MonHoc.MaMonHoc = selectedRow.Cells["Column1"].Value.ToString();
                MonHoc.TenMonHoc = selectedRow.Cells["Column2"].Value.ToString();

                // Ép kiểu số một cách an toàn để tránh lỗi
                int soTinChi;
                if (int.TryParse(selectedRow.Cells["Column3"].Value.ToString(), out soTinChi))
                {
                    MonHoc.SoTinChi = soTinChi;
                }

                // Mở form sửa
                A.GiaoDien.MonHoc MH = new A.GiaoDien.MonHoc(ChucNang, MonHoc);
                MH.DuLieu = new MonHoc.DuLieuTruyenVe(LayDuLieu);
                MH.ShowDialog(this);

                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy thông tin môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaMonHoc();
            txtTimKiem.Focus();
        }
        //KÍCH VÀO BẢNG
        private void tbDanhSachMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA MÔN HỌC
        private void XoaMonHoc()
        {
            // Dùng CurrentRow để kiểm tra, thay cho biến cờ
            if (tbDanhSachMonHoc.CurrentRow == null || tbDanhSachMonHoc.CurrentRow.IsNewRow)
            {
                // Sửa lại thông báo cho chính xác
                MessageBox.Show("Bạn hãy chọn môn học muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = tbDanhSachMonHoc.CurrentRow;
            MonHoc_ThongTin MonHoc = new MonHoc_ThongTin();

            // Lấy dữ liệu bằng TÊN CỘT
            MonHoc.MaMonHoc = selectedRow.Cells["Column1"].Value.ToString();

            // Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học có mã " + MonHoc.MaMonHoc + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cls_MonHoc.XoaMonHoc(MonHoc);
                    // Tải lại dữ liệu sau khi xóa thành công
                    tbDanhSachMonHoc.DataSource = cls_MonHoc.DanhSachMonHocToanTruong();
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
            XoaMonHoc();
            txtTimKiem.Focus();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                MonHoc_ThongTin MH = new MonHoc_ThongTin();
                MH.MaMonHoc = txtTimKiem.Text;
                tbDanhSachMonHoc.DataSource = cls_MonHoc.TimMonHoc(MH);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemMonHoc();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaMonHoc();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaMonHoc();
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
                SuaMonHoc();
                txtTimKiem.Focus();
            }
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            MonHoc_ThongTin MH = new MonHoc_ThongTin();
            MH.MaMonHoc = txtTimKiem.Text;
            BaoCao.BaoCao.DuLieu = cls_MonHoc.TimMonHoc(MH);
            BaoCao.BaoCao.Kieu = "TimKiemMonHoc";
            BaoCao.BaoCao BC = new BaoCao.BaoCao();
            BC.ShowDialog();
        }
    }
}
