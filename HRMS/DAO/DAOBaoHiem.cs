using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HRMS.DTO;

namespace HRMS.DAO
{
    class DAOBaoHiem : DBConnect
    {
        public DataTable Get()
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from BaoHiem", _conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get(string condition)
        {
            try
            {
                string sql = string.Format("Select * from BaoHiem where {0}", condition);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Get(List<string> listProperties)
        {
            try
            {

                string sql = "select distinct " + listProperties[0];
                for (int i = 1; i < listProperties.Count; i++)
                {
                    sql += (", " + listProperties[i]);
                }
                sql += " from BaoHiem";

                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Get(List<string> listProperties, string condition)
        {
            try
            {
                string sql = "select  " + listProperties[0];
                for (int i = 1; i < listProperties.Count; i++)
                {
                    sql += (", " + listProperties[i]);
                }
                sql += " from BaoHiem";

                sql += (" where " + condition);

                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable CtBaoHiem(string maNV)
        {
            try
            {
                _conn.Open();
                SqlCommand comm = new SqlCommand("CtBaoHiem", _conn);
                comm.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@MaNhanVien", maNV);
                comm.Parameters.Add(para);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comm;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                _conn.Close();
                return dataTable;
            }
            catch
            {
                return null;
            }
        }
    }
}
