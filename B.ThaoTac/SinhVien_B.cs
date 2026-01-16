/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using D.ThongTin;
using C.DuLieu;
using System.Data.SqlClient;

namespace B.ThaoTac
{
    public class SinhVien_B
    {

        //###=========================GIAO DIỆN DANH SÁCH SINH VIÊN===================###//
        public DataTable DanhSachSinhVien()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVien();
        }

        public DataTable TimKiemSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.TimKiemSinhVien(SV);
        }

        public int ThemSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.ThemSinhVien(SV);
        }

        public int SuaThongTinSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.SuaThongTinSinhVien(SV);
        }

        public byte[] LayAnhSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.LayAnhSinhVien(SV);
        }

        public int XoaSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.XoaSinhVien(SV);
        }
        //###=========================================================================###//
        //###=========================GIAO DIỆN QUẢN LÝ ĐIỂM==========================###//
        public DataTable DanhSachSinhVienCuaLop(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienCuaLop(SV);
        }
        //###=========================================================================###//

        //###=========================GIAO DIỆN XÉT RA TRƯỜNG=========================###//
        public DataTable DanhSachSinhVienRaTruong()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruong();
        }

        public DataTable DanhSachSinhVienRaTruongDuocNhanBang()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruongDuocNhanBang();
        }

        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruongKhongDuocNhanBang();
        }
        public DataTable ThongKeSinhVienTheoKhoa()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.ThongKeSinhVienTheoKhoa();
        }
        public DataTable LaySinhVienTheoKhoaHoc(string maKhoaHoc)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.LaySinhVienTheoKhoaHoc(maKhoaHoc);
        }
    }
}

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using D.ThongTin;
using C.DuLieu;
using System.Data.SqlClient;

namespace B.ThaoTac
{
    public class SinhVien_B
    {
        // DANH SÁCH SINH VIÊN
        public DataTable DanhSachSinhVien()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVien();
        }
        public DataTable TimKiemSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.TimKiemSinhVien(SV);
        }
        public int ThemSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.ThemSinhVien(SV);
        }
        public int SuaThongTinSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.SuaThongTinSinhVien(SV);
        }
        public byte[] LayAnhSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.LayAnhSinhVien(SV);
        }
        public int XoaSinhVien(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.XoaSinhVien(SV);
        }

        // QUẢN LÝ ĐIỂM
        public DataTable DanhSachSinhVienCuaLop(SinhVien_ThongTin SV)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienCuaLop(SV);
        }

        // XÉT RA TRƯỜNG - HÀM MỚI (lọc)
        public DataTable DanhSachSinhVienRaTruong1(string maKhoaHoc, string maHe, string maLop)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruong1(maKhoaHoc, maHe, maLop);
        }
        public DataTable DanhSachSinhVienRaTruongDuocNhanBang1(string maKhoaHoc, string maHe, string maLop)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruongDuocNhanBang1(maKhoaHoc, maHe, maLop);
        }
        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang1(string maKhoaHoc, string maHe, string maLop)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruongKhongDuocNhanBang1(maKhoaHoc, maHe, maLop);
        }

        // CÁC HÀM KHÁC
        public DataTable ThongKeSinhVienTheoKhoa()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.ThongKeSinhVienTheoKhoa();
        }
        public DataTable LaySinhVienTheoKhoaHoc(string maKhoaHoc)
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.LaySinhVienTheoKhoaHoc(maKhoaHoc);
        }

        // HÀM CŨ (nếu cần dùng cho giao diện cũ)
        /*
        public DataTable DanhSachSinhVienRaTruong()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruong();
        }
        public DataTable DanhSachSinhVienRaTruongDuocNhanBang()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruongDuocNhanBang();
        }
        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang()
        {
            SinhVien_C cls = new SinhVien_C();
            return cls.DanhSachSinhVienRaTruongKhongDuocNhanBang();
        }
        */
    }
}
