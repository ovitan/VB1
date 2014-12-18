using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public  class DTO_TinhTrangXe
    {
        private string _ma_tinh_trang;
        private string _ten_tinh_trang;

        public string ma_tinh_trang
        {
            get { return _ma_tinh_trang; }
            set { _ma_tinh_trang = value; }
        }
        public string ten_tinh_trang
        {
            get { return _ten_tinh_trang; }
            set { _ten_tinh_trang = value; }
        }   
    }
}
