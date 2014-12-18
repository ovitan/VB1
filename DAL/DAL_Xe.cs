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
    public class DAL_Xe
    {
        ConnectData data = new ConnectData();
        public List<DTO_Xe> GetAll_Xe()
        {
            List<DTO_Xe> listxe = new List<DTO_Xe>();
            string sql = "select *,B.ten_tinh_trang from dm_xe A join dm_tinh_trang_xe B on A.ma_tinh_trang=B.ma_tinh_trang order by ngay_tao desc";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            if (dr != null)
            {
                while (dr.Read())
                {
                    DTO_Xe xe = new DTO_Xe();
                    xe.ma_so_xe = dr["ma_so_xe"].ToString();
                    //xe.ma_tinh_trang = Convert.ToInt32(dr["ma_tinh_trang"].ToString());
                    xe.loai_xe = dr["loai_xe"].ToString();
                    xe.nhan_hieu = dr["nhan_hieu"].ToString();
                    xe.trong_luong =Convert.ToInt32(dr["trong_luong"].ToString());
                    xe.ngay_tao = Convert.ToDateTime(dr["ngay_tao"].ToString());
                    xe.ten_tinh_trang = dr["ten_tinh_trang"].ToString();
                    listxe.Add(xe);
                }
                data.DisConnect();
            }
            return listxe;
        }
        public List<DTO_Xe> GetAll_Xe_1()
        {
            List<DTO_Xe> listxe_1 = new List<DTO_Xe>();
            string sql = "select *,B.ten_tinh_trang from dm_xe A join dm_tinh_trang_xe B on A.ma_tinh_trang=B.ma_tinh_trang and ten_tinh_trang=N'Đang ở bãi' order by ngay_tao desc";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            if (dr != null)
            {
                while (dr.Read())
                {
                    DTO_Xe xe = new DTO_Xe();
                    xe.ma_so_xe = dr["ma_so_xe"].ToString();
                    xe.ma_tinh_trang = Convert.ToInt32(dr["ma_tinh_trang"].ToString());
                    xe.loai_xe = dr["loai_xe"].ToString();
                    xe.nhan_hieu = dr["nhan_hieu"].ToString();
                    xe.trong_luong = Convert.ToInt32(dr["trong_luong"].ToString());
                    xe.ngay_tao = Convert.ToDateTime(dr["ngay_tao"].ToString());
                    xe.ten_tinh_trang = dr["ten_tinh_trang"].ToString();
                    listxe_1.Add(xe);
                }
                data.DisConnect();
            }
            return listxe_1;
        }
        public bool Create_Xe(DTO_Xe xe)
        {
            string sql = "insert into dm_xe(ma_so_xe,trong_luong,loai_xe,nhan_hieu,ma_tinh_trang,ngay_tao) values(@ma_so_xe,@trong_luong,@loai_xe,@nhan_hieu,@ma_tinh_trang,@ngay_tao)";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_so_xe",xe.ma_so_xe),
                new SqlParameter("@trong_luong",xe.trong_luong),
                new SqlParameter("@loai_xe",xe.loai_xe),
                new SqlParameter("@nhan_hieu",xe.nhan_hieu),
                new SqlParameter("@ma_tinh_trang",xe.ma_tinh_trang.ToString()),
                new SqlParameter("@ngay_tao",xe.ngay_tao)         
            };
            return data.ExcuteNonQuery(sql, prs);
        }
        public bool Update_Xe( DTO_Xe xe)
        {
            string sql = "update dm_xe set trong_luong=@trong_luong,loai_xe=@loai_xe,nhan_hieu=@nhan_hieu,ma_tinh_trang=@ma_tinh_trang,ngay_tao=@ngay_tao where ma_so_xe=@ma_so_xe";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_so_xe",xe.ma_so_xe),
                new SqlParameter("@trong_luong",xe.trong_luong),
                new SqlParameter("@loai_xe",xe.loai_xe),
                new SqlParameter("@nhan_hieu",xe.nhan_hieu),
                new SqlParameter("@ma_tinh_trang",xe.ma_tinh_trang),
                new SqlParameter("@ngay_tao",xe.ngay_tao)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
        public bool Delete_Xe(string ma_so_xe)
        {
            string sql = "delete dm_xe where ma_so_xe=@ma_so_xe";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_so_xe",ma_so_xe)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
    }
}
