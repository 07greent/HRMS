using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HRMS.DTO;

namespace HRMS.DAO
{
    class DAOTaiKhoan : DBConnect
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Taikhoan", _conn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        public bool themTaiKhoan(DTO_TaiKhoan tv)
        {
            try
            {               
                _conn.Open();


                string SQL = string.Format("INSERT INTO TAIKHOAN (TenDangNhap, MatKhau) " +
                                           "VALUES ('{0}', '{1}')",
                                            tv.TaiKhoan_TenDangNhap, tv.TaiKhoan_MatKhau);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception )
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }


        public bool suaTaiKhoan(DTO_TaiKhoan tv)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE TAIKHOAN " + "SET MATKHAU = '{1}' " +"WHERE TENDN = '{0}'",
                                          tv.TaiKhoan_TenDangNhap, tv.TaiKhoan_MatKhau);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception )
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }


        public bool xoaTaiKhoan(string TENDN)
        {
            try
            {               
                _conn.Open();
              
                string SQL = string.Format("DELETE FROM TAIKHOAN WHERE TENDangNhap = '{0}' ", TENDN);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
            
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception )
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
