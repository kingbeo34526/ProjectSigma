using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace nigga123
{
    public partial class QuanLiDonThuoc : Form
    {
        private int maHoSo;
        private DonThuocBUS donThuocBUS = new DonThuocBUS();
        private int maBenhNhan;
        public QuanLiDonThuoc(int maHoSo, int maBenhNhan)
        {
            InitializeComponent();
            this.maHoSo = maHoSo;
            this.maBenhNhan = maBenhNhan;
        }

        private void QuanLiDonThuoc_Load(object sender, EventArgs e)
        {
            TxtHoSo.Text = maHoSo.ToString();
            TxtMaBN.Text = BenhNhanBUS.LayTenBenhNhan(maBenhNhan);
            LoadDanhSachDonThuoc();
        }
        private void LoadDanhSachDonThuoc()
        {
            DgvDonThuoc.DataSource = donThuocBUS.LayDanhSachDonThuoc(maHoSo);
        }

        private void DgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maDonThuoc = Convert.ToInt32(DgvDonThuoc.Rows[e.RowIndex].Cells["MaDonThuoc"].Value);
                DgvChiTietDonThuoc.DataSource = donThuocBUS.LayChiTietDonThuoc(maDonThuoc);
                DgvChiTietDonThuoc.Columns["MaChiTiet"].Visible = false; // Ẩn cột MaChiTiet
            }
        }

        private void button1_Click(object sender, EventArgs e) // Nút thêm
        {
            ThemDonThuoc frm = new ThemDonThuoc(maHoSo);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            LoadDanhSachDonThuoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DgvDonThuoc.SelectedRows.Count > 0)
            {
                int maDonThuoc = Convert.ToInt32(DgvDonThuoc.SelectedRows[0].Cells["MaDonThuoc"].Value);

                if (MessageBox.Show("Bạn có chắc muốn xóa đơn thuốc này?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        donThuocBUS.XoaDonThuoc(maDonThuoc); // Gọi BUS để xóa cả đơn thuốc và chi tiết
                        LoadDanhSachDonThuoc();              // Load lại danh sách
                        DgvChiTietDonThuoc.DataSource = null; // Xóa dữ liệu chi tiết đơn thuốc trên UI
                        MessageBox.Show("Xóa đơn thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NutSua_Click(object sender, EventArgs e)
        {
            if (DgvDonThuoc.SelectedRows.Count > 0)
            {
                int maDonThuoc = Convert.ToInt32(DgvDonThuoc.SelectedRows[0].Cells["MaDonThuoc"].Value);
                SuaDonThuoc frm = new SuaDonThuoc(maDonThuoc);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                LoadDanhSachDonThuoc();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn thuốc cần sửa.");
            }
        }
    }
}
