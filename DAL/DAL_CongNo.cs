using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QLDVVTHH.DAL
{
    public class DAL_CongNo
    {
        ConnectData data = new ConnectData();

        public string _Ma_Cong_No()
        {
            return new DAL_Systems().CreateIDCode("NO", "ma_cong_no", "dm_cong_no", 5);
        }

        public DTO_HoaDon[] _List_Hoa_Don(DTO_HoaDon hoadon)
        {
            string sql = "select so_hoa_don,ngay_xuat,tong_cong from dm_hoa_don where ma_khach_hang =@mkh and ma_hop_dong=@mhd and so_hoa_don not in (select  dm_cong_no.so_hoa_don from dm_cong_no where dm_cong_no.ma_khach_hang=@mkh )";

            SqlParameter[] para = 
                    { 
                        new SqlParameter("@mkh",hoadon.ma_khach_hang.Trim()),new SqlParameter("@mhd",hoadon.ma_hop_dong.Trim())
                    };
            DataTable dt = data.ExcuteDataTable(sql, para);
            if (dt.Rows.Count > 0)
            {
                DTO_HoaDon[] HOADON_LIST = new DTO_HoaDon[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HOADON_LIST[i] = new DTO_HoaDon();
                    HOADON_LIST[i].ma_hoa_don=dt.Rows[i]["so_hoa_don"].ToString();
                    HOADON_LIST[i].ngay_Xuat_hoa_don =Convert.ToDateTime(dt.Rows[i]["ngay_xuat"].ToString());
                    HOADON_LIST[i].tong_cuot_van_chuyen = float.Parse(dt.Rows[i]["tong_cong"].ToString());
                }
                return HOADON_LIST;
            }
            return null;
        }

        public int _Them_Cong_No_Khach_Hang(DTO_HoaDon hoadon,DTO_CongNo congno)
        {
            int i = 0;
            string sql = "select * from dm_hoa_don where so_hoa_don=@mhd ";
            SqlParameter[] para = { new SqlParameter("@mhd",hoadon.ma_hoa_don.Trim())};
            DataTable dt = data.ExcuteDataTable(sql, para);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string insert = "insert into dm_cong_no(ma_cong_no,ma_khach_hang,so_hoa_don,so_tien_thanh_toan,ngay_xuat_hd)"
                                     + " values(@ma_cong_no,@ma_khach_hang,@so_hoa_don,@so_tien_thanh_toan,@ngay_xuat_hd)";
                    SqlParameter[] para2 = { 
                                           new SqlParameter("@ma_cong_no",congno.ma_cong_no.Trim()),
                                             new SqlParameter("@ma_khach_hang",dr["ma_khach_hang"].ToString()),
                                               new SqlParameter("@so_hoa_don",dr["so_hoa_don"].ToString()),
                                                 new SqlParameter("@so_tien_thanh_toan",float.Parse(dr["tong_cong"].ToString())),
                                                   new SqlParameter("@ngay_xuat_hd",Convert.ToDateTime(dr["ngay_xuat"].ToString()))
                                       };
                    bool kq = data.ExcuteNonQuery(insert, para2);
                    if (kq == false)
                    {
                        i = 1;
                    }
                }
            }
            return i;
        }

        public DTO_CongNo[] _List_View_Cong_No_Khach_Hang(DTO_CongNo congno)
        {
            string sql = "select dm_cong_no.* from dm_cong_no,dm_hoa_don "
                + "where dm_cong_no.so_hoa_don=dm_hoa_don.so_hoa_don "
                + "and dm_cong_no.ma_khach_hang=@mkh and ma_hop_dong=@mhd ";
            SqlParameter[] para = { new SqlParameter("@mkh", congno.ma_khach_hang.Trim()), new SqlParameter("@mhd", congno.ma_cong_no.Trim()) };
            DataTable dt = data.ExcuteDataTable(sql, para);
            if (dt.Rows.Count > 0)
            {
                DTO_CongNo[] CONGNO_=new DTO_CongNo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CONGNO_[i] = new DTO_CongNo();
                    CONGNO_[i].ma_cong_no = dt.Rows[i]["ma_cong_no"].ToString();
                    CONGNO_[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    CONGNO_[i].ma_hoa_don = dt.Rows[i]["so_hoa_don"].ToString();
                    CONGNO_[i].so_tien_thanh_toan = float.Parse(dt.Rows[i]["so_tien_thanh_toan"].ToString());
                    CONGNO_[i].ngay_xuat_hd = Convert.ToDateTime(dt.Rows[i]["ngay_xuat_hd"].ToString());
                }
                return CONGNO_;
            }
            return null;
        }

        public int _Xoa_Cong_No(DTO_CongNo congno)
        {
            int i = 0;
            string sql = "delete from dm_cong_no where so_hoa_don=@mhd ";
            SqlParameter[] para = {new SqlParameter("@mhd",congno.ma_hoa_don.Trim()) };
            bool kq = data.ExcuteNonQuery(sql, para);
            if (kq == false)
            {
                i = 1;
            }
            return i;
        }

        public int _Them_Thanh_Toan_Cong_No(DTO_ThanhToan tt)
        {
            int i = 0;
            string sql = "insert into dm_thanhtoan(ma_hop_dong,ma_khach_hang,dathanhtoan,ngay_thanh_toan) values(@mahopdong,@makhachhang,@sotienthanhtoan,@ngay_thanh_toan)";
            SqlParameter[] para = { 
                                        new SqlParameter("@mahopdong",tt.ma_hop_dong.Trim()),
                                        new SqlParameter("@makhachhang",tt.ma_khach_hang.Trim()),
                                        new SqlParameter("@sotienthanhtoan",tt.so_tien_thanh_toan),
                                        new SqlParameter("@ngay_thanh_toan",tt.ngay_thanh_toan)
                                  };
            bool kq = data.ExcuteNonQuery(sql, para);
            if (kq == false)
            {
                i = 1;
            }
            return i;
        }

        public DTO_ThanhToan[] _List_View_Thanh_Toan(DTO_ThanhToan tt)
        {
            string sql = "select * from  dm_thanhtoan where ma_hop_dong=@mhd and ma_khach_hang=@mkh ";
            SqlParameter[] para = 
            { 
                new SqlParameter("@mkh",tt.ma_khach_hang.Trim()),
                new SqlParameter("@mhd",tt.ma_hop_dong.Trim())
            };
            DataTable dt = data.ExcuteDataTable(sql, para);
            if (dt.Rows.Count > 0)
            {
                DTO_ThanhToan[] THANHTOAN=new DTO_ThanhToan[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    THANHTOAN[i] = new DTO_ThanhToan();
                    THANHTOAN[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    THANHTOAN[i].ma_khach_hang= dt.Rows[i]["ma_khach_hang"].ToString();
                    THANHTOAN[i].ngay_thanh_toan =Convert.ToDateTime(dt.Rows[i]["ngay_thanh_toan"].ToString());
                    THANHTOAN[i].so_tien_thanh_toan = float.Parse(dt.Rows[i]["dathanhtoan"].ToString());
                    THANHTOAN[i].ma_thanh_toan = int.Parse(dt.Rows[i]["ma_thanh_toan"].ToString());
                }
                return THANHTOAN;
            }
            return null;
        }

        public int _Xoa_So_Tien_Thanh_Toan(DTO_ThanhToan tt)
        {
            int i = 0;
            string sql="delete from  dm_thanhtoan where ma_thanh_toan=@matt ";
            SqlParameter[] para={new SqlParameter("@matt",tt.ma_thanh_toan)};
            bool kq = data.ExcuteNonQuery(sql, para);
            if (kq == false)
            {
                i = 1;
            }
            return i;
        }

        public DTO_CongNo[] _Thong_Ke_Cong_No(DTO_CongNo congno)
        {
            string sql = "select T1.ma_hop_dong,T1.ma_khach_hang,ten_khach_hang,TIENNO,TONGTRA  "
                        + "from "
                        + "(select dm_khach_hang.ma_khach_hang,dm_khach_hang.ten_khach_hang,dm_hoa_don.ma_hop_dong,SUM(so_tien_thanh_toan) as TIENNO "
                        + "from dm_cong_no,dm_hoa_don,dm_khach_hang "
                        + "where dm_cong_no.so_hoa_don=dm_hoa_don.so_hoa_don and dm_khach_hang.ma_khach_hang=dm_hoa_don.ma_khach_hang "
                        + "group by dm_khach_hang.ma_khach_hang,dm_khach_hang.ten_khach_hang,dm_hoa_don.ma_hop_dong) as T1 "
                        + "left outer join "
                        + "(select ma_hop_dong,ma_khach_hang,SUM(dathanhtoan) as TONGTRA from dm_thanhtoan  "
                        + "group by ma_hop_dong,ma_khach_hang) as T2 on T1.ma_khach_hang=T2.ma_khach_hang "
                        ;
            DataTable dt = data.ExcuteDataTable(sql,null);
            if (dt!=null&&dt.Rows.Count > 0)
            {
                DTO_CongNo[] CONGNO_ = new DTO_CongNo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CONGNO_[i] = new DTO_CongNo();
                    CONGNO_[i].ma_hop_dong= dt.Rows[i]["ma_hop_dong"].ToString();
                    CONGNO_[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    CONGNO_[i].tongno = float.Parse(dt.Rows[i]["TIENNO"].ToString());
                    CONGNO_[i].tongtra = float.Parse("0"+dt.Rows[i]["TONGTRA"].ToString());
                    CONGNO_[i].tenkhachhang = dt.Rows[i]["ten_khach_hang"].ToString();
                }
                return CONGNO_;
            }
            return null;
        }
        public int _check_ma_hoa_don_cong_no(DTO_HoaDon hd)
        {
            int i = 0;
            string sql = "select * from dm_cong_no where so_hoa_don=@shd and ma_khach_hang=@mkh";
            SqlParameter[] para = { new SqlParameter("@shd", hd.ma_hoa_don.Trim()), new SqlParameter("@mkh", hd.ma_khach_hang) };
            DataTable dt = data.ExcuteDataTable(sql, para);
            if(dt.Rows.Count>0)
            {
                i=1;
            }
            return i;
        }
    }
}
