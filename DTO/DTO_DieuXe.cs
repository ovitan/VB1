using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_DieuXe
    {
        private string _ma_dieu_xe;
        private string _ma_khach_hang;
        private string _ten_khach_hang;
        private string _noi_giao;
        private string _noi_nhan;
        private string _so_tan;
        private DateTime _ngay_dieu_xe;
        private string _ma_nhan_vien;
        private string _ma_so_xe;

        public string ma_dieu_xe
        {
            get { return _ma_dieu_xe; }
            set { _ma_dieu_xe = value; }
        }
        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public string ten_khach_hang
        {
            get { return _ten_khach_hang; }
            set { _ten_khach_hang = value; }
        }
        public string so_tan
        {
            get { return _so_tan; }
            set { _so_tan = value; }
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
        public DateTime ngay_dieu_xe
        {
            get { return _ngay_dieu_xe; }
            set { _ngay_dieu_xe = value; }
        }
        public string ma_nhan_vien
        {
            get { return _ma_nhan_vien; }
            set { _ma_nhan_vien = value; }
        }
        public string ma_so_xe
        {
            get { return _ma_so_xe; }
            set { _ma_so_xe = value; }
        }
        
        private float _trong_luong;
        private string _loai_xe;
        private string _nhan_hieu;
        private int _ma_tinh_trang;
        private string _ten_tinh_trang;
        

       
        public float trong_luong
        {
            get { return _trong_luong; }
            set { _trong_luong = value; }
        }
        public string loai_xe
        {
            get { return _loai_xe; }
            set { _loai_xe = value; }
        }
        public string nhan_hieu
        {
            get { return _nhan_hieu; }
            set { _nhan_hieu = value; }
        }
        public int ma_tinh_trang
        {
            get { return _ma_tinh_trang; }
            set { _ma_tinh_trang = value; }
        }
      
        public string ten_tinh_trang
        {
            get { return _ten_tinh_trang; }
            set { _ten_tinh_trang = value; }
        }

        
        private string _ten_nhan_vien;
        private string _cmnd;
        private string _dia_chi;
        private DateTime _nam_sinh;
        private string _dien_thoai;
        private string _chucvu;
        

     
        public string ten_nhan_vien
        {
            get { return _ten_nhan_vien; }
            set { _ten_nhan_vien = value; }
        }

        public string cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }
        public string dia_chi
        {
            get { return _dia_chi; }
            set { _dia_chi = value; }
        }
        public DateTime nam_sinh
        {
            get { return _nam_sinh; }
            set { _nam_sinh = value; }
        }
        public string dien_thoai
        {
            get { return _dien_thoai; }
            set { _dien_thoai = value; }
        }


        public string chucvu
        {
            get { return _chucvu; }
            set { _chucvu = value; }
        }


        private string _ma_hop_dong;
        private string _loaihanghoa;
        public string ma_hop_dong
        {
            get { return _ma_hop_dong; }
            set { _ma_hop_dong = value; }
        }
        public string loaihanghoa
        {
            get { return _loaihanghoa; }
            set { _loaihanghoa = value; }
        }

        private float _don_gia_chuyen;
        private float _don_gia_tan;
        public float don_gia_chuyen
        {
            get { return _don_gia_chuyen; }
            set { _don_gia_chuyen = value; }
        }
        public float don_gia_tan
        {
            get { return _don_gia_tan; }
            set { _don_gia_tan = value; }
        }

        private DateTime _ngay_ve;
        private int _ttt;
        private string _tinh_trang_thanh_toan;
        public DateTime ngay_ve
        {
            get { return _ngay_ve; }
            set { _ngay_ve = value; }
        }
        public int tttt
        {
            get { return _ttt; }
            set { _ttt = value; }
        }
        public string tinh_trang_thanh_toan
        {
            get { return _tinh_trang_thanh_toan; }
            set { _tinh_trang_thanh_toan = value; }
        }
        private float _tai_trong_xe;
        public float tai_trong_xe
        {
            get { return _tai_trong_xe; }
            set { _tai_trong_xe = value; }
        }
    }
}
