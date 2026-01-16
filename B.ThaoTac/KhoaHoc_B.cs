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
    public class KhoaHoc_B
    {

        public DataTable DanhSachKhoaHoc()
        {
            KhoaHoc_C cls = new KhoaHoc_C();
            return cls.DanhSachKhoaHoc();
        }

        public DataTable DanhSach_ThongTin_KhoaHoc()
        {
            KhoaHoc_C cls = new KhoaHoc_C();
            return cls.DanhSach_ThongTin_KhoaHoc();
        }

        public int ThemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KhoaHoc_C cls = new KhoaHoc_C();
            return cls.ThemKhoaHoc(KH);
        }

        public int ChinhSuaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KhoaHoc_C cls = new KhoaHoc_C();
            return cls.ChinhSuaKhoaHoc(KH);
        }

        public int XoaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KhoaHoc_C cls = new KhoaHoc_C();
            return cls.XoaKhoaHoc(KH);
        }

        public DataTable TimKiemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KhoaHoc_C cls = new KhoaHoc_C();
            return cls.TimKiemKhoaHoc(KH);
        }
    }
}
