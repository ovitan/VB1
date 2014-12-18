using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    class DTO_DichVu
    {
        private string _khu_vuc;
        private string _phan_vung;
        private float _don_gia_chuyen;
        private float _don_gia_tan;

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
    }
}
