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
using QLDVVTHH.UC_TIMKIEM;

namespace QLDVVTHH.UI
{
    public partial class frmTimKetQua : Form
    {
        public string _truyvan = "";
        public string _key_name = "";
        public string _Key_id = "";
        public frmTimKetQua()
        {
            InitializeComponent();
        }
        private void _Load_Ket_Qua_Tim_Kiem(string truyvan)
        {
            switch (truyvan)
            {
                case "nhanvien":
                    _NhanVien();
                    break;
                case "khachhang":
                    _KhachHang();
                    break;
                case "xe":
                    _Xe();
                    break;
                case "hoadon":
                    _HoaDon();
                    break;
                case "hopdong":
                    _HopDong();
                    break;
                default:
                    break;
            }
        }
        private void frmTimKetQua_Load(object sender, EventArgs e)
        {
            _Load_Ket_Qua_Tim_Kiem(_truyvan);
        }
        private void _NhanVien()
        {
            lvthongtintimkiem.Items.Clear();

            lvthongtintimkiem.Columns.Add("STT", 60);
            lvthongtintimkiem.Columns.Add("Mã Nhân Viên", 100);
            lvthongtintimkiem.Columns.Add("Tên Nhân Viên", 150);
            lvthongtintimkiem.Columns.Add("CMND", 100);
            lvthongtintimkiem.Columns.Add("Năm Sinh", 100);
            lvthongtintimkiem.Columns.Add("Chức Vụ", 100);
            lvthongtintimkiem.Columns.Add("Điện Thoại", 100);
            lvthongtintimkiem.Columns.Add("Địa Chỉ", 400);
            DTO_NhanVien dto = new DTO_NhanVien();
            dto.ma_nhan_vien = _Key_id.Trim();
            dto.ten_nhan_vien = _key_name.Trim();
            int STT = 1;
            if (new BLL_TraCuu()._Tim_NhanVien(dto) != null)
            {
                foreach (DTO_NhanVien nv in new BLL_TraCuu()._Tim_NhanVien(dto))
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem ie1 = new ListViewItem.ListViewSubItem(item, nv.ma_nhan_vien);
                    item.SubItems.Add(ie1);
                    ListViewItem.ListViewSubItem ie2 = new ListViewItem.ListViewSubItem(item, nv.ten_nhan_vien);
                    item.SubItems.Add(ie2);
                    ListViewItem.ListViewSubItem ie3 = new ListViewItem.ListViewSubItem(item, nv.cmnd);
                    item.SubItems.Add(ie3);
                    ListViewItem.ListViewSubItem ie4 = new ListViewItem.ListViewSubItem(item, nv.nam_sinh.ToShortDateString());
                    item.SubItems.Add(ie4);
                    ListViewItem.ListViewSubItem ie5 = new ListViewItem.ListViewSubItem(item, nv.chucvu);
                    item.SubItems.Add(ie5);
                    ListViewItem.ListViewSubItem ie6 = new ListViewItem.ListViewSubItem(item, nv.dien_thoai);
                    item.SubItems.Add(ie6);
                    ListViewItem.ListViewSubItem ie7 = new ListViewItem.ListViewSubItem(item, nv.dia_chi);
                    item.SubItems.Add(ie7);

                    lvthongtintimkiem.Items.Add(item);
                    STT++;

                }
            }
        }
        private void _KhachHang()
        {
            lvthongtintimkiem.Items.Clear();

            lvthongtintimkiem.Columns.Add("STT", 60);
            lvthongtintimkiem.Columns.Add("Mã Khách Hàng", 100);
            lvthongtintimkiem.Columns.Add("Thông Tin", 200);
            lvthongtintimkiem.Columns.Add("Mã Số Thếu", 100);
            lvthongtintimkiem.Columns.Add("Điện Thoại", 100);
            lvthongtintimkiem.Columns.Add("Fax", 120);
            lvthongtintimkiem.Columns.Add("Địa Chỉ", 500);

            DTO_KhachHang dto = new DTO_KhachHang();
            dto.ma_khach_hang = _Key_id.ToString();
            dto.ten_khach_hang = _key_name.ToString();
            int STT = 1;
            if (new BLL_TraCuu()._Tim_KhachHang(dto) != null)
            {
                foreach (DTO_KhachHang kh in new BLL_TraCuu()._Tim_KhachHang(dto))
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem ie1 = new ListViewItem.ListViewSubItem(item,kh.ma_khach_hang.ToString());
                    item.SubItems.Add(ie1);
                    ListViewItem.ListViewSubItem ie2 = new ListViewItem.ListViewSubItem(item, kh.ten_khach_hang.Trim());
                    item.SubItems.Add(ie2);
                    ListViewItem.ListViewSubItem ie3 = new ListViewItem.ListViewSubItem(item, kh.ma_so_thue);
                    item.SubItems.Add(ie3);
                    ListViewItem.ListViewSubItem ie4 = new ListViewItem.ListViewSubItem(item, kh.dien_thoai);
                    item.SubItems.Add(ie4);
                    ListViewItem.ListViewSubItem ie5 = new ListViewItem.ListViewSubItem(item, kh.fax);
                    item.SubItems.Add(ie5);
                    ListViewItem.ListViewSubItem ie6 = new ListViewItem.ListViewSubItem(item, kh.dia_chi);
                    item.SubItems.Add(ie6);

                    lvthongtintimkiem.Items.Add(item);
                    STT++;
                }
            }
        }
        private void _Xe()
        {
            lvthongtintimkiem.Items.Clear();

            lvthongtintimkiem.Columns.Add("STT", 60);
            lvthongtintimkiem.Columns.Add("Mã Số Xe", 100);
            lvthongtintimkiem.Columns.Add("Loại Xe", 100);
            lvthongtintimkiem.Columns.Add("Tải Trọng", 100);
            lvthongtintimkiem.Columns.Add("Nhãn Hiệu", 150);
            lvthongtintimkiem.Columns.Add("Tình Trạng Xe", 220);
            lvthongtintimkiem.Columns.Add("Ngày Nhập Dữ Liệu", 500);

            DTO_Xe xx = new DTO_Xe();
            xx.ma_so_xe = _Key_id.Trim();
            int STT = 1;
            if (new BLL_TraCuu()._Tim_ThongTinXe(xx) != null)
            {
                foreach (DTO_Xe dto in new BLL_TraCuu()._Tim_ThongTinXe(xx))
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem ie1 = new ListViewItem.ListViewSubItem(item, dto.ma_so_xe);
                    item.SubItems.Add(ie1);
                    ListViewItem.ListViewSubItem ie2 = new ListViewItem.ListViewSubItem(item, dto.loai_xe);
                    item.SubItems.Add(ie2);
                    ListViewItem.ListViewSubItem ie3 = new ListViewItem.ListViewSubItem(item,dto.trong_luong.ToString("###,###"));
                    item.SubItems.Add(ie3);
                    ListViewItem.ListViewSubItem ie4 = new ListViewItem.ListViewSubItem(item, dto.nhan_hieu);
                    item.SubItems.Add(ie4);
                    ListViewItem.ListViewSubItem ie5 = new ListViewItem.ListViewSubItem(item, dto.ten_tinh_trang);
                    item.SubItems.Add(ie5);
                    ListViewItem.ListViewSubItem ie6 = new ListViewItem.ListViewSubItem(item, dto.ngay_tao.ToShortDateString());
                    item.SubItems.Add(ie6);

                    lvthongtintimkiem.Items.Add(item);
                    STT++;
                }
            }
        }
        private void _HoaDon()
        {
            lvthongtintimkiem.Items.Clear();

            lvthongtintimkiem.Columns.Add("STT", 60);
            lvthongtintimkiem.Columns.Add("Mã Khách Hàng", 100);
            lvthongtintimkiem.Columns.Add("Thông Tin Khách Hàng", 150);
            lvthongtintimkiem.Columns.Add("Mã Hợp Đồng", 100);
            lvthongtintimkiem.Columns.Add("Mã Hóa Đơn", 100);
            lvthongtintimkiem.Columns.Add("Ngày Xuất Hóa Đơn", 150);
            lvthongtintimkiem.Columns.Add("Tổng Khối Lượng(Tấn)", 150);
            lvthongtintimkiem.Columns.Add("Tổng Cước Vận Chuyển(VNĐ)", 150);
            lvthongtintimkiem.Columns.Add("Hóa Đơn Tính Từ Ngày", 150);
            lvthongtintimkiem.Columns.Add("Đến Ngày", 150);

            DTO_HoaDon hd = new DTO_HoaDon();
            hd.ma_hoa_don = _Key_id.Trim();
            int STT = 1;
            if (new BLL_TraCuu()._Tim_HoaDon(hd) != null)
            {
                foreach (DTO_HoaDon dto in new BLL_TraCuu()._Tim_HoaDon(hd))
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem ie1 = new ListViewItem.ListViewSubItem(item, dto.ma_khach_hang);
                    item.SubItems.Add(ie1);
                    ListViewItem.ListViewSubItem ie2 = new ListViewItem.ListViewSubItem(item, dto.tenkhachhang);
                    item.SubItems.Add(ie2);
                    ListViewItem.ListViewSubItem ie3 = new ListViewItem.ListViewSubItem(item, dto.ma_hop_dong);
                    item.SubItems.Add(ie3);
                    ListViewItem.ListViewSubItem ie4 = new ListViewItem.ListViewSubItem(item, dto.ma_hoa_don);
                    item.SubItems.Add(ie4);
                    //ListViewItem.ListViewSubItem ie5 = new ListViewItem.ListViewSubItem(item, dto.ngay_tao.ToShortDateString());
                    //item.SubItems.Add(ie5);
                    ListViewItem.ListViewSubItem ie6 = new ListViewItem.ListViewSubItem(item, dto.tong_khoi_luong.ToString("###,###"));
                    item.SubItems.Add(ie6);
                    ListViewItem.ListViewSubItem ie7 = new ListViewItem.ListViewSubItem(item, dto.tong_cuot_van_chuyen.ToString("###,###,###"));
                    item.SubItems.Add(ie7);
                   // ListViewItem.ListViewSubItem ie8 = new ListViewItem.ListViewSubItem(item, dto.tu_ngay.ToShortDateString());
                   // item.SubItems.Add(ie8);
                    //ListViewItem.ListViewSubItem ie9 = new ListViewItem.ListViewSubItem(item, dto.den_ngay.ToShortDateString());
                   // item.SubItems.Add(ie9);

                    lvthongtintimkiem.Items.Add(item);
                    STT++;
                }
            }
        }
        private void _HopDong()
        {
            lvthongtintimkiem.Items.Clear();

            lvthongtintimkiem.Columns.Add("STT", 60);
            lvthongtintimkiem.Columns.Add("Mã Khách Hàng", 100);
            lvthongtintimkiem.Columns.Add("Thông Tin Khách Hàng", 150);
            lvthongtintimkiem.Columns.Add("Mã Hợp Đồng", 100);
            lvthongtintimkiem.Columns.Add("Loại Hàng Hóa", 100);
            lvthongtintimkiem.Columns.Add("Lộ Trình Vận Chuyển", 150);
            lvthongtintimkiem.Columns.Add("Phương Thức Vận Chuyển", 150);
            lvthongtintimkiem.Columns.Add("Giá Trị Hợp Đồng", 150);
            lvthongtintimkiem.Columns.Add("Phương Thức Thanh Toán", 150);
            lvthongtintimkiem.Columns.Add("Ngày Bắt Đầu", 150);
            lvthongtintimkiem.Columns.Add("Ngày Kết Thúc", 150);
            lvthongtintimkiem.Columns.Add("Ngày Lập Hợp Đồng", 150);

            DTO_HopDong hd = new DTO_HopDong();
            hd.ma_hop_dong= _Key_id.Trim();
            int STT = 1;
            if (new BLL_TraCuu()._Tim_HopDong(hd) != null)
            {
                foreach (DTO_HopDong dto in new BLL_TraCuu()._Tim_HopDong(hd))
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    ListViewItem.ListViewSubItem ie1 = new ListViewItem.ListViewSubItem(item, dto.ma_khach_hang);
                    item.SubItems.Add(ie1);
                    ListViewItem.ListViewSubItem ie2 = new ListViewItem.ListViewSubItem(item, dto.ten_khach_hang);
                    item.SubItems.Add(ie2);
                    ListViewItem.ListViewSubItem ie3 = new ListViewItem.ListViewSubItem(item, dto.ma_hop_dong);
                    item.SubItems.Add(ie3);
                    ListViewItem.ListViewSubItem ie4 = new ListViewItem.ListViewSubItem(item, dto.loaihanghoa);
                    item.SubItems.Add(ie4);
                    ListViewItem.ListViewSubItem ie5 = new ListViewItem.ListViewSubItem(item, dto.lotrinhvanchuyen);
                    item.SubItems.Add(ie5);
                    ListViewItem.ListViewSubItem ie6 = new ListViewItem.ListViewSubItem(item, dto.phuongthucvanchuyen);
                    item.SubItems.Add(ie6);
                    ListViewItem.ListViewSubItem ie7 = new ListViewItem.ListViewSubItem(item, dto.giatrihopdong);
                    item.SubItems.Add(ie7);
                    ListViewItem.ListViewSubItem ie8 = new ListViewItem.ListViewSubItem(item, dto.phuongthucthanhtoan);
                    item.SubItems.Add(ie8);
                    ListViewItem.ListViewSubItem ie9 = new ListViewItem.ListViewSubItem(item, dto.ngay_bat_dau.ToShortDateString());
                    item.SubItems.Add(ie9);
                    ListViewItem.ListViewSubItem ie10 = new ListViewItem.ListViewSubItem(item, dto.ngay_ket_thuc.ToShortDateString());
                    item.SubItems.Add(ie10);
                    ListViewItem.ListViewSubItem ie11 = new ListViewItem.ListViewSubItem(item, dto.ngay_tao.ToShortDateString());
                    item.SubItems.Add(ie11);

                    lvthongtintimkiem.Items.Add(item);
                    STT++;
                }
            }
        }
    }
}
