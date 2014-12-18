using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_ThanhToan
    {
        private int _ma_thanh_toan;
        private string _ma_khach_hang;
        private DateTime _ngay_thanh_toan;
        private float _so_tien_thanh_toan;
        private string _ma_hop_dong;
        public string ma_hop_dong
        {
            get { return _ma_hop_dong; }
            set { _ma_hop_dong = value; }
        }
        public int ma_thanh_toan
        {
            get { return _ma_thanh_toan; }
            set { _ma_thanh_toan = value; }
        }
        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public DateTime ngay_thanh_toan
        {
            get { return _ngay_thanh_toan; }
            set { _ngay_thanh_toan = value; }
        }
        public float so_tien_thanh_toan
        {
            get { return _so_tien_thanh_toan; }
            set { _so_tien_thanh_toan = value; }
        }
    }
}
