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
    public partial class frmDieuXe : Form
    {
        AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
        DAL_NhanVien dal_nv = null;
        DAL_Tinhtrangxe dal_ttxe = null;
        DAL_DieuXe dal_dx = null;
        DAL_Xe dal_xe = null;
        DAL_KhachHang dal_kh = null;
        DAL_HopDong dal_hd = null;
        public frmDieuXe()
        {
            dal_nv = new DAL_NhanVien();
            dal_ttxe = new DAL_Tinhtrangxe();
            dal_dx = new DAL_DieuXe();
            dal_xe = new DAL_Xe();
            dal_kh = new DAL_KhachHang();
            dal_hd = new DAL_HopDong();
            InitializeComponent();
            grv_TTxe.AutoGenerateColumns = false;
            grv_KH.AutoGenerateColumns = false;
            grv_NV.AutoGenerateColumns = false;
            grv_dieuxe.AutoGenerateColumns = false;
            Loadcbb_soxe();
            Loadkhachhang();
            _load_tinh_trang_thanh_toan();


            EnableControl(false);
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            txt_madieuxe.Text = new BLL_DieuXe()._Ma_Dieu_Xe_Moi();

            Auto_NoiNhan();
            Auto_NoiGiao();
        }

        private void Auto_NoiNhan()
        {
            if(new BLL_DieuXe().Get_NoiNhan()!=null)
            {
                foreach (DTO_DieuXe dx in new BLL_DieuXe().Get_NoiNhan())
                {
                    auto1.Add(dx.noi_nhan.ToString());
                }
                txt_noinhan.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_noinhan.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_noinhan.AutoCompleteCustomSource = auto1;
            }
        }
        private void Auto_NoiGiao()
        {
            if (new BLL_DieuXe().Get_NoiGiao() != null)
            {
                foreach (DTO_DieuXe dx in new BLL_DieuXe().Get_NoiGiao())
                {
                    auto2.Add(dx.noi_giao.ToString());
                }
                txt_noigiao.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_noigiao.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_noigiao.AutoCompleteCustomSource = auto2;
            }
        }

        private void _load_tinh_trang_thanh_toan()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");
            DataRow row = dt.NewRow();
            row["Text"] = "Chưa Thanh Toán";
            row["Value"] = "0";
            dt.Rows.InsertAt(row, 0);
            DataRow row2 = dt.NewRow();
            row2["Text"] = "Đã Thanh Toán";
            row2["Value"] = "1";
            dt.Rows.InsertAt(row2, 0);

            cbtinhtrangthanhtoan.DataSource = dt;
            cbtinhtrangthanhtoan.DisplayMember = "Text";
            cbtinhtrangthanhtoan.ValueMember = "Value";

            cbtinhtrangthanhtoan.SelectedIndex = 1;
        }
        private void frmDieuXe_Load(object sender, EventArgs e)
        {
            BindDataGridView_TTxe();
            BinbDataGridView_Dieuxe();
        }
        private void BindDataGridView_TTxe()
        {
            grv_TTxe.DataSource = dal_xe.GetAll_Xe_1();
        } 
        private void BinbDataGridView_Dieuxe()
        {
            grv_dieuxe.DataSource=dal_dx.GetAll_DX();
        }
        private void Loadkhachhang()
        {
            //cbbRoleId.Items.Clear();
            //cbb_khachhang.DataSource = dal_kh.GetAll_KH();
            //cbb_khachhang.DisplayMember = "ten_khach_hang";
            //cbb_khachhang.ValueMember = "ma_khach_hang";
            List<DTO_KhachHang> kh = new List<DTO_KhachHang>();
            var groups = dal_kh.GetAll_KH();
            kh.Add(new DTO_KhachHang() { ma_khach_hang = "-1", ten_khach_hang = "Chọn tên" });
            kh.AddRange(groups);
            cbb_khachhang.DataSource = kh;
            cbb_khachhang.DisplayMember = "ten_khach_hang";
            cbb_khachhang.ValueMember = "ma_khach_hang";
            //cbb_khachhang.SelectedValue = "-1";
            
        }
        private void Loadcbb_soxe()
        {
            List<DTO_Xe> soxe = new List<DTO_Xe>();
            var groups = dal_xe.GetAll_Xe();
            soxe.Add(new DTO_Xe() { ma_so_xe = "Chọn số xe" });
            soxe.AddRange(groups);
            cbb_soxe.DataSource = soxe;
            cbb_soxe.ValueMember = "ma_so_xe";//cái mã cũng là cái sô xe
            cbb_soxe.DisplayMember = "ma_so_xe";
            //cbb_soxe.SelectedValue = "-1";
            //cbb_soxe.DataSource = dal_nv.dt_GetAll();
            //cbb_tinh_trang.DisplayMember = "ten_tinh_trang";
            //cbb_soxe.ValueMember = "ma_so_xe";
        }
        private void cbb_soxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbb_soxe.SelectedValue != null)
            {
                
                string chonsoxe = cbb_soxe.SelectedValue.ToString().Trim();
                if (cbb_soxe.SelectedIndex == 0)
                {
                    txt_trongluongxe.Text = "";
                    grv_NV.DataSource = dal_nv.dt_GetAll();
                }
                else
                {
                    // int i = cbb_soxe.SelectedIndex;
                    grv_NV.DataSource = null;
                    grv_NV.DataSource = dal_nv.GetAll_NV_ID(chonsoxe);
                    DTO_Xe dto = new DTO_Xe();
                    dto.ma_so_xe = cbb_soxe.SelectedValue.ToString();
                    List<DTO_Xe> li = new BLL_DieuXe().Get_TrongLuongXe(dto);
                    foreach (DTO_Xe xe in li)
                    {
                        txt_trongluongxe.Text = xe.trong_luong.ToString();
                    }
                    //txt_trongluongxe.Text = grv_TTxe.Rows[i].Cells["coltrongluong"].Value.ToString();
                }
            }
        }

        private void cbb_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_khachhang.SelectedValue != null)
            {
                string chonKH = cbb_khachhang.SelectedValue.ToString();
                if (cbb_khachhang.SelectedIndex == 0)
                    grv_KH.DataSource = dal_hd.GetAll_KH_HD_HH();
                else
                {
                    grv_KH.DataSource = dal_hd.GetAll_KH_ID(chonKH);
                }
            }
            //MessageBox.Show(cbb_khachhang.SelectedValue.ToString());
        }


        //dieuxe
        
        private void EnableControl(bool flag)
        {
            txt_madieuxe.Enabled = flag;
            cbb_soxe.Enabled = flag;
            txt_sotan.Enabled = flag;
            txt_noinhan.Enabled = flag;
            txt_noigiao.Enabled = flag;
            cbb_khachhang.Enabled = flag;
            data_ngaydieuxe.Enabled = flag;
        }    
        private void ResetControl()
        {
            txt_madieuxe.Text = string.Empty;
            txt_sotan.Text = string.Empty;
            txt_noinhan.Text = string.Empty;
            txt_noigiao.Text = string.Empty;
            data_ngaydieuxe.Value = DateTime.Now;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            //btn_sua.Enabled = false;         
            MethodHelper.ClearErrorProvider();
        }

        //private void btn_xoa_Click(object sender, EventArgs e)
        //{
        //    if (txt_madieuxe.Text.Length > 0)
        //    {
        //        dal_dx.Delete_Dxe(txt_madieuxe.Text.Trim());
        //        BinbDataGridView_Dieuxe();
        //        ResetControl();

        //        btn_xoa.Enabled = false;
        //        btn_sua.Enabled = false;
        //    }
        //}
        private bool CheckBeforeSave()
        {
            bool flag = true;
            if (txt_madieuxe.Enabled && txt_madieuxe.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_madieuxe, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_sotan.Enabled && txt_sotan.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_sotan, Const.EMPTY_MESSAGE);

                flag = false;
            }
            if (!txt_sotan.Enabled && !txt_sotan.Enabled)
                flag = false;
            return flag;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ResetControl();

            txt_madieuxe.Text = new BLL_DieuXe()._Ma_Dieu_Xe_Moi();
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            DTO_DieuXe dx = new DTO_DieuXe();
            dx.ma_dieu_xe = txt_madieuxe.Text;
            dx.ma_khach_hang = Convert.ToString(cbb_khachhang.SelectedValue.ToString());
            dx.ma_so_xe = Convert.ToString(cbb_soxe.SelectedValue);
            dx.so_tan = txt_sotan.Text;
            dx.noi_giao = txt_noigiao.Text;
            dx.noi_nhan = txt_noinhan.Text;
            dx.ngay_dieu_xe = data_ngaydieuxe.Value;
            dx.ngay_ve = dtpngayve.Value;
            dx.tttt = int.Parse(cbtinhtrangthanhtoan.SelectedValue.ToString());
            if (txt_madieuxe.Enabled)
            {
                dal_dx.Create_DX(dx);              
            }
            else
            {
                dal_dx.Update_DX(dx);
            }
            BinbDataGridView_Dieuxe();
            if ((int.Parse(txt_sotan.Text) > int.Parse(txt_trongluongxe.Text)) && (int.Parse(txt_sotan.Text) - int.Parse(txt_trongluongxe.Text) > 0))
            {
                MessageBox.Show("Điều Thêm Xe " + (int.Parse(txt_sotan.Text) - int.Parse(txt_trongluongxe.Text)).ToString() + " Tấn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            ResetControl();


            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (txt_madieuxe.Text.Length > 0)
            {
                EnableControl(true);
                txt_madieuxe.Enabled = false;
                MethodHelper.ClearErrorProvider();

                //cbbRoleId.Items.Clear();
                btn_luu.Enabled = true;
            }
        }  
    

        private void btn_xoa_Click(object sender, EventArgs e)
        {
             if (txt_madieuxe.Text.Length > 0)
            {
                dal_dx.Delete_Dxe(txt_madieuxe.Text.Trim());
                BinbDataGridView_Dieuxe();
                ResetControl();

                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void grv_dieuxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex < 0)
                return;
            //if (e.RowIndex == grv_nhan_vien.Rows.Count-1)
            //    return;
            DTO_DieuXe dieuxe = grv_dieuxe.Rows[e.RowIndex].DataBoundItem as DTO_DieuXe;

            txt_madieuxe.Text = dieuxe.ma_dieu_xe;
            txt_noigiao.Text = dieuxe.noi_giao;
            txt_noinhan.Text = dieuxe.noi_nhan;
            txt_sotan.Text = dieuxe.so_tan;
            cbb_khachhang.SelectedValue = dieuxe.ma_khach_hang.Trim();
            //cbb_soxe.SelectedValue = dieuxe.ma_so_xe.Trim();
            cbb_soxe.Text = grv_dieuxe.Rows[i].Cells["col_sx"].Value.ToString();
           // cbb_soxe.SelectedIndex = 3;
           // MessageBox.Show(dieuxe.ma_so_xe.Trim());
            data_ngaydieuxe.Value = Convert.ToDateTime(dieuxe.ngay_dieu_xe);
            if (grv_dieuxe.Rows[i].Cells["ngay_ve"].Value.ToString().Trim()!="01/01/0001 12:00:00 SA") 
            { 
                dtpngayve.Value = Convert.ToDateTime(dieuxe.ngay_ve); 
                //MessageBox.Show(grv_dieuxe.Rows[i].Cells["ngay_ve"].Value.ToString() );
            };
            cbtinhtrangthanhtoan.SelectedValue = dieuxe.tinh_trang_thanh_toan == "Chưa Thanh Toán" ? 0 : 1;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grv_TTxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex < 0)
                return;
            cbb_soxe.Text = grv_TTxe.Rows[i].Cells["Column1"].Value.ToString();
        }
    }
}

