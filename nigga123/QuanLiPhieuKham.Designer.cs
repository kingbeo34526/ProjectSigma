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
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 427);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lọc theo trạng thái";
            // 
            // DgvPhieuKham
            // 
            this.DgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPhieuKham.Location = new System.Drawing.Point(28, 18);
            this.DgvPhieuKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvPhieuKham.Name = "DgvPhieuKham";
            this.DgvPhieuKham.RowHeadersWidth = 62;
            this.DgvPhieuKham.Size = new System.Drawing.Size(1006, 369);
            this.DgvPhieuKham.TabIndex = 12;
            this.DgvPhieuKham.SelectionChanged += new System.EventHandler(this.DgvPhieuKham_SelectionChanged);
            // 
            // NutLapHS
            // 
            this.NutLapHS.Location = new System.Drawing.Point(768, 409);
            this.NutLapHS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutLapHS.Name = "NutLapHS";
            this.NutLapHS.Size = new System.Drawing.Size(198, 57);
            this.NutLapHS.TabIndex = 14;
            this.NutLapHS.Text = "Lập hồ sơ khám bệnh";
            this.NutLapHS.UseVisualStyleBackColor = true;
            this.NutLapHS.Click += new System.EventHandler(this.NutLapHS_Click);
            // 
            // CbTrangThai
            // 
            this.CbTrangThai.FormattingEnabled = true;
            this.CbTrangThai.Location = new System.Drawing.Point(199, 424);
            this.CbTrangThai.Name = "CbTrangThai";
            this.CbTrangThai.Size = new System.Drawing.Size(183, 28);
            this.CbTrangThai.TabIndex = 18;
            this.CbTrangThai.SelectedIndexChanged += new System.EventHandler(this.CbTrangThai_SelectedIndexChanged);
            // 
            // NutXem
            // 
            this.NutXem.Location = new System.Drawing.Point(562, 409);
            this.NutXem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutXem.Name = "NutXem";
            this.NutXem.Size = new System.Drawing.Size(198, 57);
            this.NutXem.TabIndex = 19;
            this.NutXem.Text = "Xem hồ sơ khám bệnh";
            this.NutXem.UseVisualStyleBackColor = true;
            this.NutXem.Click += new System.EventHandler(this.NutXem_Click);
            // 
            // NutDonThuoc
            // 
            this.NutDonThuoc.Location = new System.Drawing.Point(435, 409);
            this.NutDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutDonThuoc.Name = "NutDonThuoc";
            this.NutDonThuoc.Size = new System.Drawing.Size(119, 57);
            this.NutDonThuoc.TabIndex = 20;
            this.NutDonThuoc.Text = "Đơn thuốc";
            this.NutDonThuoc.UseVisualStyleBackColor = true;
            this.NutDonThuoc.Click += new System.EventHandler(this.NutDonThuoc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(974, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLiPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NutDonThuoc);
            this.Controls.Add(this.NutXem);
            this.Controls.Add(this.CbTrangThai);
            this.Controls.Add(this.NutLapHS);
            this.Controls.Add(this.DgvPhieuKham);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLiPhieuKham";
            this.Text = "Quản lí phiếu khám";
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
    }
}