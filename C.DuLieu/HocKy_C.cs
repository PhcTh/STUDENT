using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class HocKy_C
    {
        public DataTable DanhSachHocKy()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachHocKy", con))
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

        //LẤY RA DANH SÁCH THÔNG TIN ĐẦY ĐỦ VỀ HỌC KỲ
        public DataTable DanhSachThongTinHocKy()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachThongTinHocKy", con))
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

        //XÓA 1 HỌC KỲ.
        public int XoaHocKy(HocKy_ThongTin HK)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaHocKy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocKy", HK.MaHocKy);
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

        //THÊM 1 HỌC KỲ.
        public int ThemHocKy(HocKy_ThongTin HK)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemHocKy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocKy", HK.MaHocKy);
                    cmd.Parameters.AddWithValue("@TenHocKy", HK.TenHocKy);
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

        //SỬA 1 HỌC KỲ.
        public int SuaHocKy(HocKy_ThongTin HK)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SuaHocKy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocKy", HK.MaHocKy);
                    cmd.Parameters.AddWithValue("@TenHocKy", HK.TenHocKy);
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

        //TÌM KIẾM HỌC KỲ.
        public DataTable TimKiemHocKy(HocKy_ThongTin HK)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemHocKy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", HK.MaHocKy);
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