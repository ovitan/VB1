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
    public class BLL_HopDong
    {
        DAL_HopDong hd = new DAL_HopDong();
        public DataTable _Bang_Ma_Khach_Hang()
        {
            return hd._Bang_Ma_Khach_Hang();
        }
        public string _Ten_Khach_Hang_Theo_Ma_Khach_Hang(DTO_KhachHang kh)
        {
            return hd._Ten_Khach_Hang_Theo_Ma_Khach_Hang(kh);
        }
        public string _Ma_Hop_Dong()
        {
            return hd._Ma_Hop_Dong();
        }
        public int _Them_Hop_Dong(DTO_HopDong dt_hd)
        {
            return hd._Them_Hop_Dong(dt_hd);
        }
        public DTO_HopDong[] _List_Hop_Dong_Cung_Khach_Hang(DTO_HopDong dt_hd)
        {
            return hd._List_Hop_Dong_Cung_Khach_Hang(dt_hd);
        }
        public bool _Xoa_Hop_Dong(DTO_HopDong dto)
        {
            return hd._Xoa_Hop_Dong(dto);
        }
        public bool _Update_Hop_Dong(DTO_HopDong dto)
        {
            return hd._Update_Hop_Dong(dto);
        }
        public DTO_HopDong[] _Tim_Khach_Hang_Hop_Dong(DTO_HopDong dto)
        {
            return hd._Tim_Khach_Hang_Hop_Dong(dto);
        }
        public List<DTO_HopDong> GetAll_KH_HD_HH()
        {
            return hd.GetAll_KH_HD_HH();
        }
        public List<DTO_HopDong> GetAll_KH_ID(string KHID)
        {
            return hd.GetAll_KH_ID(KHID);
        }
        public List<DTO_HopDong> Ma_HD()
        {
            return hd.Ma_HD();
        }
    }
}
