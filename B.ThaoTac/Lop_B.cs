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
    public class Lop_B
    {

        //LÂY RA DANH SÁCH LƠP HỌC.
        public DataTable DanhSachLop()
        {
            Lop_C cls = new Lop_C();
            return cls.DanhSachLop();
        }
        //DANH SÁCH THÔNG TIN ĐẦY ĐỦ LỚP HỌC.
        public DataTable DanhSach_ThongTin_Lop()
        {
            Lop_C cls = new Lop_C();
            return cls.DanhSach_ThongTin_Lop();
        }
        //THÊM LỚP HỌC MỚI
        public int ThemLopHocMoi(Lop_ThongTin Lop)
        {
            Lop_C cls = new Lop_C();
            return cls.ThemLopHocMoi(Lop);
        }
        //SỬA THÔNG TIN LỚP HỌC
        public int SuaThongTinLopHoc(Lop_ThongTin Lop)
        {
            Lop_C cls = new Lop_C();
            return cls.SuaThongTinLopHoc(Lop);
        }

        //XÓA LỚP HỌC
        public int XoaLopHoc(Lop_ThongTin Lop)
        {
            Lop_C cls = new Lop_C();
            return cls.XoaLopHoc(Lop);
        }

        //TÌM KIẾM LỚP HỌC
        public DataTable TimKiemLopHoc(Lop_ThongTin Lop)
        {
            Lop_C cls = new Lop_C();
            return cls.TimKiemLopHoc(Lop);
        }
    }
}