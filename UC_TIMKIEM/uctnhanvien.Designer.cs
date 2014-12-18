namespace QLDVVTHH.UC_TIMKIEM
{
    partial class uctnhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttenhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.btntruyvan = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên Nhân Viên :";
            // 
            // txttenhanvien
            // 
            this.txttenhanvien.Location = new System.Drawing.Point(16, 25);
            this.txttenhanvien.MaxLength = 50;
            this.txttenhanvien.Name = "txttenhanvien";
            this.txttenhanvien.Size = new System.Drawing.Size(251, 20);
            this.txttenhanvien.TabIndex = 1;
            this.txttenhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenhanvien_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Mã Nhân Viên :";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(16, 84);
            this.txtmanhanvien.MaxLength = 10;
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(251, 20);
            this.txtmanhanvien.TabIndex = 3;
            this.txtmanhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmanhanvien_KeyPress);
            // 
            // btntruyvan
            // 
            this.btntruyvan.Location = new System.Drawing.Point(92, 120);
            this.btntruyvan.Name = "btntruyvan";
            this.btntruyvan.Size = new System.Drawing.Size(75, 23);
            this.btntruyvan.TabIndex = 4;
            this.btntruyvan.Text = "Truy Vấn";
            this.btntruyvan.UseVisualStyleBackColor = true;
            this.btntruyvan.Click += new System.EventHandler(this.btntruyvan_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(92, 149);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // uctnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntruyvan);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenhanvien);
            this.Controls.Add(this.label1);
            this.Name = "uctnhanvien";
            this.Size = new System.Drawing.Size(281, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Button btntruyvan;
        private System.Windows.Forms.Button btnthoat;
    }
}
