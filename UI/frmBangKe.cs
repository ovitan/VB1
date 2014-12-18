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
    public partial class frmBangKe : Form
    {
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        public frmBangKe()
        {
            InitializeComponent();
            _AUTO_COMPLE_MA_KHACH_HANG();
            txtmabangke.Text = new BLL_BangKe()._Ma_Bang_Ke();
            _combobox_ten_khach_hang();
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
            cbhopdong.DataSource = new BLL_BangKe()._List_Hop_Dong(dto);
            cbhopdong.DisplayMember = "ma_hop_dong";
            cbhopdong.ValueMember = "ma_hop_dong";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_control()
        {
            txtdongiachuyen.Text = "";
            txtdongiatan.Text = "";
            txtmabangke.Text = "";
            txtmasoxe.Text = "";
            txtnoigiao.Text = "";
            txtnoinhan.Text="";
            txtkhoiluong.Text = "";
        }

        private void txtdongiatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else
            {
                e.Handled = true;
            }
        }

        private void txtdongiachuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else
            {
                e.Handled = true;
            }
        }
        private void _Load_ComBobox_Dieu_xe()
        {
            DTO_DieuXe dx = new DTO_DieuXe();
            dx.ma_khach_hang = txtmakhachhang.Text.Trim();
            cbmadieuxe.DataSource = new BLL_BangKe()._List_Ma_Dieu_Xe(dx);
            cbmadieuxe.DisplayMember = "ma_dieu_xe";
            cbmadieuxe.ValueMember = "ma_so_xe";
        }
        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text.Trim() != "")
            {
                DTO_KhachHang dto = new DTO_KhachHang();
                dto.ma_khach_hang = txtmakhachhang.Text.Trim().ToString();
                _Load_Combobox_Hop_Dong(dto.ma_khach_hang);
                _Load_ComBobox_Dieu_xe();

            }
            else
            {
                lvthongtin.Items.Clear();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmabangke.Text.Trim() == new BLL_BangKe()._Ma_Bang_Ke())
            {
                string message = "";
                if (txtmabangke.Text.Trim() == "")
                {
                    message += " Chưa Nhập Mã Bảng Kê ";
                }
                if (txtmakhachhang.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Mã Khách Hàng ";
                }
                if (cbhopdong.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Tạo Hợp Đồng ";
                }
                if (txtmasoxe.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Mã Số Xe ";
                }
                if (txtkhoiluong.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Khối Lượng ";
                }
                if (txtnoinhan.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Nơi Nhận ";
                }
                if (txtnoigiao.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Nơi Giao ";
                }
                if (cbmadieuxe.Text.Trim()== "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Chọn Mã Điều Xe ";
                }
                if (message == "")
                {
                    DTO_BangKe dto = new DTO_BangKe();
                    dto.ma_bang_ke = txtmabangke.Text.Trim();
                    dto.ma_khach_hang = txtmakhachhang.Text.Trim();
                    dto.ngay_van_chuyen = dtpngayvanchuyen.Value;
                    dto.ngay_tao = DateTime.Now;
                    dto.ngay_cap_nhat = DateTime.Now;
                    dto.so_xe = txtmasoxe.Text.Trim();
                    dto.noi_giao = txtnoigiao.Text.Trim();
                    dto.noi_nhan = txtnoinhan.Text.Trim();
                    dto.khoi_luong = float.Parse("0" + txtkhoiluong.Text.Trim());
                    dto.don_gia_tan = float.Parse("0" + txtdongiatan.Text.Trim());
                    dto.don_gia_chuyen = float.Parse("0" + txtdongiachuyen.Text.Trim());
                    dto.ghi_chu = rtbghichu.Text.Trim();
                    dto.ma_dieu_xe = cbmadieuxe.Text.Trim();
                    int insert = new BLL_BangKe()._Them_BangKe(dto);
                    if (insert == 1)
                    {
                        message = " Lưu Bản Kê Thất Bại ";
                        MessageBox.Show(message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _Load_ListView_DanhSachBangKe_KhachHang();
                        _Load_ComBobox_Dieu_xe();
                        txtmabangke.Text = new BLL_BangKe()._Ma_Bang_Ke();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn" + message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không Thể Thêm Mới.Kiểm Tra Lại Mã Bảng Kê !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _Load_ListView_DanhSachBangKe_KhachHang()
        {
            lvthongtin.Items.Clear();
            DTO_BangKe bk=new DTO_BangKe();
            bk.ma_khach_hang=txtmakhachhang.Text.Trim();
            bk.ma_bang_ke=cbhopdong.Text.Trim();
            int STT = 1;
            float tongcong = 0;
            if (new BLL_BangKe().DanhSachBangKe_TheoMaKhachHang_MaHopDong(bk) != null)
            {
                foreach (DTO_BangKe dto in new BLL_BangKe().DanhSachBangKe_TheoMaKhachHang_MaHopDong(bk))
                {
                    ListViewItem lvi = new ListViewItem(STT.ToString());
                    ListViewItem.ListViewSubItem ite1 = new ListViewItem.ListViewSubItem(lvi, dto.ma_bang_ke);
                    lvi.SubItems.Add(ite1);

                    ListViewItem.ListViewSubItem ite11 = new ListViewItem.ListViewSubItem(lvi, dto.ma_dieu_xe.Trim());
                    lvi.SubItems.Add(ite11);

                    ListViewItem.ListViewSubItem ite2 = new ListViewItem.ListViewSubItem(lvi, dto.ngay_van_chuyen.ToShortDateString());
                    lvi.SubItems.Add(ite2);
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
                    ListViewItem.ListViewSubItem ite9 = new ListViewItem.ListViewSubItem(lvi, ( dto.don_gia_chuyen + (dto.khoi_luong > 15 ? ((dto.khoi_luong - 15) * dto.don_gia_tan) : 0)).ToString("###,###,###"));
                    lvi.SubItems.Add(ite9);
                    ListViewItem.ListViewSubItem ite10 = new ListViewItem.ListViewSubItem(lvi, dto.ghi_chu);
                    lvi.SubItems.Add(ite10);

                    lvthongtin.Items.Add(lvi);
                    STT++;
                    tongcong += (dto.don_gia_chuyen) + (dto.khoi_luong > 15 ? ((dto.khoi_luong - 15) * dto.don_gia_tan) : 0);
                }
            }
            lvthongtin.View = View.Details;
            _Tinh_TongCong_Thue_ThanhTien("Tổng Cộng", tongcong);
            _Tinh_TongCong_Thue_ThanhTien("Thếu 10%", tongcong*10/100);
            _Tinh_TongCong_Thue_ThanhTien("Tổng Thành Tiền", tongcong+(tongcong*10/100));
        }

        private void txtkhoiluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = ',';
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar==54) { }
            else if (e.KeyChar == decimalChar && txtkhoiluong.Text.IndexOf(decimalChar.ToString()) == -1) { }
            else
            {
                e.Handled = true;
            }
        }

        private void btntaoma_Click(object sender, EventArgs e)
        {
            txtmabangke.Text = new BLL_BangKe()._Ma_Bang_Ke();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            DialogResult kq=MessageBox.Show("Bạn Muốn Cập Nhật Mã Bảng Kê : "+txtmabangke.Text.Trim(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                string message = "";
                if (txtmabangke.Text.Trim() == "")
                {
                    message += " Chưa Nhập Mã Bảng Kê ";
                }
                if (txtmakhachhang.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Mã Khách Hàng ";
                }
                if (cbhopdong.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Tạo Hợp Đồng ";
                }
                if (txtmasoxe.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Mã Số Xe ";
                }
                if (txtkhoiluong.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Khối Lượng ";
                }
                if (txtnoinhan.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Nơi Nhận ";
                }
                if (txtnoigiao.Text.Trim() == "")
                {
                    message += (string.IsNullOrEmpty(message) ? " " : " - ") + "Chưa Nhập Nơi Giao ";
                }
                if (message == "")
                {
                    DTO_BangKe dto = new DTO_BangKe();
                    dto.ma_bang_ke = txtmabangke.Text.Trim();
                    dto.ma_khach_hang = txtmakhachhang.Text.Trim();
                    dto.ngay_van_chuyen = dtpngayvanchuyen.Value;
                    dto.ngay_tao = DateTime.Now;
                    dto.ngay_cap_nhat = DateTime.Now;
                    dto.so_xe = txtmasoxe.Text.Trim();
                    dto.noi_giao = txtnoigiao.Text.Trim();
                    dto.noi_nhan = txtnoinhan.Text.Trim();
                    dto.khoi_luong = int.Parse("0" + txtkhoiluong.Text.Trim());
                    dto.don_gia_tan = float.Parse("0" + txtdongiatan.Text.Trim());
                    dto.don_gia_chuyen = float.Parse("0" + txtdongiachuyen.Text.Trim());
                    dto.ghi_chu = rtbghichu.Text.Trim();
                    dto.ma_dieu_xe = cbmadieuxe.Text.Trim();
                    int update = new BLL_BangKe()._CapNhat_BangKe(dto);
                    if (update == 1)
                    {
                        message = " Bảng Kê Này Đã Xuất Hóa Đơn Không Thể Cập Nhật ";
                        MessageBox.Show(message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _Load_ListView_DanhSachBangKe_KhachHang();
                        _Load_ComBobox_Dieu_xe();
                        txtkhoiluong.Text = "";
                        txtnoigiao.Text = "";
                        rtbghichu.Text = "";
                        txtmasoxe.Text = "";
                        txtmabangke.Text = new BLL_BangKe()._Ma_Bang_Ke();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn" + message + "!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void lvthongtin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem ite in lvthongtin.Items)
            {
                if (ite.Selected)
                {
                    if (ite.SubItems[1].Text.Trim() != "")
                    {
                        txtmabangke.Text = ite.SubItems[1].Text;
                        dtpngayvanchuyen.Value = Convert.ToDateTime(ite.SubItems[3].Text);
                        txtmasoxe.Text = ite.SubItems[4].Text;
                        txtnoinhan.Text = ite.SubItems[5].Text;
                        txtnoigiao.Text = ite.SubItems[6].Text;
                        txtkhoiluong.Text = ite.SubItems[7].Text;
                        txtdongiachuyen.Text = ite.SubItems[8].Text;
                        txtdongiatan.Text = ite.SubItems[9].Text;
                        rtbghichu.Text = ite.SubItems[11].Text;
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmabangke.Text.Trim() != new BLL_BangKe()._Ma_Bang_Ke())
            {
                DialogResult kq = MessageBox.Show("Bạn Muốn Xóa Mã Bảng Kê : " + txtmabangke.Text.Trim(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kq == DialogResult.OK)
                {
                    DTO_BangKe dto = new DTO_BangKe();
                    dto.ma_bang_ke = txtmabangke.Text.Trim();
                    int delete = new BLL_BangKe()._Xoa_BangKe(dto);
                    if (delete == 0)
                    {
                        MessageBox.Show("Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _Load_ListView_DanhSachBangKe_KhachHang();
                        _Load_ComBobox_Dieu_xe();
                    }
                    if (delete == 2)
                    {
                        MessageBox.Show("Mã Bảng Kê Không Tồn Tại Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (delete == 1)
                    {
                        MessageBox.Show("Bảng Kê Đã Xuất Hóa Đơn Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã Bảng Kê Không Tồn Tại Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbhopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvthongtin.Items.Clear();
            if (cbhopdong.Text.Trim() != "")
            {
                _Load_ListView_DanhSachBangKe_KhachHang();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.ma_khach_hang = txtmakhachhang.Text.Trim();
            kh.ten_khach_hang = cbkhachhang.Text.Trim();
            DTO_HopDong hd = new DTO_HopDong();
            hd.ma_hop_dong = cbhopdong.Text.Trim();
            DTO_BangKe bk = new DTO_BangKe();
            bk.ma_bang_ke = txtmabangke.Text.Trim();
            bk.so_xe = txtmasoxe.Text.Trim();
            bk.ngay_van_chuyen = dtpngayvanchuyen.Value;
            bk.noi_nhan = txtnoinhan.Text.Trim();
            bk.noi_giao = txtnoigiao.Text.Trim();
            bk.khoi_luong = float.Parse("0" + txtkhoiluong.Text.Trim());
            bk.don_gia_chuyen = float.Parse("0" + txtdongiachuyen.Text.Trim());
            bk.don_gia_tan = float.Parse("0" + txtdongiatan.Text.Trim());
            bk.ghi_chu = rtbghichu.Text.Trim();

            lvthongtin.Items.Clear();
            int STT = 1;
            float tongcong = 0;
            if (new BLL_BangKe()._Tim_BangKe(bk,hd,kh) != null)
            {
                foreach (DTO_BangKe dto in new BLL_BangKe()._Tim_BangKe(bk, hd, kh))
                {
                    ListViewItem lvi = new ListViewItem(STT.ToString());
                    ListViewItem.ListViewSubItem ite1 = new ListViewItem.ListViewSubItem(lvi, dto.ma_bang_ke);
                    lvi.SubItems.Add(ite1);

                    ListViewItem.ListViewSubItem ite11 = new ListViewItem.ListViewSubItem(lvi, dto.ma_dieu_xe.Trim());
                    lvi.SubItems.Add(ite11);

                    ListViewItem.ListViewSubItem ite2 = new ListViewItem.ListViewSubItem(lvi, dto.ngay_van_chuyen.ToShortDateString());
                    lvi.SubItems.Add(ite2);
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
                    ListViewItem.ListViewSubItem ite9 = new ListViewItem.ListViewSubItem(lvi, ( dto.don_gia_chuyen + (dto.khoi_luong > 15 ? ((dto.khoi_luong - 15) * dto.don_gia_tan) : 0)).ToString("###,###,###"));
                    lvi.SubItems.Add(ite9);
                    ListViewItem.ListViewSubItem ite10 = new ListViewItem.ListViewSubItem(lvi, dto.ghi_chu);
                    lvi.SubItems.Add(ite10);

                    lvthongtin.Items.Add(lvi);
                    STT++;
                    tongcong += ( dto.don_gia_chuyen  + (dto.khoi_luong > 15 ? ((dto.khoi_luong - 15) * dto.don_gia_tan) : 0));
                }
            }
            lvthongtin.View = View.Details;
            _Tinh_TongCong_Thue_ThanhTien("Tổng Cộng", tongcong);
            _Tinh_TongCong_Thue_ThanhTien("Thếu 10%", tongcong * 10 / 100);
            _Tinh_TongCong_Thue_ThanhTien("Tổng Thành Tiền", tongcong + (tongcong * 10 / 100));
        }

        private void _Tinh_TongCong_Thue_ThanhTien(string tengiatri,float giatri)
        {
            if (lvthongtin.Items.Count > 0)
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
                lv9.Font = new System.Drawing.Font("Microsoft Sans Serif",8, System.Drawing.FontStyle.Regular);

                ListViewItem.ListViewSubItem lv10 = new ListViewItem.ListViewSubItem(MA, "VNĐ");
                MA.SubItems.Add(lv10);

                lv10.ForeColor = System.Drawing.Color.Red;
                lv10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);

                lvthongtin.Items.Add(MA);

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
            lvthongtin.Items.Clear();
            if (cbkhachhang.Text.Trim() != "")
            {
                txtmakhachhang.Text = cbkhachhang.SelectedValue.ToString();
            }
        }

        private void mnxoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn Chắc Chắc Muốn Xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                foreach (ListViewItem item in lvthongtin.Items)
                {
                    if (item.Selected)
                    {
                        DTO_BangKe dto = new DTO_BangKe();
                        dto.ma_bang_ke = item.SubItems[1].Text;
                        int delete = new BLL_BangKe()._Xoa_BangKe(dto);
                        if (delete == 0)
                        {

                        }
                    }
                }
                _Load_ListView_DanhSachBangKe_KhachHang();
                _Load_ComBobox_Dieu_xe();
            }
        }

        private void cbmadieuxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmadieuxe.Text.Trim() != "" && txtmakhachhang.Text.Trim() != "")
            {
                DTO_DieuXe _xe = new DTO_DieuXe();
                _xe.ma_khach_hang = txtmakhachhang.Text;
                if (new BLL_BangKe()._List_Ma_Dieu_Xe(_xe) != null)
                {
                    foreach (DTO_DieuXe dx in new BLL_BangKe()._List_Ma_Dieu_Xe(_xe))
                    {
                        if (dx.ma_dieu_xe.Trim() == cbmadieuxe.Text.Trim())
                        {
                            txtmasoxe.Text = dx.ma_so_xe.Trim();
                            txtnoinhan.Text = dx.noi_nhan;
                            txtnoigiao.Text = dx.noi_giao;
                            dtpngayvanchuyen.Value = dx.ngay_dieu_xe;
                            txtkhoiluong.Text = dx.so_tan;
                            txtdongiachuyen.Text = dx.don_gia_chuyen.ToString();
                            txtdongiatan.Text = dx.don_gia_tan.ToString();
                        }
                    }
                }
            }
            else
            {
                reset_control();
            }
        }
    }
}
