using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;

namespace QLDVVTHH.DAL
{
    class DAL_Tinhtrangxe
    {
        ConnectData data = new ConnectData();
        public List<DTO_TinhTrangXe> GetAll_TTXE()
        {
            string sql = "select * from dm_tinh_trang_xe";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_TinhTrangXe>(dr);
        }
        public bool Create_TTxe(DTO_TinhTrangXe TTxe)
        {
            string sql = "insert into dm_tinh_trang_xe(ma_tinh_trang,ten_tinh_trang) values(@ma_tinh_trang,@ten_tinh_trang)";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_tinh_trang",TTxe.ma_tinh_trang),
                new SqlParameter("@ten_tinh_trang",TTxe.ten_tinh_trang)
            };
            return data.ExcuteNonQuery(sql, prs); 
        }
        public bool Update_TTxe(DTO_TinhTrangXe TTxe)
        {
            string sql = "update dm_tinh_trang_xe set ten_tinh_trang=@ten_tinh_trang where ma_tinh_trang=@ma_tinh_trang";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_tinh_trang",TTxe.ma_tinh_trang),
                new SqlParameter("@ten_tinh_trang",TTxe.ten_tinh_trang)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
        public bool Delete_TTxe(string ma_tt)
        {
            string sql = "delete [dm_tinh_trang_xe] where ma_tinh_trang = @ma_tinh_trang";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_tinh_trang",ma_tt)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
    }
}
