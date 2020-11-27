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
    class DAOChucVu:DBConnect
    {
        public DataTable getChucVu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", _conn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
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
        public bool themChucVu(DTO_ChucVu tv)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO ChucVu (MaCV,TenCV) " +
                                           "VALUES ('{0}', '{1}')",
                                            tv.CtChucVu_MaCV, tv.CtChucVu_TenCV);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

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
        public bool suaChucVu(DTO_ChucVu tv)
        {
            try
            {
               
                _conn.Open();
               
                string SQL = string.Format("UPDATE TAIKHOAN " +
                                           "SET MaCV = '{1}' " +
                                           "WHERE TenCV = '{0}'",
                                          tv.CtChucVu_MaCV, tv.CtChucVu_TenCV);
              
                SqlCommand cmd = new SqlCommand(SQL, _conn);
           
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
