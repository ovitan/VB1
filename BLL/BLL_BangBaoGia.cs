using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DAL;
using QLDVVTHH.DTO;
namespace QLDVVTHH.BLL
{
    public class BLL_BangBaoGia
    {
        DAL_BangBaoGia bbg = new DAL_BangBaoGia();
        public List<DTO_BangBaoGia> GetALl_BG()
        {
            return bbg.GetALl_BG();
        }
        public bool Create_BG(DTO_BangBaoGia BG)
        {
            return bbg.Create_BG(BG);
        }
        public bool Update_BG(DTO_BangBaoGia BG)
        {
            return bbg.Update_BG(BG);
        }
        public bool Delete_BG(string ma_BG)
        {
            return bbg.Delete_BG(ma_BG);
        }
        public string Ma_BG()
        {
            return bbg.Ma_BG();
        }
        //public string _Ma_Bang_Bao_Gia()
        //{
        //    return new DAL_BangBaoGia()._Ma_Bang_Bao_Gia();
        //}
        //public DTO_BangBaoGia[] _DS_Combobox_Noi_Nhan(DTO_BangBaoGia dto)
        //{
        //    return new DAL_BangBaoGia()._DS_Combobox_Noi_Nhan(dto);
        //}
        //public DTO_BangBaoGia[] _DS_Combobox_Noi_Giao(DTO_BangBaoGia dto)
        //{
        //    return new DAL_BangBaoGia()._DS_Combobox_Noi_Giao(dto);
        //}
        //public int _Them_BaoGia(DTO_BangBaoGia dto)
        //{
        //    return new DAL_BangBaoGia()._Them_BaoGia(dto);
        //}
        //public DTO_BangBaoGia[] _DS_ListView_BangBaoGia(DTO_BangBaoGia dto)
        //{
        //    return new DAL_BangBaoGia()._DS_ListView_BangBaoGia(dto);
        //}
        public DTO_HopDong[] _DS_Date_ThoiGianHopDong(DTO_HopDong dto)
        {
            return new DAL_BangBaoGia()._DS_Date_ThoiGianHopDong(dto);
        }
        //public int _Xoa_BaoGia(DTO_BangBaoGia dto)
        //{
        //    return new DAL_BangBaoGia()._Xoa_BaoGia(dto);
        //}
        //public int _CapNhat_BaoGia(DTO_BangBaoGia dto)
        //{
        //    return new DAL_BangBaoGia()._CapNhat_BaoGia(dto);
        //}
        //public int _ApDungBaoGia_BangKe(DTO_HopDong hopdong, DTO_BangBaoGia baogia)
        //{
        //    return new DAL_BangBaoGia()._ApDungBaoGia_BangKe(hopdong, baogia);
        //}
    }
}
