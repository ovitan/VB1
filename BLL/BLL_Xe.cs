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
    public class BLL_Xe
    {
        DAL_Xe dal_xe = new DAL_Xe();
        public List<DTO_Xe> GetAll_Xe()
        {
            return dal_xe.GetAll_Xe();
        }
        public List<DTO_Xe> GetAll_Xe_1()
        {
            return dal_xe.GetAll_Xe_1();
        }
        public bool Create_Xe(DTO_Xe xe)
        {
            return dal_xe.Create_Xe(xe);
        }
        public bool Update_Xe(DTO_Xe xe)
        {
            return dal_xe.Update_Xe(xe);
        }
        public bool Delete_Xe(string ma_xe)
        {
            return dal_xe.Delete_Xe(ma_xe);
        }
    }
}
