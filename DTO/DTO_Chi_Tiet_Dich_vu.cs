using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    class DTO_Chi_Tiet_Dich_vu
    {
        private string _khu_vuc;
        private string _phan_vung;
        private string _ma_bao_gia;
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
        public string ma_bao_gia
        {
            get { return _ma_bao_gia; }
            set { _ma_bao_gia = value; }
        }
    }
}
