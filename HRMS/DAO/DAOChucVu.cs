using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HRMS.DTO;
using System.Diagnostics.Eventing.Reader;

namespace HRMS.DAO
{
    class DAOChucVu:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from ChucVu", _conn);
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
                string sql = string.Format("Select * from ChucVu where {0}", condition);
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
                sql += " from ChucVu";

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
                sql += " from ChucVu";

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
        public DataTable CtChucVu(string maCV)
        {
            try
            {
                _conn.Open();
                SqlCommand comm = new SqlCommand("CTChucVu", _conn);
                comm.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@MaCV", maCV);
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
        public bool themChucVu(DTO_ChucVu cv)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("themChucVu", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaCV", cv.CtChucVu_MaCV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenCV", cv.CtChucVu_TenCV);
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
        public bool suaChucVu(DTO_ChucVu cv)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("suaChucVu", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaCV", cv.CtChucVu_MaCV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenCV", cv.CtChucVu_TenCV);
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
        public bool xoaChucVu(string maCV)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Delete", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhanVien", maCV);
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
