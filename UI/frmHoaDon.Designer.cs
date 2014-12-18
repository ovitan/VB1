namespace QLDVVTHH.UI
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.lvhoadon = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsmenulv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mntsxoalv = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmahopdong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtvngayxuathoadon = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntaoma = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.lvchitiethoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncongno = new System.Windows.Forms.Button();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsmenulv.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LẬP HÓA ĐƠN VẬN CHUYỂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn Khách Hàng :";
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(110, 41);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(229, 21);
            this.cbkhachhang.TabIndex = 3;
            this.cbkhachhang.SelectedIndexChanged += new System.EventHandler(this.cbkhachhang_SelectedIndexChanged);
            // 
            // lvhoadon
            // 
            this.lvhoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c5,
            this.c55,
            this.c56,
            this.c6});
            this.lvhoadon.ContextMenuStrip = this.cmsmenulv;
            this.lvhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvhoadon.FullRowSelect = true;
            this.lvhoadon.Location = new System.Drawing.Point(1, 122);
            this.lvhoadon.Name = "lvhoadon";
            this.lvhoadon.Size = new System.Drawing.Size(1004, 200);
            this.lvhoadon.TabIndex = 4;
            this.lvhoadon.UseCompatibleStateImageBehavior = false;
            this.lvhoadon.View = System.Windows.Forms.View.Details;
            this.lvhoadon.VirtualListSize = 1000;
            this.lvhoadon.SelectedIndexChanged += new System.EventHandler(this.lvhoadon_SelectedIndexChanged);
            // 
            // c1
            // 
            this.c1.Text = "STT";
            this.c1.Width = 71;
            // 
            // c2
            // 
            this.c2.Text = "Mã Hóa Đơn";
            this.c2.Width = 110;
            // 
            // c5
            // 
            this.c5.Text = "Tổng Giá  Vận Chuyển";
            this.c5.Width = 177;
            // 
            // c55
            // 
            this.c55.Text = "Thếu 10%";
            this.c55.Width = 130;
            // 
            // c56
            // 
            this.c56.Text = "Tổng Cộng";
            this.c56.Width = 154;
            // 
            // c6
            // 
            this.c6.Text = "Ngày Xuất Hóa Đơn";
            this.c6.Width = 150;
            // 
            // cmsmenulv
            // 
            this.cmsmenulv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntsxoalv});
            this.cmsmenulv.Name = "cmsmenulv";
            this.cmsmenulv.Size = new System.Drawing.Size(95, 26);
            // 
            // mntsxoalv
            // 
            this.mntsxoalv.Name = "mntsxoalv";
            this.mntsxoalv.Size = new System.Drawing.Size(94, 22);
            this.mntsxoalv.Text = "Xóa";
            this.mntsxoalv.Click += new System.EventHandler(this.mntsxoalv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Khách Hàng :";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(442, 42);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(229, 20);
            this.txtmakhachhang.TabIndex = 7;
            this.txtmakhachhang.TextChanged += new System.EventHandler(this.txtmakhachhang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã Hợp Đồng :";
            // 
            // cbmahopdong
            // 
            this.cbmahopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmahopdong.FormattingEnabled = true;
            this.cbmahopdong.Location = new System.Drawing.Point(763, 38);
            this.cbmahopdong.Name = "cbmahopdong";
            this.cbmahopdong.Size = new System.Drawing.Size(229, 21);
            this.cbmahopdong.TabIndex = 9;
            this.cbmahopdong.SelectedIndexChanged += new System.EventHandler(this.cbmahopdong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã Hóa Đơn :";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmahoadon.Location = new System.Drawing.Point(110, 68);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(192, 20);
            this.txtmahoadon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày :";
            // 
            // dtvngayxuathoadon
            // 
            this.dtvngayxuathoadon.Location = new System.Drawing.Point(442, 68);
            this.dtvngayxuathoadon.Name = "dtvngayxuathoadon";
            this.dtvngayxuathoadon.Size = new System.Drawing.Size(229, 20);
            this.dtvngayxuathoadon.TabIndex = 13;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(110, 94);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(67, 23);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Xuất";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(930, 94);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 18;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(191, 94);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(67, 23);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntaoma
            // 
            this.btntaoma.Location = new System.Drawing.Point(302, 66);
            this.btntaoma.Name = "btntaoma";
            this.btntaoma.Size = new System.Drawing.Size(37, 21);
            this.btntaoma.TabIndex = 20;
            this.btntaoma.Text = "+";
            this.btntaoma.UseVisualStyleBackColor = true;
            this.btntaoma.Click += new System.EventHandler(this.btntaoma_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(273, 94);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(67, 23);
            this.btntim.TabIndex = 23;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // lvchitiethoadon
            // 
            this.lvchitiethoadon.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvchitiethoadon.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvchitiethoadon.BackColor = System.Drawing.SystemColors.Window;
            this.lvchitiethoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.c9,
            this.c10,
            this.c11});
            this.lvchitiethoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvchitiethoadon.FullRowSelect = true;
            this.lvchitiethoadon.Location = new System.Drawing.Point(1, 321);
            this.lvchitiethoadon.Name = "lvchitiethoadon";
            this.lvchitiethoadon.ShowItemToolTips = true;
            this.lvchitiethoadon.Size = new System.Drawing.Size(1004, 311);
            this.lvchitiethoadon.TabIndex = 24;
            this.lvchitiethoadon.UseCompatibleStateImageBehavior = false;
            this.lvchitiethoadon.View = System.Windows.Forms.View.Details;
            this.lvchitiethoadon.VirtualListSize = 10000;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Bảng Kê";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Vận Chuyển";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Số Xe";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nơi Nhận";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nơi Giao";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số Tấn";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn Giá Chuyến";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 150;
            // 
            // c9
            // 
            this.c9.Text = "Đơn Giá Tấn";
            this.c9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c9.Width = 150;
            // 
            // c10
            // 
            this.c10.Text = "Thành Tiền";
            this.c10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c10.Width = 200;
            // 
            // c11
            // 
            this.c11.Text = "Ghi Chú";
            this.c11.Width = 300;
            // 
            // btncongno
            // 
            this.btncongno.Location = new System.Drawing.Point(442, 94);
            this.btncongno.Name = "btncongno";
            this.btncongno.Size = new System.Drawing.Size(229, 23);
            this.btncongno.TabIndex = 25;
            this.btncongno.Text = "Thêm Hóa Đơn Vào Công Nợ";
            this.btncongno.UseVisualStyleBackColor = true;
            this.btncongno.Click += new System.EventHandler(this.btncongno_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã Điều Xe";
            this.columnHeader9.Width = 104;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.btncongno);
            this.Controls.Add(this.lvchitiethoadon);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btntaoma);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtvngayxuathoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmahoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmahopdong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvhoadon);
            this.Controls.Add(this.cbkhachhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.cmsmenulv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.ListView lvhoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmahopdong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtvngayxuathoadon;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c5;
        private System.Windows.Forms.ColumnHeader c6;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntaoma;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.ListView lvchitiethoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader c9;
        private System.Windows.Forms.ColumnHeader c10;
        private System.Windows.Forms.ColumnHeader c11;
        private System.Windows.Forms.ContextMenuStrip cmsmenulv;
        private System.Windows.Forms.ToolStripMenuItem mntsxoalv;
        private System.Windows.Forms.ColumnHeader c55;
        private System.Windows.Forms.ColumnHeader c56;
        private System.Windows.Forms.Button btncongno;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}