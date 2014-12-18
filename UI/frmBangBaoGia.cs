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
    public partial class frmBangBaoGia : Form
    {
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        public frmBangBaoGia()
        {
            //InitializeComponent();
            //_combobox_ten_khach_hang();
            //_AUTO_COMPLE_MA_KHACH_HANG();
            //txtmabaogia.Text = new BLL_BangBaoGia()._Ma_Bang_Bao_Gia();
            //_Load_Combobox_Noi_Giao();
        }
        private void frmBangBaoGia_Load(object sender, EventArgs e)
        {

        }

        //private void _Load_Combobox_Hop_Dong(string makh)
        //{
        //    DTO_HopDong dto = new DTO_HopDong();
        //    dto.ma_khach_hang = makh;
        //    cbhopdong.DataSource = new BLL_BangKe()._List_Hop_Dong(dto);
        //    cbhopdong.DisplayMember = "ma_hop_dong";
        //    cbhopdong.ValueMember = "ma_hop_dong";
        //}

        //private void _Load_Combobox_Noi_Nhan()
        //{
        //    if (txtmakhachhang.Text.Trim() != "")
        //    {
        //        DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //        dto.ma_bao_gia = txtmakhachhang.Text.Trim();
        //        dto.ma_hop_dong = cbhopdong.Text.Trim();
        //        dto.tu_ngay = dtptungay.Value;
        //        dto.den_ngay = dtpdenngay.Value;
        //        cbnoinhan.DataSource = new BLL_BangBaoGia()._DS_Combobox_Noi_Nhan(dto);
        //        cbnoinhan.DisplayMember = "noi_nhan";
        //        cbnoinhan.ValueMember = "noi_nhan";
        //    }
        //}

        //private void _Load_Combobox_Noi_Giao()
        //{
        //    if (txtmakhachhang.Text.Trim() != "" && cbnoinhan.Text.Trim() != "")
        //    {
        //        DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //        dto.ma_bao_gia = txtmakhachhang.Text.Trim();
        //        dto.ma_hop_dong = cbhopdong.Text.Trim();
        //        dto.tu_ngay = dtptungay.Value;
        //        dto.den_ngay = dtpdenngay.Value;
        //        dto.noi_nhan = cbnoinhan.Text.Trim();
        //        cbnoigiao.DataSource = new BLL_BangBaoGia()._DS_Combobox_Noi_Giao(dto);
        //        cbnoigiao.DisplayMember = "noi_giao";
        //        cbnoigiao.ValueMember = "noi_giao";
        //    }
        //}

        //private void _AUTO_COMPLE_MA_KHACH_HANG()
        //{
        //    DataTable dt = new BLL_HopDong()._Bang_Ma_Khach_Hang();
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            auto.Add(dr["ma_khach_hang"].ToString());
        //        }
        //    }
        //    txtmakhachhang.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    txtmakhachhang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txtmakhachhang.AutoCompleteCustomSource = auto;
        //}

        //private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    lvthongtinbaogia.Items.Clear();
        //    if (cbkhachhang.Text.Trim() != "")
        //    {
        //        txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString();
        //    }
        //}

        //private void _combobox_ten_khach_hang()
        //{
        //    DataTable dt = new BLL_BangKe()._List_Ten_Khach_Hang();
        //    DataRow row = dt.NewRow();
        //    row["ten_khach_hang"] = "";
        //    row["ma_khach_hang"] = "";
        //    dt.Rows.InsertAt(row, 0);

        //    cbkhachhang.DisplayMember = "ten_khach_hang";
        //    cbkhachhang.ValueMember = "ma_khach_hang";
        //    cbkhachhang.DataSource = dt;



        //    cbkhachhang.SelectedIndex = 0;
        //}

        //private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtmakhachhang.Text.Trim() != "")
        //    {
        //        DTO_KhachHang dto = new DTO_KhachHang();
        //        dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString();
        //        _Load_Combobox_Hop_Dong(dto.ma_khach_hang);

        //    }
        //    else
        //    {
        //        lvthongtinbaogia.Items.Clear();
        //    }
        //}

        //private void btnthoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btntaoma_Click(object sender, EventArgs e)
        //{
        //    txtmabaogia.Text = new BLL_BangBaoGia()._Ma_Bang_Bao_Gia();
        //}

        //private void txtdongiachuyen_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == 54) { }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtdongiatan_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == 54) { }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}

       

        //private void dtpdenngay_ValueChanged(object sender, EventArgs e)
        //{
        //    _Load_Combobox_Noi_Nhan();
        //}

        //private void cbnoinhan_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _Load_Combobox_Noi_Giao();
        //}

        //private void btnthem_Click(object sender, EventArgs e)
        //{
        //    string message = "";
        //    if (txtmakhachhang.Text.Trim() == "")
        //    {
        //        message += " Chưa Nhập Mã Khách Hàng ";
        //    }
        //    if (txtmabaogia.Text.Trim() == "")
        //    {
        //        message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Mã Báo Giá ";
        //    }
        //    if (cbnoinhan.Text.Trim() == "")
        //    {
        //        message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Nơi Nhận ";
        //    }
        //    if (cbnoigiao.Text.Trim() == "")
        //    {
        //        message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Nơi Giao ";
        //    }
        //    if (txtdongiachuyen.Text.Trim() == "")
        //    {
        //        message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Đơn Giá Chuyến ";
        //    }
        //    if (txtdongiatan.Text.Trim() == "")
        //    {
        //        message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Đơn Giá Tấn ";
        //    }
        //    if (message == "")
        //    {
        //        DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //        dto.ma_bao_gia = txtmabaogia.Text.Trim();
        //        dto.ma_hop_dong = cbhopdong.Text.Trim();
        //        dto.tu_ngay = dtptungay.Value;
        //        dto.den_ngay = dtpdenngay.Value;
        //        dto.noi_nhan = cbnoinhan.Text.Trim();
        //        dto.noi_giao = cbnoigiao.Text.Trim();
        //        dto.don_gia_chuyen = float.Parse(txtdongiachuyen.Text.Trim());
        //        dto.don_gia_tan = float.Parse(txtdongiatan.Text.Trim());
        //        dto.ngay_tao = DateTime.Now;
        //        dto.ngay_cap_nhat = DateTime.Now;


        //        int insert = new BLL_BangBaoGia()._Them_BaoGia(dto);

        //        if (insert == 1)
        //        {
        //            MessageBox.Show("Mã Bản Báo Giá Đã Tồn Tại Không Thể Thêm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        if (insert == 2)
        //        {
        //            MessageBox.Show("Thêm Báo Giá Thất Bại !Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        if (insert == 0)
        //        {

        //            MessageBox.Show("Thêm Báo Giá Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            _Add_ListView_DanhSachBaoGia();
        //            _Load_Combobox_Noi_Giao();
        //            txtmabaogia.Text = new BLL_BangBaoGia()._Ma_Bang_Bao_Gia();

        //        }
        //    }
        //    if (message != "")
        //    {
        //        MessageBox.Show("Bạn" + message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void _Add_ListView_DanhSachBaoGia()
        //{
        //    lvthongtinbaogia.Items.Clear();
        //    DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //    dto.ma_bao_gia = txtmakhachhang.Text.Trim();
        //    dto.ma_hop_dong = cbhopdong.Text.Trim();
        //    int STT = 1;
        //    if (new BLL_BangBaoGia()._DS_ListView_BangBaoGia(dto) != null)
        //    {
        //        foreach (DTO_BangBaoGia dto_bg in new BLL_BangBaoGia()._DS_ListView_BangBaoGia(dto))
        //        {
        //            ListViewItem lvi = new ListViewItem(STT.ToString());
        //            ListViewItem.ListViewSubItem ite1 = new ListViewItem.ListViewSubItem(lvi, dto_bg.ma_bao_gia);
        //            lvi.SubItems.Add(ite1);
        //            ListViewItem.ListViewSubItem ite2 = new ListViewItem.ListViewSubItem(lvi, dto_bg.ma_hop_dong.ToString());
        //            lvi.SubItems.Add(ite2);
        //            ListViewItem.ListViewSubItem ite3 = new ListViewItem.ListViewSubItem(lvi, dto_bg.noi_nhan);
        //            lvi.SubItems.Add(ite3);
        //            ListViewItem.ListViewSubItem ite4 = new ListViewItem.ListViewSubItem(lvi, dto_bg.noi_giao);
        //            lvi.SubItems.Add(ite4);
        //            ListViewItem.ListViewSubItem ite5 = new ListViewItem.ListViewSubItem(lvi, dto_bg.tu_ngay.ToShortDateString());
        //            lvi.SubItems.Add(ite5);
        //            ListViewItem.ListViewSubItem ite6 = new ListViewItem.ListViewSubItem(lvi, dto_bg.den_ngay.ToShortDateString());
        //            lvi.SubItems.Add(ite6);
        //            ListViewItem.ListViewSubItem ite7 = new ListViewItem.ListViewSubItem(lvi, dto_bg.don_gia_chuyen.ToString("###,###,###"));
        //            lvi.SubItems.Add(ite7);
        //            ListViewItem.ListViewSubItem ite8 = new ListViewItem.ListViewSubItem(lvi, dto_bg.don_gia_tan.ToString("###,###,###"));
        //            lvi.SubItems.Add(ite8);
        //            ListViewItem.ListViewSubItem ite9 = new ListViewItem.ListViewSubItem(lvi, dto_bg.ngay_tao.ToShortDateString());
        //            lvi.SubItems.Add(ite9);
        //            ListViewItem.ListViewSubItem ite10 = new ListViewItem.ListViewSubItem(lvi, dto_bg.ngay_cap_nhat.ToShortDateString());
        //            lvi.SubItems.Add(ite10);

        //            lvthongtinbaogia.Items.Add(lvi);
        //            STT++;
        //        }
        //    }
        //    lvthongtinbaogia.View = View.Details;
        //}

        //private void cbhopdong_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbhopdong.Text.Trim() != "")
        //    {
        //        DTO_HopDong hd = new DTO_HopDong();
        //        hd.ma_hop_dong = cbhopdong.Text.Trim();
        //        hd.ma_khach_hang = txtmakhachhang.Text.Trim();
        //        if (new BLL_BangBaoGia()._DS_Date_ThoiGianHopDong(hd) != null)
        //        {
        //            foreach (DTO_HopDong dto in new BLL_BangBaoGia()._DS_Date_ThoiGianHopDong(hd))
        //            {
        //                dtptungay.Value = dto.ngay_bat_dau;
        //                dtpdenngay.Value = dto.ngay_ket_thuc;
        //            }
        //        }
        //        _Add_ListView_DanhSachBaoGia();
        //    }
        //}

        //private void btnxoa_Click(object sender, EventArgs e)
        //{
        //    if (txtmabaogia.Text.Trim() != "")
        //    {
        //        DialogResult kq = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Mã Báo Giá : " + txtmabaogia.Text.Trim() + "!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (kq == DialogResult.OK)
        //        {
        //            DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //            dto.ma_bao_gia = txtmabaogia.Text.Trim();
        //            int i = new BLL_BangBaoGia()._Xoa_BaoGia(dto);
        //            if (i == 0)
        //            {
        //                _Add_ListView_DanhSachBaoGia();
        //                _Load_Combobox_Noi_Giao();
        //            }
        //            if (i == 1)
        //            {
        //                MessageBox.Show(" Xóa Mã Báo Giá : " + txtmabaogia.Text.Trim() + " Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //}

        //private void btncapnhat_Click(object sender, EventArgs e)
        //{
        //    if (txtmabaogia.Text != "" && txtmabaogia.Text.Trim() != new BLL_BangBaoGia()._Ma_Bang_Bao_Gia())
        //    {
        //        DialogResult kq = MessageBox.Show("Bạn Muốn Cập Nhật Thông Tin Mã Báo Giá : " + txtmabaogia.Text.Trim() + "!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (kq == DialogResult.OK)
        //        {
        //            DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //            dto.ma_bao_gia = txtmabaogia.Text.Trim();
        //            dto.don_gia_chuyen = float.Parse("0" + txtdongiachuyen.Text.Trim());
        //            dto.don_gia_tan = float.Parse("0" + txtdongiatan.Text.Trim());
        //            int i = new BLL_BangBaoGia()._CapNhat_BaoGia(dto);
        //            if (i == 1)
        //            {
        //                MessageBox.Show(" Cập Nhật Mã Báo Giá : " + txtmabaogia.Text.Trim() + " Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                _Add_ListView_DanhSachBaoGia();
        //            }
        //        }
        //    }
        //}

        //private void mnxoa_Click(object sender, EventArgs e)
        //{
        //    DialogResult kq = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (kq == DialogResult.OK)
        //    {
        //        foreach (ListViewItem item in lvthongtinbaogia.Items)
        //        {
        //            if (item.Selected)
        //            {
        //                DTO_BangBaoGia dto = new DTO_BangBaoGia();
        //                dto.ma_bao_gia = item.SubItems[1].Text;
        //                int i = new BLL_BangBaoGia()._Xoa_BaoGia(dto);
        //            }
        //        }
        //        _Add_ListView_DanhSachBaoGia();
        //        _Load_Combobox_Noi_Giao();
        //    }
        //}

        //private void lvthongtinbaogia_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    foreach (ListViewItem item in lvthongtinbaogia.Items)
        //    {
        //        if (item.Selected)
        //        {
        //            cbhopdong.SelectedValue = item.SubItems[2].Text;
        //            txtmabaogia.Text = item.SubItems[1].Text;
        //            txtdongiachuyen.Text = item.SubItems[7].Text;
        //            txtdongiatan.Text = item.SubItems[8].Text;
        //            dtptungay.Value = Convert.ToDateTime(item.SubItems[5].Text);
        //            dtpdenngay.Value = Convert.ToDateTime(item.SubItems[6].Text);
        //        }
        //    }
        //}

        //private void btnapdung_Click(object sender, EventArgs e)
        //{
        //    if (txtmakhachhang.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (txtmabaogia.Text.Trim() != "")
        //    {
        //        DialogResult kq = MessageBox.Show("Bạn Muốn Áp Dụng Mã Báo Giá : " + txtmabaogia.Text + " Vào Bảng Kê!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (kq == DialogResult.OK)
        //        {
        //            DTO_BangBaoGia baogia = new DTO_BangBaoGia();
        //            baogia.ma_bao_gia = txtmabaogia.Text.Trim();

        //            DTO_HopDong hopdong = new DTO_HopDong();
        //            hopdong.ma_hop_dong = cbhopdong.Text.Trim();
        //            hopdong.ma_khach_hang = txtmakhachhang.Text.Trim();

        //            int i = new BLL_BangBaoGia()._ApDungBaoGia_BangKe(hopdong, baogia);

        //            if (i == 0)
        //            {
        //                MessageBox.Show("Áp Dụng Báo Giá Vào Bảng Kê Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Áp Dụng Báo Giá Vào Bảng Kê Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //}

        //private void apToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (txtmakhachhang.Text.Trim() != "")
        //    {
        //        DialogResult kq = MessageBox.Show("Bạn Muốn Áp Dụng Mã Báo Giá : " + txtmabaogia.Text + " Vào Bảng Kê!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (kq == DialogResult.OK)
        //        {
        //            foreach (ListViewItem item in lvthongtinbaogia.Items)
        //            {
        //                if (item.Selected)
        //                {

        //                    DTO_BangBaoGia baogia = new DTO_BangBaoGia();
        //                    baogia.ma_bao_gia = item.SubItems[1].Text;

        //                    DTO_HopDong hopdong = new DTO_HopDong();
        //                    hopdong.ma_hop_dong = item.SubItems[2].Text;
        //                    hopdong.ma_khach_hang = txtmakhachhang.Text.Trim();

        //                    int i = new BLL_BangBaoGia()._ApDungBaoGia_BangKe(hopdong, baogia);

        //                    if (i == 0)
        //                    {

        //                    }

        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
