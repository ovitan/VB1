using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDVVTHH.Common
{
    public static class Const
    {
        public const string EMPTY_MESSAGE = "Không được rỗng";
        public const string DATE_FORMAT = "dd/MM/yyyy";
        public const string DATE_TIME_FORMAT = "dd/MM/yyyy hh:mm:ss";
        public const string FIRST_CHAR_INPUT = "PN-";
        public const string FIRST_CHAR_BILL = "PB-";
        public const string NUMBER_FORMAT = "{0:0,0.00}";
        public const string EMPTY_FROMAT = ".........................";
        public static QLDVVTHH.DTO.DTO_NhanVien CurrentUser = new DTO.DTO_NhanVien();
    }
}
