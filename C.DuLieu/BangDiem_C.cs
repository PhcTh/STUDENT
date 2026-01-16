using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class BangDiem_C
    {
        //LẤY ĐIỂM TRONG 1 HỌC KỲ CỦA SINH VIÊN.
        public DataTable LayDiemTheoKySinhVien(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LayDiemTheoKySinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        //THÊM KẾT QUẢ HỌC TẬP 
        public int ThemKetQua(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemKetQua", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", BD.MaMonHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
                    cmd.Parameters.AddWithValue("@DiemQuaTrinh", BD.DiemQuaTrinh);
                    cmd.Parameters.AddWithValue("@DiemThi", BD.DiemThi);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                        throw;
                    }
                }
            }
            return result;
        }

        //UPDATE ĐIỂM QUÁ TRÌNH VÀO ĐIỂM THI
        public int UpDateDiemQTVaDiemThi(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpDateDiemQTVaDiemThi", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", BD.MaMonHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
                    cmd.Parameters.AddWithValue("@DiemQuaTrinh", BD.DiemQuaTrinh);
                    cmd.Parameters.AddWithValue("@DiemThi", BD.DiemThi);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                        throw;
                    }
                }
            }
            return result;
        }

        //XÓA ĐIỂM CỦA SINH VIÊN.
        public int XoaDiemCuaSinhVien(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaDiemCuaSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@STT", BD.Stt);
                    try
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
            }
            return result;
        }

        //LẤY TOÀN BỘ ĐIỂM - KẾT QUẢ HỌC TẬP CỦA SINH VIÊN.
        public DataTable LayKetQuaHocTap(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LayKetQuaHocTap", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
            }
            return dt;
        }
        //LẤY RA KẾT QUẢ HỌC TẬP ĐÀO TẠO CỦA SINH VIÊN.
        public DataTable KetQuaTongKetDaoTao(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("KetQuaTongKetDaoTao", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
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

        //SỐ TÍN CHỈ ĐẠT TRONG KỲ.
        public DataTable SoTinChiDat(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SoTinChiDat", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
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

        //KẾT QUẢ ĐIỂM TRUNG BÌNH HỌC KỲ - TÍNH MÔN TRƯỢT.
        public DataTable KetQuaTongKetHocKy(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("KetQuaTongKetHocKy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", BD.MaSinhVien);
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
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

        //LẤY RA DANH SÁCH SINH VIÊN ĐỦ ĐIỀU KIỆN XÉT HỌC BỔNG
        public DataTable DanhSachSinhVienXetHocBong(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienXetHocBong", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
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

        //DANH SÁCH SINH VIÊN CỦA KHOA ĐƯỢC XÉT HỌC BỔNG
        public DataTable DanhSachSinhVienXetHocBong_Khoa(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienXetHocBong_Khoa", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
                    cmd.Parameters.AddWithValue("@TimKiem", BD.MaMonHoc);
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

        //DANH SÁCH SINH VIÊN CỦA KHOA ĐƯỢC XÉT HỌC BỔNG - TOP
        public DataTable DanhSachSinhVienXetHocBong_Khoa_Top(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienXetHocBong_Khoa_Top", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);

                    cmd.Parameters.AddWithValue("@TimKiem", BD.MaMonHoc);

                    cmd.Parameters.AddWithValue("@Top", BD.MaSinhVien);
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

        // Thống kê phổ điểm môn học
        public DataTable ThongKePhoDiemMonHoc(BangDiem_ThongTin BD)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Gọi đến SP
                using (SqlCommand cmd = new SqlCommand("ThongKePhoDiemMonHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Truyền vào 2 tham số cần thiết
                    cmd.Parameters.AddWithValue("@MaMonHoc", BD.MaMonHoc);
                    cmd.Parameters.AddWithValue("@MaHocKy", BD.MaHocKy);
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thống kê phổ điểm: " + ex.Message);
                    }
                }
            }
            return dt;
        }
    }
}