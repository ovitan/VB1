using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.DTO;
using QLDVVTHH.BLL;

namespace QLDVVTHH.UI
{
    public partial class frmTTDieuXe : Form
    {
  
        public frmTTDieuXe()
        {
            InitializeComponent();
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

        private void _list_view_xe()
        {
            lvxe.Items.Clear();
            if (new BLL_DieuXe().Get_List_Xe_DangOBai() != null)
            {
                int stt = 1;
                foreach (DTO_Xe xe in new BLL_DieuXe().Get_List_Xe_DangOBai())
                {
                    
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    ListViewItem.ListViewSubItem ite1 = new ListViewItem.ListViewSubItem(lvi, xe.ma_so_xe);
                    lvi.SubItems.Add(ite1);
                    ListViewItem.ListViewSubItem ite2 = new ListViewItem.ListViewSubItem(lvi, xe.trong_luong.ToString("###,###"));
                    lvi.SubItems.Add(ite2);
                    ListViewItem.ListViewSubItem ite3 = new ListViewItem.ListViewSubItem(lvi, xe.ten_tinh_trang);
                    lvi.SubItems.Add(ite3);
                    ListViewItem.ListViewSubItem ite4 = new ListViewItem.ListViewSubItem(lvi, xe.loai_xe);
                    lvi.SubItems.Add(ite4);
                    

                    lvxe.Items.Add(lvi);
                    stt++;
                }
            }
        }
        private void _list_view_nhan_vien(string masx)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.ma_so_xe = masx;
            lvnhanvien.Items.Clear();
            if (new BLL_DieuXe().Get_List_Xe_Nhan_Vien(nv) != null)
            {
                int stt = 1;
                
                foreach (DTO_NhanVien nhanvien in new BLL_DieuXe().Get_List_Xe_Nhan_Vien(nv))
                {
                    
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    ListViewItem.ListViewSubItem ite1 = new ListViewItem.ListViewSubItem(lvi, nhanvien.ten_nhan_vien);
                    lvi.SubItems.Add(ite1);
                    ListViewItem.ListViewSubItem ite2 = new ListViewItem.ListViewSubItem(lvi, nhanvien.cmnd);
                    lvi.SubItems.Add(ite2);
                    ListViewItem.ListViewSubItem ite3 = new ListViewItem.ListViewSubItem(lvi, nhanvien.dia_chi);
                    lvi.SubItems.Add(ite3);
                    ListViewItem.ListViewSubItem ite4 = new ListViewItem.ListViewSubItem(lvi, nhanvien.dien_thoai);
                    lvi.SubItems.Add(ite4);
                    ListViewItem.ListViewSubItem ite5 = new ListViewItem.ListViewSubItem(lvi, nhanvien.chucvu);
                    lvi.SubItems.Add(ite5);
                    ListViewItem.ListViewSubItem ite6 = new ListViewItem.ListViewSubItem(lvi, nhanvien.nam_sinh.ToShortDateString());
                    lvi.SubItems.Add(ite6);

                    lvnhanvien.Items.Add(lvi);
                    stt++;
                }
            }
        }
        private void _load_cb_noi_nhan(DTO_BangBaoGia bgg)
        {
            cbnoinhan.DataSource = new BLL_DieuXe()._List_Get_NoiNhan(bgg);
            cbnoinhan.DisplayMember = "noi_nhan";
            cbnoinhan.ValueMember = "noi_nhan";
        }
        private void _load_cb_noi_giao(DTO_DieuXe xx)
        {
            cbnoigiao.DataSource = new BLL_DieuXe()._List_Get_NoiGiao(xx);
            cbnoigiao.DisplayMember = "noi_giao";
            cbnoigiao.ValueMember = "noi_giao";
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _Load_List_View_Dieu_Xe(string mahopdong)
        {
            if (cbhopdong.Text.Trim() != "")
            {
                lvthongtindieuxe.Items.Clear();
                lvthongtindieuxe.Groups.Clear();
                DTO_DieuXe xxx = new DTO_DieuXe();
                xxx.ma_hop_dong = mahopdong;
                if (new BLL_DieuXe()._List_Get_Dieu_Xe_By_KhachHang_HopDong(xxx) != null)
                {
                    foreach (DTO_DieuXe dx in new BLL_DieuXe()._List_Get_Dieu_Xe_By_KhachHang_HopDong(xxx))
                    {
                        ListViewItem item = new ListViewItem(new string[] 
                      {
                         "",dx.ma_so_xe,dx.tai_trong_xe.ToString(),dx.noi_nhan,dx.noi_giao,dx.so_tan,dx.ngay_dieu_xe.ToShortDateString(),dx.ngay_ve.ToShortDateString()=="01/01/0001"?"":dx.ngay_ve.ToShortDateString(),dx.tinh_trang_thanh_toan,dx.ma_dieu_xe
                      });
                        GroupItem(item);
                        this.lvthongtindieuxe.Items.Add(item);
                    }
                }
            }
        }
        private void GroupItem(ListViewItem item)
        {
            bool group_exists = false;
            foreach (ListViewGroup group in this.lvthongtindieuxe.Groups)
            {
                if (group.Header == item.SubItems[9].Text)
                {
                    item.Group = group;
                    group_exists = true;
                    break;
                }
            }
            if (!group_exists)
            {
                ListViewGroup group = new ListViewGroup(item.SubItems[9].Text);
                this.lvthongtindieuxe.Groups.Add(group);
                item.Group = group;
            }
        }
        private void frmTTDieuXe_Load(object sender, EventArgs e)
        {
            _load_tinh_trang_thanh_toan();
            _combobox_ten_khach_hang();
            txtmadieuxe.Text = new BLL_DieuXe()._Ma_Dieu_Xe_Moi();
            _list_view_xe();
        }

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkhachhang.Text.Trim() != "")
            {
                _Load_Combobox_Hop_Dong(cbkhachhang.SelectedValue.ToString().Trim());
            }
            else
            {
                cbhopdong.DataSource = null;
            }
        }

