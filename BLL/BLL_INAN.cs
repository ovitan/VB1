using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;
namespace QLDVVTHH.BLL
{
    public class BLL_INAN
    {
        public int _Luu_Data_Khach_Hang_Rpt()
        {
            return new DAL_INAN()._Luu_Data_Khach_Hang_Rpt();
        }
        public int _Luu_Data_Nhan_Vien_Rpt()
        {
            return new DAL_INAN()._Luu_Data_Khach_Hang_Rpt();
        }
        public int _Luu_Data_Xe_Rpt()
        {
            return new DAL_INAN()._Luu_Data_Xe_Rpt();
        }
        public int _Luu_Data_Hoa_Don(DTO_HoaDon dto)
        {
            return new DAL_INAN()._Luu_Data_Hoa_Don(dto);
        }
    }
}
