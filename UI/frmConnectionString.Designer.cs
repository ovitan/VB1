namespace QLDVVTHH.UI
{
    partial class frmConnectionString
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
            this.txtservername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdatatbase = new System.Windows.Forms.ComboBox();
            this.btnketnoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btntao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name :";
            // 
            // txtservername
            // 
            this.txtservername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtservername.Enabled = false;
            this.txtservername.Location = new System.Drawing.Point(93, 51);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(250, 20);
            this.txtservername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn CSDL :";
            // 
            // cbdatatbase
            // 
            this.cbdatatbase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdatatbase.FormattingEnabled = true;
            this.cbdatatbase.Location = new System.Drawing.Point(93, 89);
            this.cbdatatbase.Name = "cbdatatbase";
            this.cbdatatbase.Size = new System.Drawing.Size(250, 21);
            this.cbdatatbase.TabIndex = 3;
            // 
            // btnketnoi
            // 
            this.btnketnoi.Location = new System.Drawing.Point(93, 129);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(75, 23);
            this.btnketnoi.TabIndex = 4;
            this.btnketnoi.Text = "Kết Nối";
            this.btnketnoi.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(200, 129);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tạo CSDL :";
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(93, 10);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(75, 23);
            this.btntao.TabIndex = 7;
            this.btntao.Text = "Tạo";
            this.btntao.UseVisualStyleBackColor = true;
            // 
            // frmConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 187);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnketnoi);
            this.Controls.Add(this.cbdatatbase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.label1);
            this.Name = "frmConnectionString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CẤU HÌNH KẾT NỐI SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbdatatbase;
        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntao;
    }
}