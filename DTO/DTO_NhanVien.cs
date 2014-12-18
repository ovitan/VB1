using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_NhanVien
    {
        private string _ma_nhan_vien;
        private string _ten_nhan_vien;
        public string _ma_so_xe;
        private string _cmnd;
        private string _dia_chi;
        private DateTime _nam_sinh;
        private string _dien_thoai;
        private string _chucvu;
        private DateTime _ngay_tao;
        private string _ma_hop_dong;

        public string ma_nhan_vien
        {
            get { return _ma_nhan_vien; }
            set { _ma_nhan_vien = value; }
        }
        public string ten_nhan_vien
        {
            get { return _ten_nhan_vien; }
            set { _ten_nhan_vien = value; }
        }
        public string ma_so_xe
        {
            get { return _ma_so_xe; }
            set { _ma_so_xe = value; }
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
       
        public DateTime ngay_tao
        {
            get { return _ngay_tao; }
            set { _ngay_tao = value; }
        }

        public string chucvu 
        { 
            get{ return _chucvu; }
            set { _chucvu = value; } 
        }
        public string ma_hop_dong
        {
            get { return _ma_hop_dong; }
            set { _ma_hop_dong = value; }
        }
    }
}
