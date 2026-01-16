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
    public class MonHoc_B
    {

        public DataTable DanhSachMonHoc()
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.DanhSachMonHoc();
        }

        public DataTable TimKiemMonHoc(MonHoc_ThongTin MH)
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.TimKiemMonHoc(MH);
        }

        public DataTable DanhSachMonHocToanTruong()
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.DanhSachMonHocToanTruong();
        }

        public int XoaMonHoc(MonHoc_ThongTin MH)
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.XoaMonHoc(MH);
        }

        public int ThemMonHoc(MonHoc_ThongTin MH)
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.ThemMonHoc(MH);
        }

        public int SuaMonHoc(MonHoc_ThongTin MH)
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.SuaMonHoc(MH);
        }

        public DataTable TimMonHoc(MonHoc_ThongTin MH)
        {
            MonHoc_C cls = new MonHoc_C();
            return cls.TimMonHoc(MH);
        }
    }
}
