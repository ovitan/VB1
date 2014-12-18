using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLDVVTHH.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLDVVTHH.DAL
{
    public class DAL_HoaDon
    {
        ConnectData data = new ConnectData();
        public string _Ma_Hoa_Don()
        {
            string ma = "";
            if (DateTime.Now.Month.ToString().Length > 1)
            {
                ma += DateTime.Now.Month.ToString();
            }
            else
            {
                ma += "0" + DateTime.Now.Month.ToString();
            }
            ma += DateTime.Now.Year.ToString().Substring(2, 2);
            return new DAL_Systems().CreateIDCode(ma, "so_hoa_don", "dm_hoa_don", 7);
        }

        public int _Lap_Hoa_Hon_Van_Chuyen(DTO_HopDong hopdong,DTO_HoaDon hoadon)
        {
            int i = 0;

            string kt = "select * from dm_hoa_don where so_hoa_don=@mhhd ";
            SqlParameter[] ktpara = { new SqlParameter("@mhhd",hoadon.ma_hoa_don.Trim())};
            DataTable dtkt = data.ExcuteDataTable(kt, ktpara);
            if (dtkt.Rows.Count > 0)
            {
                return i = 2;
            }

            string ngayxuathd = "select top 1 * from dm_hoa_don where ma_hop_dong=@mhd order by ngay_xuat desc";
            SqlParameter[] kthd = { new SqlParameter("@mhd", hopdong.ma_hop_dong.Trim()) };
            DataTable dtkthd = data.ExcuteDataTable(ngayxuathd, kthd);

            string ngayvc = "ngay_van_chuyen<=@ngayxuathoadon ";
            DateTime ngaygioihan=DateTime.Now;
            if (dtkthd.Rows.Count > 0)
            {
                foreach (DataRow dr in dtkthd.Rows)
                {
                    ngayvc = "ngay_van_chuyen<=@ngayxuathoadon and ngay_van_chuyen >@gioihanngay ";
                    ngaygioihan=Convert.ToDateTime(dr["ngay_xuat"].ToString());
                }
            }

            string query1 = "select * "
                            + "from "
                            + "(select dm_bang_ke.* "
                            + "from dm_bang_ke,dm_hop_dong "
                            + "where dm_bang_ke.ma_khach_hang=dm_hop_dong.ma_khach_hang "
                            + "and ngay_van_chuyen>=ngay_bat_dau and ngay_van_chuyen <= ngay_ket_thuc "
                            + "and dm_bang_ke.ma_khach_hang=@mkh "
                            + "and ma_hop_dong=@mhd) as KQ "
                            + "where  " + ngayvc;
            SqlParameter[] para1={
                                       new SqlParameter("@mkh",hopdong.ma_khach_hang.Trim()),
                                       new SqlParameter("@mhd",hopdong.ma_hop_dong.Trim()),
                                       new SqlParameter("@ngayxuathoadon",hoadon.ngay_Xuat_hoa_don),
                                       new SqlParameter("@gioihanngay",ngaygioihan)
                                 };
            DataTable KQ_BangKe=data.ExcuteDataTable(query1,para1);
            float tongkhoiluong = 0; 
            float tongthanhtien = 0;
            if (KQ_BangKe != null && KQ_BangKe.Rows.Count > 0)
            {
                foreach (DataRow dr in KQ_BangKe.Rows)
                {
                    tongkhoiluong+=float.Parse(dr["khoi_luong"].ToString());
                    tongthanhtien += (float.Parse(dr["don_gia_chuyen"].ToString()) + ((float.Parse(dr["khoi_luong"].ToString()) > 15)?(float.Parse(dr["khoi_luong"].ToString()) - 15) * (float.Parse(dr["don_gia_tan"].ToString())):0));
                }
            }
            float tongthanhtiensau_theu = (tongthanhtien) + (tongthanhtien * 10 / 100);

            string sql = "insert into dm_hoa_don(so_hoa_don,ma_hop_dong,ma_khach_hang,tongcuocvanchuyen,ngay_xuat,thue,tong_cong)" 
                         +" values (@ma_hoa_don,@ma_hop_dong,@ma_khach_hang,@tongcuocvanchuyen,@ngay_xuat,@thue,@tong_cong) "
                         ;
            SqlParameter[] para2 = { 
                                       new SqlParameter("@ma_hoa_don",hoadon.ma_hoa_don.Trim()),
                                       new SqlParameter("@ma_hop_dong",hopdong.ma_hop_dong.Trim()),
                                       new SqlParameter("@ma_khach_hang",hopdong.ma_khach_hang),
                                       new SqlParameter("@tongcuocvanchuyen",tongthanhtien),
                                       new SqlParameter("@ngay_xuat",hoadon.ngay_Xuat_hoa_don),
                                       new SqlParameter("@thue",(tongthanhtien * 10 / 100)),
                                       new SqlParameter("@tong_cong",tongthanhtiensau_theu),
                                   };
            bool kq = data.ExcuteNonQuery(sql, para2);
            if (kq == true)
            {
                string insertquey = "insert into dm_hoa_don_chi_tiet(ma_hoa_don,ma_bang_ke) values (@ma_hoa_don,@mabangke)";
                bool kq2 = true;
                foreach (DataRow dr_i in KQ_BangKe.Rows)
                {
                    SqlParameter[] para3 = 
                                     {
                                        new SqlParameter("@ma_hoa_don",hoadon.ma_hoa_don.Trim()),
                                        new SqlParameter("@mabangke",dr_i["ma_bang_ke"].ToString())
                                     };
                    kq2 = data.ExcuteNonQuery(insertquey, para3);
                }
                if (kq2 == false)
                {
                    i = 1;
                }
            }
            return i;
        }

        public DTO_HoaDon[] _List_Hoa_Hon_Van_Chuyen(DTO_HoaDon hoadon)
        {
            string sql = "select * from dm_hoa_don where ma_khach_hang=@mkh and ma_hop_dong=@mhd order by ngay_xuat desc";
            SqlParameter[] para = 
            {
                new SqlParameter("@mkh",hoadon.ma_khach_hang.Trim()),new SqlParameter("@mhd",hoadon.ma_hop_dong.Trim())
            };
            DataTable dt = data.ExcuteDataTable(sql, para);
            if (dt != null && dt.Rows.Count > 0)
            {
                DTO_HoaDon[] dto = new DTO_HoaDon[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dto[i] = new DTO_HoaDon();
                    dto[i].ma_hoa_don = dt.Rows[i]["so_hoa_don"].ToString();
                    dto[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    dto[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    //dto[i].tong_khoi_luong = float.Parse(dt.Rows[i]["tongkhoiluong"].ToString());
                    dto[i].tong_cuot_van_chuyen = float.Parse(dt.Rows[i]["tongcuocvanchuyen"].ToString());
                    dto[i].theu = float.Parse(dt.Rows[i]["thue"].ToString());
                    dto[i].tong_cong = float.Parse(dt.Rows[i]["tong_cong"].ToString());
                    dto[i].ngay_Xuat_hoa_don =Convert.ToDateTime(dt.Rows[i]["ngay_xuat"].ToString());
                }
                return dto;
            }
            return null;
        }

        public DTO_BangKe[] _List_Chi_Tiet_Hoa_Hon_Van_Chuyen(DTO_Chi_Tiet_Hoa_Don ct)
        {
            string sql = "select dm_bang_ke.* from dm_bang_ke,dm_hoa_don_chi_tiet where dm_bang_ke.ma_bang_ke=dm_hoa_don_chi_tiet.ma_bang_ke and ma_hoa_don=@mhd ";
            SqlParameter[] prs = 
            {
                    new SqlParameter("@mhd",ct.ma_hoa_don.Trim())
            };
            DataTable dt = data.ExcuteDataTable(sql, prs);
            if (dt.Rows.Count > 0)
            {
                DTO_BangKe[] BangKe = new DTO_BangKe[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BangKe[i] = new DTO_BangKe();
                    BangKe[i].ma_bang_ke = dt.Rows[i]["ma_bang_ke"].ToString();
                    BangKe[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    BangKe[i].ngay_van_chuyen = Convert.ToDateTime(dt.Rows[i]["ngay_van_chuyen"].ToString());
                    BangKe[i].khoi_luong = float.Parse(dt.Rows[i]["khoi_luong"].ToString());
                    BangKe[i].noi_nhan = dt.Rows[i]["noi_nhan"].ToString();
                    BangKe[i].noi_giao = dt.Rows[i]["noi_giao"].ToString();
                    BangKe[i].don_gia_tan = float.Parse(dt.Rows[i]["don_gia_tan"].ToString());
                    BangKe[i].don_gia_chuyen = float.Parse(dt.Rows[i]["don_gia_chuyen"].ToString());
                    BangKe[i].ghi_chu = dt.Rows[i]["ghi_chu"].ToString();
                    BangKe[i].ma_dieu_xe = dt.Rows[i]["ma_dieu_xe"].ToString();
                    string msx = "select ma_so_xe from dm_dieu_xe,dm_bang_bao_gia where ma_khach_hang='" + ct.ma_khach_hang.Trim() + "' and dm_bang_bao_gia.noi_nhan=dm_dieu_xe.noi_nhan and dm_bang_bao_gia.noi_giao=dm_dieu_xe.noi_giao and ngay_ve is not NULL and tinh_trang_thanh_toan=0 and ma_dieu_xe='" + dt.Rows[i]["ma_dieu_xe"].ToString().Trim() +"'";
                    DataTable dtt = data.ExcuteDataTable(msx, null);
                    foreach (DataRow dr in dtt.Rows)
                    {
                        BangKe[i].so_xe += dr["ma_so_xe"].ToString().Trim() + " ; ";
                    }
                }
                return BangKe;
            }
            return null;
        }

        public int _Xoa_Hoa_Don_Van_Chuyen(DTO_HoaDon hoadon)
        {
            int i = 0;
            string sql = "delete from dm_hoa_don_chi_tiet where ma_hoa_don=@mhd delete from dm_hoa_don where so_hoa_don=@mhd ";
            SqlParameter[] para = { new SqlParameter("@mhd",hoadon.ma_hoa_don.Trim())};
            bool kq = data.ExcuteNonQuery(sql, para);
            if (kq == false)
            {
                i = 1;
            }
            return i;
        }

        public DTO_HoaDon[] _Tim_Hoa_Hon_Van_Chuyen(DTO_HoaDon hoadon)
        {
            string query="";
            if(hoadon.ma_khach_hang.Trim()!="")
            {
                query=" ma_khach_hang=@mkh ";
            }
            if(hoadon.ma_hop_dong.Trim()!="")
            {
                query+=(string.IsNullOrEmpty(query)?"":" and ");
                query+=" ma_hop_dong=@mhd ";
            }
            if(hoadon.ma_hoa_don.Trim()!="")
            {
                query+=(string.IsNullOrEmpty(query)?"":" and ");
                query += " so_hoa_don=@mahd ";
            }
            string sql = "select * from dm_hoa_don where "+ query +" order by ngay_xuat desc";
            SqlParameter[] para = 
            {
                new SqlParameter("@mkh",hoadon.ma_khach_hang.Trim()),new SqlParameter("@mhd",hoadon.ma_hop_dong.Trim()),new SqlParameter("@mahd",hoadon.ma_hoa_don.Trim())
            };
            DataTable dt = data.ExcuteDataTable(sql, para);
            if (dt != null && dt.Rows.Count > 0)
            {
                DTO_HoaDon[] dto = new DTO_HoaDon[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dto[i] = new DTO_HoaDon();
                    dto[i].ma_hoa_don = dt.Rows[i]["so_hoa_don"].ToString();
                    dto[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    dto[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    dto[i].tong_cuot_van_chuyen = float.Parse(dt.Rows[i]["tongcuocvanchuyen"].ToString());
                    dto[i].theu = float.Parse(dt.Rows[i]["thue"].ToString());
                    dto[i].tong_cong = float.Parse(dt.Rows[i]["tong_cong"].ToString());
                    dto[i].ngay_Xuat_hoa_don = Convert.ToDateTime(dt.Rows[i]["ngay_xuat"].ToString());
                }
                return dto;
            }
            return null;
        }

        public DTO_HoaDon[] _List_Hoa_Don(DTO_HoaDon hoadon)
        {
            string sql = "select ma_hoa_don,ngay_tao,tongcuocvanchuyen from dm_hoa_don where ma_khach_hang =@mkh and ma_hop_dong=@mhd ";

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
                    HOADON_LIST[i].ma_hoa_don = dt.Rows[i]["so_hoa_don"].ToString();
                    HOADON_LIST[i].tong_cuot_van_chuyen = float.Parse(dt.Rows[i]["tongcuocvanchuyen"].ToString());
                }
                return HOADON_LIST;
            }
            return null;
        }
    }
}
