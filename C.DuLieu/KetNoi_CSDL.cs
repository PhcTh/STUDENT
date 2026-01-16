using System;
using System.Configuration;

namespace C.DuLieu
{
    /// <summary>
    /// Lớp này chỉ có một nhiệm vụ duy nhất:
    /// Đọc file App.config và cung cấp chuỗi kết nối (connection string) đến CSDL.
    /// </summary>
    class KetNoi_CSDL
    {
        /// <summary>
        /// Phương thức này đọc file App.config và trả về chuỗi kết nối hoàn chỉnh.
        /// </summary>
        /// <returns>Một chuỗi kết nối đến SQL Server.</returns>
        public string LayChuoiKetNoi()
        {
            string connectionString = "";
            try
            {
                string LuaChon = ConfigurationManager.AppSettings["LuaChon"].ToString();

                if (LuaChon.Equals("Sử Dụng Tài Khoản"))
                {
                    connectionString = @"data source=" + ConfigurationManager.AppSettings["Server"].ToString()
                                     + ";initial catalog=QLSINHVIEN;user id="
                                     + ConfigurationManager.AppSettings["Username"].ToString()
                                     + ";password=" + ConfigurationManager.AppSettings["Password"].ToString() + "";
                }
                else // Mặc định hoặc "Không Dùng Tài Khoản"
                {
                    connectionString = @"data source=" + ConfigurationManager.AppSettings["Server"].ToString()
                                     + ";initial catalog=QLSINHVIEN;integrated security=True;";
                }
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi ra cửa sổ Output để dễ dàng gỡ lỗi, hoặc có thể hiện MessageBox nếu cần.
                System.Diagnostics.Debug.WriteLine("Lỗi khi đọc file cấu hình App.config: " + ex.Message);
            }

            return connectionString;
        }
    }
}