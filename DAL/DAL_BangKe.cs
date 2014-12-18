using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLDVVTHH.DAL
{
    public class DAL_BangKe
    {
        ConnectData data = new ConnectData();
        public int _Them_BangKe(DTO_BangKe dto)
        {
            int i = 0;
            try
            {
                string sql = "insert into dm_bang_ke(ma_dieu_xe,ma_bang_ke,ma_khach_hang,so_xe,ngay_van_chuyen,noi_nhan,noi_giao,khoi_luong,don_gia_tan,don_gia_chuyen,ghi_chu) values(@ma_dieu_xe,@mabangke,@makh,@soxe,@ngayvanchuyen,@noinhan,@noigiao,@khoiluong,@dongiatan,@dongiachuyen,@ghichu) ";
                SqlParameter[] prs = 
                {
                    new SqlParameter("@ma_dieu_xe",dto.ma_dieu_xe.Trim()),
                    new SqlParameter("@mabangke",dto.ma_bang_ke.Trim()),
                    new SqlParameter("@makh",dto.ma_khach_hang.Trim()),
                    new SqlParameter("@soxe",dto.so_xe.Trim()),
                    new SqlParameter("@ngayvanchuyen",dto.ngay_van_chuyen),
                    new SqlParameter("@noinhan",dto.noi_nhan.Trim()),
                    new SqlParameter("@noigiao",dto.noi_giao.Trim()),
                    new SqlParameter("@khoiluong",dto.khoi_luong),
                    new SqlParameter("@dongiatan",dto.don_gia_tan),
                    new SqlParameter("@dongiachuyen",dto.don_gia_chuyen),
                    new SqlParameter("@ghichu",dto.ghi_chu)
                 };
                data.ExcuteNonQuery(sql, prs);
            }
            catch
            {
                i = 1;
            }
            return i;
        }
        public DataTable _List_Hop_Dong(DTO_HopDong hd)
        {
            string sql = "select ma_hop_dong from dm_hop_dong where ma_khach_hang=@mahd order by ma_hop_dong desc";
            SqlParameter[] prs = 
            {
                new SqlParameter("@mahd",hd.ma_khach_hang.Trim())
            };
            return data.ExcuteDataTable(sql, prs);
        }
        public String _Ma_Bang_Ke()
        {
            string ma = DateTime.Now.Day.ToString();
            if (DateTime.Now.Month.ToString().Length > 1)
            {
                ma += DateTime.Now.Month.ToString();
            }
            else
            {
                ma += "0" + DateTime.Now.Month.ToString();
            }
            ma+=DateTime.Now.Year.ToString().Substring(2, 2);
            return new DAL_Systems().CreateIDCode(ma, "ma_bang_ke", "dm_bang_ke", 10);
        }
        public DTO_BangKe[] _DanhSachBangKe_TheoMaKhachHang_MaHopDong(DTO_BangKe dto)
        {
            string sql = "select ma_bang_ke,dm_bang_ke.ma_khach_hang,ma_dieu_xe,so_xe,ngay_van_chuyen,khoi_luong,noi_nhan,noi_giao,ghi_chu,don_gia_chuyen,don_gia_tan from dm_bang_ke,dm_hop_dong where dm_bang_ke.ma_khach_hang=dm_hop_dong.ma_khach_hang and ngay_van_chuyen >= dm_hop_dong.ngay_bat_dau and ngay_van_chuyen<= ngay_ket_thuc and dm_bang_ke.ma_khach_hang=@mkh and ma_hop_dong=@mahd order by ngay_van_chuyen desc";
            SqlParameter[] prs = 
            {
                    new SqlParameter("@mkh",dto.ma_khach_hang.Trim()),
                    new SqlParameter("@mahd",dto.ma_bang_ke.Trim()),
            };
            DataTable dt = data.ExcuteDataTable(sql, prs);
            if (dt.Rows.Count > 0)
            {
                DTO_BangKe[] BangKe = new DTO_BangKe[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BangKe[i] = new DTO_BangKe();
                    BangKe[i].ma_bang_ke = dt.Rows[i]["ma_bang_ke"].ToString();
                    BangKe[i].ma_dieu_xe = dt.Rows[i]["ma_dieu_xe"].ToString();
                    BangKe[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    BangKe[i].ngay_van_chuyen = Convert.ToDateTime(dt.Rows[i]["ngay_van_chuyen"].ToString());
                    BangKe[i].khoi_luong = float.Parse(dt.Rows[i]["khoi_luong"].ToString());
                    BangKe[i].noi_nhan = dt.Rows[i]["noi_nhan"].ToString();
                    BangKe[i].noi_giao = dt.Rows[i]["noi_giao"].ToString();
                    BangKe[i].so_xe = dt.Rows[i]["so_xe"].ToString();
                    BangKe[i].don_gia_tan = float.Parse(dt.Rows[i]["don_gia_tan"].ToString());
                    BangKe[i].don_gia_chuyen = float.Parse(dt.Rows[i]["don_gia_chuyen"].ToString());
                    BangKe[i].ghi_chu = dt.Rows[i]["ghi_chu"].ToString();
                }
                return BangKe;
            }
            return null;
        }
        public int _CapNhat_BangKe(DTO_BangKe dto)
        {
            int i = 0;
            string query = "select * from dm_hoa_don_chi_tiet where ma_bang_ke=@mabangke";
            SqlParameter[] qpr = 
                 {
                    new SqlParameter("@mabangke",dto.ma_bang_ke.Trim()),
                 };
            DataTable dt = data.ExcuteDataTable(query, qpr);
            if (dt.Rows.Count > 0)
            {
                i = 1;
            }
            if (i == 0)
            {
                string sql = "update dm_bang_ke set ma_dieu_xe=@madieuxe,khoi_luong=@khoi_luong,ngay_van_chuyen=@ngay_van_chuyen,noi_giao=@noi_giao,noi_nhan=@noi_nhan,don_gia_tan=@don_gia_tan,don_gia_chuyen=@don_gia_chuyen,ghi_chu=@ghi_chu,so_xe=@so_xe where ma_khach_hang=@makhachhang and ma_bang_ke=@ma_bang_ke ";
                SqlParameter[] prs = 
                 {
                    new SqlParameter("@madieuxe",dto.ma_dieu_xe.Trim()),
                    new SqlParameter("@ma_bang_ke",dto.ma_bang_ke.Trim()),
                    new SqlParameter("@makhachhang",dto.ma_khach_hang.Trim()),
                    new SqlParameter("@so_xe",dto.so_xe.Trim()),
                    new SqlParameter("@ngay_van_chuyen",dto.ngay_van_chuyen),
                    new SqlParameter("@noi_nhan",dto.noi_nhan.Trim()),
                    new SqlParameter("@noi_giao",dto.noi_giao.Trim()),
                    new SqlParameter("@khoi_luong",dto.khoi_luong),
                    new SqlParameter("@don_gia_tan",dto.don_gia_tan),
                    new SqlParameter("@don_gia_chuyen",dto.don_gia_chuyen),
                    new SqlParameter("@ghi_chu",dto.ghi_chu)
                 };
                data.ExcuteNonQuery(sql, prs);
            }
           return i;
        }
        public int _Xoa_BangKe(DTO_BangKe dto)
        {
            int i = 0;
            string query = "select * from dm_hoa_don_chi_tiet where ma_bang_ke=@mabangke";
            SqlParameter[] qpr = 
                 {
                    new SqlParameter("@mabangke",dto.ma_bang_ke.Trim()),
                 };
            DataTable dt = data.ExcuteDataTable(query, qpr);
            if (dt.Rows.Count > 0)
            {
                i = 1;
            }
            string query2 = "select * from dm_bang_ke where ma_bang_ke=@mabangke";
            SqlParameter[] qpr2 = 
                 {
                    new SqlParameter("@mabangke",dto.ma_bang_ke.Trim()),
                 };
            DataTable dt2 = data.ExcuteDataTable(query2, qpr2);
            if (dt2.Rows.Count == 0)
            {
                i = 2;
            }
            if (i == 0)
            {
                string sql = "delete from dm_bang_ke where ma_bang_ke=@ma_bang_ke";
                SqlParameter[] prs = 
                 {
                    new SqlParameter("@ma_bang_ke",dto.ma_bang_ke.Trim())
                 };
                data.ExcuteNonQuery(sql, prs);
            }
            return i;
        }
        public DTO_BangKe[] _Tim_BangKe(DTO_BangKe bangke,DTO_HopDong hopdong,DTO_KhachHang khachhang)
        {
            string truyvan="";
            if(khachhang.ma_khach_hang.Trim()!="")
            {
                truyvan += "and dm_khach_hang.ma_khach_hang=@mkh ";
            }
            if (khachhang.ten_khach_hang.Trim() != "")
            {
                truyvan += "and ten_khach_hang like N'%" + khachhang.ten_khach_hang.Trim() + "%' ";
            }
            if (hopdong.ma_hop_dong.Trim()!="")
            {
                truyvan += "and ngay_van_chuyen >= dm_hop_dong.ngay_bat_dau and ngay_van_chuyen<= dm_hop_dong.ngay_ket_thuc ";
            }
            if (bangke.ma_bang_ke.Trim() != "")
            {
                truyvan += "and ma_bang_ke=@mbk ";
            }
            if (bangke.so_xe.Trim() != "")
            {
                truyvan += "and so_xe like N'%" + bangke.so_xe.Trim() + "%' ";
            }
            if (bangke.noi_nhan.Trim()!="")
            {
                truyvan += "and noi_nhan like N'%" + bangke.noi_nhan.Trim() + "%' ";
            }
            if (bangke.noi_giao.Trim() != "")
            {
                truyvan += "and noi_giao like N'%" + bangke.noi_giao.Trim() + "%'";
            }
            if (bangke.khoi_luong.ToString().Trim() != "" && bangke.khoi_luong>0)
            {
                truyvan += "and khoi_luong like N'%" + bangke.khoi_luong.ToString().Trim() + "%'";
            }
            if (bangke.don_gia_chuyen.ToString().Trim()!= "" && bangke.don_gia_chuyen>0)
            {
                truyvan += "and don_gia_chuyen like N'%" + bangke.don_gia_chuyen.ToString().Trim() + "%'";
            }
            if (bangke.don_gia_tan.ToString().Trim() != "" && bangke.don_gia_tan >0)
            {
                truyvan += "and don_gia_tan like N'%"+bangke.don_gia_tan.ToString().Trim() +"%' ";
            }
            if (bangke.ghi_chu.Trim() != "")
            {
                truyvan += "and ghi_chu like N'%" + bangke.ghi_chu.Trim() + "%'";
            }
            string sql = "select distinct ma_bang_ke,ma_dieu_xe,dm_khach_hang.ma_khach_hang,so_xe,ngay_van_chuyen,khoi_luong,noi_nhan,noi_giao,ghi_chu,don_gia_chuyen,don_gia_tan "
                         + "from dm_bang_ke,dm_hop_dong,dm_khach_hang "
                         + "where dm_khach_hang.ma_khach_hang=dm_bang_ke.ma_khach_hang and dm_hop_dong.ma_khach_hang=dm_khach_hang.ma_khach_hang "
                         + truyvan + " and dm_hop_dong.ma_hop_dong=@mhd and ngay_van_chuyen<= @ngayvanchuyen order by ngay_van_chuyen desc";
            SqlParameter[] prs = 
            {
                    new SqlParameter("@mkh",khachhang.ma_khach_hang.Trim()),
                    new SqlParameter("@mbk",bangke.ma_bang_ke.Trim()),
                    new SqlParameter("@mhd",hopdong.ma_hop_dong.Trim()),
                    new SqlParameter("@ngayvanchuyen",bangke.ngay_van_chuyen)
            };
            DataTable dt = data.ExcuteDataTable(sql, prs);
            if (dt.Rows.Count > 0)
            {
                DTO_BangKe[] BangKe = new DTO_BangKe[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BangKe[i] = new DTO_BangKe();
                    BangKe[i].ma_bang_ke = dt.Rows[i]["ma_bang_ke"].ToString();
                    BangKe[i].ma_dieu_xe = dt.Rows[i]["ma_dieu_xe"].ToString();
                    BangKe[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    BangKe[i].ngay_van_chuyen = Convert.ToDateTime(dt.Rows[i]["ngay_van_chuyen"].ToString());
                    BangKe[i].khoi_luong = float.Parse(dt.Rows[i]["khoi_luong"].ToString());
                    BangKe[i].noi_nhan = dt.Rows[i]["noi_nhan"].ToString();
                    BangKe[i].noi_giao = dt.Rows[i]["noi_giao"].ToString();
                    BangKe[i].so_xe = dt.Rows[i]["so_xe"].ToString();
                    BangKe[i].don_gia_tan = float.Parse(dt.Rows[i]["don_gia_tan"].ToString());
                    BangKe[i].don_gia_chuyen = float.Parse(dt.Rows[i]["don_gia_chuyen"].ToString());
                    BangKe[i].ghi_chu = dt.Rows[i]["ghi_chu"].ToString();
                }
                return BangKe;
            }
            return null;
        }
        public DataTable _List_Ten_Khach_Hang()
        {
            string sql = "select ten_khach_hang,ma_khach_hang from dm_khach_hang order by ma_khach_hang desc";
            return data.ExcuteDataTable(sql, null);
        }
        public DTO_DieuXe[] _List_Ma_Dieu_Xe(DTO_DieuXe _xe)
        {
            //string sql = "select ma_dieu_xe,ma_so_xe,dm_dieu_xe.noi_nhan,dm_dieu_xe.noi_giao,so_tan,ngay_dieu_xe,don_gia_tan,don_gia_chuyen from dm_dieu_xe,dm_bang_bao_gia where ma_khach_hang=@mkh and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe not in (select distinct ma_dieu_xe from dm_bang_ke where dm_bang_ke.ma_khach_hang=@mkh ) "; //and ngay_ve=NULL and tinh_trang_thanh_toan=NULL;
            string sql = "select distinct ma_dieu_xe,dm_dieu_xe.noi_nhan,dm_dieu_xe.noi_giao,sum(so_tan) as so_tan,ngay_dieu_xe,don_gia_tan,don_gia_chuyen "
                + "from dm_dieu_xe,dm_bang_bao_gia "
                + "where ma_khach_hang=@mkh and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao "
                + "and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe  "
                + "not in (select distinct ma_dieu_xe from dm_bang_ke where dm_bang_ke.ma_khach_hang=@mkh ) "
                + "group by ma_dieu_xe,dm_dieu_xe.noi_nhan,dm_dieu_xe.noi_giao,ngay_dieu_xe,don_gia_tan,don_gia_chuyen ";
            SqlParameter[] prs = 
            {
                new SqlParameter("@mkh",_xe.ma_khach_hang.Trim())
            };
            DataTable dt=data.ExcuteDataTable(sql, prs);
            if (dt.Rows.Count > 0)
            {
                DTO_DieuXe[] _xx=new DTO_DieuXe[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    _xx[i] = new DTO_DieuXe();
                    _xx[i].ma_dieu_xe = dt.Rows[i]["ma_dieu_xe"].ToString();
                    string msx = "select ma_so_xe from dm_dieu_xe,dm_bang_bao_gia where ma_khach_hang='" + _xe.ma_khach_hang.Trim() + "' and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe='" + _xx[i].ma_dieu_xe.Trim() + "'";
                    DataTable dtt = data.ExcuteDataTable(msx, null);
                    foreach (DataRow dr in dtt.Rows)
                    {
                        _xx[i].ma_so_xe += dr["ma_so_xe"].ToString().Trim()+" ; ";
                    }
                    _xx[i].noi_nhan = dt.Rows[i]["noi_nhan"].ToString();
                    _xx[i].noi_giao= dt.Rows[i]["noi_giao"].ToString();
                    _xx[i].so_tan = float.Parse(dt.Rows[i]["so_tan"].ToString()).ToString();
                    _xx[i].ngay_dieu_xe = Convert.ToDateTime(dt.Rows[i]["ngay_dieu_xe"].ToString());
                    _xx[i].don_gia_tan = float.Parse(dt.Rows[i]["don_gia_tan"].ToString());
                    _xx[i].don_gia_chuyen = float.Parse(dt.Rows[i]["don_gia_chuyen"].ToString());
                }
                return _xx;
            }
            return null;
        }
    }
}
