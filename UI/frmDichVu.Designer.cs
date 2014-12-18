namespace QLDVVTHH.UI
{
    partial class frmDichVu
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dongiachuyen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dongiatan = new System.Windows.Forms.TextBox();
            this.txt_khuvuc = new System.Windows.Forms.TextBox();
            this.txt_phanvung = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grv_dichvu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO GIÁ DỊCH VỤ VẬN CHUYỂN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khu Vực :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phân Vùng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Đơn Giá Chuyến";
            // 
            // txt_dongiachuyen
            // 
            this.txt_dongiachuyen.Location = new System.Drawing.Point(446, 101);
            this.txt_dongiachuyen.MaxLength = 100;
            this.txt_dongiachuyen.Name = "txt_dongiachuyen";
            this.txt_dongiachuyen.Size = new System.Drawing.Size(200, 20);
            this.txt_dongiachuyen.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Đơn Giá Tấn";
            // 
            // txt_dongiatan
            // 
            this.txt_dongiatan.Location = new System.Drawing.Point(120, 105);
            this.txt_dongiatan.MaxLength = 100;
            this.txt_dongiatan.Name = "txt_dongiatan";
            this.txt_dongiatan.Size = new System.Drawing.Size(200, 20);
            this.txt_dongiatan.TabIndex = 18;
            // 
            // txt_khuvuc
            // 
            this.txt_khuvuc.Location = new System.Drawing.Point(120, 61);
            this.txt_khuvuc.MaxLength = 100;
            this.txt_khuvuc.Name = "txt_khuvuc";
            this.txt_khuvuc.Size = new System.Drawing.Size(200, 20);
            this.txt_khuvuc.TabIndex = 24;
            // 
            // txt_phanvung
            // 
            this.txt_phanvung.Location = new System.Drawing.Point(446, 61);
            this.txt_phanvung.MaxLength = 100;
            this.txt_phanvung.Name = "txt_phanvung";
            this.txt_phanvung.Size = new System.Drawing.Size(200, 20);
            this.txt_phanvung.TabIndex = 25;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(591, 163);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 30;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(461, 163);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 29;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(335, 163);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(213, 163);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(94, 163);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grv_dichvu
            // 
            this.grv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.grv_dichvu.Location = new System.Drawing.Point(141, 225);
            this.grv_dichvu.Name = "grv_dichvu";
            this.grv_dichvu.Size = new System.Drawing.Size(453, 206);
            this.grv_dichvu.TabIndex = 31;
            this.grv_dichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_dichvu_CellClick);
            this.grv_dichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_dichvu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "khu_vuc";
            this.Column1.HeaderText = "Khu vực";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "phan_vung";
            this.Column2.HeaderText = "Phân vùng";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "don_gia_tan";
            this.Column4.HeaderText = "Đơn giá tấn";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "don_gia_chuyen";
            this.Column3.HeaderText = "Đơn giá chuyến";
            this.Column3.Name = "Column3";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 489);
            this.Controls.Add(this.grv_dichvu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_phanvung);
            this.Controls.Add(this.txt_khuvuc);
            this.Controls.Add(this.txt_dongiatan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_dongiachuyen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIÁ DỊCH VỤ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_dichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dongiachuyen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dongiatan;
        private System.Windows.Forms.TextBox txt_khuvuc;
        private System.Windows.Forms.TextBox txt_phanvung;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView grv_dichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}