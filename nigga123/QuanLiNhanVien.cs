using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Xml.Linq;

namespace nigga123
{
    public partial class QuanLiNhanVien : Form
    {
        private string TenDangNhapHienTai;
        public QuanLiNhanVien(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhapHienTai = tenDangNhap;
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            List<NhanVienDTO> danhSachNhanVien = NhanVienBUS.LayDanhSachNhanVien();

            // Gán danh sách vào DataGridView
            DgvNV.DataSource = danhSachNhanVien;
            // HeaderText
            DgvNV.Columns["Ten"].HeaderText = "Họ và Tên";
            DgvNV.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            DgvNV.Columns["Email"].HeaderText = "Email";
            DgvNV.Columns["MaNV"].HeaderText = "Mã Nhân Viên";

            // Ẩn cột PhanQuyen (số) để chỉ hiển thị dạng chữ
            DgvNV.Columns["PhanQuyen"].Visible = false;
            DgvNV.Columns["PhanQuyenHienThi"].HeaderText = "Phân quyền";
            DgvNV.ClearSelection();
        }


        private int GetPhanQuyen()
        {
            if (RQL.Checked) return 1; // Quản lí
            if (RBS.Checked) return 2; // Bác sĩ
            return 3; // Lễ tân
        }
        private void ButtonThem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan ttk = new TaoTaiKhoan();
            ttk.Show();
        }

        private void DgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtHVT.Text = DgvNV.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                TxtUsername.Text = DgvNV.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                TxtEmail.Text = DgvNV.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                TxtMaNV.Text = DgvNV.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();

                string phanQuyen = DgvNV.Rows[e.RowIndex].Cells["PhanQuyenHienThi"].Value.ToString();
                RQL.Checked = (phanQuyen == "Quản lý");
                RBS.Checked = (phanQuyen == "Bác sĩ");
                RLT.Checked = (phanQuyen == "Lễ tân");
            }
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            if (DgvNV.SelectedRows.Count > 0)
            {
                string tenDangNhap = DgvNV.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                if (tenDangNhap == TenDangNhapHienTai)
                {
                    MessageBox.Show("Không thể thay đổi thông tin tài khoản đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNV = Convert.ToInt32(DgvNV.SelectedRows[0].Cells["MaNV"].Value);
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = maNV,
                    Ten = TxtHVT.Text,
                    Email = TxtEmail.Text,
                    PhanQuyen = GetPhanQuyen()
                };

                if (NhanVienBUS.SuaNhanVien(nv))
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!");
                }
            }
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (DgvNV.SelectedRows.Count > 0)
            {
                string tenDangNhap = DgvNV.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                if (tenDangNhap == TenDangNhapHienTai)
                {
                    MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNV = Convert.ToInt32(DgvNV.SelectedRows[0].Cells["MaNV"].Value);
                if (NhanVienBUS.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
                }
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = TxtTimKiem.Text.Trim();
            DgvNV.DataSource = NhanVienBUS.TimKiemNhanVien(keyword);
        }


        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            DgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvNV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvNV.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvNV.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvNV.MultiSelect = false; // Không cho phép chọn nhiều dòng
        }
    }
}
