using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class NganhDaoTao_C
    {
        public DataTable DanhSachNganhDaoTao()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachNganhDaoTao", con))
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

        //TÌM KIẾM NGÀNH ĐÀO TẠO
        public DataTable TimKiemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemNganhDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenNganh", NDT.TenNganh);
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

        //LẤY RA DANH SÁCH THÔNG TIN ĐẦY ĐỦ VỀ NGÀNH ĐÀO TẠO
        public DataTable DanhSachThongTinNganhDaoTao()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachThongTinNganhDaoTao", con))
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

        //XÓA 1 NGANH ĐÀO TẠO.
        public int XoaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaNganhDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNganh", NDT.MaNganh);
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

        //THÊM 1 NGÀNH ĐÀO TẠO.
        public int ThemNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemNganhDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNganh", NDT.MaNganh);
                    cmd.Parameters.AddWithValue("@TenNganh", NDT.TenNganh);
                    cmd.Parameters.AddWithValue("@MaKhoa", NDT.MaKhoa);
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

        //SỬA 1 NGÀNH ĐÀO TẠO.
        public int SuaNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SuaNganhDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNganh", NDT.MaNganh);
                    cmd.Parameters.AddWithValue("@TenNganh", NDT.TenNganh);
                    cmd.Parameters.AddWithValue("@MaKhoa", NDT.MaKhoa);
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

        //TÌM KIẾM NGÀNH ĐÀO TẠO ĐẦY ĐỦ.
        public DataTable TimKiemThongTinNganhDaoTao(NganhDaoTao_ThongTin NDT)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemThongTinNganhDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", NDT.MaNganh);
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