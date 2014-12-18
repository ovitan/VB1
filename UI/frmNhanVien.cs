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
    public partial class frmNhanVien : Form
    {
        private DAL_NhanVien dal = null;
        private DAL_Xe dalxe = null;
        public frmNhanVien()
        {           
            InitializeComponent();                     
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
           
            dal = new DAL_NhanVien();
            dalxe = new DAL_Xe();
            grv_nhan_vien.AutoGenerateColumns = false;
            EnableControl(false);
            Loadcbbmasoxe();

            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            grv_nhan_vien.DataSource = dal.dt_GetAll();
        }
        private void Loadcbbmasoxe()
        {
            //cbbRoleId.Items.Clear();
            cbb_masoxe.DataSource = dalxe.GetAll_Xe();
            //cbb_tinh_trang.DisplayMember = "ten_tinh_trang";
            cbb_masoxe.ValueMember = "ma_so_xe";
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.ma_nhan_vien = txt_ma_nhan_vien.Text;
            nv.ten_nhan_vien = txt_ten_nhan_vien.Text;
            nv.ma_so_xe = Convert.ToString(cbb_masoxe.SelectedValue);
            nv.cmnd = txt_cmnd.Text;
            nv.dia_chi = txt_dia_chi.Text;
            nv.dien_thoai = txt_dien_thoai.Text;
            nv.chucvu = Convert.ToString(cbb_chuc_vu.SelectedItem);
            nv.ngay_tao = DateTime.Now;
            nv.nam_sinh = dt_nam_sinh.Value;
            if (txt_ma_nhan_vien.Enabled)
                dal.Create_nv(nv);
            else
                dal.Update_nv(nv);
            BindDataGridView();
            ResetControl();
            

            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;       
        }
        private void EnableControl(bool flag)
        {
            txt_ma_nhan_vien.Enabled = flag;
            txt_ten_nhan_vien.Enabled = flag;
            txt_cmnd.Enabled = flag;
            txt_dia_chi.Enabled = flag;
            txt_dien_thoai.Enabled = flag;
            cbb_chuc_vu.Enabled = flag;
            dt_nam_sinh.Enabled = flag;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ResetControl();

            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;            
        }
        private void ResetControl()
        {
            txt_ma_nhan_vien.Text = string.Empty;
            txt_ten_nhan_vien.Text = string.Empty;
            txt_cmnd.Text = string.Empty;
            txt_dia_chi.Text = string.Empty;
            txt_dien_thoai.Text = string.Empty;
            dt_nam_sinh.Value = DateTime.Now;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            txt_ten_nhan_vien.Focus();
            MethodHelper.ClearErrorProvider();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_ma_nhan_vien.Text.Length > 0)
            {
                dal.Delete_nv(txt_ma_nhan_vien.Text.Trim());
                BindDataGridView();
                ResetControl();

                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }
        private bool CheckBeforeSave()
        {
            bool flag = true;
            if (txt_ma_nhan_vien.Enabled && txt_ma_nhan_vien.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_ma_nhan_vien, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_ten_nhan_vien.Enabled && txt_ten_nhan_vien.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_ten_nhan_vien, Const.EMPTY_MESSAGE);

                flag = false;
            }
            if (!txt_ten_nhan_vien.Enabled && !txt_ma_nhan_vien.Enabled)
                flag = false;
            return flag;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_ma_nhan_vien.Text.Length > 0)
            {
                EnableControl(true);
                txt_ma_nhan_vien.Enabled = false;
                MethodHelper.ClearErrorProvider();

                //cbbRoleId.Items.Clear();
                btn_luu.Enabled = true;
            }
        }     
       
        private void grv_nhan_vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex < 0)
                return;
            //if (e.RowIndex == grv_nhan_vien.Rows.Count-1)
            //    return;
            DTO_NhanVien nhanvien = grv_nhan_vien.Rows[e.RowIndex].DataBoundItem as DTO_NhanVien;

            txt_ma_nhan_vien.Text = nhanvien.ma_nhan_vien;
            txt_ten_nhan_vien.Text = nhanvien.ten_nhan_vien;
            txt_cmnd.Text = nhanvien.cmnd;
            txt_dia_chi.Text = nhanvien.dia_chi;
            txt_dien_thoai.Text = nhanvien.dien_thoai;
            dt_nam_sinh.Value = Convert.ToDateTime(nhanvien.nam_sinh);
            cbb_chuc_vu.SelectedItem = nhanvien.chucvu.Trim();
         //   cbb_masoxe.SelectedItem = nhanvien.ma_so_xe.Trim();
            cbb_masoxe.Text = grv_nhan_vien.Rows[i].Cells["col_soxe"].Value.ToString();
            //cbbMaLoaiTB.Text = dgvDanhSachTB.Rows[curIndex].Cells["colMaLoaiTB"].Value.ToString();
            //int i = e.RowIndex;
            //txt_ma_nhan_vien.Text = grv_nhan_vien.Rows[i].Cells[0].Value.ToString();
            //txt_ten_nhan_vien.Text = grv_nhan_vien.Rows[i].Cells[1].Value.ToString();
            //txt_cmnd.Text = grv_nhan_vien.Rows[i].Cells[2].Value.ToString();
            //txt_dia_chi.Text = grv_nhan_vien.Rows[i].Cells[3].Value.ToString();
            //txt_dien_thoai.Text = grv_nhan_vien.Rows[i].Cells[4].Value.ToString();
            //dt_nam_sinh.Value = Convert.ToDateTime(grv_nhan_vien.Rows[i].Cells[5].Value.ToString());
            //cbb_chuc_vu.SelectedItem = grv_nhan_vien.Rows[i].Cells[6].Value.ToString();



            EnableControl(false);
            MethodHelper.ClearErrorProvider();

            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true; 
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txt_ma_nhan_vien_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_ma_nhan_vien.Enabled == true)
        //    {
        //        txt_ma_nhan_vien.Text = MethodHelper.GetIdFromName(txt_ma_nhan_vien.Text);
        //    }
        //}
    }
}
