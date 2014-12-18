using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_CongNo
    {
        private string _ma_cong_no;
        private string _ma_khach_hang;
        private DateTime _ngay_xuat_hd;
        private string _ma_hoa_don;
        private float _so_tien_thanh_toan;
        private string _tenkhachhang;
        private float _tongno;
        private float _tongtra;
        private float _con_lai;
        private string _ma_hd;

        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public string ma_cong_no
        {
            get { return _ma_cong_no; }
            set { _ma_cong_no = value; }
        }
        public DateTime ngay_xuat_hd
        {
            get { return _ngay_xuat_hd; }
            set { _ngay_xuat_hd = value; }
        }
        public string ma_hoa_don
        {
            get { return _ma_hoa_don; }
            set { _ma_hoa_don = value; }
        }
        public float so_tien_thanh_toan
        {
            get { return _so_tien_thanh_toan; }
            set { _so_tien_thanh_toan = value; }
        }

        public string tenkhachhang
        {
            get { return _tenkhachhang; }
            set { _tenkhachhang = value; }
        }
        public float tongno
        {
            get { return _tongno; }
            set { _tongno = value; }
        }
        public float tongtra
        {
            get { return _tongtra; }
            set { _tongtra = value; }
        }
        public float so_tien_con_lai
        {
            get { return _con_lai; }
            set { _con_lai = value; }
        }

        public string ma_hop_dong
        {
            get { return _ma_hd; }
            set { _ma_hd = value; }
        }
    }
}
