using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QLDVVTHH.BLL
{
    public class BLL_HoaDon
    {
        public string _Ma_Hoa_Don()
        {
            return new DAL_HoaDon()._Ma_Hoa_Don();
        }
        public int _Lap_Hoa_Hon_Van_Chuyen(DTO_HopDong hopdong, DTO_HoaDon hoadon)
        {
            return new DAL_HoaDon()._Lap_Hoa_Hon_Van_Chuyen( hopdong, hoadon);
        }
        public DTO_HoaDon[] _List_Hoa_Hon_Van_Chuyen(DTO_HoaDon hoadon)
        {
            return new DAL_HoaDon()._List_Hoa_Hon_Van_Chuyen(hoadon);
        }
        public DTO_BangKe[] _List_Chi_Tiet_Hoa_Hon_Van_Chuyen(DTO_Chi_Tiet_Hoa_Don ct)
        {
            return new DAL_HoaDon()._List_Chi_Tiet_Hoa_Hon_Van_Chuyen(ct);
        }
        public int _Xoa_Hoa_Don_Van_Chuyen(DTO_HoaDon hoadon)
        {
            return new DAL_HoaDon()._Xoa_Hoa_Don_Van_Chuyen(hoadon);
        }
        public DTO_HoaDon[] _Tim_Hoa_Hon_Van_Chuyen(DTO_HoaDon hoadon)
        {
            return new DAL_HoaDon()._Tim_Hoa_Hon_Van_Chuyen(hoadon);
        }
        public DTO_HoaDon[] _List_Hoa_Don(DTO_HoaDon hoadon)
        {
            return new DAL_HoaDon()._List_Hoa_Don(hoadon);
        }
    }
}
