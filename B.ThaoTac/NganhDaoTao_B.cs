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
    public class NganhDaoTao_B
    {

        public DataTable DanhSachNganhDaoTao()
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.DanhSachNganhDaoTao();
        }

        public DataTable TimKiemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.TimKiemNganhDaoTao(NDT);
        }

        public DataTable DanhSachThongTinNganhDaoTao()
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.DanhSachThongTinNganhDaoTao();
        }

        public int XoaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.XoaNganhDaoTao(NDT);
        }

        public int ThemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.ThemNganhDaoTao(NDT);
        }

        public int SuaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.SuaNganhDaoTao(NDT);
        }

        public DataTable TimKiemThongTinNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            NganhDaoTao_C cls = new NganhDaoTao_C();
            return cls.TimKiemThongTinNganhDaoTao(NDT);
        }
    }
}
