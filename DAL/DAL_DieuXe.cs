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
    class DAL_DieuXe
    {
        ConnectData data = new ConnectData();
        public List<DTO_DieuXe> GetAll_DX()
        {
            string sql = "select ma_dieu_xe,ma_so_xe,so_tan,A.ma_khach_hang,noi_giao,noi_nhan,ngay_dieu_xe,ngay_ve,ma_so_xe,dia_chi,fax,ngay_tao, B.ten_khach_hang,case tinh_trang_thanh_toan when 0 then N'Chưa Thanh Toán' when 1 then N'Đã Thanh Toán' end as 'tinh_trang_thanh_toan' from dm_dieu_xe A join dm_khach_hang B on A.ma_khach_hang = B.ma_khach_hang";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DieuXe>(dr);
        }
        public List<DTO_Xe> Get_TrongLuongXe(DTO_Xe dto)
        {
            string sql = "select * from dm_xe  where ma_so_xe='" + dto.ma_so_xe.Trim() + "'";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_Xe>(dr);
        }
        public bool Create_DX(DTO_DieuXe DX)
        {
            string sql = "insert into dm_dieu_xe(ma_hop_dong,ma_dieu_xe,ma_so_xe,ma_khach_hang,noi_giao,noi_nhan,so_tan,ngay_dieu_xe,tinh_trang_thanh_toan) values(@ma_hop_dong,@ma_dieu_xe,@ma_so_xe,@ma_khach_hang,@noi_giao,@noi_nhan,@so_tan,@ngay_dieu_xe,0)";
            SqlParameter[] prs =
            {
                new SqlParameter("@ma_hop_dong",DX.ma_hop_dong.Trim()),
                new SqlParameter("@ma_dieu_xe",DX.ma_dieu_xe.Trim()),
                new SqlParameter("@ma_so_xe",DX.ma_so_xe.Trim()),
                new SqlParameter("@ma_khach_hang",DX.ma_khach_hang.Trim()),
                new SqlParameter("@noi_giao",DX.noi_giao.Trim()),
                new SqlParameter("@noi_nhan",DX.noi_nhan.Trim()),
                new SqlParameter("@ngay_dieu_xe",DX.ngay_dieu_xe),
                new SqlParameter("@so_tan",DX.so_tan),
            };
            if (data.ExcuteNonQuery(sql, prs) == true)
            {
                string Update = "Update dm_xe set ma_tinh_trang=2 where ma_so_xe='" + DX.ma_so_xe.Trim() + "' ";
                data.ExcuteNonQuery(Update, null);
            }
            return true;
        }
        public bool Update_DX (DTO_DieuXe DXE)
        {
            string sql = "update dm_dieu_xe set ngay_ve=@ngay_ve,tinh_trang_thanh_toan=@tinh_trang_thanh_toan, ma_so_xe=@ma_so_xe,ma_khach_hang=@ma_khach_hang,noi_giao=@noi_giao,noi_nhan=@noi_nhan,so_tan=@so_tan,ngay_dieu_xe=@ngay_dieu_xe where ma_dieu_xe=@ma_dieu_xe";
            SqlParameter[] prs =
            {
                new SqlParameter("@ma_dieu_xe",DXE.ma_dieu_xe),
                new SqlParameter("@ma_so_xe",DXE.ma_so_xe),
                new SqlParameter("@ma_khach_hang",DXE.ma_khach_hang),
                new SqlParameter("@noi_giao",DXE.noi_giao),
                new SqlParameter("@noi_nhan",DXE.noi_nhan),
                new SqlParameter("@ngay_dieu_xe",DXE.ngay_dieu_xe),
                new SqlParameter("@so_tan",DXE.so_tan),
                new SqlParameter("@ngay_ve",DXE.ngay_ve),
                new SqlParameter("@tinh_trang_thanh_toan",DXE.tttt)
            };
            if (data.ExcuteNonQuery(sql, prs) == true)
            {
                string Update = "Update dm_xe set ma_tinh_trang=1 where ma_so_xe='" + DXE.ma_so_xe.Trim() + "' ";
                data.ExcuteNonQuery(Update, null);
            }
            return true;
        }
        public bool Delete_Dxe(string ma_dx)
        {
            string sql = "delete [dm_dieu_xe] where ma_dieu_xe = @ma_dieu_xe";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_dieu_xe",ma_dx)
            };
            return data.ExcuteNonQuery(sql, prs);
        }

        public List<DTO_DieuXe> Get_NoiNhan()
        {
            string sql = "select noi_nhan from dm_bang_bao_gia";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DieuXe>(dr);
        }
        public List<DTO_DieuXe> Get_NoiGiao()
        {
            string sql = "select noi_giao from dm_bang_bao_gia";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_DieuXe>(dr);
        }
        /////////////////////////////////////////////////////////////////////DUNG CHUNG/////////////////////////////////////////////////////////////////////////////////
        public string _Ma_Dieu_Xe_Moi()
        {
            return new DAL_Systems().CreateIDCode("D", "ma_dieu_xe", "dm_dieu_xe", 7);
        }
        ///////////////////////////////////////////////////////////////////CODE DIEU XE GIAO DIEN TTDieuXe//////////////////////////////////////////////////////////////
        public bool Delete_Dieu_Xe(DTO_DieuXe dxx)
        {
            string check = "select * from dm_bang_ke where ma_dieu_xe='" + dxx.ma_dieu_xe.Trim() + "'";
            DataTable dtt = data.ExcuteDataTable(check, null);
            if (dtt != null && dtt.Rows.Count > 0)
            {
                return false;
            }
            string update_xe = "Update dm_xe set ma_tinh_trang=1 where ma_so_xe in (select ma_so_xe from dm_dieu_xe where ma_dieu_xe =@ma_dieu_xe) ";
            SqlParameter[] prs1 = 
            {
                new SqlParameter("@ma_dieu_xe",dxx.ma_dieu_xe.Trim())
            };
            if (data.ExcuteNonQuery(update_xe, prs1) == true)
            {
                string sql = "delete from dm_dieu_xe where ma_dieu_xe =@ma_dieu_xe ";
                SqlParameter[] prs2 = 
                        {
                new SqlParameter("@ma_dieu_xe",dxx.ma_dieu_xe.Trim())
                         };

                return data.ExcuteNonQuery(sql, prs2);
            }
            return false;
        }
        public bool Update_Dieu_Xe(DTO_DieuXe DXE)
        {
            string sql = "update dm_dieu_xe set ngay_ve=@ngay_ve,tinh_trang_thanh_toan=@tinh_trang_thanh_toan where ma_dieu_xe=@ma_dieu_xe and ma_so_xe=@ma_so_xe";
            SqlParameter[] prs =
            {
                new SqlParameter("@ma_dieu_xe",DXE.ma_dieu_xe.Trim()),
                new SqlParameter("@ma_so_xe",DXE.ma_so_xe.Trim()),
                new SqlParameter("@ma_khach_hang",DXE.ma_khach_hang.Trim()),
                new SqlParameter("@noi_giao",DXE.noi_giao),
                new SqlParameter("@noi_nhan",DXE.noi_nhan),
                new SqlParameter("@ngay_dieu_xe",DXE.ngay_dieu_xe),
                new SqlParameter("@so_tan",DXE.so_tan),
                new SqlParameter("@ngay_ve",DXE.ngay_ve),
                new SqlParameter("@tinh_trang_thanh_toan",DXE.tttt)
            };
            if (data.ExcuteNonQuery(sql, prs) == true)
            {
                string Update = "Update dm_xe set ma_tinh_trang=1 where ma_so_xe='" + DXE.ma_so_xe.Trim() + "' ";
                data.ExcuteNonQuery(Update, null);
            }
            return true;
        }
        public List<DTO_Xe> Get_List_Xe_DangOBai()
        {
            string sql = "select dm_xe.*,ten_tinh_trang from dm_xe,dm_tinh_trang_xe where dm_xe.ma_tinh_trang=dm_tinh_trang_xe.ma_tinh_trang and dm_xe.ma_tinh_trang=1 order by dm_xe.trong_luong desc";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt!=null&&dt.Rows.Count > 0)
            {
                List<DTO_Xe> xe = new List<DTO_Xe>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_Xe xx = new DTO_Xe();
                    xx.ma_so_xe = dr["ma_so_xe"].ToString();
                    xx.trong_luong = float.Parse(dr["trong_luong"].ToString());
                    xx.nhan_hieu = dr["nhan_hieu"].ToString();
                    xx.ten_tinh_trang = dr["ten_tinh_trang"].ToString();
                    xx.loai_xe = dr["loai_xe"].ToString();
                    xe.Add(xx);
                }
                return xe;
            }
            return null;
        }
        public List<DTO_NhanVien> Get_List_Xe_Nhan_Vien(DTO_NhanVien nv)
        {
            string sql = "select * from dm_nhan_vien where ma_so_xe='"+nv._ma_so_xe.Trim()+"'";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if(dt!=null&&dt.Rows.Count>0)
            {
                List<DTO_NhanVien> nn=new List<DTO_NhanVien>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_NhanVien nvv = new DTO_NhanVien();
                    nvv.ma_nhan_vien = dr["ma_nhan_vien"].ToString();
                    nvv.ten_nhan_vien = dr["ten_nhan_vien"].ToString();
                    nvv.cmnd= dr["cmnd"].ToString();
                    nvv.dia_chi = dr["dia_chi"].ToString();
                    nvv.dien_thoai = dr["dien_thoai"].ToString();
                    nvv.nam_sinh = Convert.ToDateTime(dr["nam_sinh"].ToString());
                    nvv.chucvu = dr["chucvu"].ToString();
                    nn.Add(nvv);
                }
                return nn;
            }
            return null;
        }
        public List<DTO_BangBaoGia> _List_Get_Ma_Bao_Gia(DTO_BangBaoGia bg)
        {
            string sql = "select ma_bao_gia from dm_bang_bao_gia where ma_hop_dong='" + bg.ma_hop_dong.Trim() + "' and Getdate()>=tu_ngay and getdate()<= den_ngay ";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_BangBaoGia> xx = new List<DTO_BangBaoGia>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_BangBaoGia dxe = new DTO_BangBaoGia();
                    dxe.ma_bao_gia = dr["ma_bao_gia"].ToString();
                    xx.Add(dxe);
                }
                return xx;
            }
            return null;
        }
        public List<DTO_DieuXe> _List_Get_NoiNhan(DTO_BangBaoGia bg)
        {
            string sql = "select distinct noi_nhan from dm_bang_bao_gia where ma_bao_gia='"+bg.ma_bao_gia.Trim()+"'";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_DieuXe> xx = new List<DTO_DieuXe>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_DieuXe dxe = new DTO_DieuXe();
                    dxe.noi_nhan=dr["noi_nhan"].ToString();
                    xx.Add(dxe);
                }
                return xx;
            }
            return null;
        }
        public List<DTO_DieuXe> _List_Get_NoiGiao(DTO_DieuXe dxx)
        {
            string sql = "select distinct noi_giao from dm_bang_bao_gia where noi_nhan=N'"+dxx.noi_nhan.Trim()+"'";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_DieuXe> xx = new List<DTO_DieuXe>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_DieuXe dxe = new DTO_DieuXe();
                    dxe.noi_giao = dr["noi_giao"].ToString();
                    xx.Add(dxe);
                }
                return xx;
            }
            return null;
        }
        public List<DTO_DieuXe> _List_Get_Dieu_Xe_By_KhachHang_HopDong(DTO_DieuXe dxx)
        {
            string sql = "select ma_hop_dong,trong_luong,ma_dieu_xe,A.ma_so_xe,so_tan,A.ma_khach_hang,noi_giao,noi_nhan,ngay_dieu_xe,ngay_ve,dia_chi,fax,B.ngay_tao, B.ten_khach_hang,case tinh_trang_thanh_toan when 0 then N'Chưa Thanh Toán' when 1 then N'Đã Thanh Toán' end as 'tinh_trang_thanh_toan' from dm_dieu_xe A join dm_khach_hang B on A.ma_khach_hang = B.ma_khach_hang and ma_hop_dong='" + dxx.ma_hop_dong.Trim() + "' , dm_xe where dm_xe.ma_so_xe=A.ma_so_xe  order by ma_dieu_xe desc,trong_luong desc";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_DieuXe> dxe = new List<DTO_DieuXe>();
                foreach (DataRow dr in dt.Rows)
                {
                    DTO_DieuXe xx = new DTO_DieuXe();
                    xx.ma_hop_dong=dr["ma_hop_dong"].ToString();
                    xx.ma_dieu_xe=dr["ma_dieu_xe"].ToString();
                    xx.so_tan = dr["so_tan"].ToString();
                    xx.ma_khach_hang=dr["ma_khach_hang"].ToString();
                    xx.noi_giao=dr["noi_giao"].ToString();
                    xx.noi_nhan=dr["noi_nhan"].ToString();
                    xx.ngay_dieu_xe =Convert.ToDateTime(dr["ngay_dieu_xe"].ToString());
                    if (dr["ngay_ve"].ToString() != "")
                    {
                        xx.ngay_ve = Convert.ToDateTime(dr["ngay_ve"].ToString());
                    }
                    xx.ma_so_xe=dr["ma_so_xe"].ToString();
                    xx.ten_khach_hang = dr["ten_khach_hang"].ToString();
                    xx.tinh_trang_thanh_toan = dr["tinh_trang_thanh_toan"].ToString();
                    xx.tai_trong_xe = float.Parse(dr["trong_luong"].ToString());
                    dxe.Add(xx);
                }
                return dxe;
            }
            return null;
        }
        public float _Get_Tong_Trong_Luong(DTO_DieuXe dxx)
        {
            float tong_tan = 0;
            string sql = "select sum(so_tan) as so_tan from dm_dieu_xe where ma_dieu_xe='"+dxx.ma_dieu_xe.Trim()+"'";
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt!=null&&dt.Rows.Count > 0)
            {
                tong_tan = float.Parse("0"+dt.Rows[0][0].ToString());
            }
            return tong_tan;
        }

    }
}
