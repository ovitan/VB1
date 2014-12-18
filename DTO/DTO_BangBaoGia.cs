using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_BangBaoGia
    {
        private string  _ma_bao_gia;
        private string _ma_hop_dong;
        private DateTime _tu_ngay;
        private DateTime _den_ngay;
        private string _noi_giao;
        private string _noi_nhan;
        private float _don_gia_tan;
        private float _don_gia_chuyen;
        private string _ghi_chu;
        //private DateTime _ngay_tao;
        //private DateTime _ngay_cap_nhat;

        public string ma_bao_gia
        {
            get { return _ma_bao_gia; }
            set { _ma_bao_gia = value; }
        }
        public string ma_hop_dong
        {
            get { return _ma_hop_dong; }
            set { _ma_hop_dong = value; }
        }
        
        public DateTime tu_ngay
        {
            get { return _tu_ngay; }
            set { _tu_ngay = value; }
        }
        public DateTime den_ngay
        {
            get { return _den_ngay; }
            set { _den_ngay = value; }
        }

        public string ghi_chu
        {
            get { return _ghi_chu; }
            set { _ghi_chu = value; }
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
        //public DateTime ngay_tao
        //{
        //    get { return _ngay_tao; }
        //    set { _ngay_tao = value; }
        //}
        //public DateTime ngay_cap_nhat
        //{
        //    get { return _ngay_cap_nhat; }
        //    set { _ngay_cap_nhat = value; }
        //}
        private string _khu_vuc;
        private string _phan_vung;
        //private float _don_gia_chuyen;
        //private float _don_gia_tan;

        public string khu_vuc
        {
            get { return _khu_vuc; }
            set { _khu_vuc = value; }
        }
        public string phan_vung
        {
            get { return _phan_vung; }
            set { _phan_vung = value; }
        }
        //public float don_gia_chuyen
        //{
        //    get { return _don_gia_chuyen; }
        //    set { _don_gia_chuyen = value; }
        //}
        //public float don_gia_tan
        //{
        //    get { return _don_gia_tan; }
        //    set { _don_gia_tan = value; }
        //}

    }
}
