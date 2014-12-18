namespace QLDVVTHH.UI
{
    partial class frmThongKeCongNo
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.lvthongkecongno = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "THỐNG KÊ CÔNG NỢ";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(921, 605);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lvthongkecongno
            // 
            this.lvthongkecongno.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvthongkecongno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c3,
            this.c33,
            this.c4,
            this.c5,
            this.c6,
            this.c7});
            this.lvthongkecongno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvthongkecongno.FullRowSelect = true;
            this.lvthongkecongno.GridLines = true;
            this.lvthongkecongno.HoverSelection = true;
            this.lvthongkecongno.Location = new System.Drawing.Point(0, 30);
            this.lvthongkecongno.MultiSelect = false;
            this.lvthongkecongno.Name = "lvthongkecongno";
            this.lvthongkecongno.ShowItemToolTips = true;
            this.lvthongkecongno.Size = new System.Drawing.Size(1008, 569);
            this.lvthongkecongno.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvthongkecongno.TabIndex = 4;
            this.lvthongkecongno.UseCompatibleStateImageBehavior = false;
            this.lvthongkecongno.View = System.Windows.Forms.View.Details;
            this.lvthongkecongno.VirtualListSize = 100000;
            // 
            // c1
            // 
            this.c1.Text = "STT";
            this.c1.Width = 67;
            // 
            // c2
            // 
            this.c2.Text = "Mã Khách Hàng";
            this.c2.Width = 108;
            // 
            // c3
            // 
            this.c3.Text = "Thông Tin Khách Hàng";
            this.c3.Width = 204;
            // 
            // c33
            // 
            this.c33.Text = "Mã Hợp Đồng";
            this.c33.Width = 98;
            // 
            // c4
            // 
            this.c4.Text = "Tổng  Nợ";
            this.c4.Width = 138;
            // 
            // c5
            // 
            this.c5.Text = "Tổng Số Tiền Đã Trả";
            this.c5.Width = 153;
            // 
            // c6
            // 
            this.c6.Text = "Số Tiền Còn Lại";
            this.c6.Width = 132;
            // 
            // c7
            // 
            this.c7.Text = "Đơn Vị";
            this.c7.Width = 110;
            // 
            // frmThongKeCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvthongkecongno);
            this.Name = "frmThongKeCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ CÔNG NỢ";
            this.Load += new System.EventHandler(this.frmThongKeCongNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c5;
        private System.Windows.Forms.ColumnHeader c6;
        private System.Windows.Forms.ColumnHeader c7;
        private System.Windows.Forms.ColumnHeader c33;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ListView lvthongkecongno;
    }
}