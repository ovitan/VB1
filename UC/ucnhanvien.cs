using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.UI;
using QLDVVTHH.BLL;
using QLDVVTHH.DTO;
using QLDVVTHH.UC;

namespace QLDVVTHH.UC
{
    public partial class ucnhanvien : UserControl
    {
        public ucnhanvien()
        {
            InitializeComponent();
            new BLL_INAN()._Luu_Data_Nhan_Vien_Rpt();
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
            uc.strReport = "rptnhanvien.rdlc";
            uc.MdiParent = Main.ActiveForm;
            uc.Show();
        }
    }
}
