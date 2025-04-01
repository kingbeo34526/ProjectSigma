using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace nigga123
{
    public partial class ThongKe : Form
    {
        private BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
        private ThuocBUS thuocBUS = new ThuocBUS();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadBenhNhan();
            LoadTrangThai();
            LoadThuoc();
            LoadXuatExcel();
            DgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvThuoc.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvThuoc.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvThuoc.MultiSelect = false; // Không cho phép chọn nhiều dòng
            DgvBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động co giãn theo độ rộng của DGV
            DgvBN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
            DgvBN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái cho nội dung
            DgvBN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Hàng tự động điều chỉnh kích thước theo nội dung
            DgvBN.AllowUserToResizeRows = false; // Không cho phép resize dòng
            DgvBN.AllowUserToResizeColumns = true; // Cho phép resize cột
            DgvBN.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn nguyên dòng
            DgvBN.MultiSelect = false; // Không cho phép chọn nhiều dòng
            DgvBN.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
            DgvBN.Columns["HoTen"].HeaderText = "Họ Tên";
            DgvBN.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            DgvBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
            DgvBN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            DgvBN.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            DgvBN.Columns["CanCuocCongDan"].HeaderText = "CCCD";
            DgvBN.Columns["TrangThai"].HeaderText = "Trạng Thái";
            DgvThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            DgvThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            DgvThuoc.Columns["DonViThuoc"].HeaderText = "Đơn Vị";
            DgvThuoc.Columns["SoLuong"].HeaderText = "Số Lượng";
            DgvThuoc.Columns["Gia"].HeaderText = "Giá";
        }
        private void LoadBenhNhan()
        {
            TxtTong.Text = benhNhanBUS.GetTotalBenhNhan().ToString();
        }

        private void LoadTrangThai()
        {
            DataTable dtTrangThai = benhNhanBUS.GetAllTrangThai(); // Lấy danh sách trạng thái từ BUS

            // Thêm "Tất cả" vào danh sách trạng thái
            DataRow newRow = dtTrangThai.NewRow();
            newRow["TrangThai"] = "Tất cả";
            dtTrangThai.Rows.InsertAt(newRow, 0);

            CbTT.DataSource = dtTrangThai;
            CbTT.DisplayMember = "TrangThai";
        }

        private void LoadThuoc()
        {
            DgvThuoc.DataSource = ThuocBUS.GetAllThuoc();
            TxtTSLT.Text = thuocBUS.GetTotalThuoc().ToString();
        }
        private void DgvBN_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvBN.Columns[e.ColumnIndex].Name == "GioiTinh" && e.Value != null)
            {
                // Kiểm tra nếu giá trị là null hoặc rỗng, không xử lý
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.Value = ""; // Giữ trống
                    e.FormattingApplied = true;
                    return;
                }
                e.Value = e.Value.ToString() == "1" ? "Nam" : "Nữ";
                e.FormattingApplied = true;
            }
        }
        private void DgvThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvThuoc.Columns[e.ColumnIndex].Name == "DonViThuoc" && e.Value != null) // Cột cần hiển thị đơn vị
            {
                if (e.Value != null)
                {
                    switch (e.Value.ToString())
                    {
                        case "1":
                            e.Value = "Viên";
                            break;
                        case "2":
                            e.Value = "Hộp";
                            break;
                        case "3":
                            e.Value = "Chai";
                            break;
                    }
                    e.FormattingApplied = true;
                }
            }
        }
        private void XuatExcel(string filePath, string luaChon)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Lỗi: Không thể khởi tạo Excel. Kiểm tra cài đặt Microsoft Excel.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheetBN = null, worksheetThuoc = null;

                if (luaChon == "Bệnh Nhân" || luaChon == "Cả Hai")
                {
                    worksheetBN = workbook.Sheets[1];
                    worksheetBN.Name = "Bệnh Nhân";
                    GhiDuLieuExcel(worksheetBN, DgvBN);
                }

                if (luaChon == "Thuốc" || luaChon == "Cả Hai")
                {
                    worksheetThuoc = luaChon == "Cả Hai" ? workbook.Sheets.Add(After: workbook.Sheets[workbook.Sheets.Count]) : workbook.Sheets[1];
                    worksheetThuoc.Name = "Thuốc";
                    GhiDuLieuExcel(worksheetThuoc, DgvThuoc);
                }

                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GhiDuLieuExcel(Excel.Worksheet worksheet, DataGridView dgv)
        {
            Excel.Range headerRange;

            // Định dạng tiêu đề
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv.Columns.Count]];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Color.LightGray;  // Màu nền tiêu đề
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Ghi dữ liệu
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Áp dụng viền cho toàn bộ bảng
            Excel.Range usedRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dgv.Rows.Count + 1, dgv.Columns.Count]];
            usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Tự động điều chỉnh độ rộng cột
            usedRange.Columns.AutoFit();
        }

        private void LoadXuatExcel()
        {
            CbXuat.Items.Add("Bệnh Nhân");
            CbXuat.Items.Add("Thuốc");
            CbXuat.Items.Add("Cả Hai");
            CbXuat.SelectedIndex = 0; // Mặc định chọn "Bệnh nhân"
        }
        private void CbTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = CbTT.Text;
            DgvBN.DataSource = benhNhanBUS.GetBenhNhanByTrangThai(trangThai);
        }
        private void NutXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            // Lấy lựa chọn từ ComboBox
            string luaChon = CbXuat.SelectedItem?.ToString() ?? "Cả Hai";
            saveFileDialog.FileName = "ThongKe_" + luaChon.Replace(" ", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                XuatExcel(filePath, luaChon);
            }
        }

        private void NutThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DgvThuoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; 
        }
    }
}
