using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nigga123
{
    public partial class TaoTaiKhoan : Form
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        private int ChuyenDoiPhanQuyen(string vaiTro)
        {
            switch (vaiTro)
            {
                case "Quản lý":
                    return 1;
                case "Bác sĩ":
                    return 2;
                case "Lễ tân":
                    return 3;
                default:
                    return 3; // Mặc định là Lễ tân nếu có lỗi
            }
        }
        private bool KiemTraEmailHopLe(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        private void NutTao_Click(object sender, EventArgs e)
        {
            string ten = BoxTen.Text;
            string tenDangNhap = BoxUsername.Text;
            string email = BoxEmail.Text;
            int phanQuyen = ChuyenDoiPhanQuyen(CbPhanQuyen.SelectedItem.ToString()); // Chuyển từ chữ sang số

            if (string.IsNullOrWhiteSpace(tenDangNhap) || tenDangNhap.Length < 5)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 5 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !KiemTraEmailHopLe(email))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nvBUS.KiemTraEmailTonTai(email))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nvBUS.TaoTaiKhoan(ten, tenDangNhap, email, phanQuyen))
            {
                MessageBox.Show("Tài khoản đã được tạo. Kiểm tra email để nhận mật khẩu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            CbPhanQuyen.Items.Add("Quản lý");
            CbPhanQuyen.Items.Add("Bác sĩ");
            CbPhanQuyen.Items.Add("Lễ tân");
            CbPhanQuyen.SelectedIndex = 0; // Mặc định chọn "Quản lý"
        }

        private void NutHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
