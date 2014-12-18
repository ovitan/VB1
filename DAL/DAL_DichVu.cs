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
    class DAL_DichVu
    {
        ConnectData data = new ConnectData();
        public List<DTO_DichVu> GetAll_DV()
        {
            string sql = "select * from dm_dich_vu";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DichVu>(dr);
        }
        public List<DTO_DichVu> KV()
        {
            string sql = "select khu_vuc from dm_dich_vu";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DichVu>(dr);
        }
        public List<DTO_DichVu> KV_2()
        {
            string sql = "select distinct khu_vuc from dm_dich_vu";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_DichVu> dvv = new List<DTO_DichVu>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_DichVu d = new DTO_DichVu();
                    d.khu_vuc = dr["khu_vuc"].ToString();
                    dvv.Add(d);
                }
                return dvv;
            }
            return null;
        }
        public List<DTO_DichVu> PV()
        {
            string sql = "select phan_vung from dm_dich_vu";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DichVu>(dr);
        }
        public List<DTO_DichVu> PV_2(DTO_DichVu dv)
        {
            string sql = "select phan_vung from dm_dich_vu where khu_vuc='"+dv.khu_vuc.Trim()+"'";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_DichVu> dvv = new List<DTO_DichVu>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_DichVu d = new DTO_DichVu();
                    d.phan_vung = dr["phan_vung"].ToString();
                    dvv.Add(d);
                }
                return dvv;
            }
            return null;
        }
        public List<DTO_DichVu> DOngia(DTO_DichVu dto)
        {
            string sql = "select * from dm_dich_vu  where khu_vuc='" + dto.khu_vuc.Trim() + "'";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DichVu>(dr);
        }
        public List<DTO_DichVu> DOngia_2(DTO_DichVu dto)
        {
            string sql = "select * from dm_dich_vu  where khu_vuc='" + dto.khu_vuc.Trim() + "' and phan_vung='"+dto.phan_vung.Trim()+"'";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DichVu>(dr);
        }
        public bool Create_DV(DTO_DichVu DV)
        {
            string sql = "insert into dm_dich_vu(khu_vuc,phan_vung,don_gia_chuyen,don_gia_tan) values(@khu_vuc,@phan_vung,@don_gia_chuyen,@don_gia_tan)";
            SqlParameter[] prs = 
            {
                new SqlParameter("@khu_vuc",DV.khu_vuc),
                new SqlParameter("@phan_vung",DV.phan_vung),
                new SqlParameter("@don_gia_chuyen",DV.don_gia_chuyen),
                new SqlParameter("@don_gia_tan",DV.don_gia_tan)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
        public bool Update_DVU(DTO_DichVu DV)
        {
            string sql = "update dm_dich_vu set phan_vung=@phan_vung,don_gia_chuyen=@don_gia_chuyen,don_gia_tan=@don_gia_tan where khu_vuc=@khu_vuc";
            SqlParameter[] prs = 
            {
                new SqlParameter("@khu_vuc",DV.khu_vuc),
                new SqlParameter("@phan_vung",DV.phan_vung),
                new SqlParameter("@don_gia_chuyen",DV.don_gia_chuyen),
                new SqlParameter("@don_gia_tan",DV.don_gia_tan)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
        public bool Delete_DV(string ma_dv)
        {
            string sql = "delete [dm_dich_vu] where khu_vuc=@khu_vuc";
            SqlParameter[] prs = 
            {
                new SqlParameter("@khu_vuc",ma_dv),
                //new SqlParameter("@phan_vung",ma_dv)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
    }
}
