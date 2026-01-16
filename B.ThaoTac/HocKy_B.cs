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
    public class HocKy_B
    {

        public DataTable DanhSachHocKy()
        {
            HocKy_C cls = new HocKy_C();
            return cls.DanhSachHocKy();
        }

        public DataTable DanhSachThongTinHocKy()
        {
            HocKy_C cls = new HocKy_C();
            return cls.DanhSachThongTinHocKy();
        }

        public int XoaHocKy(HocKy_ThongTin HK)
        {
            HocKy_C cls = new HocKy_C();
            return cls.XoaHocKy(HK);
        }

        public int ThemHocKy(HocKy_ThongTin HK)
        {
            HocKy_C cls = new HocKy_C();
            return cls.ThemHocKy(HK);
        }

        public int SuaHocKy(HocKy_ThongTin HK)
        {
            HocKy_C cls = new HocKy_C();
            return cls.SuaHocKy(HK);
        }

        public DataTable TimKiemHocKy(HocKy_ThongTin HK)
        {
            HocKy_C cls = new HocKy_C();
            return cls.TimKiemHocKy(HK);
        }
    }
}
