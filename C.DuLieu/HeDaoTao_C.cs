using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class HeDaoTao_C
    {
        //LẤY DANH SÁCH HỆ ĐÀO TẠO
        public DataTable DanhSachHeDaoTao()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachHeDaoTao", con))
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

        //XÓA 1 HỆ ĐÀO TẠO.
        public int XoaHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaHeDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHe", HDT.MaHe);
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

        //THÊM 1 HỆ ĐÀO TẠO
        public int ThemHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemHeDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHe", HDT.MaHe);
                    cmd.Parameters.AddWithValue("@TenHe", HDT.TenHe);
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

        //SỬA 1 HỆ ĐÀO TẠO.
        public int SuaHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SuaHeDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHe", HDT.MaHe);
                    cmd.Parameters.AddWithValue("@TenHe", HDT.TenHe);
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

        //TÌM KIẾM HỆ ĐÀO TẠO.
        public DataTable TimKiemHeDaoTao(HeDaoTao_ThongTin HDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemHeDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", HDT.MaHe);
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