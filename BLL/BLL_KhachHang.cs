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
    public class BLL_KhachHang
    {
        DAL_KhachHang KH = new DAL_KhachHang();
        public List<DTO_KhachHang>GetAll_KH()
        {
            return KH.GetAll_KH();      
        }
        public List<DTO_KhachHang> GetAll_KH_ID(string KHID)
        {
            return KH.GetAll_KH_ID(KHID);
        }
        //public DataTable GetAll_KH_ID(string KHID)
        //{
        //    return KH.GetAll_KH_ID(KHID);
        //}
        //public List<DTO_KhachHang> GetAll_KH_HD_HH()
        //{
        //    return KH.GetAll_KH_HD_HH();
        //}
        public bool Create_KH(DTO_KhachHang kh)
        {
            return KH.Create_KH(kh);
        }
        public bool Update_KH(DTO_KhachHang kh)
        {
            return KH.Update_KH(kh);
        }
        public bool Delete_kh(string ma_kh)
        {
            return KH.Delete_kh(ma_kh);
        }
    }
}
