using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;

namespace QLDVVTHH.BLL
{
    public class BLL_TraCuu
    {
        public DTO_KhachHang[] _Tim_KhachHang(DTO_KhachHang dto)
        {
          return new DAL_TraCuu()._Tim_KhachHang(dto);
        }
        public DTO_NhanVien[] _Tim_NhanVien(DTO_NhanVien dto)
        {
            return new DAL_TraCuu()._Tim_NhanVien(dto);
        }
        public DTO_Xe[] _Tim_ThongTinXe(DTO_Xe xe)
        {
            return new DAL_TraCuu()._Tim_ThongTinXe(xe);
        }
        public DTO_HoaDon[] _Tim_HoaDon(DTO_HoaDon dto)
        {
            return new DAL_TraCuu()._Tim_HoaDon(dto);
        }
        public DTO_HopDong[] _Tim_HopDong(DTO_HopDong dto)
        {
            return new DAL_TraCuu()._Tim_HopDong(dto);
        }
    }
}
