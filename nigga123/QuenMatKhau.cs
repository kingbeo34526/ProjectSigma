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
    public partial class QuenMatKhau : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = BoxEmailReset.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(BoxEmailReset.Text) || !Regex.IsMatch(BoxEmailReset.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập đúng định dạng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nvBUS.KiemTraEmailTonTai(email))
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nvBUS.QuenMatKhau(email))
            {
                MessageBox.Show("Mật khẩu mới đã được gửi qua email.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi gửi mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
