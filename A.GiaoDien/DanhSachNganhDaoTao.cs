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
    public partial class DanhSachNganhDaoTao : Form
    {
        //KHAI BÁO DÙNG CHUNG
        NganhDaoTao_B cls_NganhDaoTao = new NganhDaoTao_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaNganh = null;
        private string quyenHienTai = "";
        public DanhSachNganhDaoTao(string quyenHienTai)
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
        private void DanhSachNganhDaoTao_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            try
            {
                tbNganhDaoTao.DataSource = cls_NganhDaoTao.DanhSachThongTinNganhDaoTao();
            }
            catch { }
            txtTimKiem.Focus();
        }
        //LẤY DỮ LIỆU GỬI VỀ.
        public void LayDuLieu(NganhDaoTao_ThongTin NDT)
        {
            this.MaNganh = NDT.MaNganh;
            if (!this.MaNganh.Equals(""))
            {
                try
                {
                    tbNganhDaoTao.DataSource = cls_NganhDaoTao.DanhSachThongTinNganhDaoTao();
                }
                catch { }
            }
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON THÊM
        private void ThemNganhDaoTao()
        {
            ChucNang = "F9";
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
            A.GiaoDien.QuanLyNganhDaoTao QLNDT = new A.GiaoDien.QuanLyNganhDaoTao(ChucNang, NDT);
            QLNDT.DuLieu = new QuanLyNganhDaoTao.DuLieuTruyenVe(LayDuLieu);
            QLNDT.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        //
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemNganhDaoTao();
            txtTimKiem.Focus();
        }
        //KHI KÍCH BUTTON SỬA THÔNG TIN
        private void SuaNganhDaoTao()
        {
            // Bước 1: Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (tbNganhDaoTao.CurrentRow == null || tbNganhDaoTao.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn chưa chọn ngành đào tạo nào để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu chưa có dòng nào hợp lệ được chọn
            }

            try
            {
                // Bước 2: Lấy dòng đang được chọn một cách an toàn
                DataGridViewRow selectedRow = tbNganhDaoTao.CurrentRow;

                ChucNang = "F10";
                NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();

                // Bước 3: Lấy dữ liệu trực tiếp từ "selectedRow" bằng TÊN CỘT
                // Hãy chắc chắn tên các cột trong DataGridView của bạn được đặt đúng là "MaNganh", "TenNganh", "MaKhoa"
                NDT.MaNganh = selectedRow.Cells["Column1"].Value.ToString();
                NDT.TenNganh = selectedRow.Cells["Column2"].Value.ToString();
                NDT.MaKhoa = selectedRow.Cells["Column2"].Value.ToString(); // Dòng này giờ sẽ hoạt động đúng

                // Bước 4: Mở form sửa
                A.GiaoDien.QuanLyNganhDaoTao QLNDT = new A.GiaoDien.QuanLyNganhDaoTao(ChucNang, NDT);
                QLNDT.DuLieu = new QuanLyNganhDaoTao.DuLieuTruyenVe(LayDuLieu);
                QLNDT.ShowDialog(this);

                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy thông tin ngành đào tạo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNganhDaoTao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SuaNganhDaoTao();
        }
        //XÓA NGÀNH ĐÀO TẠO.
        private void XoaNganhDaoTao()
        {
            // Bước 1: Dùng CurrentRow để kiểm tra, thay cho biến cờ. An toàn và chính xác hơn.
            if (tbNganhDaoTao.CurrentRow == null || tbNganhDaoTao.CurrentRow.IsNewRow)
            {
                // Sửa lại thông báo cho chính xác
                MessageBox.Show("Bạn hãy chọn ngành đào tạo muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = tbNganhDaoTao.CurrentRow;
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();

            // Bước 2: Lấy dữ liệu bằng TÊN CỘT, không dùng chỉ số
            NDT.MaNganh = selectedRow.Cells["Column1"].Value.ToString();

            // Bước 3: Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có thật sự muốn xóa ngành đào tạo có mã " + NDT.MaNganh + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cls_NganhDaoTao.XoaNganhDaoTao(NDT);
                    // Tải lại dữ liệu sau khi xóa thành công
                    tbNganhDaoTao.DataSource = cls_NganhDaoTao.DanhSachThongTinNganhDaoTao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này. Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            XoaNganhDaoTao();
        }

        private void KhiAnTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
                NDT.MaNganh = txtTimKiem.Text;
                tbNganhDaoTao.DataSource = cls_NganhDaoTao.TimKiemThongTinNganhDaoTao(NDT);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemNganhDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaNganhDaoTao();
                txtTimKiem.Focus();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaNganhDaoTao();
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
                SuaNganhDaoTao();
                txtTimKiem.Focus();
            }

        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            NganhDaoTao_ThongTin NDT = new NganhDaoTao_ThongTin();
            NDT.MaNganh = txtTimKiem.Text;
            BaoCao.BaoCao.DuLieu = cls_NganhDaoTao.TimKiemThongTinNganhDaoTao(NDT);
            BaoCao.BaoCao.Kieu = "TimKiemNganhDaoTao";
            BaoCao.BaoCao BC = new BaoCao.BaoCao();
            BC.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
