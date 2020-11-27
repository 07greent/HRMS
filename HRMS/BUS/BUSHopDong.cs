using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.DAO;
using HRMS.DTO;
using System.Data;

namespace HRMS.BUS
{
    class BUSHopDong
    {
        DAOHopDong daoHopDong = new DAOHopDong();
         public DataTable getHopDong()
        {
            return daoHopDong.Get();
        }

        public DataTable getHopDong(string condition)
        {
            return daoHopDong.Get(condition);
        }

        public DataTable getHopDong(List<string> listProperties)
        {
            return daoHopDong.Get(listProperties);
        }

        public DataTable getHopDong(List<string> listProperties, string condition)
        {
            return daoHopDong.Get(listProperties, condition);
        }

        public bool ThemHopDong(string maHD,DateTime ngayVaoLam, int hesoLuong,string maCV,string maPB)
        {
            DTO_HopDong dtoHopDong = new DTO_HopDong(maHD,ngayVaoLam,hesoLuong,maCV,maPB);
            return daoHopDong.ThemHD(dtoHopDong);
        }
        public DataTable CTHD(string maHD, DateTime ngayVaoLam, int hesoLuong, string maCV, string maPB)
        {
            return daoHopDong.CtHopDong(maHD);
        }
    }
}
