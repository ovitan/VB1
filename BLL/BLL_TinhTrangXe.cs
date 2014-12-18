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
    class BLL_TinhTrangXe
    {
        DAL_Tinhtrangxe ttxe = new DAL_Tinhtrangxe();
        public List<DTO_TinhTrangXe> GetAll_TTXE()
        {
            return ttxe.GetAll_TTXE();
        }
        public bool Create_TTxe(DTO_TinhTrangXe TTxe)
        {
            return ttxe.Create_TTxe(TTxe);
        }
        public bool Update_TTxe(DTO_TinhTrangXe TTxe)
        {
            return ttxe.Update_TTxe(TTxe);
        }
        public bool Delete_TTxe(string ma_tt)
        {
            return ttxe.Delete_TTxe(ma_tt);
        }
    }
}
