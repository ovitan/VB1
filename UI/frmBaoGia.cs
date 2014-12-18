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
    public partial class txt_mabaogia : Form
    {
        BLL_BangBaoGia bll_bg = null;
        BLL_HopDong bll_hd = null;
        BLL_DichVu bll_dv = null;
        public txt_mabaogia()
        {
            bll_bg = new BLL_BangBaoGia();
            bll_hd = new BLL_HopDong();
            bll_dv = new BLL_DichVu();
            InitializeComponent();
            txt_ma_bao_gia.Text = bll_bg.Ma_BG();
        }

        private void frmBaoGia_Load(object sender, EventArgs e)
        {
            grv_BG.AutoGenerateColumns = false;
            LoadGridview();
            _Load_Combobox_Hop_Dong();
            Load_cbb_khuvuc_phanvung();
            


            EnableControl(false);
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
        }
        private void LoadGridview()
        {
            grv_BG.DataSource = bll_bg.GetALl_BG();
        }
        private void _Load_Combobox_Hop_Dong()
        {          
            List<DTO_HopDong> hd = new List<DTO_HopDong>();         
            var groups = bll_hd.Ma_HD();
            hd.Add(new DTO_HopDong(){ma_hop_dong="Chọn hợp đồng"});
            hd.AddRange(groups);
            cbb_hopdong.DataSource = hd;
            cbb_hopdong.ValueMember = "ma_hop_dong";
            cbb_hopdong.DisplayMember = "ma_hop_dong";

        }
        private void Load_cbb_khuvuc_phanvung()
        {
            List<DTO_DichVu> dv = new List<DTO_DichVu>();
            var groups = bll_dv.KV_2();
            dv.Add(new DTO_DichVu() { khu_vuc = "Chọn Khu Vực" });
            dv.AddRange(groups);
            cbb_khuvuc.DataSource = dv;
            cbb_khuvuc.ValueMember = "khu_vuc";
            cbb_khuvuc.DisplayMember = "khu_vuc";
        }
        private void Load_cbb_phanvung(DTO_DichVu dv)
        {
            //List<DTO_DichVu> dv1 = new List<DTO_DichVu>();
            //var groups = bll_dv.PV_2(dv);
            //dv1.Add(new DTO_DichVu() { phan_vung = "Chọn Phân Vùng" });
            //dv1.AddRange(groups);
            cbb_phanvung.DataSource = bll_dv.PV_2(dv);           
            cbb_phanvung.ValueMember = "phan_vung";
            cbb_phanvung.DisplayMember = "phan_vung";
        }

        private void cbb_khuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_khuvuc.SelectedText != "Chọn Khu Vực")
            {
                DTO_DichVu dvv = new DTO_DichVu();
                dvv.khu_vuc = cbb_khuvuc.Text.Trim();
                Load_cbb_phanvung(dvv);

            }
        }
        private void EnableControl(bool flag)
        {
            txt_ma_bao_gia.Enabled = flag;
            cbb_khuvuc.Enabled = flag;
            txt_dongiachuyen.Enabled = flag;
            txt_noinhan.Enabled = flag;
            txt_noigiao.Enabled = flag;
            cbb_phanvung.Enabled = flag;
            cbb_hopdong.Enabled = flag;
               cbb_khuvuc.Enabled=flag;
            dtptungay.Enabled = flag;
            dtpdenngay.Enabled = flag;
        }
        private void ResetControl()
        {
            txt_ma_bao_gia.Text = string.Empty;
            txt_dongiachuyen.Text = string.Empty;
            txt_dongiatan.Text = string.Empty;
            txt_noinhan.Text = string.Empty;
            txt_noigiao.Text = string.Empty;
            txt_ghichu.Text = string.Empty;
            dtpdenngay.Value = DateTime.Now;
            dtptungay.Value = DateTime.Now;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;         
            MethodHelper.ClearErrorProvider();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ResetControl();
            txt_ma_bao_gia.Text = bll_bg.Ma_BG();
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_ma_bao_gia.Text.Length > 0)
            {
                EnableControl(true);
                txt_ma_bao_gia.Enabled = false;
                MethodHelper.ClearErrorProvider();

                btn_luu.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_ma_bao_gia.Text.Length > 0)
            {
                bll_bg.Delete_BG(txt_ma_bao_gia.Text.Trim());
                LoadGridview();
                ResetControl();

                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
          // txt_ma_bao_gia.Text = new BLL_BangBaoGia().Ma_BG();// Lay Ma Moi Nhat
            if (!CheckBeforeSave())
                return;
            DTO_BangBaoGia bg = new DTO_BangBaoGia();
            bg.ma_bao_gia = txt_ma_bao_gia.Text;
            bg.noi_giao = txt_noigiao.Text;
            bg.ma_hop_dong = cbb_hopdong.SelectedValue.ToString();
            bg.noi_nhan = txt_noinhan.Text;
            bg.tu_ngay = dtptungay.Value;
            bg.den_ngay = dtpdenngay.Value;
            bg.ghi_chu = txt_ghichu.Text;
            //bg.khu_vuc = cbb_khuvuc.SelectedValue.ToString();
            //bg.phan_vung = cbb_phanvung.SelectedValue.ToString();
            bg.don_gia_chuyen = float.Parse(txt_dongiachuyen.Text);
            bg.don_gia_tan = float.Parse(txt_dongiatan.Text);
            if (dtptungay.Value >= dtpdenngay.Value)
            {
                MessageBox.Show("Thời Gian Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txt_ma_bao_gia.Enabled)
                {
                    bll_bg.Create_BG(bg);
                }
                else
                {
                    bll_bg.Update_BG(bg);
                }
                LoadGridview();
                ResetControl();
                txt_ma_bao_gia.Text = new BLL_BangBaoGia().Ma_BG();

                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
         
         
        }
        private bool CheckBeforeSave()
        {
            bool flag = true;
            if (txt_ma_bao_gia.Enabled && txt_ma_bao_gia.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_ma_bao_gia, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (txt_noigiao.Enabled && txt_noigiao.Text.Length == 0)
            {
                MethodHelper.AddErrorProvider(txt_noigiao, Const.EMPTY_MESSAGE);
                flag = false;
            }
            if (!txt_ma_bao_gia.Enabled && !txt_noigiao.Enabled)
                flag = false;
            return flag;
        }

        private void grv_BG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= e.RowIndex;
            if (e.RowIndex < 0)
                return;
            DTO_BangBaoGia grvbg = grv_BG.Rows[i].DataBoundItem as DTO_BangBaoGia;
            txt_ma_bao_gia.Text = grvbg.ma_bao_gia;
            txt_dongiachuyen.Text =Convert.ToString(grvbg.don_gia_chuyen);
            txt_dongiatan.Text = Convert.ToString(grvbg.don_gia_tan);
            txt_ghichu.Text = grvbg.ghi_chu;
            //cbb_hopdong.SelectedItem= grvbg.ma_hop_dong;
            cbb_hopdong.Text = grv_BG.Rows[i].Cells["colHD"].Value.ToString();
            txt_noigiao.Text = grvbg.noi_giao;
            txt_noinhan.Text = grvbg.noi_nhan;
            //cbb_khuvuc.SelectedItem = grvbg.khu_vuc;
            //cbb_phanvung.SelectedItem = grvbg.phan_vung;
            dtpdenngay.Value =Convert.ToDateTime(grvbg.den_ngay);
            dtptungay.Value = Convert.ToDateTime(grvbg.tu_ngay);

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

        private void cbb_phanvung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonkv = cbb_khuvuc.SelectedValue.ToString().Trim();
            if (cbb_khuvuc.SelectedIndex == 0)
            {
                txt_dongiachuyen.Text = "";
                txt_dongiatan.Text = "";
            }
            else
            {
                DTO_DichVu dto = new DTO_DichVu();
                dto.khu_vuc = cbb_khuvuc.SelectedValue.ToString();
                dto.phan_vung = cbb_phanvung.SelectedValue.ToString();
                List<DTO_DichVu> li = new BLL_DichVu().DOngia_2(dto);
                foreach (DTO_DichVu dg in li)
                {
                        txt_dongiachuyen.Text = dg.don_gia_chuyen.ToString();
                        txt_dongiatan.Text = dg.don_gia_tan.ToString();
                }
            }
        }

        private void cbb_hopdong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
