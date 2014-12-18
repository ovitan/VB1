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
    public partial class frmXe : Form
    {
        private DAL_Tinhtrangxe dal_ttx = null;
        private DAL_Xe dal_xe = null;
        public frmXe()
        {
            dal_ttx = new DAL_Tinhtrangxe();
            dal_xe = new DAL_Xe();
            InitializeComponent();
        }
        private void frmXe_Load(object sender, EventArgs e)
        {
            EnableControl(false);

            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            Loadcbbttxe();
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            grv_xe.DataSource = dal_xe.GetAll_Xe();
        }
        private void ResetControl()
        {
            txt_ma_so_xe.Text = string.Empty;
            txt_nhan_hieu.Text = string.Empty;
            txt_trong_luong.Text = string.Empty;
            txt_loai_xe.Text = string.Empty;           
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;

            MethodHelper.ClearErrorProvider();
        }
        private void EnableControl(bool flag)
        {
            txt_ma_so_xe.Enabled = flag;
            txt_nhan_hieu.Enabled = flag;
            txt_trong_luong.Enabled = flag;
            txt_loai_xe.Enabled = flag;        
            cbb_tinh_trang.Enabled = flag;
        }
        private void Loadcbbttxe()
        {
            //cbbRoleId.Items.Clear();
            cbb_tinh_trang.DataSource = dal_ttx.GetAll_TTXE();
            cbb_tinh_trang.DisplayMember = "ten_tinh_trang";
            cbb_tinh_trang.ValueMember = "ma_tinh_trang";
        }
        private void btn_them_Click(object sender, System.EventArgs e)
        {
            EnableControl(true);
            ResetControl();

            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;           
        }

        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            if (txt_ma_so_xe.Text.Length > 0)
            {
                EnableControl(true);
                txt_ma_so_xe.Enabled = false;
                MethodHelper.ClearErrorProvider();

                //cbbRoleId.Items.Clear();
                btn_luu.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, System.EventArgs e)
        {
            if (txt_ma_so_xe.Text.Length > 0)
            {
                dal_xe.Delete_Xe(txt_ma_so_xe.Text.Trim());
                BindDataGridView();
                ResetControl();

                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void grv_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex == 0)
                return;
            DTO_Xe xe = grv_xe.Rows[e.RowIndex].DataBoundItem as DTO_Xe;
            txt_ma_so_xe.Text = Convert.ToString(xe.ma_so_xe);
            txt_loai_xe.Text = xe.loai_xe;
            txt_nhan_hieu.Text = xe.nhan_hieu;
            txt_trong_luong.Text = Convert.ToString(xe.trong_luong);
            cbb_tinh_trang.SelectedValue = xe.ma_tinh_trang.ToString().Trim();
            EnableControl(false);
            MethodHelper.ClearErrorProvider();

            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true; 
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            DTO_Xe xe = new DTO_Xe();
            xe.ma_so_xe = txt_ma_so_xe.Text;
            xe.loai_xe = txt_loai_xe.Text;
            xe.nhan_hieu = txt_nhan_hieu.Text;
            xe.trong_luong =Convert.ToInt32(txt_trong_luong.Text);
            xe.ma_tinh_trang =Convert.ToInt32(cbb_tinh_trang.SelectedValue);
            xe.ngay_tao = DateTime.Now;
            if (txt_ma_so_xe.Enabled)
                dal_xe.Create_Xe(xe);
            else
                dal_xe.Update_Xe(xe);
            BindDataGridView();
            ResetControl();
            MethodHelper.ClearErrorProvider();

            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;           

        }
        private bool CheckBeforeSave()
        {
            bool flag = true;
            if (txt_ma_so_xe.Enabled && txt_ma_so_xe.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_ma_so_xe, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_loai_xe.Enabled && txt_loai_xe.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_loai_xe, Const.EMPTY_MESSAGE);

                flag = false;
            }
            if (!txt_loai_xe.Enabled && !txt_ma_so_xe.Enabled)
                flag = false;
            return flag;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
