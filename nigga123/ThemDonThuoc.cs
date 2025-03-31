using BUS;
using DTO;
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
    public partial class ThemDonThuoc : Form
    {
        private int maHoSo;
        private DonThuocBUS donThuocBUS = new DonThuocBUS();
        private ChiTietDonThuocBUS chiTietDonThuocBUS = new ChiTietDonThuocBUS();
        private ThuocBUS thuocBUS = new ThuocBUS();
        private int maDonThuoc; // Mã đơn thuốc mới
        public ThemDonThuoc(int maHoSo)
        {
            InitializeComponent();
            this.maHoSo = maHoSo;
        }

        private void ThemDonThuoc_Load(object sender, EventArgs e)
        {
            TxtHoSo.Text = maHoSo.ToString();
            LoadDanhSachThuoc();
            TaoDonThuocMoi();
        }
        private void LoadDanhSachThuoc()
        {
            CbThuoc.DataSource = ThuocBUS.GetAllThuoc();
            CbThuoc.DisplayMember = "TenThuoc";
            CbThuoc.ValueMember = "MaThuoc";
        }
        private void TaoDonThuocMoi()
        {
            DonThuocDTO donThuoc = new DonThuocDTO
            {
                MaHoSo = maHoSo,
                NgayLap = DateTime.Now
            };

            donThuocBUS.ThemDonThuoc(donThuoc);

            // Lấy mã đơn thuốc vừa tạo
            DataTable dt = donThuocBUS.LayDanhSachDonThuoc(maHoSo);
            if (dt.Rows.Count > 0)
            {
                maDonThuoc = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["MaDonThuoc"]);
            }
        }
        private void LoadDanhSachChiTiet()
        {
            DgvCTDT.DataSource = donThuocBUS.LayChiTietDonThuoc(maDonThuoc); 
            DgvCTDT.Columns["MaChiTiet"].Visible = false; // Ẩn cột MaChiTiet
        }
        private bool KiemTraDuLieu()
        {
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
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            int maThuoc = Convert.ToInt32(CbThuoc.SelectedValue);
            int soLuong = Convert.ToInt32(TxtSL.Text);

            ChiTietDonThuocDTO chiTiet = new ChiTietDonThuocDTO
            {
                MaDonThuoc = maDonThuoc,
                MaThuoc = maThuoc,
                SoLuong = soLuong
            };

            chiTietDonThuocBUS.ThemChiTietDonThuoc(chiTiet);
            LoadDanhSachChiTiet();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (DgvCTDT.SelectedRows.Count > 0)
            {
                int maChiTiet = Convert.ToInt32(DgvCTDT.SelectedRows[0].Cells["MaChiTiet"].Value);
                chiTietDonThuocBUS.XoaChiTietDonThuoc(maChiTiet);
                LoadDanhSachChiTiet();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
