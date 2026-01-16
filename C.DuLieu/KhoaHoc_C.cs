using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class KhoaHoc_C
    {
        public DataTable DanhSachKhoaHoc()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachKhoaHoc", con))
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

        public DataTable DanhSach_ThongTin_KhoaHoc()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSach_ThongTin_KhoaHoc", con))
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

        public int ThemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemKhoaHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", KH.MaKhoaHoc);
                    cmd.Parameters.AddWithValue("@NgayBatDau", KH.NgayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", KH.NgayKetThuc);
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

        public int ChinhSuaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ChinhSuaKhoaHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", KH.MaKhoaHoc);
                    cmd.Parameters.AddWithValue("@NgayBatDau", KH.NgayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", KH.NgayKetThuc);
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

        public int XoaKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaKhoaHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", KH.MaKhoaHoc);

                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        throw; // giữ nguyên thông báo từ SQL (RAISERROR)
                    }
                }
            }
            return result;
        }

        public DataTable TimKiemKhoaHoc(KhoaHoc_ThongTin KH)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemKhoaHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", KH.MaKhoaHoc);
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