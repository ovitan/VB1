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
    public partial class frmKhachHang : Form
    {
        private DAL_KhachHang dal =null;
        public frmKhachHang()
        {
            InitializeComponent();
            dal = new DAL_KhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            

            EnableControl(false);

            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            grv_khachhang.DataSource = dal.GetAll_KH();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.ma_khach_hang= txt_ma_khachhang.Text;
            kh.ten_khach_hang = txt_ten_khachhang.Text;
            kh.ma_so_thue = Convert.ToString(txt_sothue.Text);
            kh.fax = txt_fax.Text;
            kh.dia_chi = txt_diachi.Text;
            kh.dien_thoai = txt_dienthoai.Text;
            kh.ngay_tao = DateTime.Now;
            if (txt_ma_khachhang.Enabled)
                dal.Create_KH(kh);
            else
                dal.Update_KH(kh);
            BindDataGridView();

            ResetControl();


            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;     
        }

        private void EnableControl(bool flag)
        {
            txt_ma_khachhang.Enabled = flag;
            txt_ten_khachhang.Enabled = flag;
            txt_sothue.Enabled = flag;
            txt_fax.Enabled = flag;
            txt_dienthoai.Enabled = flag;
            txt_diachi.Enabled = flag;
        }
        private void ResetControl()
        {
            txt_ma_khachhang.Text = string.Empty;
            txt_ten_khachhang.Text = string.Empty;
            txt_sothue.Text= string.Empty;
            txt_diachi.Text = string.Empty;
            txt_dienthoai.Text = string.Empty;
            txt_fax.Text = string.Empty;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            txt_ten_khachhang.Focus();
            MethodHelper.ClearErrorProvider();


        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ResetControl();

            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_ma_khachhang.Text.Length > 0)
            {
                dal.Delete_kh(txt_ma_khachhang.Text.Trim());
                BindDataGridView();
                ResetControl();

                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_ma_khachhang.Text.Length > 0)
            {
                EnableControl(true);
                txt_ma_khachhang.Enabled = false;
                MethodHelper.ClearErrorProvider();

                //cbbRoleId.Items.Clear();
                btn_luu.Enabled = true;
            }
        }
        

        private void grv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DTO_KhachHang KH = grv_khachhang.Rows[e.RowIndex].DataBoundItem as DTO_KhachHang;
            txt_ma_khachhang.Text = KH.ma_khach_hang;
            txt_ten_khachhang.Text = KH.ten_khach_hang;
            txt_sothue.Text = KH.ma_so_thue;
            txt_fax.Text = KH.fax;
            txt_diachi.Text = KH.dia_chi;
            txt_dienthoai.Text = KH.dien_thoai;
            EnableControl(false);
            MethodHelper.ClearErrorProvider();

            //if (e.RowIndex < 0)
            //    return;
            //if (e.RowIndex == grv_khachhang.Rows.Count - 1)
            //    return;
            //int i = e.RowIndex;
            //txt_ma_khachhang.Text = grv_khachhang.Rows[i].Cells[0].Value.ToString();
            //txt_ten_khachhang.Text = grv_khachhang.Rows[i].Cells[1].Value.ToString();
            //txt_sothue.Text = grv_khachhang.Rows[i].Cells[2].Value.ToString();
            //txt_diachi.Text = grv_khachhang.Rows[i].Cells[3].Value.ToString();
            //txt_dienthoai.Text = grv_khachhang.Rows[i].Cells[4].Value.ToString();
            //txt_fax.Text = grv_khachhang.Rows[i].Cells[5].Value.ToString();           
            
            
            
            
            EnableControl(false);
            MethodHelper.ClearErrorProvider();

            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true; 
        }
        private bool CheckBeforeSave()
        {
            bool flag = true;
            if (txt_ma_khachhang.Enabled && txt_ma_khachhang.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_ma_khachhang, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_ten_khachhang.Enabled && txt_ten_khachhang.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_ten_khachhang, Const.EMPTY_MESSAGE);

                flag = false;
            }
            if (!txt_ten_khachhang.Enabled && !txt_ma_khachhang.Enabled)
                flag = false;
            return flag;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    
    }
}
