using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace HRMS.DAO
{
    class DBConnect
    {
     
        protected SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-2EQI5L4R\\MSSQLSERVER01;Initial" +
            " Catalog=QLNhanSu;Integrated Security=True");
     
    }
}
