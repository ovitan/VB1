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
    public class DAL_KhachHang
    {
        ConnectData data = new ConnectData();
        //public DataTable GetAll_KH()
        //{
        //    string sql = "select * from dm_khach_hang";
        //    return data.ExcuteDataTable(sql, null);
        //}
        public List<DTO_KhachHang>GetAll_KH()
        {
            string sql = "select * from dm_khach_hang";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_KhachHang>(dr);
        }
        //public List<DTO_KhachHang> GetAll_KH_HD_HH()
        //{
        //    string sql = "select *, A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang order by B.ngay_tao desc";
        //    SqlDataReader dr = data.ExcuteDataReader(sql, null);
        //    return data.MapDataReaderToObject<DTO_KhachHang>(dr);
        //}
        public List<DTO_KhachHang> GetAll_KH_ID(string KHID)
        {
            string sql = "select A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang where B.ma_khach_hang = @ma_khach_hang";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_khach_hang",KHID)
            };
            SqlDataReader dr = data.ExcuteDataReader(sql, prs);
            return data.MapDataReaderToObject<DTO_KhachHang>(dr);
        }
        //public DataTable GetAll_KH_ID(string KHID)
        //{
        //    string sql = "select ma_hop_dong from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang where A.ma_khach_hang = @ma_khach_hang";
        //    SqlParameter[] prs = 
        //    {
        //        new SqlParameter("@ma_khach_hang",KHID)
        //    };
        //    return data.ExcuteDataTable(sql, prs);
        //}
        public bool Create_KH(DTO_KhachHang kh)
        {
            string sql = "insert into dm_khach_hang(ma_khach_hang,ten_khach_hang,ma_so_thue,fax,dia_chi,dien_thoai,ngay_tao) values(@ma_khach_hang,@ten_khach_hang,@ma_so_thue,@fax,@dia_chi,@dien_thoai,@ngay_tao)";
            SqlParameter[] prs =
            {
                new SqlParameter("@ma_khach_hang",kh.ma_khach_hang),
                new SqlParameter("@ten_khach_hang",kh.ten_khach_hang),
                new SqlParameter("@ma_so_thue",kh.ma_so_thue),
                new SqlParameter("@fax",kh.fax),
                new SqlParameter("@dia_chi",kh.dia_chi),
                new SqlParameter("@dien_thoai",kh.dien_thoai),
                new SqlParameter("@ngay_tao",kh.ngay_tao)
            };
            return data.ExcuteNonQuery(sql,prs); 
        }
        public bool Update_KH(DTO_KhachHang kh)
        {
            string sql = "update dm_khach_hang set ten_khach_hang=@ten_khach_hang,ma_so_thue=@ma_so_thue,dia_chi=@dia_chi,dien_thoai=@dien_thoai,fax=@fax,ngay_tao=@ngay_tao where ma_khach_hang=@ma_khach_hang";
            SqlParameter[] prs =
            {
                new SqlParameter("@ma_khach_hang",kh.ma_khach_hang),
                new SqlParameter("@ten_khach_hang",kh.ten_khach_hang),
                new SqlParameter("@ma_so_thue",kh.ma_so_thue),
                new SqlParameter("@fax",kh.fax),
                new SqlParameter("@dia_chi",kh.dia_chi),
                new SqlParameter("@dien_thoai",kh.dien_thoai),
                new SqlParameter("@ngay_tao",kh.ngay_tao)
            };
            return data.ExcuteNonQuery(sql, prs); 
        }
        public bool Delete_kh(string ma_kh)
        {
            string sql = "delete [dm_khach_hang] where ma_khach_hang = @ma_khach_hang";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_khach_hang",ma_kh)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
    }
}
