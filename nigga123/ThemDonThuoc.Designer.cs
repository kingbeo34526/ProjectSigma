namespace nigga123
{
    partial class ThemDonThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHoSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbThuoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSL = new System.Windows.Forms.TextBox();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.DgvCTDT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hồ Sơ:";
            // 
            // TxtHoSo
            // 
            this.TxtHoSo.Location = new System.Drawing.Point(79, 21);
            this.TxtHoSo.Name = "TxtHoSo";
            this.TxtHoSo.ReadOnly = true;
            this.TxtHoSo.Size = new System.Drawing.Size(61, 20);
            this.TxtHoSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn thuốc:";
            // 
            // CbThuoc
            // 
            this.CbThuoc.FormattingEnabled = true;
            this.CbThuoc.Location = new System.Drawing.Point(79, 46);
            this.CbThuoc.Name = "CbThuoc";
            this.CbThuoc.Size = new System.Drawing.Size(121, 21);
            this.CbThuoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // TxtSL
            // 
            this.TxtSL.Location = new System.Drawing.Point(79, 72);
            this.TxtSL.Name = "TxtSL";
            this.TxtSL.Size = new System.Drawing.Size(50, 20);
            this.TxtSL.TabIndex = 6;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(12, 119);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 7;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(93, 119);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 8;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(174, 119);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 9;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // DgvCTDT
            // 
            this.DgvCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCTDT.Location = new System.Drawing.Point(258, 9);
            this.DgvCTDT.Name = "DgvCTDT";
            this.DgvCTDT.RowHeadersWidth = 62;
            this.DgvCTDT.Size = new System.Drawing.Size(240, 134);
            this.DgvCTDT.TabIndex = 10;
            // 
            // ThemDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 156);
            this.ControlBox = false;
            this.Controls.Add(this.DgvCTDT);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.TxtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtHoSo);
            this.Controls.Add(this.label1);
            this.Name = "ThemDonThuoc";
            this.Text = "Thêm đơn thuốc";
            this.Load += new System.EventHandler(this.ThemDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCTDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSL;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.DataGridView DgvCTDT;
    }
}