using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_Chi_Tiet_Hoa_Don
    {
        private int _ma_chi_tiet_hoa_don;
        private string _ma_hoa_don;
        private string _ma_bang_ke;
        private string _ma_khach_hang;
        public string ma_khach_hang
        {
            get { return _ma_khach_hang; }
            set { _ma_khach_hang = value; }
        }
        public int ma_chi_tiet_hoa_don
        {
            get { return _ma_chi_tiet_hoa_don; }
            set { _ma_chi_tiet_hoa_don = value; }
        }
        public string ma_hoa_don
        {
            get { return _ma_hoa_don; }
            set { _ma_hoa_don = value; }
        }
        public string ma_bang_ke
        {
            get { return _ma_bang_ke; }
            set { _ma_bang_ke = value; }
        }
    }
}
