namespace QLDVVTHH.UI
{
    partial class frmTTDieuXe
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
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbhopdong = new System.Windows.Forms.ComboBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lvxe = new System.Windows.Forms.ListView();
            this.c0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvnhanvien = new System.Windows.Forms.ListView();
            this.h0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.cbbaogia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbnoigiao = new System.Windows.Forms.ComboBox();
            this.cbnoinhan = new System.Windows.Forms.ComboBox();
            this.cbtinhtrangthanhtoan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpngayve = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsotan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvthongtindieuxe = new System.Windows.Forms.ListView();
            this.ch0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.txtmadieuxe = new System.Windows.Forms.TextBox();
            this.btnthemma = new System.Windows.Forms.Button();
            this.ch11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Khách Hàng :";
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(112, 2);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(200, 21);
            this.cbkhachhang.TabIndex = 1;
            this.cbkhachhang.SelectedIndexChanged += new System.EventHandler(this.cbkhachhang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn Hợp Đồng :";
            // 
            // cbhopdong
            // 
            this.cbhopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhopdong.FormattingEnabled = true;
            this.cbhopdong.Location = new System.Drawing.Point(414, 2);
            this.cbhopdong.Name = "cbhopdong";
            this.cbhopdong.Size = new System.Drawing.Size(200, 21);
            this.cbhopdong.TabIndex = 3;
            this.cbhopdong.SelectedIndexChanged += new System.EventHandler(this.cbhopdong_SelectedIndexChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lvxe);
            this.gb1.Location = new System.Drawing.Point(4, 29);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(500, 177);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Chọn Xe";
            // 
            // lvxe
            // 
            this.lvxe.CheckBoxes = true;
            this.lvxe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.lvxe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvxe.FullRowSelect = true;
            this.lvxe.Location = new System.Drawing.Point(3, 16);
            this.lvxe.MultiSelect = false;
            this.lvxe.Name = "lvxe";
            this.lvxe.Size = new System.Drawing.Size(494, 158);
            this.lvxe.TabIndex = 0;
            this.lvxe.UseCompatibleStateImageBehavior = false;
            this.lvxe.View = System.Windows.Forms.View.Details;
            this.lvxe.SelectedIndexChanged += new System.EventHandler(this.lvxe_SelectedIndexChanged);
            // 
            // c0
            // 
            this.c0.Text = "STT";
            this.c0.Width = 69;
            // 
            // c1
            // 
            this.c1.Text = "Mã Số Xe";
            this.c1.Width = 101;
            // 
            // c2
            // 
            this.c2.Text = "Tải Trọng";
            this.c2.Width = 106;
            // 
            // c3
            // 
            this.c3.Text = "Tình Trạng Xe";
            this.c3.Width = 105;
            // 
            // c4
            // 
            this.c4.Text = "Loại Xe";
            this.c4.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvnhanvien);
            this.groupBox1.Location = new System.Drawing.Point(510, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Viên Xe";
            // 
            // lvnhanvien
            // 
            this.lvnhanvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.h0,
            this.h1,
            this.h2,
            this.h3,
            this.h4,
            this.h5,
            this.h6});
            this.lvnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvnhanvien.FullRowSelect = true;
            this.lvnhanvien.Location = new System.Drawing.Point(3, 16);
            this.lvnhanvien.MultiSelect = false;
            this.lvnhanvien.Name = "lvnhanvien";
            this.lvnhanvien.Size = new System.Drawing.Size(487, 158);
            this.lvnhanvien.TabIndex = 0;
            this.lvnhanvien.UseCompatibleStateImageBehavior = false;
            this.lvnhanvien.View = System.Windows.Forms.View.Details;
            // 
            // h0
            // 
            this.h0.Text = "STT";
            this.h0.Width = 66;
            // 
            // h1
            // 
            this.h1.Text = "Tên Nhân Viên";
            this.h1.Width = 107;
            // 
            // h2
            // 
            this.h2.Text = "CMND";
            this.h2.Width = 88;
            // 
            // h3
            // 
            this.h3.Text = "Địa Chỉ";
            this.h3.Width = 87;
            // 
            // h4
            // 
            this.h4.Text = "Điện Thoại";
            this.h4.Width = 100;
            // 
            // h5
            // 
            this.h5.Text = "Chức Vụ";
            this.h5.Width = 120;
            // 
            // h6
            // 
            this.h6.Text = "Năm Sinh";
            this.h6.Width = 100;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.cbbaogia);
            this.gb3.Controls.Add(this.label10);
            this.gb3.Controls.Add(this.cbnoigiao);
            this.gb3.Controls.Add(this.cbnoinhan);
            this.gb3.Controls.Add(this.cbtinhtrangthanhtoan);
            this.gb3.Controls.Add(this.label8);
            this.gb3.Controls.Add(this.dtpngayve);
            this.gb3.Controls.Add(this.label7);
            this.gb3.Controls.Add(this.dtpngaydi);
            this.gb3.Controls.Add(this.label6);
            this.gb3.Controls.Add(this.label5);
            this.gb3.Controls.Add(this.label4);
            this.gb3.Controls.Add(this.txtsotan);
            this.gb3.Controls.Add(this.label3);
            this.gb3.Location = new System.Drawing.Point(4, 212);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(999, 72);
            this.gb3.TabIndex = 6;
            this.gb3.TabStop = false;
            this.gb3.Text = "Thông Tin Chuyến ";
            // 
            // cbbaogia
            // 
            this.cbbaogia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbaogia.FormattingEnabled = true;
            this.cbbaogia.Location = new System.Drawing.Point(18, 36);
            this.cbbaogia.Name = "cbbaogia";
            this.cbbaogia.Size = new System.Drawing.Size(102, 21);
            this.cbbaogia.TabIndex = 22;
            this.cbbaogia.SelectedIndexChanged += new System.EventHandler(this.cbbaogia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Chọn Báo Giá :";
            // 
            // cbnoigiao
            // 
            this.cbnoigiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnoigiao.FormattingEnabled = true;
            this.cbnoigiao.Location = new System.Drawing.Point(190, 43);
            this.cbnoigiao.Name = "cbnoigiao";
            this.cbnoigiao.Size = new System.Drawing.Size(191, 21);
            this.cbnoigiao.TabIndex = 20;
            // 
            // cbnoinhan
            // 
            this.cbnoinhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnoinhan.FormattingEnabled = true;
            this.cbnoinhan.Location = new System.Drawing.Point(190, 12);
            this.cbnoinhan.Name = "cbnoinhan";
            this.cbnoinhan.Size = new System.Drawing.Size(191, 21);
            this.cbnoinhan.TabIndex = 19;
            this.cbnoinhan.SelectedIndexChanged += new System.EventHandler(this.cbnoinhan_SelectedIndexChanged);
            // 
            // cbtinhtrangthanhtoan
            // 
            this.cbtinhtrangthanhtoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtinhtrangthanhtoan.FormattingEnabled = true;
            this.cbtinhtrangthanhtoan.Location = new System.Drawing.Point(804, 39);
            this.cbtinhtrangthanhtoan.Name = "cbtinhtrangthanhtoan";
            this.cbtinhtrangthanhtoan.Size = new System.Drawing.Size(188, 21);
            this.cbtinhtrangthanhtoan.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tình Trạng Thanh Toán :";
            // 
            // dtpngayve
            // 
            this.dtpngayve.Location = new System.Drawing.Point(804, 12);
            this.dtpngayve.Name = "dtpngayve";
            this.dtpngayve.Size = new System.Drawing.Size(188, 20);
            this.dtpngayve.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày Về :";
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Location = new System.Drawing.Point(468, 38);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(188, 20);
            this.dtpngaydi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Đi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nơi Giao :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nơi Nhận :";
            // 
            // txtsotan
            // 
            this.txtsotan.Location = new System.Drawing.Point(468, 13);
            this.txtsotan.Name = "txtsotan";
            this.txtsotan.Size = new System.Drawing.Size(188, 20);
            this.txtsotan.TabIndex = 7;
            this.txtsotan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsotan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng Số Tấn :";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(4, 290);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(102, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm Điều Xe";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(112, 290);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa Điều Xe";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(220, 290);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(102, 23);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa Điều Xe";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(928, 290);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvthongtindieuxe);
            this.groupBox2.Location = new System.Drawing.Point(4, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 309);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Điều Xe";
            // 
            // lvthongtindieuxe
            // 
            this.lvthongtindieuxe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch0,
            this.ch1,
            this.ch11,
            this.ch2,
            this.ch3,
            this.ch4,
            this.ch5,
            this.ch6,
            this.ch7,
            this.ch8});
            this.lvthongtindieuxe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvthongtindieuxe.FullRowSelect = true;
            this.lvthongtindieuxe.Location = new System.Drawing.Point(3, 16);
            this.lvthongtindieuxe.MultiSelect = false;
            this.lvthongtindieuxe.Name = "lvthongtindieuxe";
            this.lvthongtindieuxe.Size = new System.Drawing.Size(993, 290);
            this.lvthongtindieuxe.TabIndex = 0;
            this.lvthongtindieuxe.UseCompatibleStateImageBehavior = false;
            this.lvthongtindieuxe.View = System.Windows.Forms.View.Details;
            this.lvthongtindieuxe.SelectedIndexChanged += new System.EventHandler(this.lvthongtindieuxe_SelectedIndexChanged);
            // 
            // ch0
            // 
            this.ch0.Text = "Mã Điều Xe";
            this.ch0.Width = 118;
            // 
            // ch1
            // 
            this.ch1.Text = "Mã Số Xe";
            this.ch1.Width = 110;
            // 
            // ch2
            // 
            this.ch2.Text = "Nơi Nhận";
            this.ch2.Width = 184;
            // 
            // ch3
            // 
            this.ch3.Text = "Nơi Giao";
            this.ch3.Width = 154;
            // 
            // ch4
            // 
            this.ch4.Text = "Số Tấn Mỗi Xe";
            this.ch4.Width = 100;
            // 
            // ch5
            // 
            this.ch5.Text = "Ngày Đi";
            this.ch5.Width = 114;
            // 
            // ch6
            // 
            this.ch6.Text = "Ngày Về";
            this.ch6.Width = 91;
            // 
            // ch7
            // 
            this.ch7.Text = "Tình Trạng Thanh Toán";
            this.ch7.Width = 200;
            // 
            // ch8
            // 
            this.ch8.Text = "Mã Điều Xe";
            this.ch8.Width = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã Điều Xe :";
            // 
            // txtmadieuxe
            // 
            this.txtmadieuxe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmadieuxe.Location = new System.Drawing.Point(704, 7);
            this.txtmadieuxe.Name = "txtmadieuxe";
            this.txtmadieuxe.Size = new System.Drawing.Size(215, 20);
            this.txtmadieuxe.TabIndex = 21;
            // 
            // btnthemma
            // 
            this.btnthemma.Location = new System.Drawing.Point(925, 5);
            this.btnthemma.Name = "btnthemma";
            this.btnthemma.Size = new System.Drawing.Size(75, 23);
            this.btnthemma.TabIndex = 22;
            this.btnthemma.Text = "..+..";
            this.btnthemma.UseVisualStyleBackColor = true;
            this.btnthemma.Click += new System.EventHandler(this.btnthemma_Click);
            // 
            // ch11
            // 
            this.ch11.Text = "Tải Trọng Của Xe";
            this.ch11.Width = 100;
            // 
            // frmTTDieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.btnthemma);
            this.Controls.Add(this.txtmadieuxe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.cbhopdong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbkhachhang);
            this.Controls.Add(this.label1);
            this.Name = "frmTTDieuXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐIỀU XE";
            this.Load += new System.EventHandler(this.frmTTDieuXe_Load);
            this.gb1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbhopdong;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ListView lvxe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvnhanvien;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsotan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpngayve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbtinhtrangthanhtoan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvthongtindieuxe;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c0;
        private System.Windows.Forms.ColumnHeader h0;
        private System.Windows.Forms.ColumnHeader h1;
        private System.Windows.Forms.ColumnHeader h2;
        private System.Windows.Forms.ColumnHeader h3;
        private System.Windows.Forms.ColumnHeader h4;
        private System.Windows.Forms.ColumnHeader h5;
        private System.Windows.Forms.ColumnHeader h6;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.ColumnHeader ch5;
        private System.Windows.Forms.ColumnHeader ch6;
        private System.Windows.Forms.ColumnHeader ch7;
        private System.Windows.Forms.ComboBox cbnoigiao;
        private System.Windows.Forms.ComboBox cbnoinhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmadieuxe;
        private System.Windows.Forms.Button btnthemma;
        private System.Windows.Forms.ColumnHeader ch0;
        private System.Windows.Forms.ColumnHeader ch8;
        private System.Windows.Forms.ComboBox cbbaogia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader ch11;
    }
}