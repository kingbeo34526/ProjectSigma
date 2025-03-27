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
            CustomizeUI();
        }
        private void CustomizeUI()
        {
            // Căn giữa form
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(240, 240, 240); // Màu nền nhẹ

            // Thiết lập Font chữ
            Font font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Label tiêu đề
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;

            // TextBox Username
            Txb_Username.Font = font;
            Txb_Username.BorderStyle = BorderStyle.FixedSingle;
            Txb_Username.BackColor = Color.White;
            Txb_Username.ForeColor = Color.Black;
            //Txb_Username.Width = 250;
            //Txb_Username.Height = 35;

            // TextBox Password
            Txb_Password.Font = font;
            Txb_Password.BorderStyle = BorderStyle.FixedSingle;
            Txb_Password.BackColor = Color.White;
            Txb_Password.ForeColor = Color.Black;
            //Txb_Password.Width = 250;
            //Txb_Password.Height = 35;
            Txb_Password.UseSystemPasswordChar = true; // Ẩn password

            // Checkbox "Ghi nhớ đăng nhập"
            GhiNhoMatKhau.Font = font;
            GhiNhoMatKhau.ForeColor = Color.Black;

            // Nút Đăng nhập
            NutDangNhap.Font = font;
            NutDangNhap.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            NutDangNhap.ForeColor = Color.White;
            NutDangNhap.FlatStyle = FlatStyle.Flat;
            NutDangNhap.FlatAppearance.BorderSize = 0;
            //NutDangNhap.Width = 120;
            //NutDangNhap.Height = 40;
            NutDangNhap.Cursor = Cursors.Hand;
            NutDangNhap.MouseEnter += (s, e) => { NutDangNhap.BackColor = Color.FromArgb(41, 128, 185); }; // Hover
            NutDangNhap.MouseLeave += (s, e) => { NutDangNhap.BackColor = Color.FromArgb(52, 152, 219); };

            // Nút Thoát
            NutThoat.Font = font;
            NutThoat.BackColor = Color.FromArgb(231, 76, 60); // Đỏ
            NutThoat.ForeColor = Color.White;
            NutThoat.FlatStyle = FlatStyle.Flat;
            NutThoat.FlatAppearance.BorderSize = 0;
            //NutThoat.Width = 120;
            //NutThoat.Height = 40;
            NutThoat.Cursor = Cursors.Hand;
            NutThoat.MouseEnter += (s, e) => { NutThoat.BackColor = Color.FromArgb(192, 57, 43); }; // Hover
            NutThoat.MouseLeave += (s, e) => { NutThoat.BackColor = Color.FromArgb(231, 76, 60); };
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
