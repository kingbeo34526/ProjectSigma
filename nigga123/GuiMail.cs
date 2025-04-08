using BUS;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nigga123
{
    public partial class GuiMail : Form
    {
        private int MaHoSo;
        private string EmailBenhNhan;
        public GuiMail(int maHoSo)
        {
            InitializeComponent();
            MaHoSo = maHoSo;
            LoadThongTinBenhNhan();
        }

        private void GuiMail_Load(object sender, EventArgs e)
        {
        }
        private void LoadThongTinBenhNhan()
        {
            // Lấy thông tin hồ sơ từ bảng HoSoKhamBenh
            var hoSoDataTable = HoSoKhamBenhBUS.GetHoSoById(MaHoSo);

            if (hoSoDataTable.Rows.Count > 0)
            {
                // Truy xuất thông tin từ dòng đầu tiên của DataTable
                var hoSo = hoSoDataTable.Rows[0];

                // Lấy thông tin email từ DAL
                EmailBenhNhan = BenhNhanBUS.GetEmailByMaHoSo(MaHoSo);
                string tenBenhNhan = BenhNhanBUS.GetTenBenhNhanByMaHoSo(MaHoSo);
                DateTime ngayHenDate = Convert.ToDateTime(hoSo["NgayHen"].ToString());
                LblDateHen.Text = Convert.ToDateTime(hoSo["NgayHen"]).ToString("dd/MM/yyyy");
                // Kiểm tra xem hồ sơ này đã có đơn thuốc chưa
                bool daCoDonThuoc = DonThuocBUS.HasDonThuocByMaHoSo(MaHoSo);
                CbDonThuoc.Enabled = daCoDonThuoc;

                if (!daCoDonThuoc)
                {
                    CbDonThuoc.Checked = false; // Không cho tick nếu không có đơn thuốc
                }
                // Logic xác định tình trạng hẹn
                string tinhTrangHen = "";

                if (hoSo["TrangThai"].ToString() == "Đã khám")
                {
                    tinhTrangHen = "Đã khám";
                    LblTT.ForeColor = Color.Green; // Màu xanh cho đã khám
                }
                else if (DateTime.Now > ngayHenDate)
                {
                    tinhTrangHen = "Trễ hẹn";
                    LblTT.ForeColor = Color.Red; // Màu đỏ cho trễ hẹn
                }
                else if (hoSo["TrangThai"].ToString() == "Chờ khám")
                {
                    tinhTrangHen = "Chưa khám";
                    LblTT.ForeColor = Color.Red; // Màu vàng cho chưa khám
                }
                else
                {
                    tinhTrangHen = "Đúng hẹn";
                    LblTT.ForeColor = Color.Green; // Màu xanh cho đúng hẹn
                }
                LblTT.Text = tinhTrangHen;
                if (!string.IsNullOrEmpty(EmailBenhNhan))
                {
                    TxtEmail.Text = EmailBenhNhan;

                    // Cập nhật nội dung email tùy vào trạng thái khám
                    string trangThai = hoSo["TrangThai"].ToString();  // Truy cập cột TrangThai
                    string ngayHen = hoSo["NgayHen"].ToString();      // Truy cập cột NgayHen
                    string ketQuaKham = hoSo["KetQuaKham"].ToString(); // Truy cập cột KetQuaKham

                    TxtND.Text = trangThai == "Chờ khám"
                        ? $"Nhập trạng thái khám của bệnh nhân này"
                        : $"{ketQuaKham}";
                    LblBenhNhan.Text = tenBenhNhan;  // Hiển thị tên bệnh nhân trên giao diện
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin email của bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hồ sơ khám bệnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NutGui_Click(object sender, EventArgs e)
        {
            var hoSo = HoSoKhamBenhBUS.GetHoSoById(MaHoSo).Rows[0];
            try
            {
                // Kiểm tra nếu email không rỗng
                if (string.IsNullOrEmpty(TxtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập email bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("work.anhkhoa2607@gmail.com");  // Địa chỉ email gửi
                mail.To.Add(TxtEmail.Text);  // Địa chỉ email của bệnh nhân
                mail.Subject = "Thông tin khám bệnh";  // Tiêu đề email

                // Cập nhật nội dung email với HTML
                string tenBenhNhan = BenhNhanBUS.GetTenBenhNhanByMaHoSo(MaHoSo);
                string emailContent = $@"
                <html>
                <head>
                    <style>
                        body, p, h1, h2, h3, h4, h5, h6, strong, span, div {{
                            color: #000000 !important; /* Đảm bảo toàn bộ chữ màu đen */
                            font-family: 'Arial', sans-serif;
                        }}
                        .container {{
                            width: 600px;
                            margin: 0 auto;
                            background-color: #ffffff;
                            border-radius: 8px;
                            padding: 20px;
                            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                        }}
                        h1 {{
                            text-align: center;
                            font-size: 28px;
                            margin-bottom: 10px;
                        }}
                        .content {{
                            padding: 15px;
                            background-color: #f9f9f9;
                            border-radius: 8px;
                            margin-top: 20px;
                            margin-bottom: 20px;
                        }}
                        .status {{
                            padding: 8px 12px;
                            background-color: #e1f5e1;
                            color: #388e3c !important;
                            border-radius: 5px;
                            font-weight: bold;
                        }}
                        .footer {{
                            text-align: center;
                            font-size: 12px;
                            color: #000000 !important; /* Chữ ở footer cũng đen */
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h1>Thông tin khám bệnh</h1>
                        <p><strong>Xin chào, {tenBenhNhan}!</strong></p>
                        <div class='content'>
                            <p><strong>Trạng thái khám:</strong> <span class='status'>{TxtND.Text}</span></p>
                            <p><strong>Lịch khám:</strong> {(hoSo["TrangThai"].ToString() == "Chờ khám" ? $"Vào lúc {hoSo["NgayHen"]}" : "Đã hoàn thành.")}</p>
                            <p><strong>Kết quả khám:</strong> {hoSo["KetQuaKham"].ToString()}</p>
                        </div>
                        <div class='footer'>
                            <p>Chúc bạn một ngày tốt lành!</p>
                            <p><small>Đây là email tự động từ hệ thống quản lý bệnh nhân. Vui lòng không trả lời email này.</small></p>
                        </div>
                    </div>
                </body>
                </html>";
                if (CbDonThuoc.Checked)
                {
                    // Giả sử có hàm lấy nội dung đơn thuốc dạng HTML từ BUS
                    string htmlDonThuoc = DonThuocBUS.GetDonThuocHtml(MaHoSo);
                    emailContent += "<hr/><h3>Đơn thuốc đính kèm:</h3>" + htmlDonThuoc;
                }
                // Gán nội dung HTML vào Body của email
                mail.Body = emailContent;
                mail.IsBodyHtml = true;  // Bật chế độ HTML cho nội dung email
                // Cấu hình SMTP để gửi email
                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("work.anhkhoa2607@gmail.com", "kzop xsnd dkdu mpns"),  // Thông tin đăng nhập email
                    EnableSsl = true
                };

                // Gửi email
                smtp.Send(mail);

                // Hiển thị thông báo thành công
                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu gửi email thất bại
                MessageBox.Show("Gửi email thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NutHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
