using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void NutTao_Click(object sender, EventArgs e)
        {
            string ten = BoxTen.Text;
            string tenDangNhap = BoxUsername.Text;
            string email = BoxEmail.Text;
            int phanQuyen = ChuyenDoiPhanQuyen(CbPhanQuyen.SelectedItem.ToString()); // Chuyển từ chữ sang số
            // Kiểm tra email đã tồn tại chưa
            if (nvBUS.KiemTraEmailTonTai(email))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
                return;
            }
            if (nvBUS.TaoTaiKhoan(ten, tenDangNhap, email, phanQuyen))
            {
                MessageBox.Show("Tài khoản đã được tạo. Kiểm tra email để nhận mật khẩu.");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại.");
            }
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            CbPhanQuyen.Items.Add("Quản lý");
            CbPhanQuyen.Items.Add("Bác sĩ");
            CbPhanQuyen.Items.Add("Lễ tân");
            CbPhanQuyen.SelectedIndex = 0; // Mặc định chọn "Quản lý"
        }
    }
}
