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
    public partial class uchoadon : UserControl
    {
        public uchoadon()
        {
            InitializeComponent();
            _combobox_ten_khach_hang();
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
            uc.strReport = "rpthoadon.rdlc";
            if (cbhoadon.Text.Trim() != "")
            {
                DTO_HoaDon dto = new DTO_HoaDon();
                dto.ma_hoa_don = cbhoadon.Text.Trim();
                new BLL_INAN()._Luu_Data_Hoa_Don(dto);
            }
            uc.MdiParent = Main.ActiveForm;
            uc.Show();
        }
        private void _combobox_ten_khach_hang()
        {
            DataTable dt = new BLL_BangKe()._List_Ten_Khach_Hang();
            DataRow row = dt.NewRow();
            row["ten_khach_hang"] = "";
            row["ma_khach_hang"] = "";
            dt.Rows.InsertAt(row, 0);

            cbkhachhang.DisplayMember = "ten_khach_hang";
            cbkhachhang.ValueMember = "ma_khach_hang";
            cbkhachhang.DataSource = dt;



            cbkhachhang.SelectedIndex = 0;
        }
        private void _Load_Combobox_Hop_Dong(string makh)
        {
            DTO_HopDong dto = new DTO_HopDong();
            dto.ma_khach_hang = makh;
            cbhopdong.DataSource = new BLL_BangKe()._List_Hop_Dong(dto);
            cbhopdong.DisplayMember = "ma_hop_dong";
            cbhopdong.ValueMember = "ma_hop_dong";
        }
        private void cbhopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbhopdong.Text.Trim() != "")
            {
                _Load_Combobox_Hoa_Don();
            }
        }
        private void _Load_Combobox_Hoa_Don()
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.ma_khach_hang = cbkhachhang.SelectedValue.ToString();
            hoadon.ma_hop_dong = cbhopdong.SelectedValue.ToString();
            cbhoadon.DataSource = new BLL_HoaDon()._List_Hoa_Don(hoadon);
            cbhoadon.DisplayMember = "ma_hoa_don";
            cbhoadon.ValueMember = "ma_hoa_don";
        }

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkhachhang.Text.Trim() != "")
            {
                _Load_Combobox_Hop_Dong(cbkhachhang.SelectedValue.ToString());
            }
        }
    }
}
