using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.DTO;
using HRMS.DAO;
using System.Data;

namespace HRMS.BUS
{
    class BUSBaoHiem
    {
        DAOBaoHiem daoBaoHiem = new DAOBaoHiem();
        public DataTable getBaoHiem()
        {
            return daoBaoHiem.Get();
        }

        public DataTable getBaoHiem(string condition)
        {
            return daoBaoHiem.Get(condition);
        }

        public DataTable getBaoHiem(List<string> listProperties)
        {
            return daoBaoHiem.Get(listProperties);
        }

        public DataTable getBaoHiem(List<string> listProperties, string condition)
        {
            return daoBaoHiem.Get(listProperties, condition);
        }
        public DataTable CTBH(string maNV)
        {
            return daoBaoHiem.CtBaoHiem(maNV);
        }    
    }
}
