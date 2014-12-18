using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.DTO
{
    public class DTO_ResizeForm
    {
        private int _ChieuCao;
        private int _ChieuDai;
        private string _index;
        public int CHIEU_CAO
        {
            get { return _ChieuCao; }
            set { _ChieuCao = value; }
        }
        public int CHIEU_DAI
        {
            get { return _ChieuDai; }
            set { _ChieuDai = value; }
        }
        public string Index
        {
            get { return _index; }
            set { _index = value; }
        }
    }
}
