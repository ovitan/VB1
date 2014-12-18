namespace QLDVVTHH.UI
{
    partial class frmTimKetQua
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
            this.lvthongtintimkiem = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvthongtintimkiem
            // 
            this.lvthongtintimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvthongtintimkiem.FullRowSelect = true;
            this.lvthongtintimkiem.GridLines = true;
            this.lvthongtintimkiem.Location = new System.Drawing.Point(0, 0);
            this.lvthongtintimkiem.MultiSelect = false;
            this.lvthongtintimkiem.Name = "lvthongtintimkiem";
            this.lvthongtintimkiem.Size = new System.Drawing.Size(1008, 632);
            this.lvthongtintimkiem.TabIndex = 0;
            this.lvthongtintimkiem.UseCompatibleStateImageBehavior = false;
            this.lvthongtintimkiem.View = System.Windows.Forms.View.Details;
            // 
            // frmTimKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.lvthongtintimkiem);
            this.Location = new System.Drawing.Point(305, 0);
            this.Name = "frmTimKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KẾT QUẢ TRA CỨU";
            this.Load += new System.EventHandler(this.frmTimKetQua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvthongtintimkiem;
    }
}