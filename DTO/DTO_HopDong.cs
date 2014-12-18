using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_HopDong
    {
        private string _ma_hop_dong;
        private string _ma_khach_hang;
        private DateTime _ngay_tao;
        private DateTime _ngay_bat_dau;
        private DateTime _ngay_ket_thuc;
        private string _ten_khach_hang;
        private string _loaihanghoa;
        private string _lotrinhvanchuyen;
        private string _phuongthucvanchuyen;
        private string _giatrihopdong;
        private string _phuongthucthanhtoan;

        public string ma_hop_dong
        {
            get { return _ma_hop_dong; }
            set { _ma_hop_dong = value; }
        }
        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public DateTime ngay_tao
        {
            get { return _ngay_tao; }
            set { _ngay_tao = value; }
        }
        public DateTime ngay_bat_dau
        {
            get { return _ngay_bat_dau; }
            set { _ngay_bat_dau = value; }
        }
        public DateTime ngay_ket_thuc
        {
            get { return _ngay_ket_thuc; }
            set { _ngay_ket_thuc = value; }
        }
        public string ten_khach_hang
        {
            get { return _ten_khach_hang; }
            set { _ten_khach_hang = value; }
        }

        public string loaihanghoa
        {
            get { return _loaihanghoa; }
            set { _loaihanghoa = value; }
        }
        public string lotrinhvanchuyen
        {
            get { return _lotrinhvanchuyen; }
            set { _lotrinhvanchuyen = value; }
        }
        public string phuongthucvanchuyen
        {
            get { return _phuongthucvanchuyen; }
            set { _phuongthucvanchuyen = value; }
        }
        public string giatrihopdong
        {
            get { return _giatrihopdong; }
            set { _giatrihopdong = value; }
        }
        public string phuongthucthanhtoan
        {
            get { return _phuongthucthanhtoan; }
            set { _phuongthucthanhtoan = value; }
        }
    }
}
