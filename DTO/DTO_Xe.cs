using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_Xe
    {
        private string _ma_so_xe;
        private float _trong_luong;
        private string _loai_xe;
        private string _nhan_hieu;
        private int _ma_tinh_trang;
        private string _ten_tinh_trang;
        private DateTime _ngay_tao;

        public string ma_so_xe
        {
            get { return _ma_so_xe; }
            set { _ma_so_xe = value; }
        }
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
        public DateTime ngay_tao
        {
            get { return _ngay_tao; }
            set { _ngay_tao = value; }
        }
        public string ten_tinh_trang
        {
            get { return _ten_tinh_trang; }
            set { _ten_tinh_trang = value; }
        }   
    }
}
