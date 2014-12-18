using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_BangKe
    {
        private string _ma_bang_ke;
        private string _ma_khach_hang;
        private DateTime _ngay_van_chuyen;
        private float _khoi_luong;
        private float _don_gia_tan;
        private float _don_gia_chuyen;
        private string _noi_nhan;
        private string _noi_giao;
        private string _so_xe;
        private DateTime _ngay_tao;
        private DateTime _ngay_cap_nhat;
        private string _ghi_chu;
        private string _ma_dieu_xe;

        public string ma_dieu_xe
        {
            get { return _ma_dieu_xe; }
            set { _ma_dieu_xe = value; }
        }
        public string ma_bang_ke
        {
            get { return _ma_bang_ke; }
            set { _ma_bang_ke = value; }
        }
        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public DateTime ngay_van_chuyen
        {
            get { return _ngay_van_chuyen; }
            set { _ngay_van_chuyen = value; }
        }
        public float khoi_luong
        {
            get { return _khoi_luong; }
            set { _khoi_luong = value; }
        }
        public float don_gia_tan
        {
            get { return _don_gia_tan; }
            set { _don_gia_tan = value; }
        }
        public float don_gia_chuyen
        {
            get { return _don_gia_chuyen; }
            set { _don_gia_chuyen = value; }
        }
        public string noi_giao
        {
            get { return _noi_giao; }
            set { _noi_giao = value; }
        }
        public string noi_nhan
        {
            get { return _noi_nhan; }
            set { _noi_nhan = value; }
        }
        public DateTime ngay_tao
        {
            get { return _ngay_tao; }
            set { _ngay_tao = value; }
        }
        public DateTime ngay_cap_nhat
        {
            get { return _ngay_cap_nhat; }
            set { _ngay_cap_nhat = value; }
        }
        public string ghi_chu
        {
            get { return _ghi_chu; }
            set { _ghi_chu = value; }
        }
        public string so_xe
        {
            get { return _so_xe; }
            set { _so_xe = value; }
        }
    }
}
