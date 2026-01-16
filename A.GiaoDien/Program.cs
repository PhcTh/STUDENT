using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.GiaoDien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị form cấu hình server
            DangNhapCoSoDuLieu formDangNhapCSCL = new DangNhapCoSoDuLieu();
            if (formDangNhapCSCL.ShowDialog() == DialogResult.OK)
            {
                // Nếu cấu hình OK, hiển thị form đăng nhập tài khoản
                DangNhap formDangNhap = new DangNhap();
                if (formDangNhap.ShowDialog() == DialogResult.OK)
                {
                    // Lệnh Application.Run sẽ giữ cho chương trình tiếp tục chạy với form GiaoDienChinh
                    Application.Run(new GiaoDienChinh(formDangNhap.ThongTinNguoiDung));
                }
            }
        }
    }
}
