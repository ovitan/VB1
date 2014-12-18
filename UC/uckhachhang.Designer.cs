namespace QLDVVTHH.UC
{
    partial class uckhachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbdanhsachtuyechon = new System.Windows.Forms.ComboBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbdanhsachtuyechon
            // 
            this.cbdanhsachtuyechon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdanhsachtuyechon.FormattingEnabled = true;
            this.cbdanhsachtuyechon.Location = new System.Drawing.Point(2, 3);
            this.cbdanhsachtuyechon.Name = "cbdanhsachtuyechon";
            this.cbdanhsachtuyechon.Size = new System.Drawing.Size(193, 21);
            this.cbdanhsachtuyechon.TabIndex = 0;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(21, 29);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(75, 23);
            this.btnxuat.TabIndex = 2;
            this.btnxuat.Text = "Xuất";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(102, 29);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // uckhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.cbdanhsachtuyechon);
            this.Name = "uckhachhang";
            this.Size = new System.Drawing.Size(197, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdanhsachtuyechon;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnthoat;
    }
}
