namespace QLDVVTHH.UI
{
    partial class frmInAn
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
            this.cbdanhmuc = new System.Windows.Forms.ComboBox();
            this.pndanhmuc = new System.Windows.Forms.Panel();
            this.pncontrol = new System.Windows.Forms.Panel();
            this.pndanhmuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbdanhmuc
            // 
            this.cbdanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdanhmuc.FormattingEnabled = true;
            this.cbdanhmuc.Location = new System.Drawing.Point(2, 3);
            this.cbdanhmuc.Name = "cbdanhmuc";
            this.cbdanhmuc.Size = new System.Drawing.Size(193, 21);
            this.cbdanhmuc.TabIndex = 1;
            this.cbdanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbdanhmuc_SelectedIndexChanged);
            // 
            // pndanhmuc
            // 
            this.pndanhmuc.Controls.Add(this.cbdanhmuc);
            this.pndanhmuc.Location = new System.Drawing.Point(0, 0);
            this.pndanhmuc.Name = "pndanhmuc";
            this.pndanhmuc.Size = new System.Drawing.Size(197, 27);
            this.pndanhmuc.TabIndex = 2;
            // 
            // pncontrol
            // 
            this.pncontrol.Location = new System.Drawing.Point(0, 28);
            this.pncontrol.Name = "pncontrol";
            this.pncontrol.Size = new System.Drawing.Size(197, 187);
            this.pncontrol.TabIndex = 3;
            // 
            // frmInAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 219);
            this.Controls.Add(this.pncontrol);
            this.Controls.Add(this.pndanhmuc);
            this.MaximizeBox = false;
            this.Name = "frmInAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IN ẤN";
            this.pndanhmuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdanhmuc;
        private System.Windows.Forms.Panel pndanhmuc;
        private System.Windows.Forms.Panel pncontrol;
    }
}