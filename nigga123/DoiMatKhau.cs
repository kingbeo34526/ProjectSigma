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

    public partial class DoiMatKhau : Form
    {
        private string tenDangNhap;
        private NhanVienBUS nvBUS = new NhanVienBUS(); // Gọi lớp xử lý nghiệp vụ nhân viên
        public DoiMatKhau(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;     
            Txb_Username.Text = tenDangNhap; // Điền tự động username
            Txb_Username.Enabled = false;    // Không cho chỉnh sửa
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matKhauCu = Txb_Password.Text.Trim();
            string matKhauMoi = Txb_PasswordNew.Text.Trim();
            string xacNhanMatKhau = Txb_PasswordCfm.Text.Trim();
            // Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra mật khẩu cũ
            string matKhauDaLuu = nvBUS.LayMatKhau(tenDangNhap); // Lấy mật khẩu cũ từ DB
            if (!BCrypt.Net.BCrypt.Verify(matKhauCu, matKhauDaLuu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Mã hóa mật khẩu mới
            string matKhauMoiHash = BCrypt.Net.BCrypt.HashPassword(matKhauMoi);

            // Cập nhật mật khẩu mới
            if (nvBUS.DoiMatKhau(tenDangNhap, matKhauMoiHash))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi đổi mật khẩu thành công
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
