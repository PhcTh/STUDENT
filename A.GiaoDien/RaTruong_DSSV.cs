/*
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
    public partial class RaTruong_DSSV : Form
    {
        //KHAI BÁO DÙNG CHUNG
        //BẢNG SINH VIÊN
        SinhVien_B cls_SinhVien = new SinhVien_B();
        //XỬ LÝ IN
        private int RaTruong = 0;
        private int RaTruong_NhanBang = 0;
        private int RaTruong_KhongBang = 0;
        public RaTruong_DSSV()
        {
            InitializeComponent();
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG TRONG NĂM.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruong();
            }
            catch { }
            RaTruong = 1;
        }

        private void btDSSV_RaTruong_Click(object sender, EventArgs e)
        {
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG TRONG NĂM.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruong();
            }
            catch { }
            RaTruong = 1;
            RaTruong_NhanBang = 0;
            RaTruong_KhongBang = 0;
        }

        private void btDSSV_NhanBang_Click(object sender, EventArgs e)
        {
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG ĐƯỢC NHẬN BẰNG.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruongDuocNhanBang();
            }
            catch { }
            RaTruong_NhanBang = 1;
            RaTruong = 0;
            RaTruong_KhongBang = 0;
        }

        private void btDSSV_KhongNhanBang_Click(object sender, EventArgs e)
        {
            //LOAD TOÀN BỘ DANH SÁCH SINH VIÊN RA TRƯỜNG KHÔNG ĐƯỢC NHẬN BẰNG.
            try
            {
                tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruongKhongDuocNhanBang();
            }
            catch { }
            RaTruong_KhongBang = 1;
            RaTruong = 0;
            RaTruong_NhanBang = 0;
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            if (RaTruong == 1)
            {
                BaoCao.BaoCao.DuLieu = cls_SinhVien.DanhSachSinhVienRaTruong();
                BaoCao.BaoCao.Kieu = "RaTruong";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BC.ShowDialog();
            }
            if (RaTruong_NhanBang == 1)
            {
                BaoCao.BaoCao.DuLieu = cls_SinhVien.DanhSachSinhVienRaTruongDuocNhanBang();
                BaoCao.BaoCao.Kieu = "RaTruong_NhanBang";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BC.ShowDialog();
                RaTruong_NhanBang = 0;
            }
            if (RaTruong_KhongBang == 1)
            {
                BaoCao.BaoCao.DuLieu = cls_SinhVien.DanhSachSinhVienRaTruongKhongDuocNhanBang();
                BaoCao.BaoCao.Kieu = "RaTruong_KhongBang";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BC.ShowDialog();
                RaTruong_KhongBang = 0;
            }
        }

        private void tbDanhSachSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tbDanhSachSinhVien.Columns[e.ColumnIndex].DataPropertyName == "GioiTinh")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    try
                    {
                        bool isMale = Convert.ToBoolean(e.Value);
                        e.Value = isMale ? "Nam" : "Nữ";
                        e.FormattingApplied = true;
                    }
                    catch { }
                }
            }
        }

        private void RaTruong_DSSV_Load(object sender, EventArgs e)
        {

        }
    }
}
*/


using System;
using System.Data;
using System.Windows.Forms;
using D.ThongTin;
using B.ThaoTac;

namespace A.GiaoDien
{
    public partial class RaTruong_DSSV : Form
    {
        // Khai báo các lớp thao tác
        SinhVien_B cls_SinhVien = new SinhVien_B();
        KhoaHoc_B cls_KhoaHoc = new KhoaHoc_B();
        HeDaoTao_B cls_HeDaoTao = new HeDaoTao_B();
        Lop_B cls_Lop = new Lop_B();

        // Biến để xác định chế độ lọc
        private int RaTruong = 0;
        private int RaTruong_NhanBang = 0;
        private int RaTruong_KhongBang = 0;

        public RaTruong_DSSV()
        {
            InitializeComponent();
        }

        private void RaTruong_DSSV_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu cho ComboBox Khóa học
            cbKhoaHoc.DataSource = cls_KhoaHoc.DanhSachKhoaHoc();
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc.ValueMember = "MaKhoaHoc";

            // Nạp dữ liệu cho ComboBox Hệ đào tạo
            cbHeDaoTao.DataSource = cls_HeDaoTao.DanhSachHeDaoTao();
            cbHeDaoTao.DisplayMember = "TenHe";
            cbHeDaoTao.ValueMember = "MaHe";

