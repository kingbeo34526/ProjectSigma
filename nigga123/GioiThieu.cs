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
                    <h1>Hệ Thống Quản Lý Phòng Khám Sigma</h1>
                    <p>Chào mừng bạn đến với hệ thống quản lý phòng khám <strong>Sigma</strong>.</p>
                    <p>Hệ thống giúp bạn theo dõi bệnh nhân, quản lý đơn thuốc và tối ưu hóa quy trình làm việc.</p>
                    <p>📍 <b>Địa chỉ phòng khám:</b> 66 Lâm Nhĩ, Tp. Đà Nẵng</p>
                    <p>📞 <b>Liên hệ hỗ trợ:</b> 0909 123 456 | ✉️ support.sigma@gmail.com</p>
                    <p><i>Cảm ơn bạn đã đồng hành cùng phòng khám!</i></p>
                </div>
            </body>
            </html>";

            webBrowser1.DocumentText = html;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
