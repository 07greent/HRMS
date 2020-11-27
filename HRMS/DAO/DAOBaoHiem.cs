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
        public DataTable getBaoHiem()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HopDong", _conn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
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
