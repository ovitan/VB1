using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDVVTHH.DTO;
using QLDVVTHH.DAL;

namespace QLDVVTHH.DAL
{
    public class DAL_Systems
    {
        ConnectData data = new ConnectData();
        public string CreateIDCode(string strID, string field, string table, int length)
        {
            try
            {
                string IDCode = strID + "000";
                string query = "select max(" + field.Trim() + ") from " + table.Trim() + " where left(" + field.Trim() + "," + strID.Length.ToString() + ")='" + strID.Trim() + "'";

                DataTable dt = data.ExcuteDataTable(query, null);
                if (dt.Rows[0][0].ToString()!="")
                {
                    IDCode = dt.Rows[0][0].ToString();
                }

                IDCode = IDCode.Substring(strID.Length);
                IDCode = "0000000000000000" + Convert.ToString(Convert.ToInt64(IDCode) + 1);
                IDCode = strID + IDCode.Substring(IDCode.Length - length + strID.Length);

                return IDCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
