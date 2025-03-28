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
    public partial class CauHinhDB : Form
    {
        public CauHinhDB()
        {
            InitializeComponent();
        }
        private void LoadConfig()
        {
            TxtDB.Text = ConfigBUS.GetConnectionString();
        }

        private void CauHinhDB_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void NutLuu_Click(object sender, EventArgs e)
        {
            ConfigBUS.SaveConnectionString(TxtDB.Text);
            MessageBox.Show("Chuỗi kết nối đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}
