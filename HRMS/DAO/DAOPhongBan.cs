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
    class DAOPhongBan : DBConnect
    {
//<<<<<<< HEAD
//        public DataTable getPhongBan()
//        {
//            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhongBan", _conn);
//            DataTable data = new DataTable();
//            da.Fill(data);
//            return data;
//=======
        public DataTable Get()
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from PhongBan", _conn);
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
                string sql = string.Format("Select * from PhongBan where {0}", condition);
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
                sql += " from PhongBan";

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
                sql += " from PhongBan";

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
        public bool AddPB(DTO_PhongBan pb)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("AddPB", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaPB", pb.PhongBan_MaPB);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenPB", pb.PhongBan_TenPB);
                cmd.Parameters.Add(parameter);                           
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool SuaPB(DTO_PhongBan pb)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("SuaPB", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaPB", pb.PhongBan_MaPB);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenPB", pb.PhongBan_TenPB);
                cmd.Parameters.Add(parameter);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeletePB(string MaPB)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("DeletePB", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPB", MaPB);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
