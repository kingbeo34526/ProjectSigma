using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL nvDAL = new NhanVienDAL();
        //
        // Đăng nhập, tạo tài khoản, quên mật khẩu
        //

        //public bool TaoTaiKhoan(string ten, string tenDangNhap, string email, int phanQuyen)
        //{
        //    string matKhau = TaoMatKhauNgauNhien(); // Tạo mật khẩu ngẫu nhiên
        //    string matKhauMaHoa = BCrypt.Net.BCrypt.HashPassword(matKhau); // Mã hóa mật khẩu

        //    if (nvDAL.TaoTaiKhoan(ten, tenDangNhap, email, phanQuyen, matKhauMaHoa))
        //    {
        //        GuiEmail(email, "Tài khoản mới", $"Mật khẩu của bạn là: {matKhau}");
        //        return true;
        //    }
        //    return false;
        //}
        public bool TaoTaiKhoan(string ten, string tenDangNhap, string email, int phanQuyen)
        {
            string matKhau = TaoMatKhauNgauNhien(); // Tạo mật khẩu ngẫu nhiên
            string matKhauMaHoa = BCrypt.Net.BCrypt.HashPassword(matKhau); // Mã hóa mật khẩu

            if (nvDAL.TaoTaiKhoan(ten, tenDangNhap, email, phanQuyen, matKhauMaHoa))
            {
                string subject = "Thông tin tài khoản mới - Phòng khám Sigma";
                string body = $@"
                <html>
                <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                    <h2 style='color: #28a745;'>Tài khoản của bạn đã được tạo thành công!</h2>
                    <p>Chào <strong>{ten}</strong>,</p>
                    <p>Chúng tôi đã tạo một tài khoản mới cho bạn tại <strong>Phòng khám Sigma</strong>.</p>
                    <p><strong>Tên đăng nhập:</strong> {tenDangNhap}</p>
                    <p><strong>Mật khẩu:</strong> <span style='color: #d9534f; font-weight: bold;'>{matKhau}</span></p>
                    <p>Vui lòng đăng nhập và <strong>đổi mật khẩu</strong> ngay để bảo vệ tài khoản.</p>
                    <p>Trân trọng,<br><strong>Phòng khám Sigma</strong></p>
                </body>
                </html>";

                GuiEmail(email, subject, body, true);
                return true;
            }
            return false;
        }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            string matKhauDaLuu = nvDAL.LayMatKhau(tenDangNhap);

            if (matKhauDaLuu != null && BCrypt.Net.BCrypt.Verify(matKhau, matKhauDaLuu))
            {
                return true;
            }
            return false;
        }
        public bool KiemTraEmailTonTai(string email)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE Email = @Email";
            SqlParameter[] parameters = { new SqlParameter("@Email", email) };

            int count = (int)DataProvider.ExecuteScalar(query, parameters);
            return count > 0;
        }

        private string TaoMatKhauNgauNhien()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }
        //private void GuiEmail(string emailNhan, string tieuDe, string noiDung)
        //{
        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress("work.anhkhoa2607@gmail.com");
        //    mail.To.Add(emailNhan);
        //    mail.Subject = tieuDe;
        //    mail.Body = noiDung;
        //    mail.IsBodyHtml = true;

        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //    smtp.Credentials = new System.Net.NetworkCredential("work.anhkhoa2607@gmail.com", "kzop xsnd dkdu mpns");
        //    smtp.EnableSsl = true;
        //    smtp.Send(mail);
        //}
        public static void GuiEmail(string toEmail, string subject, string body, bool isHtml = false)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(toEmail);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = isHtml; // Hỗ trợ HTML
            mail.From = new MailAddress("work.anhkhoa2607@gmail.com");

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("work.anhkhoa2607@gmail.com", "kzop xsnd dkdu mpns");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        //public bool QuenMatKhau(string email)
        //{
        //    var nhanVien = nvDAL.LayNhanVienTheoEmail(email);
        //    if (nhanVien == null) return false; // Không tìm thấy email

        //    string matKhauMoi = TaoMatKhauNgauNhien();
        //    string matKhauHash = BCrypt.Net.BCrypt.HashPassword(matKhauMoi);

        //    if (nvDAL.CapNhatMatKhau(nhanVien["TenDangNhap"].ToString(), matKhauHash))
        //    {
        //        GuiEmail(email, "Khôi phục mật khẩu", $"Mật khẩu mới của bạn là: {matKhauMoi}");
        //        return true;
        //    }
        //    return false;
        //}
        public bool QuenMatKhau(string email)
        {
            var nhanVien = nvDAL.LayNhanVienTheoEmail(email);
            if (nhanVien == null) return false; // Không tìm thấy email

            string matKhauMoi = TaoMatKhauNgauNhien();
            string matKhauHash = BCrypt.Net.BCrypt.HashPassword(matKhauMoi);

            if (nvDAL.CapNhatMatKhau(nhanVien["TenDangNhap"].ToString(), matKhauHash))
            {
                string subject = "Khôi phục mật khẩu - Phòng khám Sigma";
                string body = $@"
                <html>
                <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                    <h2 style='color: #dc3545;'>Khôi phục mật khẩu</h2>
                    <p>Chào <strong>{nhanVien["Ten"]}</strong>,</p>
                    <p>Chúng tôi đã nhận được yêu cầu khôi phục mật khẩu của bạn.</p>
                    <p><strong>Mật khẩu mới của bạn:</strong> <span style='color: #d9534f; font-weight: bold;'>{matKhauMoi}</span></p>
                    <p>Vui lòng đăng nhập và <strong>đổi mật khẩu</strong> ngay để đảm bảo an toàn tài khoản.</p>
                    <p>Nếu bạn không yêu cầu khôi phục mật khẩu, vui lòng bỏ qua email này.</p>
                    <p>Trân trọng,<br><strong>Phòng khám Sigma</strong></p>
                </body>
                </html>";

                GuiEmail(email, subject, body, true);
                return true;
            }
            return false;
        }

        public bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            string matKhauDaLuu = nvDAL.LayMatKhau(tenDangNhap);
            if (!BCrypt.Net.BCrypt.Verify(matKhauCu, matKhauDaLuu)) return false; // Sai mật khẩu cũ

            string matKhauMoiHash = BCrypt.Net.BCrypt.HashPassword(matKhauMoi);
            return nvDAL.CapNhatMatKhau(tenDangNhap, matKhauMoiHash);
        }
        public int LayQuyen(string tenDangNhap)
        {
            return nvDAL.LayQuyen(tenDangNhap);
        }
        public string LayMatKhau(string tenDangNhap)
        {
            return nvDAL.LayMatKhau(tenDangNhap); // Lấy mật khẩu từ database
        }
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            return nvDAL.CapNhatMatKhau(tenDangNhap, matKhauMoi);
        }
        //
        // Quản lí nhân viên
        //
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return NhanVienDAL.LayDanhSachNhanVien();
        }
        public static DataTable LayDanhSachBacSi()
        {
            string query = "SELECT MaNV, Ten FROM NhanVien WHERE PhanQuyen = 2";
            return DataProvider.ExecuteQuery(query);
        }
        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAL.SuaNhanVien(nv);
        }

        public static bool XoaNhanVien(int maNV)
        {
            return NhanVienDAL.XoaNhanVien(maNV);
        }
        public static DataTable TimKiemNhanVien(string keyword)
        {
            return NhanVienDAL.TimKiemNhanVien(keyword);
        }
       
    }
}
