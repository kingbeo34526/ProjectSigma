using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Windows.Forms;

//using PhongKham;

namespace nigga123
{
    public partial class QuanLiPhieuKham : Form
    {
        private int PhanQuyenNguoiDung = 0; // Lưu quyền nhân viên hiện tại
        public QuanLiPhieuKham(int phanQuyen)
        {
            InitializeComponent();
            LoadHoSo();
            LoadComboBoxTrangThai();
            NutDonThuoc.Enabled = false; 
            NutXem.Enabled = false;
            button4.Enabled = false; 
            DgvPhieuKham.CellFormatting += DgvPhieuKham_CellFormatting;
            PhanQuyenNguoiDung = phanQuyen; // Nhận quyền từ form đăng nhập hoặc main
        }
        private void LoadHoSo()
        {
            DgvPhieuKham.DataSource = HoSoKhamBenhBUS.GetAllHoSo();
        }
        private void LoadComboBoxTrangThai()
        {
            CbTrangThai.Items.Clear();
            CbTrangThai.Items.Add("Tất cả");
            CbTrangThai.Items.Add("Chờ khám");
            CbTrangThai.Items.Add("Đã khám");
            CbTrangThai.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }
        private void NutLapHS_Click(object sender, EventArgs e)
        {

            QuanLiHoSoBN form = new QuanLiHoSoBN();
            form.MdiParent = this.MdiParent; // Đặt Form Chính làm MDI Parent
            form.HoSoDaCapNhat += LoadHoSo;
            form.Show();
        }

        private void NutXem_Click(object sender, EventArgs e)
        {

            if (DgvPhieuKham.SelectedRows.Count > 0)
            {
                int maHoSo = Convert.ToInt32(DgvPhieuKham.SelectedRows[0].Cells["MaHoSo"].Value);
                QuanLiHoSoBN form = new QuanLiHoSoBN(maHoSo);
                form.MdiParent = this.MdiParent; // Đặt Form Chính làm MDI Parent
                form.HoSoDaCapNhat += LoadHoSo;
                form.Show();
            }
        }
        private void DgvPhieuKham_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn không
            NutDonThuoc.Enabled = DgvPhieuKham.SelectedRows.Count > 0;
            NutXem.Enabled = DgvPhieuKham.SelectedRows.Count > 0;
            button4.Enabled = DgvPhieuKham.SelectedRows.Count > 0; // Bật/tắt nút gửi email
        }
        private void DgvPhieuKham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvPhieuKham.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                string trangThai = e.Value.ToString();
                if (trangThai == "Chờ khám")
                {
                    e.CellStyle.ForeColor = Color.Red; // Chữ màu đỏ
                }
                else if (trangThai == "Đã khám")
                {
                    e.CellStyle.ForeColor = Color.Green; // Chữ màu xanh lá
                }
            }
        }


        private void CbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTrangThai.SelectedIndex == 0) // "Tất cả"
            {
                LoadHoSo();
            }
            else
            {
                string trangThai = CbTrangThai.SelectedItem.ToString();
                DgvPhieuKham.DataSource = HoSoKhamBenhBUS.GetHoSoByTrangThai(trangThai);
            }
        }

        private void NutDonThuoc_Click(object sender, EventArgs e)
        {
            if (PhanQuyenNguoiDung != 1 && PhanQuyenNguoiDung != 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đơn thuốc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DgvPhieuKham.SelectedRows.Count > 0)
            {
                int maHoSo = Convert.ToInt32(DgvPhieuKham.SelectedRows[0].Cells["MaHoSo"].Value);
                int maBenhNhan = Convert.ToInt32(DgvPhieuKham.SelectedRows[0].Cells["MaBenhNhan"].Value);
                QuanLiDonThuoc frmDonThuoc = new QuanLiDonThuoc(maHoSo, maBenhNhan);
                frmDonThuoc.MdiParent = this.MdiParent;
                frmDonThuoc.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hồ sơ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtTimKiemTen_TextChanged(object sender, EventArgs e)
        {
            TimKiemHoSo();
        }
        private void TimKiemHoSo()
        {
            string tenBenhNhan = TxtTimKiemTen.Text.Trim();
            if (!string.IsNullOrEmpty(tenBenhNhan))
            {
                DgvPhieuKham.DataSource = HoSoKhamBenhBUS.TimKiemHoSoTheoTen(tenBenhNhan);
            }
            else
            {
                LoadHoSo(); // Hiển thị tất cả nếu ô tìm kiếm rỗng
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadHoSo();
        }
        private void QuanLiPhieuKham_Load(object sender, EventArgs e)
        {
            DgvPhieuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvPhieuKham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvPhieuKham.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvPhieuKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvPhieuKham.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvPhieuKham.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvPhieuKham.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvPhieuKham.MultiSelect = false; // Không cho phép chọn nhiều dòng
            DgvPhieuKham.Columns["MaHoSo"].HeaderText = "Mã Hồ Sơ";
            DgvPhieuKham.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
            DgvPhieuKham.Columns["HoTen"].HeaderText = "Tên Bệnh Nhân";
            //DgvPhieuKham.Columns["MaNV"].HeaderText = "Mã Bác Sĩ";
            DgvPhieuKham.Columns["TrangThai"].HeaderText = "Trạng Thái";
            //DgvPhieuKham.Columns["NgayHen"].HeaderText = "Ngày Hẹn";
            //DgvPhieuKham.Columns["TrieuChung"].HeaderText = "Triệu Chứng";
            //DgvPhieuKham.Columns["KetQuaKham"].HeaderText = "Kết Quả Khám";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (DgvPhieuKham.SelectedRows.Count > 0)
            {
                int maHoSo = Convert.ToInt32(DgvPhieuKham.SelectedRows[0].Cells["MaHoSo"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hồ sơ này không?", "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (HoSoKhamBenhBUS.XoaHoSo(maHoSo))
                    {
                        MessageBox.Show("Xóa hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHoSo(); // Cập nhật lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa hồ sơ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hồ sơ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PhanQuyenNguoiDung != 1 && PhanQuyenNguoiDung != 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đơn thuốc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DgvPhieuKham.SelectedRows.Count > 0)
            {
                int maHoSo = Convert.ToInt32(DgvPhieuKham.SelectedRows[0].Cells["MaHoSo"].Value);
                GuiMail formEmail = new GuiMail(maHoSo);
                formEmail.MdiParent = this.MdiParent;
                formEmail.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hồ sơ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
