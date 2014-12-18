using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDVVTHH.Common
{
    public class MethodHelper
    {
        #region Property
        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"      

        };


        private static ErrorProvider error = new ErrorProvider();

        #endregion

        #region Method
        public static void OnlyNumberFloatTextBox(TextBox txt, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == '.' && !(txt as TextBox).Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }
        public static void OnlyNumberIntTextBox(TextBox txt, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            e.Handled = true;
        }

        public static string RemoveUnicode(string str)
        {

            for (int i = 1; i < VietnameseSigns.Length; i++)
            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

            }

            return str;
        }

        public static string GetIdFromName(string str)
        {
            return RemoveUnicode(str.Replace(" ", "")).ToLower();
        }


        public static void AddErrorProvider(Control ctr, string value)
        {
            error.SetError(ctr, value);
            error.SetIconPadding(ctr, -17);
        }

        public static void ClearErrorProvider()
        {
            error.Clear();
        }

        public static string GetInputId()
        {
            return Const.FIRST_CHAR_INPUT + DateTime.Now.ToString("yyMMddhhmmssms");
        }

        public static string GetBillId()
        {
            return Const.FIRST_CHAR_BILL + DateTime.Now.ToString("yyMMddhhmmssms");
        }

        #endregion
    }
}
