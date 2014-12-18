namespace QLDVVTHH.UI
{
    partial class frmXe
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma_so_xe = new System.Windows.Forms.TextBox();
            this.txt_loai_xe = new System.Windows.Forms.TextBox();
            this.txt_trong_luong = new System.Windows.Forms.TextBox();
            this.txt_nhan_hieu = new System.Windows.Forms.TextBox();
            this.cbb_tinh_trang = new System.Windows.Forms.ComboBox();
            this.grv_xe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_xe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trọng lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhãn hiệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // txt_ma_so_xe
            // 
            this.txt_ma_so_xe.Location = new System.Drawing.Point(117, 10);
            this.txt_ma_so_xe.Name = "txt_ma_so_xe";
            this.txt_ma_so_xe.Size = new System.Drawing.Size(140, 20);
            this.txt_ma_so_xe.TabIndex = 5;
            // 
            // txt_loai_xe
            // 
            this.txt_loai_xe.Location = new System.Drawing.Point(623, 10);
            this.txt_loai_xe.Name = "txt_loai_xe";
            this.txt_loai_xe.Size = new System.Drawing.Size(139, 20);
            this.txt_loai_xe.TabIndex = 6;
            // 
            // txt_trong_luong
            // 
            this.txt_trong_luong.Location = new System.Drawing.Point(367, 10);
            this.txt_trong_luong.Name = "txt_trong_luong";
            this.txt_trong_luong.Size = new System.Drawing.Size(143, 20);
            this.txt_trong_luong.TabIndex = 7;
            // 
            // txt_nhan_hieu
            // 
            this.txt_nhan_hieu.Location = new System.Drawing.Point(117, 76);
            this.txt_nhan_hieu.Name = "txt_nhan_hieu";
            this.txt_nhan_hieu.Size = new System.Drawing.Size(140, 20);
            this.txt_nhan_hieu.TabIndex = 8;
            // 
            // cbb_tinh_trang
            // 
            this.cbb_tinh_trang.FormattingEnabled = true;
            this.cbb_tinh_trang.Location = new System.Drawing.Point(437, 79);
            this.cbb_tinh_trang.Name = "cbb_tinh_trang";
            this.cbb_tinh_trang.Size = new System.Drawing.Size(249, 21);
            this.cbb_tinh_trang.TabIndex = 9;
            // 
            // grv_xe
            // 
            this.grv_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_xe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grv_xe.Location = new System.Drawing.Point(39, 197);
            this.grv_xe.Name = "grv_xe";
            this.grv_xe.Size = new System.Drawing.Size(804, 258);
            this.grv_xe.TabIndex = 10;
            this.grv_xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_xe_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_so_xe";
            this.Column1.HeaderText = "Mã số xe";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "trong_luong";
            this.Column2.HeaderText = "Trọng lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "loai_xe";
            this.Column3.HeaderText = "Loại xe";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nhan_hieu";
            this.Column4.HeaderText = "Nhãn hiệu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ten_tinh_trang";
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngay_tao";
            this.Column6.HeaderText = "Ngày tạo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ma_tinh_trang";
            this.Column7.HeaderText = "Mã tình trạng";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(117, 137);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(252, 137);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(391, 137);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(518, 137);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(641, 137);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 485);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grv_xe);
            this.Controls.Add(this.cbb_tinh_trang);
            this.Controls.Add(this.txt_nhan_hieu);
            this.Controls.Add(this.txt_trong_luong);
            this.Controls.Add(this.txt_loai_xe);
            this.Controls.Add(this.txt_ma_so_xe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXe";
            this.Text = "Tình trạng";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_xe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ma_so_xe;
        private System.Windows.Forms.TextBox txt_loai_xe;
        private System.Windows.Forms.TextBox txt_trong_luong;
        private System.Windows.Forms.TextBox txt_nhan_hieu;
        private System.Windows.Forms.ComboBox cbb_tinh_trang;
        private System.Windows.Forms.DataGridView grv_xe;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}