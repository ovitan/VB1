using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLDVVTHH.DAL
{
    public  class DAL_TraCuu
    {
        ConnectData data = new ConnectData();
        //TIM KHACH HANG
        public DTO_KhachHang[] _Tim_KhachHang(DTO_KhachHang dto)
        {
            string sql = "select * from dm_khach_hang where ma_khach_hang like '%"+dto.ma_khach_hang.Trim()+"%' and ten_khach_hang like N'%"+dto.ten_khach_hang.Trim()+"%'";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt.Rows.Count > 0)
            {
                DTO_KhachHang[] khachhang = new DTO_KhachHang[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    khachhang[i] = new DTO_KhachHang();
                    khachhang[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    khachhang[i].ten_khach_hang = dt.Rows[i]["ten_khach_hang"].ToString();
                    khachhang[i].ma_so_thue = dt.Rows[i]["ma_so_thue"].ToString();
                    khachhang[i].dia_chi = dt.Rows[i]["dia_chi"].ToString();
                    khachhang[i].dien_thoai = dt.Rows[i]["dien_thoai"].ToString();
                    khachhang[i].fax= dt.Rows[i]["fax"].ToString();
                }
                return khachhang;
            }
            return null;
        }
        //TIM NHAN VIEN
        public DTO_NhanVien[] _Tim_NhanVien(DTO_NhanVien dto)
        {
            string sql = "select * from dm_nhan_vien where  ma_nhan_vien like '%"+dto.ma_nhan_vien.Trim()+"%' and ten_nhan_vien like N'%"+dto.ten_nhan_vien.Trim()+"%' ";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt.Rows.Count > 0)
            {
                DTO_NhanVien[] khachhang = new DTO_NhanVien[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    khachhang[i] = new DTO_NhanVien();
                    khachhang[i].ma_nhan_vien = dt.Rows[i]["ma_nhan_vien"].ToString();
                    khachhang[i].ten_nhan_vien = dt.Rows[i]["ten_nhan_vien"].ToString();
                    khachhang[i].cmnd = dt.Rows[i]["cmnd"].ToString();
                    khachhang[i].dia_chi = dt.Rows[i]["dia_chi"].ToString();
                    khachhang[i].dien_thoai = dt.Rows[i]["dien_thoai"].ToString();
                    khachhang[i].nam_sinh =Convert.ToDateTime(dt.Rows[i]["nam_sinh"].ToString());
                    khachhang[i].chucvu = dt.Rows[i]["chucvu"].ToString();
                }
                return khachhang;
            }
            return null;
        }
        //TIM THONG TIN XE
        public DTO_Xe[] _Tim_ThongTinXe(DTO_Xe xe)
        {
            string sql = "select * from dm_xe,dm_tinh_trang_xe where dm_xe.ma_tinh_trang=dm_tinh_trang_xe.ma_tinh_trang and ma_so_xe like '%"+xe.ma_so_xe.Trim()+"%' ";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt.Rows.Count > 0)
            {
                DTO_Xe[] Xxe = new DTO_Xe[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Xxe[i] = new DTO_Xe();
                    Xxe[i].ma_so_xe = dt.Rows[i]["ma_so_xe"].ToString();
                    Xxe[i].loai_xe = dt.Rows[i]["loai_xe"].ToString();
                    Xxe[i].trong_luong =float.Parse(dt.Rows[i]["trong_luong"].ToString());
                    Xxe[i].nhan_hieu = dt.Rows[i]["nhan_hieu"].ToString();
                    Xxe[i].ten_tinh_trang = dt.Rows[i]["ten_tinh_trang"].ToString();
                    Xxe[i].ngay_tao = Convert.ToDateTime(dt.Rows[i]["ngay_tao"].ToString());
                }
                return Xxe;
            }
            return null;
        }
        //TIM HOA DON
        public DTO_HoaDon[] _Tim_HoaDon(DTO_HoaDon dto)
        {
            string sql = "declare @dem int "
                + "select @dem=COUNT(*)  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%"+dto.ma_hoa_don.Trim()+"%' and dm_hop_dong.ma_hop_dong like '%%' and dm_khach_hang.ma_khach_hang like '%%' "
                + "if(@dem>0) "
                + "begin "
                + "select dm_hoa_don.*,ten_khach_hang  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%" + dto.ma_hoa_don.Trim() + "%' and dm_hop_dong.ma_hop_dong like '%%' and dm_khach_hang.ma_khach_hang like '%%' "
                + "end "
                + "else "
                + "begin "
                + "select @dem=COUNT(*)  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%%' and dm_hop_dong.ma_hop_dong like '%" + dto.ma_hoa_don.Trim() + "%' and dm_khach_hang.ma_khach_hang like '%%' "
                + "if(@dem>0) "
                + "begin "
                + "select dm_hoa_don.*,ten_khach_hang  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%%' and dm_hop_dong.ma_hop_dong like '%" + dto.ma_hoa_don.Trim() + "%' and dm_khach_hang.ma_khach_hang like '%%' "
                + "end "
                + "else "
                + "begin "
                + "select dm_hoa_don.*,ten_khach_hang  from dm_hoa_don,dm_khach_hang,dm_hop_dong where dm_hoa_don.ma_khach_hang=dm_khach_hang.ma_khach_hang and dm_hop_dong.ma_hop_dong=dm_hoa_don.ma_hop_dong and ma_hoa_don like '%%' and dm_hop_dong.ma_hop_dong like '%%' and dm_khach_hang.ma_khach_hang like '%" + dto.ma_hoa_don.Trim() + "%' "
                + "end "
                + "end ";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt.Rows.Count > 0)
            {
                DTO_HoaDon[] Xxe = new DTO_HoaDon[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Xxe[i] = new DTO_HoaDon();
                    Xxe[i].ma_hoa_don = dt.Rows[i]["ma_hoa_don"].ToString();
                    Xxe[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    Xxe[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    Xxe[i].tenkhachhang = dt.Rows[i]["ten_khach_hang"].ToString();
                    //Xxe[i].ngay_tao = Convert.ToDateTime(dt.Rows[i]["ngay_tao"].ToString());
                    //Xxe[i].tu_ngay = Convert.ToDateTime(dt.Rows[i]["tu_ngay"].ToString());
                    //Xxe[i].den_ngay = Convert.ToDateTime(dt.Rows[i]["den_ngay"].ToString());
                    Xxe[i].tong_khoi_luong = float.Parse(dt.Rows[i]["tongkhoiluong"].ToString());
                    Xxe[i].tong_cuot_van_chuyen = float.Parse(dt.Rows[i]["tongcuocvanchuyen"].ToString());
                }
                return Xxe;
            }
            return null;
        }
        //TIM HOA DON
        public DTO_HopDong[] _Tim_HopDong(DTO_HopDong dto)
        {
            string sql = "select dm_hop_dong.*,ten_khach_hang from dm_hop_dong,dm_khach_hang where dm_khach_hang.ma_khach_hang=dm_hop_dong.ma_khach_hang and ma_hop_dong like '%"+dto.ma_hop_dong.Trim()+"%' ";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt.Rows.Count > 0)
            {
                DTO_HopDong[] hd = new DTO_HopDong[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hd[i] = new DTO_HopDong();
                    hd[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    hd[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    hd[i].ngay_tao =Convert.ToDateTime(dt.Rows[i]["ngay_tao"].ToString());
                    hd[i].ngay_bat_dau = Convert.ToDateTime(dt.Rows[i]["ngaybatdau"].ToString());
                    hd[i].ngay_ket_thuc = Convert.ToDateTime(dt.Rows[i]["ngayketthuc"].ToString());
                    hd[i].loaihanghoa = dt.Rows[i]["loaihanghoa"].ToString();
                    hd[i].lotrinhvanchuyen = dt.Rows[i]["lotrinhvanchuyen"].ToString();
                    hd[i].phuongthucvanchuyen = dt.Rows[i]["phuongthucvanchuyen"].ToString();
                    hd[i].giatrihopdong = dt.Rows[i]["giatrihopdong"].ToString();
                    hd[i].phuongthucthanhtoan = dt.Rows[i]["phuongthucthanhtoan"].ToString();
                    hd[i].ten_khach_hang = dt.Rows[i]["ten_khach_hang"].ToString();
                }
                return hd;
            }
            return null;
        }
    }
}
