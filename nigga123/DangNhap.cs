using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nigga123
{
    public partial class DangNhap : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GhiNhoDangNhap)
            {
                Txb_Username.Text = Properties.Settings.Default.TenDangNhap;
                Txb_Password.Text = Properties.Settings.Default.MatKhau;
                GhiNhoMatKhau.Checked = true;
            }
        }
        private void NutDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = Txb_Username.Text;
            string matKhau = Txb_Password.Text;

            if (nvBUS.DangNhap(tenDangNhap, matKhau))
            {
                // Ghi nhớ đăng nhập nếu CheckBox được chọn
                if (GhiNhoMatKhau.Checked)
                {
                    Properties.Settings.Default.GhiNhoDangNhap = true;
                    Properties.Settings.Default.TenDangNhap = tenDangNhap;
                    Properties.Settings.Default.MatKhau = matKhau; 
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.GhiNhoDangNhap = false;
                    Properties.Settings.Default.TenDangNhap = "";
                    Properties.Settings.Default.MatKhau = "";
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form chính sau khi đăng nhập thành công
                this.Hide();
                Main Main = new Main(tenDangNhap);
                Main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!\nVui lòng thử lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void buttonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan ttk = new TaoTaiKhoan();
            ttk.ShowDialog();
        }
        private void NutThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.ShowDialog();
        }
    }
}
