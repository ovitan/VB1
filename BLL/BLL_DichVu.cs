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
    class BLL_DichVu
    {
        DAL_DichVu dv = new DAL_DichVu();
        public List<DTO_DichVu> GetAll_DV()
        {
            return dv.GetAll_DV();
        }
        public List<DTO_DichVu> DOngia(DTO_DichVu dto)
        {
            return dv.DOngia(dto);
        }
        public bool Create_DV(DTO_DichVu DV)
        {
            return dv.Create_DV(DV);
        }
        public bool Update_DV(DTO_DichVu DV)
        {
            return dv.Update_DVU(DV);
        }
        public bool Delete_DV(string ma_dv)
        {
            return dv.Delete_DV(ma_dv);
        }
        public List<DTO_DichVu> KV()
        {
            return dv.KV();
        }
        public List<DTO_DichVu> PV()
        {
            return dv.PV();
        }
        public List<DTO_DichVu> KV_2()
        {
            return dv.KV_2();
        }
        public List<DTO_DichVu> PV_2(DTO_DichVu dvv)
        {
            return dv.PV_2(dvv);
        }
        public List<DTO_DichVu> DOngia_2(DTO_DichVu dto)
        {
            return dv.DOngia_2(dto);
        }
    }
}
