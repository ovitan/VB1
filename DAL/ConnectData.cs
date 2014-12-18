using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QLDVVTHH.DAL;
namespace QLDVVTHH.DAL
{
    
    public class ConnectData
    {
        string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection cn;
        SqlCommand cmd;
        private bool OpenConnect()
        {
			try {
				cn = new SqlConnection(strConn);
				cn.Open();
				return true;
			} catch {
				return false;
			}
        }
        private void CloseConnect()
        {
            cn.Close();
            cn.Dispose();
            //cmd.Dispose();
        }
        public void Connect()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }
        public void DisConnect()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        public bool ExcuteNonQuery(string sql, SqlParameter[] prs)
        {
            try
            {
                OpenConnect();
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = CommandType.Text;
                if (prs != null)
                    cm.Parameters.AddRange(prs);
                cm.ExecuteNonQuery();
                CloseConnect();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        public SqlDataReader ExcuteDataReader(string sql, SqlParameter[] prs)
        {
            try
            {
                OpenConnect();
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = CommandType.Text;
                if (prs != null)
                    cm.Parameters.AddRange(prs);
                SqlDataReader dr = cm.ExecuteReader();
                return dr; ;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable ExcuteDataTable(string sql, SqlParameter[] prs)
        {
            try
            {
                OpenConnect();
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = CommandType.Text;
                if (prs != null)
                    cm.Parameters.AddRange(prs);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataSet ExcuteDataset(string sql, SqlParameter[] prs)
        {
            try
            {
                OpenConnect();
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = CommandType.Text;
                if (prs != null)
                    cm.Parameters.AddRange(prs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<T> MapDataReaderToObject<T>(SqlDataReader dr)
        {
            List<T> list = new List<T>();
            if (dr != null)
                while (dr.Read())
                {
                    T b = (T)Activator.CreateInstance(typeof(T));
                    foreach (var pr in typeof(T).GetProperties())
                    {
                        if (pr.CanWrite)
                        {
                            try
                            {
                                var value = Convert.ChangeType(dr[pr.Name], pr.PropertyType);
                                if (pr.PropertyType.Name.Equals(typeof(string).Name))
                                    value = (value as string).Trim();
                                pr.SetValue(b, value, null);
                            }
                            catch { }
                        }
                    }
                    list.Add(b);
                }
            CloseConnect();
            return list;
        }
        public DataTable GetTable(string proc, params object[] ob)
        {
            if (!OpenConnect())
                return null;
            cmd = new SqlCommand();
            cmd.CommandText = proc;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlCommandBuilder.DeriveParameters(cmd);
            for (int i = 1; i < cmd.Parameters.Count; i++)
            {
                cmd.Parameters[i].Value = ob[i - 1];
            }
            SqlDataAdapter da = new SqlDataAdapter();
			try {
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				CloseConnect();
				da.Dispose();
				return dt;
			} catch {
				return null;
			}
        }
        public DataSet GetDataSet(string proc, params object[] ob)
        {
            if (!OpenConnect())
                return null;
            cmd = new SqlCommand();
            cmd.CommandText = proc;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlCommandBuilder.DeriveParameters(cmd);
            for (int i = 1; i < cmd.Parameters.Count; i++)
            {
                cmd.Parameters[i].Value = ob[i - 1];
            }
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                CloseConnect();
                da.Dispose();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int ExcuteStore(string proc, params object[] ob)
        {
            if (!OpenConnect())
                return -1;
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = proc;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);
            for (int i = 1; i < cmd.Parameters.Count; i++)
            {
                cmd.Parameters[i].Value = ob[i - 1];
            }
            try
            {
                cmd.ExecuteNonQuery();
                CloseConnect();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
