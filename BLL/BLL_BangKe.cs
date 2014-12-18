using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;

namespace QLDVVTHH.BLL
{
    public class BLL_BangKe
    {
        public DataTable _List_Hop_Dong(DTO_HopDong hd)
        {
            return new DAL_BangKe()._List_Hop_Dong(hd);
        }
        public String _Ma_Bang_Ke()
        {
            return new DAL_BangKe()._Ma_Bang_Ke();
        }
        public int _Them_BangKe(DTO_BangKe dto)
        {
            return new DAL_BangKe()._Them_BangKe(dto);
        }
        public DTO_BangKe[] DanhSachBangKe_TheoMaKhachHang_MaHopDong(DTO_BangKe dto)
        {
            return new DAL_BangKe()._DanhSachBangKe_TheoMaKhachHang_MaHopDong(dto);
        }
        public int _CapNhat_BangKe(DTO_BangKe dto)
        {
            return new DAL_BangKe()._CapNhat_BangKe(dto);
        }
        public int _Xoa_BangKe(DTO_BangKe dto)
        {
            return new DAL_BangKe()._Xoa_BangKe(dto);
        }
        public DTO_BangKe[] _Tim_BangKe(DTO_BangKe bangke, DTO_HopDong hopdong, DTO_KhachHang khachhang)
        {
            return new DAL_BangKe()._Tim_BangKe(bangke, hopdong, khachhang);
        }
        public DataTable _List_Ten_Khach_Hang()
        {
            return new DAL_BangKe()._List_Ten_Khach_Hang();
        }
        public DTO_DieuXe[] _List_Ma_Dieu_Xe(DTO_DieuXe _xe)
        {
            return new DAL_BangKe()._List_Ma_Dieu_Xe(_xe);
        }
    }
}
