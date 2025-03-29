namespace nigga123
{
    partial class CauHinhDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHinhDB));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.NutLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ Database:";
            // 
            // TxtDB
            // 
            this.TxtDB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDB.Location = new System.Drawing.Point(12, 27);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.Size = new System.Drawing.Size(417, 22);
            this.TxtDB.TabIndex = 1;
            // 
            // NutLuu
            // 
            this.NutLuu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutLuu.Location = new System.Drawing.Point(354, 52);
            this.NutLuu.Name = "NutLuu";
            this.NutLuu.Size = new System.Drawing.Size(75, 23);
            this.NutLuu.TabIndex = 2;
            this.NutLuu.Text = "Lưu";
            this.NutLuu.UseVisualStyleBackColor = true;
            this.NutLuu.Click += new System.EventHandler(this.NutLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lưu ý: Cấu hình xong, phần mềm sẽ khởi động lại.";
            // 
            // CauHinhDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 83);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NutLuu);
            this.Controls.Add(this.TxtDB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CauHinhDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình Database";
            this.Load += new System.EventHandler(this.CauHinhDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDB;
        private System.Windows.Forms.Button NutLuu;
        private System.Windows.Forms.Label label2;
    }
}