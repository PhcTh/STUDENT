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
    public class Khoa_B
    {

        public DataTable DanhSachKhoa()
        {
            Khoa_C cls = new Khoa_C();
            return cls.DanhSachKhoa();
        }

        public int XoaKhoa(Khoa_ThongTin K)
        {
            Khoa_C cls = new Khoa_C();
            return cls.XoaKhoa(K);
        }

        public int ThemKhoa(Khoa_ThongTin K)
        {
            Khoa_C cls = new Khoa_C();
            return cls.ThemKhoa(K);
        }

        public int SuaKhoa(Khoa_ThongTin K)
        {
            Khoa_C cls = new Khoa_C();
            return cls.SuaKhoa(K);
        }

        public DataTable TimKiemKhoa(Khoa_ThongTin K)
        {
            Khoa_C cls = new Khoa_C();
            return cls.TimKiemKhoa(K);
        }
    }
}
