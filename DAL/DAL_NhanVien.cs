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
    public class DAL_NhanVien
    {
        ConnectData data = new ConnectData();

        
        //public DataTable dt_GetAll()
        //{
        //    string sql = "select * from dm_nhan_vien";
        //    return data.ExcuteDataTable(sql, null);
        //}
        public List<DTO_NhanVien> dt_GetAll()
        {
            string sql = "select *,B.ma_so_xe from dm_xe A join dm_nhan_vien B on A.ma_so_xe=B.ma_so_xe order by A.ngay_tao desc";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_NhanVien>(dr);
        }
        //public List<DTO_NhanVien> GetAll_NV()
        //{
        //    string sql = "select * from dm_nhan_vien";
        //    SqlDataReader dr = data.ExcuteDataReader(sql, null);
        //    return data.MapDataReaderToObject<DTO_NhanVien>(dr);
        //}
        public List<DTO_NhanVien> GetAll_NV_ID(string NVID)
        {
            string sql = "select *,B.ma_so_xe from dm_nhan_vien A join dm_xe B on A.ma_so_xe = B.ma_so_xe where A.ma_so_xe = @ma_so_xe";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_so_xe",NVID)
            };
            SqlDataReader dr = data.ExcuteDataReader(sql, prs);
            return data.MapDataReaderToObject<DTO_NhanVien>(dr);
        }
        public bool Create_nv(DTO_NhanVien nhanvien)
        {
            string sql = "insert into dm_nhan_vien(ma_nhan_vien,ten_nhan_vien,ma_so_xe,cmnd,dia_chi,dien_thoai,nam_sinh,ngay_tao,chucvu) values(@ma_nhan_vien,@ten_nhan_vien,@ma_so_xe,@cmnd,@dia_chi,@dien_thoai,@nam_sinh,@ngay_tao,@chucvu)";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_nhan_vien",nhanvien.ma_nhan_vien),
                new SqlParameter("@ten_nhan_vien",nhanvien.ten_nhan_vien),
                new SqlParameter("@ma_so_xe",nhanvien.ma_so_xe),
                new SqlParameter("@cmnd",nhanvien.cmnd),
                new SqlParameter("@dia_chi",nhanvien.dia_chi),
                new SqlParameter("@dien_thoai",nhanvien.dien_thoai),
                new SqlParameter("@nam_sinh",nhanvien.nam_sinh),
                new SqlParameter("@ngay_tao",nhanvien.ngay_tao),
                new SqlParameter("@chucvu",nhanvien.chucvu)
            };
            return data.ExcuteNonQuery(sql, prs); 
        }
        public bool Update_nv(DTO_NhanVien nhanvien)
        {
            string sql = "update dm_nhan_vien set ten_nhan_vien=@ten_nhan_vien,ma_so_xe=@ma_so_xe,cmnd=@cmnd,dia_chi=@dia_chi,dien_thoai=@dien_thoai,nam_sinh=@nam_sinh,ngay_tao=@ngay_tao,chucvu=@chucvu where ma_nhan_vien=@ma_nhan_vien";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_nhan_vien",nhanvien.ma_nhan_vien),
                new SqlParameter("@ten_nhan_vien",nhanvien.ten_nhan_vien),
                new SqlParameter("@ma_so_xe",nhanvien.ma_so_xe),
                new SqlParameter("@cmnd",nhanvien.cmnd),
                new SqlParameter("@dia_chi",nhanvien.dia_chi),
                new SqlParameter("@dien_thoai",nhanvien.dien_thoai),
                new SqlParameter("@nam_sinh",nhanvien.nam_sinh),
                new SqlParameter("@ngay_tao",nhanvien.ngay_tao),
                new SqlParameter("@chucvu",nhanvien.chucvu)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
        public bool Delete_nv(string ma_nv)
        {
            string sql = "delete [dm_nhan_vien] where ma_nhan_vien = @ma_nhan_vien";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_nhan_vien",ma_nv)
            };
            return data.ExcuteNonQuery(sql, prs);
        }
    }
}