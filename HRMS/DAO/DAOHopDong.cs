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
        public DataTable getHopDong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HopDong", _conn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
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
        public bool themHopDong(DTO_HopDong hd)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO HopDong (MaCV) " + "VALUES ('{0}')", hd.HopDong_MaHD);

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
