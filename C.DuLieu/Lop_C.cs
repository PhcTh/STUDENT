using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class Lop_C
    {
        //DANH SÁCH LỚP HỌC.
        public DataTable DanhSachLop()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Stored Procedure "DanhSachLop" không có tham số.
                using (SqlCommand cmd = new SqlCommand("DanhSachLop", con))
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

        //DANH SÁCH THÔNG TIN ĐẦY ĐỦ LỚP HỌC
        public DataTable DanhSach_ThongTin_Lop()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Stored Procedure "DanhSach_ThongTin_Lop" không có tham số.
                using (SqlCommand cmd = new SqlCommand("DanhSach_ThongTin_Lop", con))
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

        //THÊM LỚP HỌC MỚI.
        public int ThemLopHocMoi(Lop_ThongTin Lop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Stored Procedure "ThemLopHocMoi" có 5 tham số.
                using (SqlCommand cmd = new SqlCommand("ThemLopHocMoi", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", Lop.MaLop);
                    cmd.Parameters.AddWithValue("@TenLop", Lop.TenLop);
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", Lop.MaKhoaHoc);
                    cmd.Parameters.AddWithValue("@MaHeDaoTao", Lop.MaHeDaoTao);
                    cmd.Parameters.AddWithValue("@MaNganh", Lop.MaNganh);
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

        //SỬA THÔNG TIN LỚP HỌC
        public int SuaThongTinLopHoc(Lop_ThongTin Lop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Stored Procedure "SuaThongTinLopHoc" có 5 tham số.
                using (SqlCommand cmd = new SqlCommand("SuaThongTinLopHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", Lop.MaLop);
                    cmd.Parameters.AddWithValue("@TenLop", Lop.TenLop);
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", Lop.MaKhoaHoc);
                    cmd.Parameters.AddWithValue("@MaHeDaoTao", Lop.MaHeDaoTao);
                    cmd.Parameters.AddWithValue("@MaNganh", Lop.MaNganh);
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

        //XÓA LỚP HỌC
        public int XoaLopHoc(Lop_ThongTin Lop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Stored Procedure "XoaLopHoc" có 1 tham số.
                using (SqlCommand cmd = new SqlCommand("XoaLopHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", Lop.MaLop);
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

        //TÌM KIẾM LỚP HỌC
        public DataTable TimKiemLopHoc(Lop_ThongTin Lop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Stored Procedure "TimKiemLopHoc" có 1 tham số.
                using (SqlCommand cmd = new SqlCommand("TimKiemLopHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", Lop.MaLop);
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