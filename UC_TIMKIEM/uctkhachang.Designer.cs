namespace QLDVVTHH.UC_TIMKIEM
{
    partial class uctkhachang
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
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.btntruyvan = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên Khách Hàng :";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(11, 29);
            this.txttenkhachhang.MaxLength = 50;
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(260, 20);
            this.txttenkhachhang.TabIndex = 1;
            this.txttenkhachhang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenkhachhang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Mã Khách Hàng :";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(10, 81);
            this.txtmakhachhang.MaxLength = 10;
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(260, 20);
            this.txtmakhachhang.TabIndex = 3;
            this.txtmakhachhang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmakhachhang_KeyPress);
            // 
            // btntruyvan
            // 
            this.btntruyvan.Location = new System.Drawing.Point(94, 110);
            this.btntruyvan.Name = "btntruyvan";
            this.btntruyvan.Size = new System.Drawing.Size(75, 23);
            this.btntruyvan.TabIndex = 4;
            this.btntruyvan.Text = "Truy Vấn";
            this.btntruyvan.UseVisualStyleBackColor = true;
            this.btntruyvan.Click += new System.EventHandler(this.btntruyvan_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(94, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // uctkhachang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntruyvan);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenkhachhang);
            this.Controls.Add(this.label1);
            this.Name = "uctkhachang";
            this.Size = new System.Drawing.Size(281, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Button btntruyvan;
        private System.Windows.Forms.Button btnthoat;
    }
}
