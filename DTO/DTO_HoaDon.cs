using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_HoaDon
    {
        private string _ma_hoa_don;
        private string _ma_khach_hang;
        private string _ma_hop_dong;
        private float _khoi_luong;
        private float _tong_cuot_van_chuyen;
        private DateTime _ngay_xuat_hoa_don;
        private float _thue;
        private float _tong_cong;
        private string _tenkhachhang;
        public string tenkhachhang
        {
            get { return _tenkhachhang; }
            set { _tenkhachhang = value; }
        }
        public string ma_hoa_don
        {
            get { return _ma_hoa_don; }
            set { _ma_hoa_don = value; }
        }
        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public DateTime ngay_Xuat_hoa_don
        {
            get { return _ngay_xuat_hoa_don; }
            set { _ngay_xuat_hoa_don = value; }
        }
        public string ma_hop_dong
        {
            get { return _ma_hop_dong; }
            set { _ma_hop_dong = value; }
        }
        public float tong_khoi_luong
        {
            get { return _khoi_luong; }
            set { _khoi_luong = value; }
        }
        public float tong_cuot_van_chuyen
        {
            get { return _tong_cuot_van_chuyen; }
            set { _tong_cuot_van_chuyen = value; }
        }
        public float theu
        {
            get { return _thue; }
            set { _thue = value; }
        }
        public float tong_cong
        {
            get { return _tong_cong; }
            set { _tong_cong = value; }
        }
    }
}
