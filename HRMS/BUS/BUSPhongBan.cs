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
    class BUSPhongBan
    {
<<<<<<< HEAD
        //DAOPhongBan daoPhongBan = new DAOPhongBan();
        //public DataTable getPhongBan()
        //{
        //    return daoPhongBan.Get();
        //}

        //public DataTable getPhongBan(string condition)
        //{
        //    return daoPhongBan.Get(condition);
        //}

        //public DataTable getPhongBan(List<string> listProperties)
        //{
        //    return daoPhongBan.Get(listProperties);
        //}

        //public DataTable getPhongBan(List<string> listProperties, string condition)
        //{
        //    return daoPhongBan.Get(listProperties, condition);
        //}
        //public bool ThemPB(string maPB,string tenPB)
        //{
        //    DTO_PhongBan dtoPhongBan = new DTO_PhongBan(maPB, tenPB);
        //    return daoPhongBan.AddPB(dtoPhongBan);
        //}
        //public bool XoaPB(string maPB)
        //{
        //    return daoPhongBan.DeletePB(maPB);
        //}
=======
        DAOPhongBan daoPhongBan = new DAOPhongBan();
        public DataTable getPhongBan()
        {
            return daoPhongBan.Get();
        }

        public DataTable getPhongBan(string condition)
        {
            return daoPhongBan.Get(condition);
        }

        public DataTable getPhongBan(List<string> listProperties)
        {
            return daoPhongBan.Get(listProperties);
        }

        public DataTable getPhongBan(List<string> listProperties, string condition)
        {
            return daoPhongBan.Get(listProperties, condition);
        }
        public bool ThemPB(string maPB,string tenPB)
        {
            DTO_PhongBan dtoPhongBan = new DTO_PhongBan(maPB, tenPB);
            return daoPhongBan.AddPB(dtoPhongBan);
        }
        public bool SuaPB(string maPB, string tenPB)
        {
            DTO_PhongBan dtoPhongBan = new DTO_PhongBan(maPB, tenPB);
            return daoPhongBan.SuaPB(dtoPhongBan);
        }
        public bool XoaPB(string maPB)
        {
            return daoPhongBan.DeletePB(maPB);
        }
>>>>>>> 387e7c3c752ee2f441329f5a971169d9ab7f2e9f
        
    }
}
