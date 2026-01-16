using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using D.ThongTin;
using B.ThaoTac;

namespace A.GiaoDien
{
    public partial class HocBong_DSSV : Form
    {
        //KHAI BÁO DÙNG CHUNG.
        //BẢNG ĐIỂM;
        BangDiem_B cls_BangDiem = new BangDiem_B();
        //BẢNG HỌC KỲ.
        HocKy_B cls_HocKy = new HocKy_B();
        //BẢNG KHOA.
        Khoa_B cls_Khoa = new Khoa_B();
        //IN
        private int HocKy = 0;
        private int Khoa = 0;
        private int Top = 0;
        public HocBong_DSSV()
        {
            InitializeComponent();
            HocKy = 1;
            try
            {
                cbHocKy.DataSource = cls_HocKy.DanhSachHocKy();
                cbHocKy.DisplayMember = "TenHocKy";
                cbHocKy.ValueMember = "MaHocKy";

                cbKhoa.DataSource = cls_Khoa.DanhSachKhoa();
                cbKhoa.DisplayMember = "TenKhoa";
                cbKhoa.ValueMember = "MaKhoa";
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu lên các ô combobox. Hãy kiểm tra kết nối!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                tbHocBong_DSSV.DataSource = cls_BangDiem.DanhSachSinhVienXetHocBong(BD);
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu lên bảng. Hãy kiểm tra kết nối!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DANH SÁCH SINH VIÊN ĐẠT HỌC BỔNG THEO KỲ HỌC TOÀN TRƯỜNG.
        private void DanhSachSinhVienDatHocBongTheoKy(object sender, EventArgs e)
        {
            try
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                tbHocBong_DSSV.DataSource = cls_BangDiem.DanhSachSinhVienXetHocBong(BD);
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu lên bảng. Hãy kiểm tra kết nối!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HocKy = 1;
        }
        //DANH SÁCH SINH VIÊN CỦA KHOA ĐẠT HỌC BỔNG TRONG KỲ HỌC.
        private void DanhSachSinhVienDatHocBongCuaKhoa(object sender, EventArgs e)
        {
            try
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                BD.MaMonHoc = cbKhoa.SelectedValue.ToString();
                tbHocBong_DSSV.DataSource = cls_BangDiem.DanhSachSinhVienXetHocBong_Khoa(BD);
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu lên bảng. Hãy kiểm tra kết nối!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DANH SÁCH SINH VIÊN CỦA KHOA ĐẠT HỌC BỔNG TRONG KỲ HỌC THEO TOP
        private void LayTopSinhVienCuaKhoa(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                try
                {
                    BangDiem_ThongTin BD = new BangDiem_ThongTin();
                    BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                    BD.MaMonHoc = cbKhoa.SelectedValue.ToString();
                    BD.MaSinhVien = txtTop.Text;
                    tbHocBong_DSSV.DataSource = cls_BangDiem.DanhSachSinhVienXetHocBong_Khoa_Top(BD);
                }
                catch
                {
                    MessageBox.Show("Không thể load dữ liệu lên bảng. Hãy kiểm tra kết nối!", "Thông báo lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Top = 1;
            }
        }
        //IN BÁO CÁO
        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            if (HocKy == 1 && Khoa == 0 && Top == 0)
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                BaoCao.BaoCao.DuLieu = cls_BangDiem.DanhSachSinhVienXetHocBong(BD);
                BaoCao.BaoCao.Kieu = "HocBong";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BaoCao.BaoCao.HocKy = cbHocKy.Text;
                BC.ShowDialog();
            }
            if (HocKy == 1 && Khoa == 1 && Top == 0)
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                BD.MaMonHoc = cbKhoa.SelectedValue.ToString();
                BaoCao.BaoCao.DuLieu = cls_BangDiem.DanhSachSinhVienXetHocBong_Khoa(BD);
                BaoCao.BaoCao.Kieu = "HocBong_Khoa";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BaoCao.BaoCao.HocKy = cbHocKy.Text;
                BaoCao.BaoCao.Khoa = cbKhoa.Text;
                BC.ShowDialog();
                Khoa = 0;
            }
            if (HocKy == 1 && Khoa == 1 && Top == 1)
            {
                BangDiem_ThongTin BD = new BangDiem_ThongTin();
                BD.MaHocKy = cbHocKy.SelectedValue.ToString();
                BD.MaMonHoc = cbKhoa.SelectedValue.ToString();
                BD.MaSinhVien = txtTop.Text;
                BaoCao.BaoCao.DuLieu = cls_BangDiem.DanhSachSinhVienXetHocBong_Khoa_Top(BD);
                BaoCao.BaoCao.Kieu = "HocBong_Khoa_Top";
                BaoCao.BaoCao BC = new BaoCao.BaoCao();
                BaoCao.BaoCao.HocKy = cbHocKy.Text;
                BaoCao.BaoCao.Khoa = cbKhoa.Text;
                BaoCao.BaoCao.Top = txtTop.Text;
                BC.ShowDialog();
                Khoa = 0;
                Top = 0;
            }
        }

        private void cbKhoa_MouseMove(object sender, MouseEventArgs e)
        {
            Khoa = 1;
        }
        

    }
}