        private void txtsotan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = ',';
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == 54) { }
            else if (e.KeyChar == decimalChar && txtsotan.Text.IndexOf(decimalChar.ToString()) == -1) { }
            else
            {
                e.Handled = true;
            }
        }

        private void btnthemma_Click(object sender, EventArgs e)
        {
            txtmadieuxe.Text = new BLL_DieuXe()._Ma_Dieu_Xe_Moi();
        }

        private void lvxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem ite in lvxe.Items)
            {
                if (ite.Selected)
                {
                    lvnhanvien.Items.Clear();
                    _list_view_nhan_vien(ite.SubItems[1].Text);
                }
            }
        }
        
        private void cbhopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbhopdong.Text.Trim() != "")
            {
                DTO_BangBaoGia bgg=new DTO_BangBaoGia();
                bgg.ma_hop_dong=cbhopdong.Text.Trim();
                _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim());

                DTO_BangBaoGia bg = new DTO_BangBaoGia();
                bg.ma_hop_dong = cbhopdong.Text.Trim();
                cbbaogia.DataSource = new BLL_DieuXe()._List_Get_Ma_Bao_Gia(bg);
                cbbaogia.DisplayMember = "ma_bao_gia";
                cbbaogia.ValueMember = "ma_bao_gia";  
            }
        }

        private void cbnoinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbnoinhan.Text.Trim() != "")
            {
                DTO_DieuXe xx = new DTO_DieuXe();
                xx.noi_nhan = cbnoinhan.Text.Trim();
                _load_cb_noi_giao(xx);
            }
        }
        private void _Them_Dieu_Xe()
        {
            string message = "";
            if (cbkhachhang.Text.Trim() == "")
            {
                message += " Chưa Chọn Khách Hàng ";
            }
            if (cbhopdong.Text.Trim() == "")
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Mã Hợp Đồng ";
            }
            if (txtmadieuxe.Text.Trim() == "")
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Có Mã Điều Xe";
            }
            if (txtsotan.Text.Trim() == "")
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Khối Lượng ";
            }
            if (cbnoinhan.Text.Trim() == "")
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Nơi Nhận ";
            }
            if (cbnoigiao.Text.Trim() == "")
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Nơi Giao ";
            }
            int stt = 0;
            bool sosanh = true;
            float _tong_tan = 0;
            foreach (ListViewItem item in lvxe.Items)
            {

                if (item.Checked)
                {
                    stt++;
                    _tong_tan += float.Parse(item.SubItems[2].Text);
                }
            }
            if (_tong_tan < float.Parse("0" + txtsotan.Text.Trim()))
            {
                sosanh = false;
            }
            if (stt == 0)
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Xe ";
            }
            if (sosanh == false && stt != 0)
            {
                message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Có Số Lượng Xe Điều Đi Không Đủ ";
            }
            if (message == "")
            {
                DTO_DieuXe dx = new DTO_DieuXe();
                dx.ma_dieu_xe = txtmadieuxe.Text.Trim();
                dx.ma_khach_hang = Convert.ToString(cbkhachhang.SelectedValue.ToString());
                dx.ngay_ve = dtpngayve.Value;
                dx.tttt = int.Parse(cbtinhtrangthanhtoan.SelectedValue.ToString());
                dx.ma_hop_dong = cbhopdong.Text.Trim();
                dx.noi_giao = cbnoigiao.Text.Trim();
                dx.noi_nhan = cbnoinhan.Text.Trim();
                dx.ngay_dieu_xe = dtpngaydi.Value;
                bool kq = true;
                float so_tan_con_lai = float.Parse(txtsotan.Text.Trim());
                while (so_tan_con_lai > 0)
                {
                    foreach (ListViewItem item in lvxe.Items)
                    {
                        if (item.Checked)
                        {
                            if (so_tan_con_lai > float.Parse(item.SubItems[2].Text))
                            {
                                dx.so_tan = item.SubItems[2].Text;
                            }
                            else
                            {
                                dx.so_tan = (so_tan_con_lai < float.Parse(item.SubItems[2].Text)) ? so_tan_con_lai.ToString() : (so_tan_con_lai - float.Parse(item.SubItems[2].Text)).ToString();
                            }
                            so_tan_con_lai = so_tan_con_lai - float.Parse(item.SubItems[2].Text);
                            dx.ma_so_xe = Convert.ToString(item.SubItems[1].Text);
                            kq = new BLL_DieuXe().Create_DX(dx);
                        }
                        if (so_tan_con_lai <= 0)
                        {
                            break;
                        }
                    }
                }
                if (kq == false)
                {
                    message = " Lưu Điều Xe Thất Bại ";
                    MessageBox.Show(message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _list_view_xe();
                    _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim());
                     txtmadieuxe.Text = new BLL_DieuXe()._Ma_Dieu_Xe_Moi();
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn" + message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmadieuxe.Text.Trim() == new BLL_DieuXe()._Ma_Dieu_Xe_Moi())
            {
                _Them_Dieu_Xe();
            }
            else
            {
                txtmadieuxe.Text = new BLL_DieuXe()._Ma_Dieu_Xe_Moi();
                _Them_Dieu_Xe();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvthongtindieuxe.Items)
            {
                if (item.Selected)
                {
                    DialogResult kq = MessageBox.Show("Bán Muốn Xóa Mã Điều Xe :"+item.SubItems[9].Text.Trim(),"Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        DTO_DieuXe dx = new DTO_DieuXe();
                        dx.ma_dieu_xe = item.SubItems[9].Text.Trim();
                        bool delete = new BLL_DieuXe().Delete_Dieu_Xe(dx);
                        if (delete == true)
                        {
                            _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim());
                            _list_view_xe();
                        }
                    }
                }
            }
        }

        private void lvthongtindieuxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvthongtindieuxe.Items)
            {
                if (item.Selected)
                {
                    txtmadieuxe.Text = item.SubItems[9].Text.Trim();
                    dtpngaydi.Value = Convert.ToDateTime(item.SubItems[6].Text);
                    if (item.SubItems[7].Text.Trim() != "")
                    {
                        dtpngayve.Value= Convert.ToDateTime(item.SubItems[7].Text);
                    }
                    cbtinhtrangthanhtoan.SelectedValue = item.SubItems[8].Text.Trim() == "Chưa Thanh Toán" ? 0 : 1;
                    DTO_DieuXe dv = new DTO_DieuXe();
                    dv.ma_dieu_xe = item.SubItems[9].Text.Trim();
                    txtsotan.Text = new BLL_DieuXe()._Get_Tong_Trong_Luong(dv).ToString();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvthongtindieuxe.Items)
            {
                if (item.Selected)
                {
                    DialogResult kq = MessageBox.Show("Bán Muốn Sửa Mã Điều Xe : " + item.SubItems[9].Text.Trim() + " - Có Mã Số Xe : " + item.SubItems[1].Text.Trim(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        string message = "";
                        if (cbkhachhang.Text.Trim() == "")
                        {
                            message += " Chưa Chọn Khách Hàng ";
                        }
                        if (cbhopdong.Text.Trim() == "")
                        {
                            message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Mã Hợp Đồng ";
                        }
                        if (txtmadieuxe.Text.Trim() == "")
                        {
                            message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Có Mã Điều Xe";
                        }
                        if (dtpngayve.Value < dtpngaydi.Value)
                        {
                            message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Ngày Về Không Hơp Lý.Vui Lòng Kiểm Tra Lại.";
                        }
                        if (message == "")
                        {
                            DTO_DieuXe dx = new DTO_DieuXe();
                            dx.ma_dieu_xe = txtmadieuxe.Text.Trim();
                            dx.ma_khach_hang = Convert.ToString(cbkhachhang.SelectedValue.ToString());
                            dx.ngay_ve = dtpngayve.Value;
                            dx.tttt = int.Parse(cbtinhtrangthanhtoan.SelectedValue.ToString());
                            dx.ma_hop_dong = cbhopdong.Text.Trim();
                            dx.noi_giao = cbnoigiao.Text.Trim();
                            dx.noi_nhan = cbnoinhan.Text.Trim();
                            dx.so_tan = txtsotan.Text.Trim();
                            dx.ngay_dieu_xe = dtpngaydi.Value;
                            dx.ma_so_xe = item.SubItems[1].Text.Trim();
                            bool update = new BLL_DieuXe().Update_Dieu_Xe(dx);
                            if (update  == true)
                            {
                                _Load_List_View_Dieu_Xe(cbhopdong.Text.Trim());
                                _list_view_xe();
                            }
                        }
                        if (message != "")
                        {
                            MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void cbbaogia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbaogia.Text.Trim() != "")
            {
                DTO_BangBaoGia bgg = new DTO_BangBaoGia();
                bgg.ma_bao_gia = cbbaogia.Text.Trim();
                _load_cb_noi_nhan(bgg);
            }
        }
    }
}
