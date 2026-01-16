using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class DangNhap_C
    {

        public DataTable KiemTraDangNhap(DangNhap_ThongTin DN)
        {
            // 1. Lấy chuỗi kết nối
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();

            // 2. Dùng 'using' để tạo kết nối và đảm bảo nó luôn được đóng
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("KiemTraDangNhap", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Thêm tham số một cách an toàn và rõ ràng
                    cmd.Parameters.AddWithValue("@TaiKhoan", DN.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", DN.MatKhau);
                    try
                    {
                        con.Open(); // 3. Mở kết nối
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt); // 4. Lấy dữ liệu
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                    // 5. Kết nối được tự động đóng ở đây
                }
            }
            return dt;
        }

        public int UpDateTrangThai(DangNhap_ThongTin DN)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpDateTrangThai", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", DN.TaiKhoan);
                    cmd.Parameters.AddWithValue("@TrangThai", DN.TrangThai);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return result;
        }

        public int UpDateMatKhau(DangNhap_ThongTin DN)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpDateMatKhau", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", DN.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", DN.MatKhau);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return result;
        }

        public DataTable DanhSachTaiKhoan()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachTaiKhoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return dt;
        }

        public int XoaTaiKhoan(DangNhap_ThongTin DN)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaTaiKhoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", DN.TaiKhoan);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return result;
        }

        public int ThemTaiKhoan(DangNhap_ThongTin DN)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemTaiKhoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", DN.TaiKhoan);
                    cmd.Parameters.AddWithValue("@Quyen", DN.Quyen);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return result;
        }

        public int ChinhSuaQuyen(DangNhap_ThongTin DN)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ChinhSuaQuyen", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", DN.TaiKhoan);
                    cmd.Parameters.AddWithValue("@Quyen", DN.Quyen);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return result;
        }

        public DataTable TimKiemTaiKhoan(DangNhap_ThongTin DN)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemTaiKhoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", DN.TaiKhoan);
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return dt;
        }

        public DataTable DanhSachQuyen()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachQuyen", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return dt;
        }
    }
}