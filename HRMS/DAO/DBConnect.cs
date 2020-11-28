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
        public SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-1OD02N22\\SQLEXPRESS;Initial" +
            " Catalog=QLNhanSu;Integrated Security=True");
    }
}
