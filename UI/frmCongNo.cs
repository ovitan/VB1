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
    public partial class frmCongNo : Form
    {
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

        private float _TongTien_Thanh_Toan = 0;

        public frmCongNo()
        {
            InitializeComponent();
            _AUTO_COMPLE_MA_KHACH_HANG();
            _combobox_ten_khach_hang();
            _Ma_Cong_No();
        }

        private void _Ma_Cong_No()
        {
            txtmacongno.Text = new BLL_CongNo()._Ma_Cong_No();
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
            cbmahopdong.DataSource = new BLL_BangKe()._List_Hop_Dong(dto);
            cbmahopdong.DisplayMember = "ma_hop_dong";
            cbmahopdong.ValueMember = "ma_hop_dong";
        }

        private void _Load_Combobox_Hoa_Don()
        {
            DTO_HoaDon hoadon = new DTO_HoaDon();
            hoadon.ma_khach_hang = txtmakhachhang.Text.Trim();
            hoadon.ma_hop_dong = cbmahopdong.Text.Trim();
            cbhoadon.DataSource = new BLL_CongNo()._List_Hoa_Don(hoadon);
            cbhoadon.DisplayMember = "ma_hoa_don";
            cbhoadon.ValueMember = "tong_cuot_van_chuyen";
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

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkhachhang.Text.Trim() != "")
            {
                lvcongno.Items.Clear();
                lvthanhtoan.Items.Clear();
                txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString();
            }
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
                lvcongno.Items.Clear();
                lvthanhtoan.Items.Clear();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmahopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text.Trim() != "" && cbmahopdong.Text.Trim() != "")
            {
                _Load_Combobox_Hoa_Don();
                _Load_List_View_Thanh_Toan();
                _Load_List_View_Cong_No();

            }
        }

        private void cbhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbhoadon.Text.Trim() != "")
            {
                txtsotien.Text = float.Parse(cbhoadon.SelectedValue.ToString()).ToString("###,###,###");
                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.ma_khach_hang = txtmakhachhang.Text.Trim();
                hoadon.ma_hop_dong = cbmahopdong.Text.Trim();
                foreach(DTO_HoaDon hd in new BLL_CongNo()._List_Hoa_Don(hoadon))
                {
                    if (hd.ma_hoa_don.Trim() == cbhoadon.Text.Trim())
                    {
                        //dtpngayxuathoadon.Value = hd.ngay_tao;
                    }
                }
            }
        }

        private void btnluucongno_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txtmakhachhang.Text.Trim()=="")
            {
                message += "Chưa Nhập Mã Khách Hàng ";
            }
            if (cbmahopdong.Text.Trim() == "")
            {
                message += string.IsNullOrEmpty(message) ? "" : "-";
                message += " Chưa Chọn Mã Hợp Đồng";
            }
            if (txtmacongno.Text.Trim() == "")
            {
                message += string.IsNullOrEmpty(message) ? "" : "-";
                message += " Chưa Nhập Mã Công Nơ";
            }
            if ( cbhoadon.Text.Trim() == "")
            {
                message += string.IsNullOrEmpty(message) ? "" : "-";
                message += " Chưa Chọn Mã Hóa Đơn ";
            }
            if(message!="")
            {
                MessageBox.Show("Bạn "+message+"!", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (message == "")
            {
                DTO_HoaDon hoadon = new DTO_HoaDon();
                hoadon.ma_khach_hang = txtmakhachhang.Text.Trim();
                hoadon.ma_hop_dong = cbmahopdong.Text.Trim();
                hoadon.ma_hoa_don = cbhoadon.Text.Trim();

                DTO_CongNo congno = new DTO_CongNo();
                congno.ma_cong_no = txtmacongno.Text.Trim();

                int i = new BLL_CongNo()._Them_Cong_No_Khach_Hang(hoadon, congno);
                if (i == 0)
                {
                    MessageBox.Show("Thêm Công Nợ Thành Công! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Ma_Cong_No();
                    _Load_List_View_Thanh_Toan();
                    _Load_List_View_Cong_No();
                }
                else
                {
                    MessageBox.Show("Thêm Công Nợ Thất Bại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btntaoma_Click(object sender, EventArgs e)
        {
            _Ma_Cong_No();
        }

        private void _Load_List_View_Cong_No()
        {
            if (txtmakhachhang.Text.Trim() != "")
            {
                lvcongno.Items.Clear();
                
                DTO_CongNo congno = new DTO_CongNo();
                congno.ma_khach_hang = txtmakhachhang.Text.Trim();
                congno.ma_cong_no = cbmahopdong.Text.Trim();
                int STT = 1;
                float tongcongno = 0;
                if (new BLL_CongNo()._List_View_Cong_No_Khach_Hang(congno) != null)
                {
                    foreach (DTO_CongNo co in new BLL_CongNo()._List_View_Cong_No_Khach_Hang(congno))
                    {
                        ListViewItem item = new ListViewItem(STT.ToString());

                        ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(item, co.ngay_xuat_hd.ToShortDateString());
                        item.SubItems.Add(lv1);

                        ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(item, co.ma_hoa_don.Trim());
                        item.SubItems.Add(lv2);

                        ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(item, co.so_tien_thanh_toan.ToString("###,###,###"));
                        item.SubItems.Add(lv3);

                        ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(item, "VNĐ");
                        item.SubItems.Add(lv4);

                        lvcongno.Items.Add(item);
                        STT++;
                        tongcongno += co.so_tien_thanh_toan;
                    }
                }

                ListViewItem itemm = new ListViewItem("");
                itemm.UseItemStyleForSubItems = false;

                ListViewItem.ListViewSubItem lvv1 = new ListViewItem.ListViewSubItem(itemm, "");
                itemm.SubItems.Add(lvv1);

                ListViewItem.ListViewSubItem lvv2 = new ListViewItem.ListViewSubItem(itemm, "Tổng Cộng");
                itemm.SubItems.Add(lvv2);
                lvv2.ForeColor = System.Drawing.Color.Blue;
                lvv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv3 = new ListViewItem.ListViewSubItem(itemm, tongcongno.ToString("###,###,###"));
                itemm.SubItems.Add(lvv3);
                lvv3.ForeColor = System.Drawing.Color.Red;
                lvv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv4 = new ListViewItem.ListViewSubItem(itemm, "VNĐ");
                itemm.SubItems.Add(lvv4);
                lvv4.ForeColor = System.Drawing.Color.Red;
                lvv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);
                lvcongno.Items.Add(itemm);
                //TONG TIEN THANH TOAN 
                ListViewItem itemm2 = new ListViewItem("");
                itemm2.UseItemStyleForSubItems = false;

                ListViewItem.ListViewSubItem lvv12 = new ListViewItem.ListViewSubItem(itemm2, "");
                itemm2.SubItems.Add(lvv12);

                ListViewItem.ListViewSubItem lvv22 = new ListViewItem.ListViewSubItem(itemm2, "Tổng Tiền Thanh Toán");
                itemm2.SubItems.Add(lvv22);
                lvv22.ForeColor = System.Drawing.Color.Blue;
                lvv22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv32 = new ListViewItem.ListViewSubItem(itemm2, _TongTien_Thanh_Toan.ToString("###,###,###"));
                itemm2.SubItems.Add(lvv32);
                lvv32.ForeColor = System.Drawing.Color.Red;
                lvv32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv42 = new ListViewItem.ListViewSubItem(itemm2, "VNĐ");
                itemm2.SubItems.Add(lvv42);
                lvv42.ForeColor = System.Drawing.Color.Red;
                lvv42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                lvcongno.Items.Add(itemm2);
                //TONG TIEN CON LAI
                ListViewItem itemm3 = new ListViewItem("");
                itemm3.UseItemStyleForSubItems = false;

                ListViewItem.ListViewSubItem lvv13 = new ListViewItem.ListViewSubItem(itemm3, "");
                itemm3.SubItems.Add(lvv13);

                ListViewItem.ListViewSubItem lvv23 = new ListViewItem.ListViewSubItem(itemm3, "Số Tiền Còn Lại");
                itemm3.SubItems.Add(lvv23);
                lvv23.ForeColor = System.Drawing.Color.Blue;
                lvv23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv33 = new ListViewItem.ListViewSubItem(itemm3, (tongcongno - _TongTien_Thanh_Toan).ToString("###,###,###"));
                itemm3.SubItems.Add(lvv33);
                lvv33.ForeColor = System.Drawing.Color.Red;
                lvv33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv43 = new ListViewItem.ListViewSubItem(itemm3, "VNĐ");
                itemm3.SubItems.Add(lvv42);
                lvv43.ForeColor = System.Drawing.Color.Red;
                lvv43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);



                lvcongno.Items.Add(itemm3);
                _TongTien_Thanh_Toan = 0;
            }
        }

        private void mnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvcongno.Items)
            {
                if (item.Selected && item.SubItems[0].Text.Trim() != "")
                {
                    DialogResult kq = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Mã Hóa Đơn :"+item.SubItems[2].Text.Trim()+" Và Số Tiền : "+item.SubItems[3].Text.Trim()+"VNĐ!", "Thống Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        DTO_CongNo congno = new DTO_CongNo();
                        congno.ma_hoa_don=item.SubItems[2].Text.Trim();
                        int i = new BLL_CongNo()._Xoa_Cong_No(congno);
                        if (i == 0)
                        {
                            _Load_List_View_Thanh_Toan();
                            _Load_List_View_Cong_No();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thất Bại. Vui Lòng Kiểm Tra Lại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            foreach (ListViewItem item in lvthanhtoan.Items)
            {
                if (item.Selected && item.SubItems[0].Text.Trim() != "")
                {
                    DialogResult kq = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa Số Tiền :" + item.SubItems[2].Text.Trim() + "VNĐ!", "Thống Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        DTO_ThanhToan tt = new DTO_ThanhToan();
                        tt.ma_thanh_toan = int.Parse(item.SubItems[4].Text.Trim());
                        int i = new BLL_CongNo()._Xoa_So_Tien_Thanh_Toan(tt);
                        if (i == 0)
                        {
                            _Load_List_View_Thanh_Toan();
                            _Load_List_View_Cong_No();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thất Bại. Vui Lòng Kiểm Tra Lại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnthemthanhtoan_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txtmakhachhang.Text.Trim() == "")
            {
                message += "Chưa Nhập Mã Khách Hàng ";
            }
            if (cbmahopdong.Text.Trim() == "")
            {
                message += string.IsNullOrEmpty(message) ? "" : "-";
                message += " Chưa Chọn Mã Hợp Đồng";
            }
            if (message != "")
            {
                MessageBox.Show("Bạn " + message + "!", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (message == "")
            {
                DTO_ThanhToan tt = new DTO_ThanhToan();
                tt.ma_hop_dong = cbmahopdong.Text.Trim();
                tt.ma_khach_hang = txtmakhachhang.Text.Trim();
                tt.ngay_thanh_toan = dtpngaythanhtoan.Value;
                tt.so_tien_thanh_toan = float.Parse(txtsotienthanhtoan.Text.Trim());

                int i = new BLL_CongNo()._Them_Thanh_Toan_Cong_No(tt);
                if (i == 0)
                {
                    MessageBox.Show("Thêm Thanh Toán Thành Công! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Load_List_View_Thanh_Toan();
                    _Load_List_View_Cong_No();
                }
                else
                {
                    MessageBox.Show("Thêm Thanh Toán Thất Bại! ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void _Load_List_View_Thanh_Toan()
        {
            if (txtmakhachhang.Text.Trim() != "")
            {
                lvthanhtoan.Items.Clear();
                DTO_ThanhToan tt = new DTO_ThanhToan();
                tt.ma_khach_hang = txtmakhachhang.Text.Trim();
                tt.ma_hop_dong = cbmahopdong.Text.Trim();
                int STT = 1;
                float tongcong = 0;
                if (new BLL_CongNo()._List_View_Thanh_Toan(tt) != null)
                {
                    foreach (DTO_ThanhToan dto in new BLL_CongNo()._List_View_Thanh_Toan(tt))
                    {
                        ListViewItem item = new ListViewItem(STT.ToString());

                        ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(item, dto.ngay_thanh_toan.ToShortDateString());
                        item.SubItems.Add(lv1);

                        ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(item, dto.so_tien_thanh_toan.ToString("###,###,###"));
                        item.SubItems.Add(lv2);

                        ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(item, "VNĐ");
                        item.SubItems.Add(lv3);

                        ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(item, dto.ma_thanh_toan.ToString());
                        item.SubItems.Add(lv4);

                        lvthanhtoan.Items.Add(item);
                        STT++;
                        tongcong += dto.so_tien_thanh_toan;
                    }
                }
                else
                {
                    _TongTien_Thanh_Toan = 0;
                }

                _TongTien_Thanh_Toan += tongcong;

                ListViewItem itemm = new ListViewItem("");
                itemm.UseItemStyleForSubItems = false;


                ListViewItem.ListViewSubItem lvv2 = new ListViewItem.ListViewSubItem(itemm, "Tổng Cộng");
                itemm.SubItems.Add(lvv2);
                lvv2.ForeColor = System.Drawing.Color.Blue;
                lvv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv3 = new ListViewItem.ListViewSubItem(itemm, tongcong.ToString("###,###,###"));
                itemm.SubItems.Add(lvv3);
                lvv3.ForeColor = System.Drawing.Color.Red;
                lvv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lvv4 = new ListViewItem.ListViewSubItem(itemm, "VNĐ");
                itemm.SubItems.Add(lvv4);
                lvv4.ForeColor = System.Drawing.Color.Red;
                lvv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                lvthanhtoan.Items.Add(itemm);
            }
        }

    }
}
