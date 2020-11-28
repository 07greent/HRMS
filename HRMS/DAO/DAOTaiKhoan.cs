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

//<<<<<<< HEAD
//        public bool themTaiKhoan(DTO_TaiKhoan tv)
//        {
//            try
//            {               
//                _conn.Open();


//                string SQL = string.Format("INSERT INTO TAIKHOAN (TenDangNhap, MatKhau) " +
//                                           "VALUES ('{0}', '{1}')",
//                                            tv.TaiKhoan_TenDangNhap, tv.TaiKhoan_MatKhau);
//                SqlCommand cmd = new SqlCommand(SQL, _conn);

//                if (cmd.ExecuteNonQuery() > 0)
//                    return true;

//            }
//            catch (Exception )
//            {

//=======
        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("themTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaNhanVien", tk.TaiKhoan_MaNhanVien);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenDangNhap", tk.TaiKhoan_TenDangNhap);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MatKhau", tk.TaiKhoan_MatKhau);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenQuyenHan", tk.TaiKhoan_TenQuyenHan);
                cmd.Parameters.Add(parameter);

            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                _conn.Close();
            }
//<<<<<<< HEAD

//            return false;
//        }


//        public bool suaTaiKhoan(DTO_TaiKhoan tv)
//=======
            return false;
        }
        public bool suaTaiKhoan(DTO_TaiKhoan tk)

        {
            try
            {
                _conn.Open();
//<<<<<<< HEAD
//                string SQL = string.Format("UPDATE TAIKHOAN " + "SET MATKHAU = '{1}' " +"WHERE TENDN = '{0}'",
//                                          tv.TaiKhoan_TenDangNhap, tv.TaiKhoan_MatKhau);

//                SqlCommand cmd = new SqlCommand(SQL, _conn);

//                if (cmd.ExecuteNonQuery() > 0)
//                    return true;

//            }
//            catch (Exception )
//            {

//=======

                SqlCommand cmd = new SqlCommand("themTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter;

                parameter = new SqlParameter("@MaNhanVien", tk.TaiKhoan_MaNhanVien);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenDangNhap", tk.TaiKhoan_TenDangNhap);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@MatKhau", tk.TaiKhoan_MatKhau);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@TenQuyenHan", tk.TaiKhoan_TenQuyenHan);
                cmd.Parameters.Add(parameter);

            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                _conn.Close();
            }
//<<<<<<< HEAD

//            return false;
//        }


//        public bool xoaTaiKhoan(string TENDN)
//=======
            return false;
        }
        public bool xoaTaiKhoan(string maNV)

        {
            try
            {               
                _conn.Open();
              
//<<<<<<< HEAD
//                string SQL = string.Format("DELETE FROM TAIKHOAN WHERE TENDangNhap = '{0}' ", TENDN);

                string SQL = string.Format("DELETE FROM TAIKHOAN WHERE MaNhanVien = '{0}' ", maNV);


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
