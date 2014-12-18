namespace QLDVVTHH.UC
{
    partial class uchoadon
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
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.cbhopdong = new System.Windows.Forms.ComboBox();
            this.cbhoadon = new System.Windows.Forms.ComboBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(3, 3);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(191, 21);
            this.cbkhachhang.TabIndex = 0;
            this.cbkhachhang.SelectedIndexChanged += new System.EventHandler(this.cbkhachhang_SelectedIndexChanged);
            // 
            // cbhopdong
            // 
            this.cbhopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhopdong.FormattingEnabled = true;
            this.cbhopdong.Location = new System.Drawing.Point(3, 30);
            this.cbhopdong.Name = "cbhopdong";
            this.cbhopdong.Size = new System.Drawing.Size(191, 21);
            this.cbhopdong.TabIndex = 1;
            this.cbhopdong.SelectedIndexChanged += new System.EventHandler(this.cbhopdong_SelectedIndexChanged);
            // 
            // cbhoadon
            // 
            this.cbhoadon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhoadon.FormattingEnabled = true;
            this.cbhoadon.Location = new System.Drawing.Point(3, 57);
            this.cbhoadon.Name = "cbhoadon";
            this.cbhoadon.Size = new System.Drawing.Size(191, 21);
            this.cbhoadon.TabIndex = 2;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(30, 94);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(128, 23);
            this.btnxuat.TabIndex = 3;
            this.btnxuat.Text = "Xuất Hóa Đơn";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(30, 123);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(128, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // uchoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.cbhoadon);
            this.Controls.Add(this.cbhopdong);
            this.Controls.Add(this.cbkhachhang);
            this.Name = "uchoadon";
            this.Size = new System.Drawing.Size(197, 185);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.ComboBox cbhopdong;
        private System.Windows.Forms.ComboBox cbhoadon;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnthoat;
    }
}
