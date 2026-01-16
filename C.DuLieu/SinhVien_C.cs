/*using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class SinhVien_C
    {
        //LẤY RA DANH SÁCH SINH VIEN.
        public DataTable DanhSachSinhVien()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVien", con))
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

        //TÌM KIẾM SINH VIÊN.
        public DataTable TimKiemSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", SV.MaSinhVien);
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

        //THÊM SINH VIÊN MỚI.
        public int ThemSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemSinhVien", con)) // gọi SP "ThemSinhVien" có 8 tham số.
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", SV.MaSinhVien);
                    cmd.Parameters.AddWithValue("@TenSinhVien", SV.TenSinhVien);
                    cmd.Parameters.AddWithValue("@NgaySinh", SV.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", SV.GioiTinh);
                    cmd.Parameters.AddWithValue("@Lop", SV.Lop);
                    cmd.Parameters.AddWithValue("@DiaChi", SV.DiaChi);
                    cmd.Parameters.AddWithValue("@ChinhSachUuTien", SV.ChinhSachUuTien);

                    // Xử lý tham số ảnh một cách an toàn
                    if (SV.Anh != null)
                    {
                        cmd.Parameters.AddWithValue("@Anh", SV.Anh);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Anh", DBNull.Value);
                    }

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

        //CHỈNH SỬA THÔNG TIN SINH VIÊN.
        public int SuaThongTinSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // SP "SuaThongTinSinhVien" không cập nhật ảnh, có 7 tham số.
                using (SqlCommand cmd = new SqlCommand("SuaThongTinSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", SV.MaSinhVien);
                    cmd.Parameters.AddWithValue("@TenSinhVien", SV.TenSinhVien);
                    cmd.Parameters.AddWithValue("@NgaySinh", SV.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", SV.GioiTinh);
                    cmd.Parameters.AddWithValue("@Lop", SV.Lop);
                    cmd.Parameters.AddWithValue("@DiaChi", SV.DiaChi);
                    cmd.Parameters.AddWithValue("@ChinhSachUuTien", SV.ChinhSachUuTien);
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

        //LẤY RA ẢNH THEO MÃ SINH VIÊN HIỂN THỊ. (Trả về byte[] thay vì SqlDataReader)
        public byte[] LayAnhSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            byte[] imageData = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LayAnhSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", SV.MaSinhVien);
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            imageData = (byte[])result;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return imageData;
        }

        //XÓA THÔNG TIN SINH VIÊN.
        public int XoaSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // SP "XoaSinhVien" có 1 tham số là @Xoa
                using (SqlCommand cmd = new SqlCommand("XoaSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Xoa", SV.MaSinhVien);
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

        //###=========================GIAO DIỆN QUẢN LÝ ĐIỂM==========================###//
        public DataTable DanhSachSinhVienCuaLop(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienCuaLop", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", SV.Lop);
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

        //###=========================GIAO DIỆN XÉT RA TRƯỜNG=========================###//
        public DataTable DanhSachSinhVienRaTruong()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruong", con))
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

        public DataTable DanhSachSinhVienRaTruongDuocNhanBang()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruongDuocNhanBang", con))
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

        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruongKhongDuocNhanBang", con))
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

        public DataTable ThongKeSinhVienTheoKhoa()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Gọi đến SP
                using (SqlCommand cmd = new SqlCommand("ThongKeSinhVienTheoKhoa", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thống kê sinh viên: " + ex.Message);
                    }
                }
            }
            return dt;
        }
        public DataTable LaySinhVienTheoKhoaHoc(string maKhoaHoc)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LaySinhVienTheoKhoaHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);
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
*/



using System;
using System.Data;
using D.ThongTin;
using System.Data.SqlClient;

namespace C.DuLieu
{
    public class SinhVien_C
    {
        //LẤY RA DANH SÁCH SINH VIEN.
        public DataTable DanhSachSinhVien()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVien", con))
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

        //TÌM KIẾM SINH VIÊN.
        public DataTable TimKiemSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TimKiemSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", SV.MaSinhVien);
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

