namespace nigga123
{
    partial class SuaDonThuoc
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
            this.DgvCTDT = new System.Windows.Forms.DataGridView();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.TxtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbThuoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDonThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCTDT
            // 
            this.DgvCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCTDT.Location = new System.Drawing.Point(306, 8);
            this.DgvCTDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvCTDT.Name = "DgvCTDT";
            this.DgvCTDT.RowHeadersWidth = 62;
            this.DgvCTDT.Size = new System.Drawing.Size(360, 206);
            this.DgvCTDT.TabIndex = 20;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(136, 179);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(112, 35);
            this.BtnThoat.TabIndex = 19;
            this.BtnThoat.Text = "Hủy";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(16, 179);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(112, 35);
            this.BtnSua.TabIndex = 17;
            this.BtnSua.Text = "Lưu";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // TxtSL
            // 
            this.TxtSL.Location = new System.Drawing.Point(118, 124);
            this.TxtSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSL.Name = "TxtSL";
            this.TxtSL.Size = new System.Drawing.Size(73, 26);
            this.TxtSL.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng:";
            // 
            // CbThuoc
            // 
            this.CbThuoc.FormattingEnabled = true;
            this.CbThuoc.Location = new System.Drawing.Point(118, 82);
            this.CbThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbThuoc.Name = "CbThuoc";
            this.CbThuoc.Size = new System.Drawing.Size(180, 28);
            this.CbThuoc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn thuốc:";
            // 
            // TxtDonThuoc
            // 
            this.TxtDonThuoc.Location = new System.Drawing.Point(118, 39);
            this.TxtDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDonThuoc.Name = "TxtDonThuoc";
            this.TxtDonThuoc.ReadOnly = true;
            this.TxtDonThuoc.Size = new System.Drawing.Size(90, 26);
            this.TxtDonThuoc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đơn thuốc:";
            // 
            // SuaDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 231);
            this.Controls.Add(this.DgvCTDT);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.TxtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDonThuoc);
            this.Controls.Add(this.label1);
            this.Name = "SuaDonThuoc";
            this.Text = "Sửa đơn thuốc";
            this.Load += new System.EventHandler(this.SuaDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCTDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCTDT;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.TextBox TxtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDonThuoc;
        private System.Windows.Forms.Label label1;
    }
}