using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace nigga123
{
    public partial class SuaDonThuoc : Form
    {
        private int maDonThuoc;
        private DonThuocBUS donThuocBUS = new DonThuocBUS();
        private ChiTietDonThuocBUS chiTietDonThuocBUS = new ChiTietDonThuocBUS();
        private ThuocBUS thuocBUS = new ThuocBUS();

        public SuaDonThuoc(int maDonThuoc)
        {
            InitializeComponent();
            this.maDonThuoc = maDonThuoc;
        }

        private void SuaDonThuoc_Load(object sender, EventArgs e)
        {
            TxtDonThuoc.Text = maDonThuoc.ToString();
            LoadDanhSachThuoc();
            LoadDanhSachChiTiet();
        }

        private void LoadDanhSachThuoc()
        {
            CbThuoc.DataSource = ThuocBUS.GetAllThuoc();
            CbThuoc.DisplayMember = "TenThuoc";
            CbThuoc.ValueMember = "MaThuoc";
        }

        private void LoadDanhSachChiTiet()
        {
            DgvCTDT.DataSource = donThuocBUS.LayChiTietDonThuoc(maDonThuoc);
            DgvCTDT.Columns["MaChiTiet"].Visible = false; // Ẩn cột MaChiTiet
        }
        private bool KiemTraDuLieu()
        {
            if (DgvCTDT.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chi tiết đơn thuốc để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (CbThuoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(TxtSL.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            int maChiTiet = Convert.ToInt32(DgvCTDT.SelectedRows[0].Cells["MaChiTiet"].Value); // Lấy từ DGV
            int maThuoc = Convert.ToInt32(CbThuoc.SelectedValue);
            int soLuong = Convert.ToInt32(TxtSL.Text);

            ChiTietDonThuocDTO chiTiet = new ChiTietDonThuocDTO
            {
                MaChiTiet = maChiTiet,  // Dùng giá trị sẵn có
                MaThuoc = maThuoc,
                SoLuong = soLuong
            };

            chiTietDonThuocBUS.SuaChiTietDonThuoc(chiTiet);
            LoadDanhSachChiTiet();
        }


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvCTDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CbThuoc.SelectedValue = DgvCTDT.Rows[e.RowIndex].Cells["MaThuoc"].Value;
                TxtSL.Text = DgvCTDT.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
        }
    }
}
