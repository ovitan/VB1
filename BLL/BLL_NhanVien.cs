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
    public class BLL_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        //public List<DAL_NhanVien> GetAllNhanvien()
        //{
        //    return nv.GetAllNhanvien();
        //}
        public List<DTO_NhanVien> dt_GetAll()
        {
            return nv.dt_GetAll();
        }
        public List<DTO_NhanVien> GetAll_NV_ID(string NVID)
        {
            return nv.GetAll_NV_ID(NVID);
        }
        //public List<DTO_NhanVien> GetAll_NV()
        //{
        //    return nv.GetAll_NV();
        //}
        public bool Create_nv(DTO_NhanVien nhanvien)
        {
            return nv.Create_nv(nhanvien);
        }
        public bool Update_nv(DTO_NhanVien nhanvien)
        {
            return nv.Update_nv(nhanvien);
        }
        public bool Delete_nv(string ma_nv)
        {
            return nv.Delete_nv(ma_nv);
        }
    }
}
