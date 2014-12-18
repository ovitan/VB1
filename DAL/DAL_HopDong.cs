using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;
namespace QLDVVTHH.DAL
{
    public class DAL_HopDong
    {
        ConnectData data = new ConnectData();
        public DataTable _Bang_Ma_Khach_Hang()
        {
            string sql = "select ma_khach_hang from dm_khach_hang";
            return data.ExcuteDataTable(sql,null);
        }
        public List<DTO_HopDong> Ma_HD()
        {
            string sql = "select ma_hop_dong from dm_hop_dong";
            //SqlDataReader dr = data.ExcuteDataReader(sql, null);
            //return data.MapDataReaderToObject<DTO_HopDong>(dr);
            DataTable dt = data.ExcuteDataTable(sql, null);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<DTO_HopDong> _hdd = new List<DTO_HopDong>();
                foreach(DataRow dr in dt.Rows)
                {
                    DTO_HopDong hdd=new DTO_HopDong();
                    hdd.ma_hop_dong=dr["ma_hop_dong"].ToString();
                    _hdd.Add(hdd);
                }
                return _hdd;
            }
            return null;
         }
        public List<DTO_HopDong> GetAll_KH_HD_HH()
        {
            string sql = "select A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang order by B.ngay_tao desc";
            SqlDataReader dr = data.ExcuteDataReader(sql, null);
            return data.MapDataReaderToObject<DTO_HopDong>(dr);
        }
        public List<DTO_HopDong> GetAll_KH_ID(string KHID)
        {
            string sql = "select A.ten_khach_hang, B.ma_hop_dong, B.loaihanghoa, A.ma_khach_hang from dm_khach_hang A join dm_hop_dong B on A.ma_khach_hang = B.ma_khach_hang where B.ma_khach_hang = @ma_khach_hang";
            SqlParameter[] prs = 
            {
                new SqlParameter("@ma_khach_hang",KHID)
            };
            SqlDataReader dr = data.ExcuteDataReader(sql, prs);
            return data.MapDataReaderToObject<DTO_HopDong>(dr);
        }
        public string _Ten_Khach_Hang_Theo_Ma_Khach_Hang(DTO_KhachHang kh)
        {
            string name = "";
            string sql = "select ten_khach_hang,ma_so_thue,dien_thoai,fax,dia_chi from dm_khach_hang where ma_khach_hang=@thamsoma";
            SqlParameter[] prs = 
            {
                new SqlParameter("@thamsoma",kh.ma_khach_hang.Trim())
            };
            DataTable dt = data.ExcuteDataTable(sql, prs);
            foreach (DataRow dr in dt.Rows)
            {
                name = "Mã Số Thuế :" + dr["ma_so_thue"].ToString() + " - Số Điện Thoại : " + dr["dien_thoai"].ToString() + " - Fax:" + dr["fax"].ToString() + " - Địa Chỉ :" + dr["dia_chi"].ToString();
            }
            return name;
        }
        public string _Ma_Hop_Dong()
        {
            return new DAL_Systems().CreateIDCode("HD", "ma_hop_dong", "dm_hop_dong", 5);
        }
        protected string CreateIDCode(string strID, string field, string table, int length)
        {
            try
            {
                string IDCode = strID + "000";
                string query = "select max(" + field.Trim() + ") from " + table.Trim() + " where left(" + field.Trim() + "," + strID.Length.ToString() + ")='" + strID.Trim() + "'";

                DataTable dt = data.ExcuteDataTable(query, null);

                IDCode = dt.Rows[0][0].ToString();

                IDCode = IDCode.Substring(strID.Length);
                IDCode = "0000000000000000" + Convert.ToString(Convert.ToInt64(IDCode) + 1);
                IDCode = strID + IDCode.Substring(IDCode.Length - length + strID.Length);

                return IDCode;
            }
            catch (Exception ex)
            {
				throw;
            }
        }
        public int _Them_Hop_Dong(DTO_HopDong hd)
        {
            int i = 0;
            try
            {
                string sql = "insert into dm_hop_dong(ma_hop_dong,ma_khach_hang,ngay_tao,ngay_bat_dau,ngay_ket_thuc,loaihanghoa,lotrinhvanchuyen,phuongthucvanchuyen,giatrihopdong,phuongthucthanhtoan) "
             + "values (@ma_hop_dong,@ma_khach_hang,@ngay_tao,@ngaybatdau,@ngayketthuc,@loaihanghoa,@lotrinhvanchuyen,@phuongthucvanchuyen,@giatrihopdong,@phuongthucthanhtoan)";
                SqlParameter[] prs = 
            {
                new SqlParameter("@ma_hop_dong",hd.ma_hop_dong.Trim()),
                new SqlParameter("@ma_khach_hang",hd.ma_khach_hang.Trim()),
                new SqlParameter("@ngay_tao",hd.ngay_tao),
                new SqlParameter("@ngaybatdau",hd.ngay_bat_dau),
                new SqlParameter("@ngayketthuc",hd.ngay_ket_thuc),
                new SqlParameter("@loaihanghoa",hd.loaihanghoa),
                new SqlParameter("@lotrinhvanchuyen",hd.lotrinhvanchuyen),
                new SqlParameter("@phuongthucvanchuyen",hd.phuongthucvanchuyen),
                new SqlParameter("@giatrihopdong",hd.giatrihopdong),
                new SqlParameter("@phuongthucthanhtoan",hd.phuongthucthanhtoan)
           }; 
                data.ExcuteNonQuery(sql, prs);
                i = 1;
            }
            catch
            {
                i = 0;
            }
            return i;
        }
        public DTO_HopDong[] _List_Hop_Dong_Cung_Khach_Hang(DTO_HopDong hd)
        {
            string sql = "select ma_hop_dong,dm_khach_hang.ma_khach_hang,ten_khach_hang,ngay_bat_dau,ngay_ket_thuc from dm_hop_dong,dm_khach_hang where dm_khach_hang.ma_khach_hang=dm_hop_dong.ma_khach_hang and dm_khach_hang.ma_khach_hang=@makh";
            SqlParameter[] prs = 
            {
                new SqlParameter("@makh",hd.ma_khach_hang.Trim())
            };
            DataTable dt= data.ExcuteDataTable(sql, prs);
            if (dt.Rows.Count > 0)
            {
                DTO_HopDong[] hopdong = new DTO_HopDong[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hopdong[i] = new DTO_HopDong();
                    hopdong[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    hopdong[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    hopdong[i].ten_khach_hang = dt.Rows[i]["ten_khach_hang"].ToString();
                    hopdong[i].ngay_bat_dau =Convert.ToDateTime(dt.Rows[i]["ngay_bat_dau"].ToString());
                    hopdong[i].ngay_ket_thuc = Convert.ToDateTime(dt.Rows[i]["ngay_ket_thuc"].ToString());
                }
                return hopdong;
            }
            return null;
        }
        public bool _Xoa_Hop_Dong(DTO_HopDong dto)
        {
            bool kt = true;
            try
            {
                string sql1 = "select * from dm_hoa_don where ma_hop_dong=@mahd";
                SqlParameter[] prs = 
                {
                   new SqlParameter("@mahd",dto.ma_hop_dong)
                };
                DataTable dt = data.ExcuteDataTable(sql1, prs);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    string sql2 = "delete from dm_hop_dong where ma_hop_dong=@mahd";
                    SqlParameter[] prs2 = 
                        {
                         new SqlParameter("@mahd",dto.ma_hop_dong)
                       };
                    data.ExcuteNonQuery(sql2, prs2);
                }
                else
                {
                    kt = false;
                }
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
        public bool _Update_Hop_Dong(DTO_HopDong dto)
        {
            bool up = true;
            try
            {
                string sql = "update dm_hop_dong set ngay_bat_dau=@ngaybd,ngay_ket_thuc=@ngaykt,loaihanghoa=@loaihanghoa,lotrinhvanchuyen=@lotrinhvanchuyen,phuongthucvanchuyen=@phuongthucvanchuyen,giatrihopdong=@giatrihopdong,phuongthucthanhtoan=@phuongthucthanhtoan where ma_hop_dong=@mahd and ma_khach_hang=@makh";
                SqlParameter[] prs = 
                {
                   new SqlParameter("@mahd",dto.ma_hop_dong),
                   new SqlParameter("@makh",dto.ma_khach_hang),
                   new SqlParameter("@ngaybd",dto.ngay_bat_dau),
                   new SqlParameter("@ngaykt",dto.ngay_ket_thuc),
                   new SqlParameter("@loaihanghoa",dto.loaihanghoa),
                   new SqlParameter("@lotrinhvanchuyen",dto.lotrinhvanchuyen),
                   new SqlParameter("@phuongthucvanchuyen",dto.phuongthucvanchuyen),
                   new SqlParameter("@giatrihopdong",dto.giatrihopdong),
                   new SqlParameter("@phuongthucthanhtoan",dto.phuongthucthanhtoan)

                };
                data.ExcuteNonQuery(sql, prs);
            }
            catch
            {
                up = false;
            }
            return up;
        }
        public DTO_HopDong[] _Tim_Khach_Hang_Hop_Dong(DTO_HopDong dto)
        {
            string url = "";
            if ((dto.ma_hop_dong == "" || dto.ma_hop_dong == null) && dto.ma_khach_hang != "")
            {
                url = "and dm_khach_hang.ma_khach_hang=@makh";
            }
            else
            {
                if (dto.ma_khach_hang != "")
                {
                    url = "and dm_khach_hang.ma_khach_hang=@makh and ma_hop_dong=@mahd";
                }
                else
                {
                    url = "and  ma_hop_dong=@mahd";
                }
            }
            string sql = "select * from dm_khach_hang,dm_hop_dong where dm_khach_hang.ma_khach_hang=dm_hop_dong.ma_khach_hang " + url; ;
            SqlParameter[] prs = 
                    {
                         new SqlParameter("@makh",dto.ma_khach_hang),
                         new SqlParameter("@mahd",dto.ma_hop_dong)
                    };
            DataTable dt = data.ExcuteDataTable(sql, prs);
            if (dt.Rows.Count > 0)
            {
                DTO_HopDong[] hopdong = new DTO_HopDong[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hopdong[i] = new DTO_HopDong();
                    hopdong[i].ma_hop_dong = dt.Rows[i]["ma_hop_dong"].ToString();
                    hopdong[i].ma_khach_hang = dt.Rows[i]["ma_khach_hang"].ToString();
                    hopdong[i].ten_khach_hang = dt.Rows[i]["ten_khach_hang"].ToString();
                    hopdong[i].ngay_bat_dau = Convert.ToDateTime(dt.Rows[i]["ngay_bat_dau"].ToString());
                    hopdong[i].ngay_ket_thuc = Convert.ToDateTime(dt.Rows[i]["ngay_ket_thuc"].ToString());
                    hopdong[i].lotrinhvanchuyen = dt.Rows[i]["lotrinhvanchuyen"].ToString();
                    hopdong[i].phuongthucvanchuyen = dt.Rows[i]["phuongthucvanchuyen"].ToString();
                    hopdong[i].loaihanghoa = dt.Rows[i]["loaihanghoa"].ToString();
                    hopdong[i].giatrihopdong = dt.Rows[i]["giatrihopdong"].ToString();
                    hopdong[i].phuongthucthanhtoan = dt.Rows[i]["phuongthucthanhtoan"].ToString();
                }
                return hopdong;
            }

            return null;
        }

    }
}
