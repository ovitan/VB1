namespace QLDVVTHH.UC_TIMKIEM
{
    partial class ucthoadon
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
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.btntruyvan = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Hóa Đơn :";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(16, 29);
            this.txtmahoadon.MaxLength = 10;
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(248, 20);
            this.txtmahoadon.TabIndex = 1;
            this.txtmahoadon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmahoadon_KeyPress);
            // 
            // btntruyvan
            // 
            this.btntruyvan.Location = new System.Drawing.Point(91, 60);
            this.btntruyvan.Name = "btntruyvan";
            this.btntruyvan.Size = new System.Drawing.Size(75, 23);
            this.btntruyvan.TabIndex = 2;
            this.btntruyvan.Text = "Truy Vấn";
            this.btntruyvan.UseVisualStyleBackColor = true;
            this.btntruyvan.Click += new System.EventHandler(this.btntruyvan_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(91, 89);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // ucthoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntruyvan);
            this.Controls.Add(this.txtmahoadon);
            this.Controls.Add(this.label1);
            this.Name = "ucthoadon";
            this.Size = new System.Drawing.Size(281, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Button btntruyvan;
        private System.Windows.Forms.Button btnthoat;
    }
}
