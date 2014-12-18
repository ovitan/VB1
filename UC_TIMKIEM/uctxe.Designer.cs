namespace QLDVVTHH.UC_TIMKIEM
{
    partial class uctxe
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
            this.txtmasoxe = new System.Windows.Forms.TextBox();
            this.btntruyvan = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Số Xe :";
            // 
            // txtmasoxe
            // 
            this.txtmasoxe.Location = new System.Drawing.Point(16, 30);
            this.txtmasoxe.MaxLength = 10;
            this.txtmasoxe.Name = "txtmasoxe";
            this.txtmasoxe.Size = new System.Drawing.Size(252, 20);
            this.txtmasoxe.TabIndex = 1;
            this.txtmasoxe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmasoxe_KeyPress);
            // 
            // btntruyvan
            // 
            this.btntruyvan.Location = new System.Drawing.Point(89, 63);
            this.btntruyvan.Name = "btntruyvan";
            this.btntruyvan.Size = new System.Drawing.Size(75, 23);
            this.btntruyvan.TabIndex = 2;
            this.btntruyvan.Text = "Truy Vấn";
            this.btntruyvan.UseVisualStyleBackColor = true;
            this.btntruyvan.Click += new System.EventHandler(this.btntruyvan_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(89, 92);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(75, 23);
            this.Thoát.TabIndex = 3;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // uctxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.btntruyvan);
            this.Controls.Add(this.txtmasoxe);
            this.Controls.Add(this.label1);
            this.Name = "uctxe";
            this.Size = new System.Drawing.Size(281, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasoxe;
        private System.Windows.Forms.Button btntruyvan;
        private System.Windows.Forms.Button Thoát;
    }
}
