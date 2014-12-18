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
    public partial class frmTinhTrangXe : Form
    {
        private DAL_Tinhtrangxe dal = null;
        public frmTinhTrangXe()
        {
            dal = new DAL_Tinhtrangxe();
            InitializeComponent();
        }

        private void frmTinhTrangXe_Load(object sender, EventArgs e)
        {
            EnableControl(false);
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;

            BindDataGridView();
        }
        private void BindDataGridView()
        {
            grv_ttxe.DataSource = dal.GetAll_TTXE();
        }

        private void grv_ttxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DTO_TinhTrangXe KH = grv_ttxe.Rows[e.RowIndex].DataBoundItem as DTO_TinhTrangXe;
            txt_matt.Text = KH.ma_tinh_trang;
            txt_tentt.Text = KH.ten_tinh_trang;
            EnableControl(false);
            MethodHelper.ClearErrorProvider();


            EnableControl(false);
            MethodHelper.ClearErrorProvider();

            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
        private void EnableControl(bool flag)
        {
            txt_matt.Enabled = flag;
            txt_tentt.Enabled = flag;
        }
        private void ResetControl()
        {
            txt_matt.Text = string.Empty;
            txt_tentt.Text = string.Empty;

            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            txt_tentt.Focus();
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
            if (txt_matt.Text.Length > 0)
            {
                dal.Delete_TTxe(txt_matt.Text.Trim());
                BindDataGridView();
                ResetControl();

                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            if (txt_matt.Text.Length > 0)
            {
                EnableControl(true);
                txt_matt.Enabled = false;
                MethodHelper.ClearErrorProvider();

                //cbbRoleId.Items.Clear();
                btn_luu.Enabled = true;
            }
        }

        private void btn_luu_Click(object sender, System.EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            DTO_TinhTrangXe TTxe = new DTO_TinhTrangXe();
            TTxe.ma_tinh_trang = txt_matt.Text;
            TTxe.ten_tinh_trang = txt_tentt.Text;
            if (txt_matt.Enabled)
                dal.Create_TTxe(TTxe);
            else
                dal.Update_TTxe(TTxe);
            BindDataGridView();

            ResetControl();


            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }
        private bool CheckBeforeSave()
        {
            bool flag = true;
            if (txt_matt.Enabled && txt_matt.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_matt, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_tentt.Enabled && txt_tentt.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_tentt, Const.EMPTY_MESSAGE);

                flag = false;
            }
            if (!txt_tentt.Enabled && !txt_matt.Enabled)
                flag = false;
            return flag;
        }
        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
