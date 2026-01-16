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
    public class BangDiem_B
    {

        public DataTable LayDiemTheoKySinhVien(BangDiem_ThongTin BD)
        {
            // Tạo đối tượng mới trong mỗi phương thức
            BangDiem_C cls = new BangDiem_C();
            return cls.LayDiemTheoKySinhVien(BD);
        }
        //Laydiemconloi
        public int ThemKetQua(BangDiem_ThongTin BD)
        {
            // Them ket qua
            BangDiem_C cls = new BangDiem_C();
            return cls.ThemKetQua(BD);
        }

        public int UpDateDiemQTVaDiemThi(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.UpDateDiemQTVaDiemThi(BD);
        }

        public int XoaDiemCuaSinhVien(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.XoaDiemCuaSinhVien(BD);
        }

        public DataTable LayKetQuaHocTap(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.LayKetQuaHocTap(BD);
        }

        public DataTable KetQuaTongKetDaoTao(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.KetQuaTongKetDaoTao(BD);
        }

        public DataTable SoTinChiDat(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.SoTinChiDat(BD);
        }

        public DataTable KetQuaTongKetHocKy(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.KetQuaTongKetHocKy(BD);
        }

        public DataTable DanhSachSinhVienXetHocBong(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.DanhSachSinhVienXetHocBong(BD);
        }

        public DataTable DanhSachSinhVienXetHocBong_Khoa(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.DanhSachSinhVienXetHocBong_Khoa(BD);
        }

        public DataTable DanhSachSinhVienXetHocBong_Khoa_Top(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.DanhSachSinhVienXetHocBong_Khoa_Top(BD);
        }
        public DataTable ThongKePhoDiemMonHoc(BangDiem_ThongTin BD)
        {
            BangDiem_C cls = new BangDiem_C();
            return cls.ThongKePhoDiemMonHoc(BD);
        }
    }
}