namespace QLDVVTHH.UI
{
    partial class frmTinhTrangXe
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
            this.grv_ttxe = new System.Windows.Forms.DataGridView();
            this.colUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tentt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ttxe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grv_ttxe
            // 
            this.grv_ttxe.AllowUserToAddRows = false;
            this.grv_ttxe.AllowUserToDeleteRows = false;
            this.grv_ttxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_ttxe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnitId,
            this.colUnitName});
            this.grv_ttxe.Location = new System.Drawing.Point(29, 8);
            this.grv_ttxe.MultiSelect = false;
            this.grv_ttxe.Name = "grv_ttxe";
            this.grv_ttxe.ReadOnly = true;
            this.grv_ttxe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grv_ttxe.Size = new System.Drawing.Size(319, 338);
            this.grv_ttxe.TabIndex = 2;
            this.grv_ttxe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_ttxe_CellClick);
            // 
            // colUnitId
            // 
            this.colUnitId.DataPropertyName = "ma_tinh_trang";
            this.colUnitId.HeaderText = "Mã tình trang";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.ReadOnly = true;
            // 
            // colUnitName
            // 
            this.colUnitName.DataPropertyName = "ten_tinh_trang";
            this.colUnitName.HeaderText = "Tên tình trạng";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.ReadOnly = true;
            this.colUnitName.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tình trạng";
            // 
            // txt_matt
            // 
            this.txt_matt.Location = new System.Drawing.Point(96, 18);
            this.txt_matt.Name = "txt_matt";
            this.txt_matt.Size = new System.Drawing.Size(182, 20);
            this.txt_matt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tình trạng";
            // 
            // txt_tentt
            // 
            this.txt_tentt.Location = new System.Drawing.Point(96, 46);
            this.txt_tentt.Name = "txt_tentt";
            this.txt_tentt.Size = new System.Drawing.Size(182, 20);
            this.txt_tentt.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(7, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(247, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(54, 23);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(187, 12);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(54, 23);
            this.btn_luu.TabIndex = 0;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(127, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(54, 23);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(67, 12);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(54, 23);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(7, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(54, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_tentt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_matt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(384, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // frmTinhTrangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grv_ttxe);
            this.Name = "frmTinhTrangXe";
            this.Text = "frmTinhTrangXe";
            this.Load += new System.EventHandler(this.frmTinhTrangXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_ttxe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_ttxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tentt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitName;
    }
}