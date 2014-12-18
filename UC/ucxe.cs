using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.UI;
using QLDVVTHH.DTO;
using QLDVVTHH.BLL;
namespace QLDVVTHH.UC
{
    public partial class ucxe : UserControl
    {
        public ucxe()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmXuatKetQua")
                {
                    mdiChild.Activate();
                    mdiChild.Close();
                }
            }
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmInAn")
                {
                    mdiChild.Activate();
                    mdiChild.Close();
                }
            }
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in Main.ActiveForm.MdiChildren)
            {
                if (mdiChild.Name == "frmXuatKetQua")
                {
                    mdiChild.Activate();
                    mdiChild.Close();
                }
            }
            frmXuatKetQua uc = new frmXuatKetQua();
            uc.strReport = "rptxe.rdlc";
            uc.MdiParent = Main.ActiveForm;
            uc.Show();
        }

        private void ucxe_Load(object sender, EventArgs e)
        {
            new BLL_INAN()._Luu_Data_Xe_Rpt();
        }
    }
}
