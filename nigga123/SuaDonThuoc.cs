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

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (DgvCTDT.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(TxtSL.Text))
            {
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
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần sửa và nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
