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
    public partial class DanhSachHeDaoTao : Form
    {
        //KHAI BÁO DÙNG CHUNG
        HeDaoTao_B cls_HeDaoTao = new HeDaoTao_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaHe = null;
        private string quyenHienTai = "";
        public DanhSachHeDaoTao(string quyen)
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
            else
            {
                btThem.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
        }
        //SAU KHI KHỞI TẠO
        private void DanhSachHeDaoTao_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            try
            {
                tbHeDaoTao.DataSource = cls_HeDaoTao.DanhSachHeDaoTao();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(HeDaoTao_ThongTin HDT)
        {
            this.MaHe = HDT.MaHe;
            if (!this.MaHe.Equals(""))
            {
                try
                {
                    tbHeDaoTao.DataSource = cls_HeDaoTao.DanhSachHeDaoTao();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemHeDaoTao()
        {
            ChucNang = "F9";
            HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();
            A.GiaoDien.QuanLyHeDaoTao QLHDT = new A.GiaoDien.QuanLyHeDaoTao(ChucNang, HDT);
            QLHDT.DuLieu = new QuanLyHeDaoTao.DuLieuTruyenVe(LayDuLieu);
            QLHDT.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemHeDaoTao();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaHeDaoTao()
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (tbHeDaoTao.CurrentRow == null || tbHeDaoTao.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn chưa chọn hệ đào tạo nào để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dòng đang được chọn một cách an toàn
                DataGridViewRow selectedRow = tbHeDaoTao.CurrentRow;

                ChucNang = "F10";
                HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();

                // Lấy dữ liệu bằng TÊN CỘT
                HDT.MaHe = selectedRow.Cells["Column1"].Value.ToString();
                HDT.TenHe = selectedRow.Cells["Column2"].Value.ToString();

                // Mở form sửa
                A.GiaoDien.QuanLyHeDaoTao QLHDT = new A.GiaoDien.QuanLyHeDaoTao(ChucNang, HDT);
                QLHDT.DuLieu = new QuanLyHeDaoTao.DuLieuTruyenVe(LayDuLieu);
                QLHDT.ShowDialog(this);

                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy thông tin hệ đào tạo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SuaHeDaoTao();
            txtTimKiem.Focus();
        }
        //KÍCH VÀO BẢNG
        private void tbHeDaoTao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA HỆ ĐÀO TẠO
        private void XoaHeDaoTao()
        {
            // Dùng CurrentRow để kiểm tra, thay cho biến cờ. An toàn và chính xác hơn.
            if (tbHeDaoTao.CurrentRow == null || tbHeDaoTao.CurrentRow.IsNewRow)
            {
                // Sửa lại thông báo cho chính xác
                MessageBox.Show("Bạn hãy chọn hệ đào tạo muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = tbHeDaoTao.CurrentRow;
            HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();

            // Lấy dữ liệu bằng TÊN CỘT
            HDT.MaHe = selectedRow.Cells["Column1"].Value.ToString();

            // Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có thật sự muốn xóa hệ đào tạo có mã " + HDT.MaHe + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cls_HeDaoTao.XoaHeDaoTao(HDT);
                    // Tải lại dữ liệu sau khi xóa thành công
                    tbHeDaoTao.DataSource = cls_HeDaoTao.DanhSachHeDaoTao();
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
            XoaHeDaoTao();
            txtTimKiem.Focus();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();
                HDT.MaHe = txtTimKiem.Text;
                tbHeDaoTao.DataSource = cls_HeDaoTao.TimKiemHeDaoTao(HDT);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemHeDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaHeDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaHeDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
            txtTimKiem.Focus();
        }

        private void KhiKichDupChuot(object sender, MouseEventArgs e)
        {
            if (this.quyenHienTai == "Admin")
            {
                SuaHeDaoTao();
                txtTimKiem.Focus();
            }
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            HeDaoTao_ThongTin HDT = new HeDaoTao_ThongTin();
            HDT.MaHe = txtTimKiem.Text;
            BaoCao.BaoCao.DuLieu = cls_HeDaoTao.TimKiemHeDaoTao(HDT);
            BaoCao.BaoCao.Kieu = "TimKiemHeDaoTao";
            BaoCao.BaoCao BC = new BaoCao.BaoCao();
            BC.ShowDialog();
        }
    }
}
