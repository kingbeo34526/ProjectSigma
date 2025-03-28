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
    public partial class Main : Form
    {
        private string tenDangNhap;
        private int quyen; // 1 = Quản lý, 2 = Bác sĩ, 3 = Lễ tân
        private DateTime thoiGianBatDau; // Biến lưu thời gian đăng nhập
        private Timer timer; // Timer để cập nhật thời gian
        private string quyenText; // Quyền hạn
        private Color quyenColor; // Màu quyền hạn

        public Main(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.quyen = new NhanVienBUS().LayQuyen(tenDangNhap); // Lấy quyền từ 
        }
        private void Main_Load(object sender, EventArgs e)
        {

            switch (quyen)
            {
                case 1:
                    quyenText = "Quản lý";
                    quyenColor = Color.Red;
                    break;
                case 2:
                    quyenText = "Bác sĩ";
                    quyenColor = Color.Blue;
                    break;
                case 3:
                    quyenText = "Lễ tân";
                    quyenColor = Color.Goldenrod;
                    break;
            }

            hệThốngTàiKhoảnToolStripMenuItem.Text = $"{tenDangNhap}";
            quyềnHạnToolStripMenuItem.Text = $"Quyền hạn hiện tại: {quyenText}";
            quyềnHạnToolStripMenuItem.ForeColor = quyenColor;

            // Phân quyền
            quảnLíTàiKhoảnToolStripMenuItem.Visible = (quyen == 1); // Chỉ quản lý mới thấy
            quảnLýThuốcToolStripMenuItem.Visible = (quyen == 1 || quyen == 2); // Quản lý và bác sĩ thấy
            bệnhNhânToolStripMenuItem.Visible = (quyen == 1 || quyen == 2 || quyen == 3); // Quản lý, bác sĩ và lễ tân thấy
            phiếuKhámBệnhToolStripMenuItem.Visible = (quyen == 1 || quyen == 2 || quyen == 3); // Quản lý, bác sĩ và lễ tân thấy

            // Lưu thời gian bắt đầu sử dụng
            thoiGianBatDau = DateTime.Now;

            // Cài đặt Timer
            timer = new Timer();
            timer.Interval = 1000; // Mỗi giây cập nhật một lần
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            string thoiGianHienTai = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");

            // Tính thời gian sử dụng
            TimeSpan thoiGianSuDung = DateTime.Now - thoiGianBatDau;
            string thoiGianSuDungText = $"{thoiGianSuDung.Hours} giờ {thoiGianSuDung.Minutes} phút {thoiGianSuDung.Seconds} giây";

            // Cập nhật Label
            LblThongTin.Text = $"🕒 {thoiGianHienTai} | ⏳ {thoiGianSuDungText}";
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Đăng xuất
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Ẩn Main trước khi mở form đăng nhập
                DangNhap loginForm = new DangNhap();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show(); // Nếu đăng nhập thành công, hiển thị lại Main
                }
                else
                {
                    this.Close(); // Nếu không đăng nhập, đóng ứng dụng
                }
            }
        }
        //
        // Chuyển form
        //
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e) // Đổi mật khẩu
        {
            DoiMatKhau dmk = new DoiMatKhau(tenDangNhap);
            dmk.MdiParent = this;
            dmk.Show();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e) // Quản lí tài khoản (Admin)
        {
            QuanLiNhanVien qlnv = new QuanLiNhanVien(tenDangNhap);
            qlnv.MdiParent = this;
            qlnv.Show();
        }

        //private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e) // Quản lí hồ sơ bệnh nhân
        //{
        //    QuanLiHoSoBN qlhsbn = new QuanLiHoSoBN();
        //    qlhsbn.ShowDialog();
        //}

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e) // Quản lí bệnh nhân
        {
            QuanLiBenhNhan qlbn = new QuanLiBenhNhan();
            qlbn.MdiParent = this;
            qlbn.Show();
        }

        private void phiếuKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e) // Quản lí phiếu khám bệnh
        {
            QuanLiPhieuKham pkb = new QuanLiPhieuKham(quyen);
            pkb.MdiParent = this;
            pkb.Show();
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e) // Quản lí thuốc
        {
            QuanLiThuoc qlt = new QuanLiThuoc();
            qlt.MdiParent= this;
            qlt.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }

        private void danhSáchĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DanhSachDonThuoc dsdt = new DanhSachDonThuoc();
            //dsdt.MdiParent = this;
            //dsdt.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu();
            gt.MdiParent = this;
            gt.Show();
            gt.ControlBox = false;
            gt.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
