namespace nigga123
{
    partial class GuiMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiMail));
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtND = new System.Windows.Forms.TextBox();
            this.NutGui = new System.Windows.Forms.Button();
            this.NutHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblDateHen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBenhNhan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbDonThuoc = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(65, 21);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(211, 20);
            this.TxtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung:";
            // 
            // TxtND
            // 
            this.TxtND.Location = new System.Drawing.Point(65, 53);
            this.TxtND.Multiline = true;
            this.TxtND.Name = "TxtND";
            this.TxtND.Size = new System.Drawing.Size(211, 67);
            this.TxtND.TabIndex = 3;
            // 
            // NutGui
            // 
            this.NutGui.Location = new System.Drawing.Point(174, 127);
            this.NutGui.Name = "NutGui";
            this.NutGui.Size = new System.Drawing.Size(45, 23);
            this.NutGui.TabIndex = 4;
            this.NutGui.Text = "Gửi";
            this.NutGui.UseVisualStyleBackColor = true;
            this.NutGui.Click += new System.EventHandler(this.NutGui_Click);
            // 
            // NutHuy
            // 
            this.NutHuy.Location = new System.Drawing.Point(224, 127);
            this.NutHuy.Name = "NutHuy";
            this.NutHuy.Size = new System.Drawing.Size(53, 23);
            this.NutHuy.TabIndex = 5;
            this.NutHuy.Text = "Hủy";
            this.NutHuy.UseVisualStyleBackColor = true;
            this.NutHuy.Click += new System.EventHandler(this.NutHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblDateHen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblBenhNhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(282, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ sơ bệnh nhân:";
            // 
            // LblTT
            // 
            this.LblTT.AutoSize = true;
            this.LblTT.Location = new System.Drawing.Point(74, 95);
            this.LblTT.Name = "LblTT";
            this.LblTT.Size = new System.Drawing.Size(35, 13);
            this.LblTT.TabIndex = 13;
            this.LblTT.Text = "LblTT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tình trạng:";
            // 
            // LblDateHen
            // 
            this.LblDateHen.AutoSize = true;
            this.LblDateHen.Location = new System.Drawing.Point(74, 64);
            this.LblDateHen.Name = "LblDateHen";
            this.LblDateHen.Size = new System.Drawing.Size(64, 13);
            this.LblDateHen.TabIndex = 11;
            this.LblDateHen.Text = "LblDateHen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày hẹn:";
            // 
            // LblBenhNhan
            // 
            this.LblBenhNhan.AutoSize = true;
            this.LblBenhNhan.Location = new System.Drawing.Point(74, 32);
            this.LblBenhNhan.Name = "LblBenhNhan";
            this.LblBenhNhan.Size = new System.Drawing.Size(36, 13);
            this.LblBenhNhan.TabIndex = 9;
            this.LblBenhNhan.Text = "LblBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bệnh nhân:";
            // 
            // CbDonThuoc
            // 
            this.CbDonThuoc.AutoSize = true;
            this.CbDonThuoc.Location = new System.Drawing.Point(69, 131);
            this.CbDonThuoc.Name = "CbDonThuoc";
            this.CbDonThuoc.Size = new System.Drawing.Size(99, 17);
            this.CbDonThuoc.TabIndex = 9;
            this.CbDonThuoc.Text = "Kèm đơn thuốc";
            this.CbDonThuoc.UseVisualStyleBackColor = true;
            // 
            // GuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 162);
            this.ControlBox = false;
            this.Controls.Add(this.CbDonThuoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NutHuy);
            this.Controls.Add(this.NutGui);
            this.Controls.Add(this.TxtND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuiMail";
            this.Text = "Gửi mail";
            this.Load += new System.EventHandler(this.GuiMail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtND;
        private System.Windows.Forms.Button NutGui;
        private System.Windows.Forms.Button NutHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblDateHen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBenhNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CbDonThuoc;
    }
}