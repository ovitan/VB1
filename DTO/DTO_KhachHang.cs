using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_KhachHang
    {
        private string _ma_khach_hang;
        private string _ten_khach_hang;
        private string _ma_so_thue;
        private string _dia_chi;
        private string _dien_thoai;
        private string _fax;
        private DateTime _ngay_tao;

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
        public  string ma_so_thue
        {
            get { return _ma_so_thue; }
            set { _ma_so_thue = value; }
        }
        public string dia_chi
        {
            get { return _dia_chi; }
            set { _dia_chi = value; }
        }
        public string dien_thoai
        {
            get { return _dien_thoai; }
            set { _dien_thoai = value; }
        }
        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        public DateTime ngay_tao
        {
            get { return _ngay_tao; }
            set { _ngay_tao = value; }
        }  
    }
}
