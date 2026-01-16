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
    public partial class DanhSachKhoaHoc : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG KHÓA HỌC
        KhoaHoc_B cls_KhoaHoc = new KhoaHoc_B();
        //
        string ChucNang = null;
        int DongChon = 0;
        int XacNhanXoa = 0;
        string MaKhoaHoc = null;
        private string quyenHienTai = "";
        public DanhSachKhoaHoc(string quyen)
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
        private void DanhSachKhoaHoc_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            txtTimKiem.Focus();
            try
            {
                tbKhoaHoc.DataSource = cls_KhoaHoc.DanhSach_ThongTin_KhoaHoc();
            }
            catch { }
        }


        public void LayDuLieu(KhoaHoc_ThongTin KhoaHoc)
        {

            this.MaKhoaHoc = KhoaHoc.MaKhoaHoc;
            if (!this.MaKhoaHoc.Equals(""))
            {
                try
                {
                    tbKhoaHoc.DataSource = cls_KhoaHoc.DanhSach_ThongTin_KhoaHoc();
                }
                catch { }
            }
        }
        //KHI CLICK BUTTON THÊM
        private void ThemKhoaHoc()
        {
            ChucNang = "F9";
            KhoaHoc_ThongTin KhoaHoc = new KhoaHoc_ThongTin();
            A.GiaoDien.KhoaHoc DSKH = new A.GiaoDien.KhoaHoc(ChucNang, KhoaHoc);
            DSKH.DuLieu = new KhoaHoc.DuLieuTruyenVe(LayDuLieu);
            DSKH.ShowDialog(this);
            XacNhanXoa = 0;
            txtTimKiem.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemKhoaHoc();
        }
        //KHI CLICK BUTTON SỬA
        private void SuaKhoaHoc()
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (tbKhoaHoc.CurrentRow == null || tbKhoaHoc.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn chưa chọn khóa học nào để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dòng đang được chọn một cách an toàn
                DataGridViewRow selectedRow = tbKhoaHoc.CurrentRow;

                ChucNang = "F10";
                KhoaHoc_ThongTin KhoaHoc = new KhoaHoc_ThongTin();

                // Lấy dữ liệu bằng TÊN CỘT
                KhoaHoc.MaKhoaHoc = selectedRow.Cells["Column1"].Value.ToString();

                // Ép kiểu DateTime một cách an toàn để tránh lỗi
                DateTime ngayBatDau, ngayKetThuc;
                if (DateTime.TryParse(selectedRow.Cells["Column2"].Value.ToString(), out ngayBatDau))
                {
                    KhoaHoc.NgayBatDau = ngayBatDau;
                }
                if (DateTime.TryParse(selectedRow.Cells["Column3"].Value.ToString(), out ngayKetThuc))
                {
                    KhoaHoc.NgayKetThuc = ngayKetThuc;
                }

                // Mở form sửa
                A.GiaoDien.KhoaHoc DSKH = new A.GiaoDien.KhoaHoc(ChucNang, KhoaHoc);
                DSKH.DuLieu = new KhoaHoc.DuLieuTruyenVe(LayDuLieu);
                DSKH.ShowDialog(this);

                XacNhanXoa = 0;
                txtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy thông tin khóa học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            SuaKhoaHoc();
        }

        private void tbKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DongChon = e.RowIndex;
            XacNhanXoa = 1;
            txtTimKiem.Focus();
        }
        //XÓA KHÓA HỌC
        private void XoaKhoaHoc()
        {
            // Dùng CurrentRow để kiểm tra, thay cho biến cờ
            if (tbKhoaHoc.CurrentRow == null || tbKhoaHoc.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Bạn hãy chọn khóa học muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = tbKhoaHoc.CurrentRow;
            KhoaHoc_ThongTin KhoaHoc = new KhoaHoc_ThongTin();

            // Lấy dữ liệu bằng TÊN CỘT
            KhoaHoc.MaKhoaHoc = selectedRow.Cells["Column1"].Value.ToString();// mã khóa học

            // Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có thật sự muốn xóa khóa học " + KhoaHoc.MaKhoaHoc + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int kq = cls_KhoaHoc.XoaKhoaHoc(KhoaHoc);

                    if (kq > 0)
                    {
                        tbKhoaHoc.DataSource = cls_KhoaHoc.DanhSach_ThongTin_KhoaHoc();
                        MessageBox.Show("Xóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khóa học để xóa (hoặc đã bị xóa trước đó).", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            XoaKhoaHoc();
        }
        //BẮT SỰ KIỆN PHÍM TẮT - VÀ TÌM KIẾM.
        private void KhiAnOTimKiem(object sender, KeyEventArgs e)
        {
            if (!e.KeyValue.ToString().Equals("120") && !e.KeyValue.ToString().Equals("121") && !e.KeyValue.ToString().Equals("122") && !e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.White;
                KhoaHoc_ThongTin KH = new KhoaHoc_ThongTin();
                KH.MaKhoaHoc = txtTimKiem.Text;
                tbKhoaHoc.DataSource = cls_KhoaHoc.TimKiemKhoaHoc(KH);
            }
            if (e.KeyValue.ToString().Equals("120"))
            {
                ThemKhoaHoc();
            }
            if (e.KeyValue.ToString().Equals("121"))
            {
                SuaKhoaHoc();
            }
            if (e.KeyValue.ToString().Equals("122"))
            {
                XoaKhoaHoc();
            }
            if (e.KeyValue.ToString().Equals("123"))
            {
                txtTimKiem.BackColor = Color.YellowGreen;
                txtTimKiem.Focus();
            }
        }


        private void KhiKichDupChuot(object sender, MouseEventArgs e)
        {
            if (this.quyenHienTai == "Admin")
            {
                SuaKhoaHoc();
            }
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            KhoaHoc_ThongTin KH = new KhoaHoc_ThongTin();
            KH.MaKhoaHoc = txtTimKiem.Text;
            BaoCao.BaoCao.DuLieu = cls_KhoaHoc.TimKiemKhoaHoc(KH);
            BaoCao.BaoCao.Kieu = "TimKiemKhoaHoc";
            BaoCao.BaoCao BC = new BaoCao.BaoCao();
            BC.ShowDialog();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
