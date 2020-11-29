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
    class DAOHopDong:DBConnect
    {
//<<<<<<< HEAD
//        public DataTable getHopDong()
//        {
//            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HopDong", _conn);
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
                SqlDataAdapter da = new SqlDataAdapter("select * from HopDong", _conn);
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
                string sql = string.Format("Select * from HopDong where {0}", condition);
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
                sql += " from HopDong";

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

        internal bool ThemHD(DTO_HopDong dtoHopDong)
        {
            throw new NotImplementedException();
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
                sql += " from HopDong";

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
        public DataTable CtHopDong(string maHD)
        {
            try
            {
                _conn.Open();
                SqlCommand comm = new SqlCommand("CtHopDong", _conn);
                comm.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@MaHD", maHD);
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
        //<<<<<<< HEAD
        public bool themHopDong(DTO_HopDong hd)
//=======
        //public bool ThemHD(DTO_HopDong hd)

        {
            try
            {
                _conn.Open();

//<<<<<<< HEAD
//                string SQL = string.Format("INSERT INTO HopDong (MaCV) " + "VALUES ('{0}')", hd.HopDong_MaHD);

//                SqlCommand cmd = new SqlCommand(SQL, _conn);

//                if (cmd.ExecuteNonQuery() > 0)
//                    return true;
//            }
//            catch (Exception)
//            {
//=======
                SqlCommand cmd = new SqlCommand("ThemHopDong", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaHD", hd.HopDong_MaHD);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@NgayVaoLam", Convert.ToDateTime(hd.HopDong_NgayVaoLam));
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@HeSoLuong", hd.HopDong_HeSoLuong);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MaCV", hd.HopDong_MaCV);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MaPB", hd.HopDong_MaPB);
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
    }
}

