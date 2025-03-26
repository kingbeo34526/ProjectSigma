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
    public partial class GioiThieu : Form
    {
        public GioiThieu()
        {
            InitializeComponent();
            LoadGioiThieu();
            this.WindowState = FormWindowState.Maximized;
        }
        private void LoadGioiThieu()
        {
            string html = @"
            <html>
            <head>
                <style>
                    body { font-family: Arial, sans-serif; text-align: center; padding: 20px; color: #333; }
                    h1 { color: #007bff; }
                    h2 { color: #28a745; }
                    p { font-size: 16px; line-height: 1.6; }
                    .container { max-width: 600px; margin: auto; padding: 20px; border: 2px solid #007bff; border-radius: 10px; background: #f9f9f9; }
                </style>
            </head>
            <body>
                <div class='container'>
                    <h1>Phòng Khám SigmaMale</h1>
                    <h2>Sức Khỏe Của Bạn - Sứ Mệnh Của Chúng Tôi</h2>
                    <p>Phòng khám <strong>SigmaMale</strong> chuyên cung cấp dịch vụ y tế chất lượng cao, đảm bảo sự hài lòng cho bệnh nhân.</p>
                    <p>Chúng tôi có đội ngũ bác sĩ chuyên nghiệp, trang thiết bị hiện đại và dịch vụ chăm sóc tận tình.</p>
                    <p>📍 <b>Địa chỉ:</b> 66 Lâm Nhĩ, Tp. Đà Nẵng</p>
                    <p>📞 <b>Liên hệ:</b> 0909 123 456 | ✉️ work.anhkhoa2607@gmail.com</p>
                    <p><i>Chúc sức khỏe và hạnh phúc!</i></p>
                </div>
            </body>
            </html>";

            webBrowser1.DocumentText = html;
        }
    }
}
