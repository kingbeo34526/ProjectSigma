using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        private void CustomizeUI()
        {
            // Căn giữa form khi mở
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            this.BackColor = Color.White; // Nền sáng
            // Bo góc Form
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width - 1, this.Height - 1, 20, 20));

            // Chỉnh tiêu đề "Đăng nhập"
            label1.Font = new Font("Poppins", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // CheckBox Ghi nhớ
            GhiNhoMatKhau.Font = new Font("Segoe UI", 10F);
            GhiNhoMatKhau.ForeColor = Color.Black;

            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            linkLabel1.ForeColor = Color.Blue;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.AutoSize = true;

            // Căn lại "Máy chủ" 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.ForeColor = Color.Gray;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.AutoSize = false;
            label4.Width = this.ClientSize.Width;

            // Cập nhật lại layout
            this.PerformLayout();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ConfigBUS.EnsureConfigFileExists();
            if (Properties.Settings.Default.GhiNhoDangNhap)
            {
                Txb_Username.Text = Properties.Settings.Default.TenDangNhap;
                Txb_Password.Text = Properties.Settings.Default.MatKhau;
                GhiNhoMatKhau.Checked = true;
            }

            string connectionString = ConfigBUS.GetConnectionString();
            string serverInfo = "Không xác định";
            // Kiểm tra nếu connectionString có chứa "N/A"
            if (string.IsNullOrEmpty(connectionString) || connectionString.Contains("N/A"))
            {
                MessageBox.Show("Cấu hình cơ sở dữ liệu chưa hợp lệ! Vui lòng thiết lập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CauHinhDB cauHinhDB = new CauHinhDB();
                cauHinhDB.ShowDialog();
            }
            if (!string.IsNullOrEmpty(connectionString))
            {
                try
                {
                    // Tách phần "Data Source=..."
                    var parts = connectionString.Split(';');
                    foreach (var part in parts)
                    {
                        if (part.Trim().StartsWith("Data Source=", StringComparison.OrdinalIgnoreCase))
                        {
                            serverInfo = part.Replace("Data Source=", "").Trim();
                            break;
                        }
                    }
                }
                catch { serverInfo = "Lỗi đọc cấu hình"; }
            }

            label4.Text = "Server: " + serverInfo;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CauHinhDB cauHinhDB = new CauHinhDB();
            cauHinhDB.ShowDialog();
        }
    }
}
