using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.BLL;
using QLDVVTHH.DTO;

namespace QLDVVTHH.UI
{
    public partial class frmHoaDon : Form
    {
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        public frmHoaDon()
        {
            InitializeComponent();
            _AUTO_COMPLE_MA_KHACH_HANG();
            _combobox_ten_khach_hang();
            _Ma_Hoa_Don();
        }
        private void _Ma_Hoa_Don()
        {
            txtmahoadon.Text=new BLL_HoaDon()._Ma_Hoa_Don();
        }
        private void _AUTO_COMPLE_MA_KHACH_HANG()
        {
            DataTable dt = new BLL_HopDong()._Bang_Ma_Khach_Hang();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    auto.Add(dr["ma_khach_hang"].ToString());
                }
            }
            txtmakhachhang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmakhachhang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmakhachhang.AutoCompleteCustomSource = auto;
        }
        private void _Load_Combobox_Hop_Dong(string makh)
        {
            DTO_HopDong dto = new DTO_HopDong();
            dto.ma_khach_hang = makh;
            cbmahopdong.DataSource = new BLL_BangKe()._List_Hop_Dong(dto);
            cbmahopdong.DisplayMember = "ma_hop_dong";
            cbmahopdong.ValueMember = "ma_hop_dong";
        }

        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text.Trim() != "")
            {
                DTO_KhachHang dto = new DTO_KhachHang();
                dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString();
                _Load_Combobox_Hop_Dong(dto.ma_khach_hang);

            }
            else
            {
                lvhoadon.Items.Clear();
                lvchitiethoadon.Items.Clear();
            }
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

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvhoadon.Items.Clear();
            if (cbkhachhang.Text.Trim() != "")
            {
                txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString();
            }
        }

        private void btntaoma_Click(object sender, EventArgs e)
        {
            _Ma_Hoa_Don();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txtmakhachhang.Text.Trim() == "")
            {
                message += "Chưa Nhập Mã Khách Hàng ";
            }
            if (cbmahopdong.Text.Trim()=="")
            {
                message += string.IsNullOrEmpty(message) ? "" : "-" + " Chưa Nhập Mã Hợp Đồng ";
            }
            if (txtmahoadon.Text.Trim()=="")
            {
                message += string.IsNullOrEmpty(message) ? "" : "-" + " Chưa Nhập Mã Hóa Đơn ";
            }
            if (message == "")
            {
                DTO_HopDong hopdong = new DTO_HopDong();
                hopdong.ma_hop_dong = cbmahopdong.Text.Trim();
                hopdong.ma_khach_hang = txtmakhachhang.Text.Trim();


                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.ma_hoa_don = txtmahoadon.Text.Trim();
                hoadon.ngay_Xuat_hoa_don = dtvngayxuathoadon.Value;
                int i = new BLL_HoaDon()._Lap_Hoa_Hon_Van_Chuyen(hopdong, hoadon);
                if (i == 0)
                {
                    MessageBox.Show("Lập Hóa Đơn Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _List_View_Hoa_Don();
                    txtmahoadon.Text = new BLL_HoaDon()._Ma_Hoa_Don();
                }
                if(i==1)
                {
                    MessageBox.Show("Lập Hóa Đơn Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (i == 2)
                {
                    MessageBox.Show("Mã Hóa Đã Tồn Tại Không Thể Lập Hóa Đơn.Vui Lòng Chọn Mã Hóa Đơn Mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (message != "")
            {
                MessageBox.Show("Bạn " + message + " !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbmahopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmahopdong.Text.Trim() != "")
            {
                _List_View_Hoa_Don();
                DTO_HopDong hd = new DTO_HopDong();
                hd.ma_hop_dong = cbmahopdong.Text.Trim();
                hd.ma_khach_hang = txtmakhachhang.Text.Trim();
                if (new BLL_BangBaoGia()._DS_Date_ThoiGianHopDong(hd) != null)
                {
                    foreach (DTO_HopDong dto in new BLL_BangBaoGia()._DS_Date_ThoiGianHopDong(hd))
                    {
                        dtvngayxuathoadon.Value = dto.ngay_bat_dau;
                    }
                }
            }
        }
        private void _List_View_Hoa_Don()
        {
            lvhoadon.Items.Clear();
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.ma_khach_hang = txtmakhachhang.Text.Trim();
            hoadon.ma_hop_dong = cbmahopdong.Text.Trim();
            int STT = 1;
            if (new BLL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon) != null && new BLL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon).Count()>0)
            {
                foreach (DTO_HoaDon hd in new BLL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon))
                {
                    ListViewItem list = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(list,hd.ma_hoa_don.Trim());
                    list.SubItems.Add(lv1);
                    ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(list, hd.tong_cuot_van_chuyen.ToString("###,###,###"));
                    list.SubItems.Add(lv2);
                    ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(list, hd.theu.ToString("###,###,###"));
                    list.SubItems.Add(lv3);
                    ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(list, hd.tong_cong.ToString("###,###,###"));
                    list.SubItems.Add(lv4);
                    ListViewItem.ListViewSubItem lv5 = new ListViewItem.ListViewSubItem(list, hd.ngay_Xuat_hoa_don.ToShortDateString());
                    list.SubItems.Add(lv5);
                    

                    lvhoadon.Items.Add(list);
                    STT++;
                }
            }
            lvchitiethoadon.Items.Clear();
        }
        private void _List_View_Chi_Tiet_Hoa_Don(string mahoadon,string makh)
        {
            lvchitiethoadon.Items.Clear();
            int STT = 1;
            float tongcong = 0;
            DTO_Chi_Tiet_Hoa_Don ct = new DTO_Chi_Tiet_Hoa_Don();
            ct.ma_hoa_don = mahoadon.ToString();
            ct.ma_khach_hang = makh;
            if (new BLL_HoaDon()._List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct) != null)
            {
                foreach (DTO_BangKe dto in new BLL_HoaDon()._List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct))
                {
                    ListViewItem lvi = new ListViewItem(STT.ToString());
                    ListViewItem.ListViewSubItem ite1 = new ListViewItem.ListViewSubItem(lvi, dto.ma_bang_ke);
                    lvi.SubItems.Add(ite1);
                    ListViewItem.ListViewSubItem ite2 = new ListViewItem.ListViewSubItem(lvi, dto.ngay_van_chuyen.ToShortDateString());
                    lvi.SubItems.Add(ite2);
                    ListViewItem.ListViewSubItem ite22 = new ListViewItem.ListViewSubItem(lvi, dto.ma_dieu_xe.Trim());
                    lvi.SubItems.Add(ite22);
                    ListViewItem.ListViewSubItem ite3 = new ListViewItem.ListViewSubItem(lvi, dto.so_xe);
                    lvi.SubItems.Add(ite3);
                    ListViewItem.ListViewSubItem ite4 = new ListViewItem.ListViewSubItem(lvi, dto.noi_nhan);
                    lvi.SubItems.Add(ite4);
                    ListViewItem.ListViewSubItem ite5 = new ListViewItem.ListViewSubItem(lvi, dto.noi_giao);
                    lvi.SubItems.Add(ite5);
                    ListViewItem.ListViewSubItem ite6 = new ListViewItem.ListViewSubItem(lvi, dto.khoi_luong.ToString());
                    lvi.SubItems.Add(ite6);
                    ListViewItem.ListViewSubItem ite7 = new ListViewItem.ListViewSubItem(lvi, dto.don_gia_chuyen.ToString("###,###,###"));
                    lvi.SubItems.Add(ite7);
                    ListViewItem.ListViewSubItem ite8 = new ListViewItem.ListViewSubItem(lvi, dto.don_gia_tan.ToString("###,###,###"));
                    lvi.SubItems.Add(ite8);
                    ListViewItem.ListViewSubItem ite9 = new ListViewItem.ListViewSubItem(lvi, ( dto.don_gia_chuyen  + (dto.khoi_luong > 15 ? ((dto.khoi_luong - 15) * dto.don_gia_tan) : 0)).ToString("###,###,###"));
                    lvi.SubItems.Add(ite9);
                    ListViewItem.ListViewSubItem ite10 = new ListViewItem.ListViewSubItem(lvi, dto.ghi_chu);
                    lvi.SubItems.Add(ite10);

                    lvchitiethoadon.Items.Add(lvi);
                    STT++;
                    tongcong += (dto.don_gia_chuyen  + (dto.khoi_luong > 15 ? ((dto.khoi_luong - 15) * dto.don_gia_tan) : 0));
                }
            }
            lvchitiethoadon.View = View.Details;
            _Tinh_TongCong_Thue_ThanhTien("Tổng Cộng", tongcong);
            _Tinh_TongCong_Thue_ThanhTien("Thếu 10%", tongcong * 10 / 100);
            _Tinh_TongCong_Thue_ThanhTien("Tổng Thành Tiền", tongcong + (tongcong * 10 / 100));
        }
        private void _Tinh_TongCong_Thue_ThanhTien(string tengiatri, float giatri)
        {
            if (lvchitiethoadon.Items.Count > 0)
            {
                ListViewItem MA = new ListViewItem("");
                MA.UseItemStyleForSubItems = false;

                ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv1);
                ListViewItem.ListViewSubItem lv11 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv11);
                ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv2);
                ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv3);
                ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv4);
                ListViewItem.ListViewSubItem lv5 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv5);
                ListViewItem.ListViewSubItem lv6 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv6);
                ListViewItem.ListViewSubItem lv7 = new ListViewItem.ListViewSubItem(MA, "");
                MA.SubItems.Add(lv7);
                ListViewItem.ListViewSubItem lv8 = new ListViewItem.ListViewSubItem(MA, tengiatri);
                MA.SubItems.Add(lv8);



                lv8.ForeColor = System.Drawing.Color.Blue;
                lv8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lv9 = new ListViewItem.ListViewSubItem(MA, giatri.ToString("###,###,###"));
                MA.SubItems.Add(lv9);

                lv9.ForeColor = System.Drawing.Color.Red;
                lv9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lv10 = new ListViewItem.ListViewSubItem(MA, "VNĐ");
                MA.SubItems.Add(lv10);

                lv10.ForeColor = System.Drawing.Color.Red;
                lv10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                lvchitiethoadon.Items.Add(MA);

            }
        }

        private void lvhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvhoadon.Items)
            {
                if (item.Selected)
                {
                     txtmahoadon.Text = item.SubItems[1].Text;
                    _List_View_Chi_Tiet_Hoa_Don(item.SubItems[1].Text,cbkhachhang.SelectedValue.ToString());
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmahoadon.Text.Trim() != "")
            {
               DialogResult kq= MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Mã Hóa Đơn : " +txtmahoadon.Text.Trim() +" !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (kq == DialogResult.Yes)
               {
                   DTO_HoaDon hoadon = new DTO_HoaDon();
                   hoadon.ma_hoa_don = txtmahoadon.Text.Trim();
                   int i = new BLL_HoaDon()._Xoa_Hoa_Don_Van_Chuyen(hoadon);
                   if (i == 0)
                   {
                       MessageBox.Show("Xóa Hóa Đơn Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       _List_View_Hoa_Don();
                       lvchitiethoadon.Items.Clear();
                   }
                   else
                   {
                       MessageBox.Show("Xóa Hóa Đơn Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
               }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Hóa Đơn Cần Xóa !","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mntsxoalv_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa  Hóa Đơn!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvhoadon.Items)
                {
                    if (item.Selected)
                    {
                        DTO_HoaDon hoadon = new DTO_HoaDon();
                        hoadon.ma_hoa_don = item.SubItems[1].Text;
                        int i = new BLL_HoaDon()._Xoa_Hoa_Don_Van_Chuyen(hoadon);
                        if (i == 0)
                        {

                        }
                    }
                }
                _List_View_Hoa_Don();
                lvchitiethoadon.Items.Clear();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            lvhoadon.Items.Clear();
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.ma_khach_hang = txtmakhachhang.Text.Trim();
            hoadon.ma_hop_dong = cbmahopdong.Text.Trim();
            hoadon.ma_hoa_don = txtmahoadon.Text.Trim();
            int STT = 1;
            if (new BLL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon) != null && new BLL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon).Count() > 0)
            {
                foreach (DTO_HoaDon hd in new BLL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon))
                {
                    ListViewItem list = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(list, hd.ma_hoa_don.Trim());
                    list.SubItems.Add(lv1);
                    ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(list, hd.tong_cuot_van_chuyen.ToString("###,###,###"));
                    list.SubItems.Add(lv2);
                    ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(list, hd.theu.ToString("###,###,###"));
                    list.SubItems.Add(lv3);
                    ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(list, hd.tong_cong.ToString("###,###,###"));
                    list.SubItems.Add(lv4);
                    ListViewItem.ListViewSubItem lv5 = new ListViewItem.ListViewSubItem(list, hd.ngay_Xuat_hoa_don.ToShortDateString());
                    list.SubItems.Add(lv5);

                    lvhoadon.Items.Add(list);
                    STT++;
                }
            }
        }

        private void btncongno_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (ListViewItem item in lvhoadon.Items)
            {
                if (item.Selected)
                {
                    DialogResult kq = MessageBox.Show("Bạn Muôn Thêm Mã Hóa Đơn : " + item.SubItems[1].Text + " Vào Công Nợ Khách Hàng !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        if (txtmakhachhang.Text.Trim() == "")
                        {
                            message += "Chưa Nhập Mã Khách Hàng ";
                        }
                        if (cbmahopdong.Text.Trim() == "")
                        {
                            message += string.IsNullOrEmpty(message) ? "" : "-";
                            message += " Chưa Chọn Mã Hợp Đồng";
                        }
                        DTO_HoaDon hd = new DTO_HoaDon();
                        hd.ma_hoa_don = item.SubItems[1].Text;
                        hd.ma_khach_hang = txtmakhachhang.Text.Trim();
                        if (new BLL_CongNo()._check_ma_hoa_don_cong_no(hd) == 1)
                        {
                            message += string.IsNullOrEmpty(message) ? "" : "-";
                            message += " Mã Hóa Đơn Đã Lưu Vào Công Nợ Khách Hàng ";
                        }
                        if (message != "")
                        {
                            MessageBox.Show(" " + message + "!", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (message == "")
                        {
                            DTO_HoaDon hoadon = new DTO_HoaDon();
                            hoadon.ma_khach_hang = txtmakhachhang.Text.Trim();
                            hoadon.ma_hop_dong = cbmahopdong.Text.Trim();
                            hoadon.ma_hoa_don = item.SubItems[1].Text;

                            DTO_CongNo congno = new DTO_CongNo();
                            congno.ma_cong_no = new BLL_CongNo()._Ma_Cong_No();

                            int i = new BLL_CongNo()._Them_Cong_No_Khach_Hang(hoadon, congno);
                            if (i == 0)
                            {
                                MessageBox.Show("Thêm Công Nợ Thành Công! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm Công Nợ Thất Bại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
    }
}
