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
            DgvChiTietDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvChiTietDonThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvChiTietDonThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvChiTietDonThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvChiTietDonThuoc.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvChiTietDonThuoc.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvChiTietDonThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvChiTietDonThuoc.MultiSelect = false; // Không cho phép chọn nhiều dòng

            
            DgvDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvDonThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvDonThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvDonThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvDonThuoc.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvDonThuoc.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvDonThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvDonThuoc.MultiSelect = false; // Không cho phép chọn nhiều dòng
            DgvDonThuoc.Columns["MaDonThuoc"].HeaderText = "Mã Đơn Thuốc";
            DgvDonThuoc.Columns["MaHoSo"].HeaderText = "Mã Hồ Sơ";
            DgvDonThuoc.Columns["NgayLap"].HeaderText = "Ngày Lập";
        }
        private void LoadDanhSachDonThuoc()
        {
            DgvDonThuoc.DataSource = donThuocBUS.LayDanhSachDonThuoc(maHoSo);
        }

        private void DgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn thuốc hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object value = DgvDonThuoc.Rows[e.RowIndex].Cells["MaDonThuoc"].Value;

            if (value == null || value == DBNull.Value)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng chọn một đơn thuốc khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.RowIndex >= 0)
            {
                int maDonThuoc = Convert.ToInt32(DgvDonThuoc.Rows[e.RowIndex].Cells["MaDonThuoc"].Value);
                DgvChiTietDonThuoc.DataSource = donThuocBUS.LayChiTietDonThuoc(maDonThuoc);
                DgvChiTietDonThuoc.Columns["MaChiTiet"].Visible = false; // Ẩn cột MaChiTiet
                if (DgvChiTietDonThuoc.Columns.Count > 0)
                {
                    DgvChiTietDonThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
                    DgvChiTietDonThuoc.Columns["SoLuong"].HeaderText = "Số Lượng";
                }
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
