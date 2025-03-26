using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nigga123
{
    public partial class QuanLiThuoc : Form
    {
        private ThuocBUS thuocBUS = new ThuocBUS();
        public QuanLiThuoc()
        {
            InitializeComponent();
        }
        private void QuanLiThuoc_Load(object sender, EventArgs e)
        {
            LoadThuoc();
            LoadDonViThuoc();
        }
        private void LoadThuoc(string keyword = "")
        {
            List<ThuocDTO> danhSachThuoc = ThuocBUS.TimKiemThuoc(keyword);
            DgvThuoc.DataSource = danhSachThuoc;
        }
        private void LoadDonViThuoc()
        {
            CbThuoc.Items.Add(new { Value = 1, Text = "Viên" });
            CbThuoc.Items.Add(new { Value = 2, Text = "Hộp" });
            CbThuoc.Items.Add(new { Value = 3, Text = "Chai" });

            CbThuoc.DisplayMember = "Text";  // Hiển thị chữ
            CbThuoc.ValueMember = "Value";   // Lưu số vào CSDL
        }

        private void NutThem_Click(object sender, EventArgs e)
        {
            string tenThuoc = TxtTenThuoc.Text;
            int donVi = (int)((dynamic)CbThuoc.SelectedItem).Value;
            int soLuong = Convert.ToInt32(TxtSL.Text);
            decimal gia = Convert.ToDecimal(TxtGia.Text);

            thuocBUS.ThemThuoc(tenThuoc, donVi, soLuong, gia);
            LoadThuoc();
        }

        private void NutSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMaThuoc.Text)) return;

            int maThuoc = Convert.ToInt32(TxtMaThuoc.Text);
            string tenThuoc = TxtTenThuoc.Text;
            int donVi = (int)((dynamic)CbThuoc.SelectedItem).Value;
            int soLuong = Convert.ToInt32(TxtSL.Text);
            decimal gia = Convert.ToDecimal(TxtGia.Text);

            thuocBUS.SuaThuoc(maThuoc, tenThuoc, donVi, soLuong, gia);
            LoadThuoc();
        }

        private void NutXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMaThuoc.Text)) return;

            int maThuoc = Convert.ToInt32(TxtMaThuoc.Text);
            thuocBUS.XoaThuoc(maThuoc);
            LoadThuoc();
        }
        private void DgvThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvThuoc.SelectedRows.Count > 0)
            {
                TxtMaThuoc.Text = DgvThuoc.SelectedRows[0].Cells["MaThuoc"].Value.ToString();
                TxtTenThuoc.Text = DgvThuoc.SelectedRows[0].Cells["TenThuoc"].Value.ToString();
                TxtSL.Text = DgvThuoc.SelectedRows[0].Cells["SoLuong"].Value.ToString();
                TxtGia.Text = DgvThuoc.SelectedRows[0].Cells["Gia"].Value.ToString();

                int donVi = Convert.ToInt32(DgvThuoc.SelectedRows[0].Cells["DonViThuoc"].Value);
                foreach (var item in CbThuoc.Items)
                {
                    if (((dynamic)item).Value == donVi)
                    {
                        CbThuoc.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadThuoc(TxtTimKiem.Text.Trim());
        }
        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
