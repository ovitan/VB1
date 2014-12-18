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
using QLDVVTHH.DAL;

namespace QLDVVTHH.UI
{
    public partial class frmHopDong : Form
    {
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        BLL_HopDong bll_hd = null;
        public frmHopDong()
        {
            bll_hd = new BLL_HopDong();
            InitializeComponent();
            _AUTO_COMPLE_MA_KHACH_HANG();
            _ma_hop_dong();
            _combobox_ten_khach_hang();
        }

        private void _AUTO_COMPLE_MA_KHACH_HANG()
        {
            DataTable dt = new BLL_HopDong()._Bang_Ma_Khach_Hang();
            if (dt!=null&&dt.Rows.Count > 0)
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

        private void _ma_hop_dong()
        {
            txtmahopdong.Text = new BLL_HopDong()._Ma_Hop_Dong().ToString();
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DialogResult kq=MessageBox.Show("Bạn Muốn Lưu Hợp Đồng Mới", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (kq == DialogResult.OK)
            {
                if (txtmahopdong.Text.Trim() == "" || txtmakhachhang.Text.Trim() == "" )
                {
                    MessageBox.Show("Thông Tìn Không Đầy Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtpngaybatdau.Value >= dtpngayketthuc.Value)
                    {
                        MessageBox.Show("Thời Gian Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        
                        DTO_HopDong hd = new DTO_HopDong();
                        hd.ma_hop_dong = txtmahopdong.Text.Trim();
                        hd.ma_khach_hang = txtmakhachhang.Text.Trim();
                        hd.ngay_tao = DateTime.Now;
                        hd.ngay_bat_dau = dtpngaybatdau.Value;
                        hd.ngay_ket_thuc = dtpngayketthuc.Value;
                        hd.loaihanghoa = txtloaihanghoa.Text.Trim();
                        hd.lotrinhvanchuyen = txtlotrinhvanchuyen.Text;
                        hd.phuongthucvanchuyen = txtphuongthucvanchuyen.Text.Trim();
                        hd.giatrihopdong = txtgiatrihopdong.Text.Trim();
                        hd.phuongthucthanhtoan = txtphuongthucthanhtoan.Text.Trim();
                        int i = bll_hd._Them_Hop_Dong(hd);
                        if (i == 1)
                        {
                            _Add_ListView();
                            MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtmahopdong.Text = new BLL_HopDong()._Ma_Hop_Dong();
                        }
                        else
                        {
                            MessageBox.Show("Lưu Hợp Đồng Mới Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text.Trim() != "")
            {
                DTO_KhachHang dto = new DTO_KhachHang();
                dto.ma_khach_hang = txtmakhachhang.Text.ToString();
            }
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            txtmahopdong.Text = "";
            txtmakhachhang.Text = "";
            txtloaihanghoa.Text = "";
            txtlotrinhvanchuyen.Text = "";
            txtphuongthucvanchuyen.Text = "";
            txtgiatrihopdong.Text = "";
            txtphuongthucthanhtoan.Text = "";
        }

        private void btntaoma_Click(object sender, EventArgs e)
        {
            _ma_hop_dong();
        }

        private void _Add_ListView()
        {
            lvthongtinhopdong.Items.Clear();
            ListViewItem MA = new ListViewItem("1");
            ListViewItem.ListViewSubItem lv0 = new ListViewItem.ListViewSubItem(MA,txtmakhachhang.Text);
            MA.SubItems.Add(lv0);
            ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(MA,cbkhachhang.Text.Trim());
            MA.SubItems.Add(lv1);
            ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(MA,txtmahopdong.Text);
            MA.SubItems.Add(lv2);
            ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(MA,dtpngaybatdau.Value.ToShortDateString());
            MA.SubItems.Add(lv3);
            ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(MA, dtpngayketthuc.Value.ToShortDateString());
            MA.SubItems.Add(lv4);

            ListViewItem.ListViewSubItem lv5 = new ListViewItem.ListViewSubItem(MA, txtloaihanghoa.Text);
            MA.SubItems.Add(lv5);
            ListViewItem.ListViewSubItem lv6 = new ListViewItem.ListViewSubItem(MA, txtlotrinhvanchuyen.Text);
            MA.SubItems.Add(lv6);
            ListViewItem.ListViewSubItem lv7 = new ListViewItem.ListViewSubItem(MA, txtphuongthucvanchuyen.Text);
            MA.SubItems.Add(lv7);
            ListViewItem.ListViewSubItem lv8 = new ListViewItem.ListViewSubItem(MA, txtgiatrihopdong.Text);
            MA.SubItems.Add(lv8);
            ListViewItem.ListViewSubItem lv9 = new ListViewItem.ListViewSubItem(MA, txtphuongthucthanhtoan.Text);
            MA.SubItems.Add(lv9);
            ListViewItem.ListViewSubItem lv10 = new ListViewItem.ListViewSubItem(MA, DateTime.Now.ToShortDateString());
            MA.SubItems.Add(lv10);

            lvthongtinhopdong.Items.Add(MA);
            lvthongtinhopdong.View = View.Details;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            bool del=false;
            foreach (ListViewItem item in lvthongtinhopdong.Items)
            {
                if (item.Selected)
                {
                    DTO_HopDong hd = new DTO_HopDong();
                    hd.ma_hop_dong = item.SubItems[3].Text.ToString();
                    DialogResult kq = MessageBox.Show("Bạn Muốn Xóa Hợp Đồng Có Mã : " + hd.ma_hop_dong, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (kq == DialogResult.OK)
                    {
                        del = new BLL_HopDong()._Xoa_Hop_Dong(hd);
                    }
                    if (del == true)
                    {
                        item.Remove();
                    }
                }
            }
            if(del == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(del == false)
            {
                MessageBox.Show("Không Xóa Được Hợp Đồng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvthongtinhopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvthongtinhopdong.Items)
            {
                if (item.Selected)
                {
                    txtmakhachhang.Text = item.SubItems[1].Text;
                    txtmahopdong.Text = item.SubItems[3].Text;
                    dtpngaybatdau.Value =Convert.ToDateTime(item.SubItems[4].Text);
                    dtpngayketthuc.Value = Convert.ToDateTime(item.SubItems[5].Text);
                    txtloaihanghoa.Text = item.SubItems[6].Text;
                    txtlotrinhvanchuyen.Text = item.SubItems[7].Text;
                    txtphuongthucvanchuyen.Text = item.SubItems[8].Text;
                    txtgiatrihopdong.Text = item.SubItems[9].Text;
                    txtphuongthucthanhtoan.Text = item.SubItems[10].Text;

                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            DTO_HopDong dto = new DTO_HopDong();
            dto.ma_hop_dong = txtmahopdong.Text;
            dto.ma_khach_hang = txtmakhachhang.Text;
            dto.ngay_bat_dau = dtpngaybatdau.Value;
            dto.ngay_ket_thuc = dtpngayketthuc.Value;
            dto.loaihanghoa = txtloaihanghoa.Text.Trim();
            dto.lotrinhvanchuyen = txtlotrinhvanchuyen.Text;
            dto.phuongthucvanchuyen = txtphuongthucvanchuyen.Text.Trim();
            dto.giatrihopdong = txtgiatrihopdong.Text.Trim();
            dto.phuongthucthanhtoan = txtphuongthucthanhtoan.Text.Trim();
            if (txtmahopdong.Text.Trim() != new BLL_HopDong()._Ma_Hop_Dong().ToString())
            {
                DialogResult kq = MessageBox.Show("Bạn Muốn Cập Nhật Hợp Đồng : " + txtmahopdong.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                bool kt = true;
                if (kq == DialogResult.OK)
                {
                    kt = new BLL_HopDong()._Update_Hop_Dong(dto);
                }
                if (kt == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    foreach (ListViewItem item in lvthongtinhopdong.Items)
                    {
                        if (item.Selected)
                        {
                            item.SubItems[1].Text = txtmakhachhang.Text;
                            item.SubItems[3].Text = txtmahopdong.Text;
                            item.SubItems[4].Text = dtpngaybatdau.Value.ToShortDateString();
                            item.SubItems[5].Text = dtpngayketthuc.Value.ToShortDateString();
                            item.SubItems[6].Text = txtloaihanghoa.Text;
                            item.SubItems[7].Text = txtlotrinhvanchuyen.Text;
                            item.SubItems[8].Text = txtphuongthucvanchuyen.Text;
                            item.SubItems[9].Text = txtgiatrihopdong.Text;
                            item.SubItems[10].Text = txtphuongthucthanhtoan.Text;

                        }
                    }
                }
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            lvthongtinhopdong.Items.Clear();
            DTO_HopDong dt=new DTO_HopDong();
            dt.ma_hop_dong=txtmahopdong.Text.Trim();
            dt.ma_khach_hang=txtmakhachhang.Text.Trim();
            int stt = 1;
            if (new BLL_HopDong()._Tim_Khach_Hang_Hop_Dong(dt) != null)
            {
                foreach (DTO_HopDong dto in new BLL_HopDong()._Tim_Khach_Hang_Hop_Dong(dt))
                {
                    ListViewItem MA = new ListViewItem(stt.ToString());
                    ListViewItem.ListViewSubItem lv0 = new ListViewItem.ListViewSubItem(MA, dto.ma_khach_hang);
                    MA.SubItems.Add(lv0);
                    ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(MA, dto.ten_khach_hang);
                    MA.SubItems.Add(lv1);
                    ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(MA, dto.ma_hop_dong);
                    MA.SubItems.Add(lv2);
                    ListViewItem.ListViewSubItem lv3 = new ListViewItem.ListViewSubItem(MA, dto.ngay_bat_dau.ToShortDateString());
                    MA.SubItems.Add(lv3);
                    ListViewItem.ListViewSubItem lv4 = new ListViewItem.ListViewSubItem(MA, dto.ngay_ket_thuc.ToShortDateString());
                    MA.SubItems.Add(lv4);
                    ListViewItem.ListViewSubItem lv5 = new ListViewItem.ListViewSubItem(MA, dto.loaihanghoa);
                    MA.SubItems.Add(lv5);
                    ListViewItem.ListViewSubItem lv6 = new ListViewItem.ListViewSubItem(MA, dto.lotrinhvanchuyen);
                    MA.SubItems.Add(lv6);
                    ListViewItem.ListViewSubItem lv7 = new ListViewItem.ListViewSubItem(MA, dto.phuongthucvanchuyen);
                    MA.SubItems.Add(lv7);
                    ListViewItem.ListViewSubItem lv8 = new ListViewItem.ListViewSubItem(MA, dto.giatrihopdong);
                    MA.SubItems.Add(lv8);
                    ListViewItem.ListViewSubItem lv9 = new ListViewItem.ListViewSubItem(MA, dto.phuongthucthanhtoan);
                    MA.SubItems.Add(lv9);

                    lvthongtinhopdong.Items.Add(MA);
                    stt++;
                }
            }
            lvthongtinhopdong.View = View.Details;
        }

        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text.Trim() != "")
            {
                DTO_KhachHang dto = new DTO_KhachHang();
                dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString();
            }
            else
            {
                lvthongtinhopdong.Items.Clear();
            }
        }

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvthongtinhopdong.Items.Clear();
            if (cbkhachhang.Text.Trim() != "")
            {
                txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString();
            }
        }
    }
}
