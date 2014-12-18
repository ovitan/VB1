namespace QLDVVTHH.UI
{
    partial class frmCongNo
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
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpngayxuathoadon = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmacongno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbhoadon = new System.Windows.Forms.ComboBox();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.lvcongno = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnxoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnluucongno = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsotienthanhtoan = new System.Windows.Forms.TextBox();
            this.btnthemthanhtoan = new System.Windows.Forms.Button();
            this.lvthanhtoan = new System.Windows.Forms.ListView();
            this.cc1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cc3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cc4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cc5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cc6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbmahopdong = new System.Windows.Forms.ComboBox();
            this.btntaoma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(119, 3);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(248, 21);
            this.cbkhachhang.TabIndex = 3;
            this.cbkhachhang.SelectedIndexChanged += new System.EventHandler(this.cbkhachhang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Khách Hàng :";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(119, 32);
            this.txtmakhachhang.MaxLength = 10;
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(248, 20);
            this.txtmakhachhang.TabIndex = 7;
            this.txtmakhachhang.TextChanged += new System.EventHandler(this.txtmakhachhang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Xuất Hóa Đơn :";
            // 
            // dtpngayxuathoadon
            // 
            this.dtpngayxuathoadon.Location = new System.Drawing.Point(119, 170);
            this.dtpngayxuathoadon.Name = "dtpngayxuathoadon";
            this.dtpngayxuathoadon.Size = new System.Drawing.Size(248, 20);
            this.dtpngayxuathoadon.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Hóa Đơn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Công Nợ :";
            // 
            // txtmacongno
            // 
            this.txtmacongno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmacongno.Location = new System.Drawing.Point(119, 100);
            this.txtmacongno.MaxLength = 10;
            this.txtmacongno.Name = "txtmacongno";
            this.txtmacongno.Size = new System.Drawing.Size(209, 20);
            this.txtmacongno.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số Tiền Hóa Đơn :";
            // 
            // cbhoadon
            // 
            this.cbhoadon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhoadon.FormattingEnabled = true;
            this.cbhoadon.Location = new System.Drawing.Point(119, 133);
            this.cbhoadon.Name = "cbhoadon";
            this.cbhoadon.Size = new System.Drawing.Size(248, 21);
            this.cbhoadon.TabIndex = 15;
            this.cbhoadon.SelectedIndexChanged += new System.EventHandler(this.cbhoadon_SelectedIndexChanged);
            // 
            // txtsotien
            // 
            this.txtsotien.ForeColor = System.Drawing.Color.Black;
            this.txtsotien.Location = new System.Drawing.Point(119, 203);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.ReadOnly = true;
            this.txtsotien.Size = new System.Drawing.Size(248, 20);
            this.txtsotien.TabIndex = 16;
            // 
            // lvcongno
            // 
            this.lvcongno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c3,
            this.c4,
            this.c5,
            this.c6});
            this.lvcongno.ContextMenuStrip = this.cms1;
            this.lvcongno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvcongno.FullRowSelect = true;
            this.lvcongno.Location = new System.Drawing.Point(371, 3);
            this.lvcongno.MultiSelect = false;
            this.lvcongno.Name = "lvcongno";
            this.lvcongno.Size = new System.Drawing.Size(633, 306);
            this.lvcongno.TabIndex = 17;
            this.lvcongno.UseCompatibleStateImageBehavior = false;
            this.lvcongno.View = System.Windows.Forms.View.Details;
            this.lvcongno.VirtualListSize = 10000;
            // 
            // c1
            // 
            this.c1.Text = "STT";
            this.c1.Width = 73;
            // 
            // c3
            // 
            this.c3.Text = "Ngày Xuất Hóa Đơn";
            this.c3.Width = 126;
            // 
            // c4
            // 
            this.c4.Text = "Mã Hóa Đơn";
            this.c4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c4.Width = 155;
            // 
            // c5
            // 
            this.c5.Text = "Số Tiền Nợ";
            this.c5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c5.Width = 139;
            // 
            // c6
            // 
            this.c6.Text = "";
            this.c6.Width = 133;
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnxoa});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(95, 26);
            // 
            // mnxoa
            // 
            this.mnxoa.Name = "mnxoa";
            this.mnxoa.Size = new System.Drawing.Size(94, 22);
            this.mnxoa.Text = "Xóa";
            this.mnxoa.Click += new System.EventHandler(this.mnxoa_Click);
            // 
            // btnluucongno
            // 
            this.btnluucongno.Location = new System.Drawing.Point(119, 237);
            this.btnluucongno.Name = "btnluucongno";
            this.btnluucongno.Size = new System.Drawing.Size(105, 23);
            this.btnluucongno.TabIndex = 18;
            this.btnluucongno.Text = "Thêm Công Nợ";
            this.btnluucongno.UseVisualStyleBackColor = true;
            this.btnluucongno.Click += new System.EventHandler(this.btnluucongno_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngày Thanh Toán :";
            // 
            // dtpngaythanhtoan
            // 
            this.dtpngaythanhtoan.Enabled = false;
            this.dtpngaythanhtoan.Location = new System.Drawing.Point(119, 313);
            this.dtpngaythanhtoan.Name = "dtpngaythanhtoan";
            this.dtpngaythanhtoan.Size = new System.Drawing.Size(248, 20);
            this.dtpngaythanhtoan.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Số Tiền Thanh Toán :";
            // 
            // txtsotienthanhtoan
            // 
            this.txtsotienthanhtoan.Location = new System.Drawing.Point(120, 351);
            this.txtsotienthanhtoan.Name = "txtsotienthanhtoan";
            this.txtsotienthanhtoan.Size = new System.Drawing.Size(248, 20);
            this.txtsotienthanhtoan.TabIndex = 23;
            // 
            // btnthemthanhtoan
            // 
            this.btnthemthanhtoan.Location = new System.Drawing.Point(118, 389);
            this.btnthemthanhtoan.Name = "btnthemthanhtoan";
            this.btnthemthanhtoan.Size = new System.Drawing.Size(105, 23);
            this.btnthemthanhtoan.TabIndex = 24;
            this.btnthemthanhtoan.Text = "Thêm Thanh Toán";
            this.btnthemthanhtoan.UseVisualStyleBackColor = true;
            this.btnthemthanhtoan.Click += new System.EventHandler(this.btnthemthanhtoan_Click);
            // 
            // lvthanhtoan
            // 
            this.lvthanhtoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cc1,
            this.cc3,
            this.cc4,
            this.cc5,
            this.cc6});
            this.lvthanhtoan.ContextMenuStrip = this.cms1;
            this.lvthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvthanhtoan.FullRowSelect = true;
            this.lvthanhtoan.Location = new System.Drawing.Point(371, 315);
            this.lvthanhtoan.MultiSelect = false;
            this.lvthanhtoan.Name = "lvthanhtoan";
            this.lvthanhtoan.Size = new System.Drawing.Size(633, 315);
            this.lvthanhtoan.TabIndex = 25;
            this.lvthanhtoan.UseCompatibleStateImageBehavior = false;
            this.lvthanhtoan.View = System.Windows.Forms.View.Details;
            this.lvthanhtoan.VirtualListSize = 1000;
            // 
            // cc1
            // 
            this.cc1.Text = "STT";
            this.cc1.Width = 75;
            // 
            // cc3
            // 
            this.cc3.Text = "Ngày Thanh Toán";
            this.cc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cc3.Width = 287;
            // 
            // cc4
            // 
            this.cc4.Text = "Số Tiền Thanh Toán";
            this.cc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cc4.Width = 139;
            // 
            // cc5
            // 
            this.cc5.Text = "";
            this.cc5.Width = 218;
            // 
            // cc6
            // 
            this.cc6.Text = "";
            this.cc6.Width = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(250, 389);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(105, 23);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mã Hợp Đồng :";
            // 
            // cbmahopdong
            // 
            this.cbmahopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmahopdong.FormattingEnabled = true;
            this.cbmahopdong.Location = new System.Drawing.Point(120, 67);
            this.cbmahopdong.Name = "cbmahopdong";
            this.cbmahopdong.Size = new System.Drawing.Size(248, 21);
            this.cbmahopdong.TabIndex = 29;
            this.cbmahopdong.SelectedIndexChanged += new System.EventHandler(this.cbmahopdong_SelectedIndexChanged);
            // 
            // btntaoma
            // 
            this.btntaoma.Location = new System.Drawing.Point(331, 99);
            this.btntaoma.Name = "btntaoma";
            this.btntaoma.Size = new System.Drawing.Size(37, 21);
            this.btntaoma.TabIndex = 30;
            this.btntaoma.Text = "+";
            this.btntaoma.UseVisualStyleBackColor = true;
            this.btntaoma.Click += new System.EventHandler(this.btntaoma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chọn Khách Hàng :";
            // 
            // frmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntaoma);
            this.Controls.Add(this.cbmahopdong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lvthanhtoan);
            this.Controls.Add(this.btnthemthanhtoan);
            this.Controls.Add(this.txtsotienthanhtoan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpngaythanhtoan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnluucongno);
            this.Controls.Add(this.lvcongno);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.cbhoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmacongno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpngayxuathoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbkhachhang);
            this.Name = "frmCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÔNG NỢ";
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpngayxuathoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmacongno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbhoadon;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.ListView lvcongno;
        private System.Windows.Forms.Button btnluucongno;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c5;
        private System.Windows.Forms.ColumnHeader c6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpngaythanhtoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsotienthanhtoan;
        private System.Windows.Forms.Button btnthemthanhtoan;
        private System.Windows.Forms.ListView lvthanhtoan;
        private System.Windows.Forms.ColumnHeader cc1;
        private System.Windows.Forms.ColumnHeader cc3;
        private System.Windows.Forms.ColumnHeader cc4;
        private System.Windows.Forms.ColumnHeader cc5;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbmahopdong;
        private System.Windows.Forms.Button btntaoma;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem mnxoa;
        private System.Windows.Forms.ColumnHeader cc6;
        private System.Windows.Forms.Label label1;
    }
}