        //THÊM SINH VIÊN MỚI.
        public int ThemSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThemSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", SV.MaSinhVien);
                    cmd.Parameters.AddWithValue("@TenSinhVien", SV.TenSinhVien);
                    cmd.Parameters.AddWithValue("@NgaySinh", SV.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", SV.GioiTinh);
                    cmd.Parameters.AddWithValue("@Lop", SV.Lop);
                    cmd.Parameters.AddWithValue("@DiaChi", SV.DiaChi);
                    cmd.Parameters.AddWithValue("@ChinhSachUuTien", SV.ChinhSachUuTien);

                    if (SV.Anh != null)
                    {
                        cmd.Parameters.AddWithValue("@Anh", SV.Anh);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Anh", DBNull.Value);
                    }

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

        //CHỈNH SỬA THÔNG TIN SINH VIÊN.
        public int SuaThongTinSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SuaThongTinSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", SV.MaSinhVien);
                    cmd.Parameters.AddWithValue("@TenSinhVien", SV.TenSinhVien);
                    cmd.Parameters.AddWithValue("@NgaySinh", SV.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", SV.GioiTinh);
                    cmd.Parameters.AddWithValue("@Lop", SV.Lop);
                    cmd.Parameters.AddWithValue("@DiaChi", SV.DiaChi);
                    cmd.Parameters.AddWithValue("@ChinhSachUuTien", SV.ChinhSachUuTien);
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

        //LẤY RA ẢNH THEO MÃ SINH VIÊN HIỂN THỊ. (Trả về byte[] thay vì SqlDataReader)
        public byte[] LayAnhSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            byte[] imageData = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LayAnhSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimKiem", SV.MaSinhVien);
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            imageData = (byte[])result;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
                }
            }
            return imageData;
        }

        //XÓA THÔNG TIN SINH VIÊN.
        public int XoaSinhVien(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("XoaSinhVien", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSinhVien", SV.MaSinhVien);
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

        //###=========================GIAO DIỆN QUẢN LÝ ĐIỂM==========================###//
        public DataTable DanhSachSinhVienCuaLop(SinhVien_ThongTin SV)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienCuaLop", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", SV.Lop);
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

        //###=========================GIAO DIỆN XÉT RA TRƯỜNG=========================###//

        // Hàm cũ (không có lọc, dùng cho giao diện cũ hoặc code cũ)
        /*
        public DataTable DanhSachSinhVienRaTruong()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruong", con))
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

        // Hàm cũ
        public DataTable DanhSachSinhVienRaTruongDuocNhanBang()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruongDuocNhanBang", con))
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

        // Hàm cũ
        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruongKhongDuocNhanBang", con))
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
        */
        // Hàm cũ thống kê
        public DataTable ThongKeSinhVienTheoKhoa()
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ThongKeSinhVienTheoKhoa", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thống kê sinh viên: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        public DataTable LaySinhVienTheoKhoaHoc(string maKhoaHoc)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LaySinhVienTheoKhoaHoc", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);
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

        // ================== BỔ SUNG HÀM MỚI - DÙNG CHO LỌC 3 TRƯỜNG ==================

        // Lấy danh sách sinh viên ra trường (lọc)
        public DataTable DanhSachSinhVienRaTruong1(string maKhoaHoc, string maHe, string maLop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruong1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", (object)maKhoaHoc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaHe", (object)maHe ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaLop", (object)maLop ?? DBNull.Value);

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

        // Lấy danh sách sinh viên ra trường được nhận bằng (lọc)
        public DataTable DanhSachSinhVienRaTruongDuocNhanBang1(string maKhoaHoc, string maHe, string maLop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruongDuocNhanBang1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", (object)maKhoaHoc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaHe", (object)maHe ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaLop", (object)maLop ?? DBNull.Value);

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

        // Lấy danh sách sinh viên ra trường không được nhận bằng (lọc)
        public DataTable DanhSachSinhVienRaTruongKhongDuocNhanBang1(string maKhoaHoc, string maHe, string maLop)
        {
            KetNoi_CSDL provider = new KetNoi_CSDL();
            string connectionString = provider.LayChuoiKetNoi();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DanhSachSinhVienRaTruongKhongDuocNhanBang1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", (object)maKhoaHoc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaHe", (object)maHe ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaLop", (object)maLop ?? DBNull.Value);

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

