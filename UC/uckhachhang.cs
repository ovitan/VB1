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
    public partial class uckhachhang : UserControl
    {
        public uckhachhang()
        {
            InitializeComponent();
            _Load_DanhSach_TuyChon();
            _Delete_Insert_Database();
        }
        private void _Delete_Insert_Database()
        {
            int i = new BLL_INAN()._Luu_Data_Khach_Hang_Rpt();
        }
        private void _Load_DanhSach_TuyChon()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            DataRow row = dt.NewRow();
            row["Text"] = "-->>In Toàn Bộ Khách Hàng";
            row["Value"] = "0002";
            dt.Rows.InsertAt(row, 0);

            cbdanhsachtuyechon.DataSource = dt;
            cbdanhsachtuyechon.DisplayMember = "Text";
            cbdanhsachtuyechon.ValueMember = "Value";

            cbdanhsachtuyechon.SelectedIndex = 0;
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
            uc.strReport = "rptkhachhang.rdlc";
            uc.MdiParent = Main.ActiveForm;
            uc.Show();
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
    }
}
