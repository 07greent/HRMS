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
        public DataTable Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhongBan", _conn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
    }
}
