namespace nigga123
{
    partial class QuanLiPhieuKham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.DgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.NutLapHS = new System.Windows.Forms.Button();
            this.CbTrangThai = new System.Windows.Forms.ComboBox();
            this.NutXem = new System.Windows.Forms.Button();
            this.NutDonThuoc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtTimKiemTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lọc theo trạng thái";
            // 
            // DgvPhieuKham
            // 
            this.DgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPhieuKham.Location = new System.Drawing.Point(19, 12);
            this.DgvPhieuKham.Name = "DgvPhieuKham";
            this.DgvPhieuKham.RowHeadersWidth = 62;
            this.DgvPhieuKham.Size = new System.Drawing.Size(671, 240);
            this.DgvPhieuKham.TabIndex = 12;
            this.DgvPhieuKham.SelectionChanged += new System.EventHandler(this.DgvPhieuKham_SelectionChanged);
            // 
            // NutLapHS
            // 
            this.NutLapHS.Location = new System.Drawing.Point(696, 115);
            this.NutLapHS.Name = "NutLapHS";
            this.NutLapHS.Size = new System.Drawing.Size(132, 39);
            this.NutLapHS.TabIndex = 14;
            this.NutLapHS.Text = "Lập hồ sơ khám bệnh";
            this.NutLapHS.UseVisualStyleBackColor = true;
            this.NutLapHS.Click += new System.EventHandler(this.NutLapHS_Click);
            // 
            // CbTrangThai
            // 
            this.CbTrangThai.FormattingEnabled = true;
            this.CbTrangThai.Location = new System.Drawing.Point(136, 263);
            this.CbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.CbTrangThai.Name = "CbTrangThai";
            this.CbTrangThai.Size = new System.Drawing.Size(123, 21);
            this.CbTrangThai.TabIndex = 18;
            this.CbTrangThai.SelectedIndexChanged += new System.EventHandler(this.CbTrangThai_SelectedIndexChanged);
            // 
            // NutXem
            // 
            this.NutXem.Location = new System.Drawing.Point(696, 72);
            this.NutXem.Name = "NutXem";
            this.NutXem.Size = new System.Drawing.Size(132, 39);
            this.NutXem.TabIndex = 19;
            this.NutXem.Text = "Xem/Sửa hồ sơ khám bệnh";
            this.NutXem.UseVisualStyleBackColor = true;
            this.NutXem.Click += new System.EventHandler(this.NutXem_Click);
            // 
            // NutDonThuoc
            // 
            this.NutDonThuoc.Location = new System.Drawing.Point(696, 29);
            this.NutDonThuoc.Name = "NutDonThuoc";
            this.NutDonThuoc.Size = new System.Drawing.Size(132, 39);
            this.NutDonThuoc.TabIndex = 20;
            this.NutDonThuoc.Text = "Đơn thuốc";
            this.NutDonThuoc.UseVisualStyleBackColor = true;
            this.NutDonThuoc.Click += new System.EventHandler(this.NutDonThuoc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tải lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtTimKiemTen
            // 
            this.TxtTimKiemTen.Location = new System.Drawing.Point(379, 264);
            this.TxtTimKiemTen.Name = "TxtTimKiemTen";
            this.TxtTimKiemTen.Size = new System.Drawing.Size(122, 20);
            this.TxtTimKiemTen.TabIndex = 23;
            this.TxtTimKiemTen.TextChanged += new System.EventHandler(this.TxtTimKiemTen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm theo tên:";
            // 
            // QuanLiPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 292);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTimKiemTen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NutDonThuoc);
            this.Controls.Add(this.NutXem);
            this.Controls.Add(this.CbTrangThai);
            this.Controls.Add(this.NutLapHS);
            this.Controls.Add(this.DgvPhieuKham);
            this.Controls.Add(this.label2);
            this.Name = "QuanLiPhieuKham";
            this.Text = "Quản lí phiếu khám bệnh";
            this.Load += new System.EventHandler(this.QuanLiPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvPhieuKham;
        private System.Windows.Forms.Button NutLapHS;
        private System.Windows.Forms.ComboBox CbTrangThai;
        private System.Windows.Forms.Button NutXem;
        private System.Windows.Forms.Button NutDonThuoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtTimKiemTen;
        private System.Windows.Forms.Label label1;
    }
}