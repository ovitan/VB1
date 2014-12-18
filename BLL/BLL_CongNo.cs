using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DAL;
using QLDVVTHH.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLDVVTHH.BLL
{
    public class BLL_CongNo
    {
        public string _Ma_Cong_No()
        {
            return new DAL_CongNo()._Ma_Cong_No();
        }
        public DTO_HoaDon[] _List_Hoa_Don(DTO_HoaDon hoadon)
        {
            return new DAL_CongNo()._List_Hoa_Don(hoadon);
        }
        public int _Them_Cong_No_Khach_Hang(DTO_HoaDon hoadon, DTO_CongNo congno)
        {
            return new DAL_CongNo()._Them_Cong_No_Khach_Hang(hoadon, congno);
        }
        public DTO_CongNo[] _List_View_Cong_No_Khach_Hang(DTO_CongNo congno)
        {
            return new DAL_CongNo()._List_View_Cong_No_Khach_Hang(congno);
        }
        public int _Xoa_Cong_No(DTO_CongNo congno)
        {
            return new DAL_CongNo()._Xoa_Cong_No(congno);
        }
        public int _Them_Thanh_Toan_Cong_No(DTO_ThanhToan tt)
        {
            return new DAL_CongNo()._Them_Thanh_Toan_Cong_No(tt);
        }
        public DTO_ThanhToan[] _List_View_Thanh_Toan(DTO_ThanhToan tt)
        {
            return new DAL_CongNo()._List_View_Thanh_Toan(tt);
        }
        public int _Xoa_So_Tien_Thanh_Toan(DTO_ThanhToan tt)
        {
            return new DAL_CongNo()._Xoa_So_Tien_Thanh_Toan(tt);
        }
        public DTO_CongNo[] _Thong_Ke_Cong_No(DTO_CongNo congno)
        {
            return new DAL_CongNo()._Thong_Ke_Cong_No(congno);
        }
        public int _check_ma_hoa_don_cong_no(DTO_HoaDon hd)
        {
            return new DAL_CongNo()._check_ma_hoa_don_cong_no(hd);
        }
    }
}
