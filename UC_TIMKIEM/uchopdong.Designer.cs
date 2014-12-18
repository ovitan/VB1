namespace QLDVVTHH.UC_TIMKIEM
{
    partial class uchopdong
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntruyvan = new System.Windows.Forms.Button();
            this.txtmahopdong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(97, 91);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntruyvan
            // 
            this.btntruyvan.Location = new System.Drawing.Point(97, 62);
            this.btntruyvan.Name = "btntruyvan";
            this.btntruyvan.Size = new System.Drawing.Size(75, 23);
            this.btntruyvan.TabIndex = 6;
            this.btntruyvan.Text = "Truy Vấn";
            this.btntruyvan.UseVisualStyleBackColor = true;
            this.btntruyvan.Click += new System.EventHandler(this.btntruyvan_Click);
            // 
            // txtmahopdong
            // 
            this.txtmahopdong.Location = new System.Drawing.Point(22, 31);
            this.txtmahopdong.MaxLength = 10;
            this.txtmahopdong.Name = "txtmahopdong";
            this.txtmahopdong.Size = new System.Drawing.Size(248, 20);
            this.txtmahopdong.TabIndex = 5;
            this.txtmahopdong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmahoadon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập Mã Hợp Đồng :";
            // 
            // uchopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntruyvan);
            this.Controls.Add(this.txtmahopdong);
            this.Controls.Add(this.label1);
            this.Name = "uchopdong";
            this.Size = new System.Drawing.Size(281, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntruyvan;
        private System.Windows.Forms.TextBox txtmahopdong;
        private System.Windows.Forms.Label label1;
    }
}