            // Nạp dữ liệu cho ComboBox Lớp
            cbLop.DataSource = cls_Lop.DanhSachLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";

            // Mặc định tải danh sách sinh viên ra trường
            LoadDanhSachSinhVien();
            RaTruong = 1;
        }

        // Nạp lại danh sách sinh viên ra trường theo bộ lọc
        private void LoadDanhSachSinhVien()
        {
            string maKhoaHoc = cbKhoaHoc.SelectedValue?.ToString();
            string maHe = cbHeDaoTao.SelectedValue?.ToString();
            string maLop = cbLop.SelectedValue?.ToString();

            // Gọi đúng thủ tục có 3 tham số
            tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruong1(maKhoaHoc, maHe, maLop);
        }

        private void LoadDanhSachSinhVienNhanBang()
        {
            string maKhoaHoc = cbKhoaHoc.SelectedValue?.ToString();
            string maHe = cbHeDaoTao.SelectedValue?.ToString();
            string maLop = cbLop.SelectedValue?.ToString();

            tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruongDuocNhanBang1(maKhoaHoc, maHe, maLop);
        }

        private void LoadDanhSachSinhVienKhongNhanBang()
        {
            string maKhoaHoc = cbKhoaHoc.SelectedValue?.ToString();
            string maHe = cbHeDaoTao.SelectedValue?.ToString();
            string maLop = cbLop.SelectedValue?.ToString();

            tbDanhSachSinhVien.DataSource = cls_SinhVien.DanhSachSinhVienRaTruongKhongDuocNhanBang1(maKhoaHoc, maHe, maLop);
        }

        // Sự kiện thay đổi bộ lọc
        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadByFilter();
        }
        private void cbHeDaoTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadByFilter();
        }
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadByFilter();
        }

        private void ReloadByFilter()
        {
            if (RaTruong == 1)
                LoadDanhSachSinhVien();
            else if (RaTruong_NhanBang == 1)
                LoadDanhSachSinhVienNhanBang();
            else if (RaTruong_KhongBang == 1)
                LoadDanhSachSinhVienKhongNhanBang();
        }

        private void btDSSV_RaTruong_Click(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();
            RaTruong = 1;
            RaTruong_NhanBang = 0;
            RaTruong_KhongBang = 0;
        }

        private void btDSSV_NhanBang_Click(object sender, EventArgs e)
        {
            LoadDanhSachSinhVienNhanBang();
            RaTruong_NhanBang = 1;
            RaTruong = 0;
            RaTruong_KhongBang = 0;
        }

        private void btDSSV_KhongNhanBang_Click(object sender, EventArgs e)
        {
            LoadDanhSachSinhVienKhongNhanBang();
            RaTruong_KhongBang = 1;
            RaTruong = 0;
            RaTruong_NhanBang = 0;
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            string maKhoaHoc = cbKhoaHoc.SelectedValue?.ToString();
            string maHe = cbHeDaoTao.SelectedValue?.ToString();
            string maLop = cbLop.SelectedValue?.ToString();

            if (RaTruong == 1)
            {
                BaoCao.BaoCao.DuLieu = cls_SinhVien.DanhSachSinhVienRaTruong1(maKhoaHoc, maHe, maLop);
                BaoCao.BaoCao.Kieu = "RaTruong";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BC.ShowDialog();
            }
            if (RaTruong_NhanBang == 1)
            {
                BaoCao.BaoCao.DuLieu = cls_SinhVien.DanhSachSinhVienRaTruongDuocNhanBang1(maKhoaHoc, maHe, maLop);
                BaoCao.BaoCao.Kieu = "RaTruong_NhanBang";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BC.ShowDialog();
                RaTruong_NhanBang = 0;
            }
            if (RaTruong_KhongBang == 1)
            {
                BaoCao.BaoCao.DuLieu = cls_SinhVien.DanhSachSinhVienRaTruongKhongDuocNhanBang1(maKhoaHoc, maHe, maLop);
                BaoCao.BaoCao.Kieu = "RaTruong_KhongBang";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BC.ShowDialog();
                RaTruong_KhongBang = 0;
            }
        }

        private void tbDanhSachSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tbDanhSachSinhVien.Columns[e.ColumnIndex].DataPropertyName == "GioiTinh")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    try
                    {
                        bool isMale = Convert.ToBoolean(e.Value);
                        e.Value = isMale ? "Nam" : "Nữ";
                        e.FormattingApplied = true;
                    }
                    catch { }
                }
            }
        }

        private void tbDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu bạn có xử lý click từng dòng thì thêm code ở đây
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
