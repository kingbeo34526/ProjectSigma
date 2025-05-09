﻿using BUS;
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
            LoadThuoc();
        }
        private void QuanLiThuoc_Load(object sender, EventArgs e)
        {

            LoadDonViThuoc();
            DgvThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            DgvThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            DgvThuoc.Columns["SoLuong"].HeaderText = "Số Lượng";
            DgvThuoc.Columns["Gia"].HeaderText = "Giá";
            DgvThuoc.Columns["DonViThuoc"].HeaderText = "Đơn Vị";
            DgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvThuoc.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvThuoc.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvThuoc.MultiSelect = false; // Không cho phép chọn nhiều dòng
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
            if (string.IsNullOrWhiteSpace(TxtTenThuoc.Text) ||
                CbThuoc.SelectedItem == null ||
                string.IsNullOrWhiteSpace(TxtSL.Text) ||
                string.IsNullOrWhiteSpace(TxtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string tenThuoc = TxtTenThuoc.Text;
                int donVi = (int)((dynamic)CbThuoc.SelectedItem).Value;
                int soLuong = int.Parse(TxtSL.Text);
                decimal gia = decimal.Parse(TxtGia.Text);

                thuocBUS.ThemThuoc(tenThuoc, donVi, soLuong, gia);
                LoadThuoc();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng và giá phải là số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NutSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn thuốc cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(TxtMaThuoc.Text)) return;
            try
            {
                int maThuoc = int.Parse(TxtMaThuoc.Text);
                string tenThuoc = TxtTenThuoc.Text;
                int donVi = (int)((dynamic)CbThuoc.SelectedItem).Value;
                int soLuong = int.Parse(TxtSL.Text);
                decimal gia = decimal.Parse(TxtGia.Text);

                thuocBUS.SuaThuoc(maThuoc, tenThuoc, donVi, soLuong, gia);
                LoadThuoc();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng và giá phải là số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NutXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn thuốc cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
        private void ClearForm()
        {
            TxtMaThuoc.Clear();
            TxtTenThuoc.Clear();
            TxtSL.Clear();
            TxtGia.Clear();
            CbThuoc.SelectedIndex = -1; // Bỏ chọn đơn vị thuốc
            TxtTimKiem.Clear();
            DgvThuoc.ClearSelection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
