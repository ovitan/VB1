namespace QLDVVTHH.UI
{
    partial class txt_mabaogia
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
            this.label8 = new System.Windows.Forms.Label();
            this.grv_BG = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_noigiao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_khuvuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_phanvung = new System.Windows.Forms.ComboBox();
            this.txt_ma_bao_gia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_dongiatan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dongiachuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_hopdong = new System.Windows.Forms.ComboBox();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_noinhan = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_BG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Nơi Nhận :";
            // 
            // grv_BG
            // 
            this.grv_BG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_BG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colHD,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grv_BG.Location = new System.Drawing.Point(14, 28);
            this.grv_BG.Name = "grv_BG";
            this.grv_BG.Size = new System.Drawing.Size(914, 205);
            this.grv_BG.TabIndex = 32;
            this.grv_BG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_BG_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_bao_gia";
            this.Column1.HeaderText = "Mã Báo Giá";
            this.Column1.Name = "Column1";
            // 
            // colHD
            // 
            this.colHD.DataPropertyName = "ma_hop_dong";
            this.colHD.HeaderText = "Mã Hợp Đồng";
            this.colHD.Name = "colHD";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "noi_nhan";
            this.Column3.HeaderText = "Nơi Nhận";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "noi_giao";
            this.Column4.HeaderText = "Nơi Giao";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "don_gia_chuyen";
            this.Column5.HeaderText = "Đơn giá chuyến";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "don_gia_tan";
            this.Column6.HeaderText = "Đơn giá tấn";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ghi_chu";
            this.Column7.HeaderText = "Ghi chú";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "tu_ngay";
            this.Column8.HeaderText = "Từ ngày";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "den_ngay";
            this.Column9.HeaderText = "Đến ngày";
            this.Column9.Name = "Column9";
            // 
            // txt_noigiao
            // 
            this.txt_noigiao.Location = new System.Drawing.Point(785, 43);
            this.txt_noigiao.Name = "txt_noigiao";
            this.txt_noigiao.Size = new System.Drawing.Size(145, 20);
            this.txt_noigiao.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Nơi Giao :";
            // 
            // cbb_khuvuc
            // 
            this.cbb_khuvuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_khuvuc.FormattingEnabled = true;
            this.cbb_khuvuc.Location = new System.Drawing.Point(129, 119);
            this.cbb_khuvuc.Name = "cbb_khuvuc";
            this.cbb_khuvuc.Size = new System.Drawing.Size(241, 21);
            this.cbb_khuvuc.TabIndex = 96;
            this.cbb_khuvuc.SelectedIndexChanged += new System.EventHandler(this.cbb_khuvuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Khu Vực :";
            // 
            // cbb_phanvung
            // 
            this.cbb_phanvung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phanvung.FormattingEnabled = true;
            this.cbb_phanvung.Location = new System.Drawing.Point(129, 158);
            this.cbb_phanvung.Name = "cbb_phanvung";
            this.cbb_phanvung.Size = new System.Drawing.Size(241, 21);
            this.cbb_phanvung.TabIndex = 94;
            this.cbb_phanvung.SelectedIndexChanged += new System.EventHandler(this.cbb_phanvung_SelectedIndexChanged);
            // 
            // txt_ma_bao_gia
            // 
            this.txt_ma_bao_gia.Location = new System.Drawing.Point(129, 40);
            this.txt_ma_bao_gia.Name = "txt_ma_bao_gia";
            this.txt_ma_bao_gia.Size = new System.Drawing.Size(121, 20);
            this.txt_ma_bao_gia.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Phân Vùng :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Mã Báo Giá  :";
            // 
            // txt_dongiatan
            // 
            this.txt_dongiatan.Location = new System.Drawing.Point(785, 82);
            this.txt_dongiatan.Name = "txt_dongiatan";
            this.txt_dongiatan.Size = new System.Drawing.Size(145, 20);
            this.txt_dongiatan.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "Đơn Giá Tấn :";
            // 
            // txt_dongiachuyen
            // 
            this.txt_dongiachuyen.Location = new System.Drawing.Point(490, 79);
            this.txt_dongiachuyen.Name = "txt_dongiachuyen";
            this.txt_dongiachuyen.Size = new System.Drawing.Size(143, 20);
            this.txt_dongiachuyen.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "LẬP BÁO GIÁ VẬN CHUYỂN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grv_BG);
            this.groupBox1.Location = new System.Drawing.Point(31, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 250);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Báo Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Đơn Giá Chuyến :";
            // 
            // cbb_hopdong
            // 
            this.cbb_hopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hopdong.FormattingEnabled = true;
            this.cbb_hopdong.Location = new System.Drawing.Point(129, 78);
            this.cbb_hopdong.Name = "cbb_hopdong";
            this.cbb_hopdong.Size = new System.Drawing.Size(241, 21);
            this.cbb_hopdong.TabIndex = 81;
            this.cbb_hopdong.SelectedIndexChanged += new System.EventHandler(this.cbb_hopdong_SelectedIndexChanged);
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Location = new System.Drawing.Point(785, 122);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(210, 20);
            this.dtpdenngay.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Đến Ngày :";
            // 
            // dtptungay
            // 
            this.dtptungay.Location = new System.Drawing.Point(490, 120);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(209, 20);
            this.dtptungay.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Báo Giá Từ Ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = " Hợp Đồng :";
            // 
            // txt_noinhan
            // 
            this.txt_noinhan.Location = new System.Drawing.Point(490, 43);
            this.txt_noinhan.Name = "txt_noinhan";
            this.txt_noinhan.Size = new System.Drawing.Size(145, 20);
            this.txt_noinhan.TabIndex = 105;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(721, 243);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 27);
            this.btn_thoat.TabIndex = 110;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(218, 245);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 23);
            this.btn_them.TabIndex = 109;
            this.btn_them.Text = "Tạo báo giá mới";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(471, 241);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 27);
            this.btn_sua.TabIndex = 108;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(595, 241);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_xoa.TabIndex = 107;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(354, 245);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 106;
            this.btn_luu.Text = "Lưu báo giá";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Ghi Chú :";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(490, 163);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(505, 62);
            this.txt_ghichu.TabIndex = 112;
            // 
            // txt_mabaogia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 590);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_noinhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_noigiao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_khuvuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_phanvung);
            this.Controls.Add(this.txt_ma_bao_gia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_dongiatan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_dongiachuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbb_hopdong);
            this.Controls.Add(this.dtpdenngay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtptungay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "txt_mabaogia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoGia";
            this.Load += new System.EventHandler(this.frmBaoGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_BG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grv_BG;
        private System.Windows.Forms.TextBox txt_noigiao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_khuvuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_phanvung;
        private System.Windows.Forms.TextBox txt_ma_bao_gia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_dongiatan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dongiachuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_hopdong;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_noinhan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}