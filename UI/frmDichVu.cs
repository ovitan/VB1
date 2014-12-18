using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.Common;
using QLDVVTHH.BLL;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;
using System.Text.RegularExpressions;
namespace QLDVVTHH.UI
{
    public partial class frmDichVu : Form
    {
        DAL_DichVu dal_dv = null;
        public frmDichVu()
        {
            dal_dv = new DAL_DichVu();
            InitializeComponent();

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            EnableControl(false);
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            grv_dichvu.DataSource = dal_dv.GetAll_DV();
        }
   
        private void EnableControl(bool flag)
        {
            txt_khuvuc.Enabled = flag;
            txt_phanvung.Enabled = flag;
            txt_dongiachuyen.Enabled = flag;
            txt_dongiatan.Enabled = flag;
        }
        private void ResetControl()
        {
            txt_phanvung.Text = string.Empty;
            txt_khuvuc.Text = string.Empty;
            txt_dongiachuyen.Text = string.Empty;
            txt_dongiatan.Text = string.Empty;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;            
            MethodHelper.ClearErrorProvider();


        }

        private void btn_them_Click(object sender, System.EventArgs e)
        {
            EnableControl(true);
            ResetControl();

            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, System.EventArgs e)
        {
            if (txt_khuvuc.Text.Length > 0)
            {
                dal_dv.Delete_DV(txt_khuvuc.Text.Trim());
                BindDataGridView();
                ResetControl();

                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            if (txt_khuvuc.Text.Length > 0)
            {
                EnableControl(true);
                txt_khuvuc.Enabled = false;
                txt_phanvung.Enabled = false;
                MethodHelper.ClearErrorProvider();

                //cbbRoleId.Items.Clear();
                btn_luu.Enabled = true;
            }
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, System.EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            DTO_DichVu dvu = new DTO_DichVu();
            dvu.khu_vuc= txt_khuvuc.Text;
            dvu.phan_vung = txt_phanvung.Text;
            dvu.don_gia_tan = Convert.ToInt32(txt_dongiatan.Text);
            dvu.don_gia_chuyen = Convert.ToInt32(txt_dongiachuyen.Text);
            if (txt_khuvuc.Enabled)
                dal_dv.Create_DV(dvu);
            else
                dal_dv.Update_DVU(dvu);
            BindDataGridView();

            ResetControl();


            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void grv_dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DTO_DichVu DV = grv_dichvu.Rows[e.RowIndex].DataBoundItem as DTO_DichVu;
            txt_khuvuc.Text = DV.khu_vuc;
            txt_phanvung.Text = DV.phan_vung;
            txt_dongiachuyen.Text = Convert.ToString(DV.don_gia_chuyen);
            txt_dongiatan.Text = Convert.ToString(DV.don_gia_tan);
            EnableControl(false);
            MethodHelper.ClearErrorProvider();


            EnableControl(false);
            MethodHelper.ClearErrorProvider();

            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
        private bool CheckBeforeSave()
        {
            bool flag = true;

            if (txt_khuvuc.Enabled && txt_khuvuc.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_khuvuc, Const.EMPTY_MESSAGE);

                flag = false;
            }
            if (txt_phanvung.Enabled && txt_phanvung.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_phanvung, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_dongiachuyen.Enabled && txt_dongiachuyen.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_dongiachuyen, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (!txt_khuvuc.Enabled && !txt_phanvung.Enabled && !txt_dongiachuyen.Enabled)
                flag = false;
            return flag;
        }

        private void grv_dichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
