using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_asp.Models
{
    public class CrudMode
    {
        /// <summary>  
        /// Get all records from the DB  
        /// </summary>  
        /// <returns>Datatable</returns> 

        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            string strConString = @"Data Source = PC - PC\SQLEXPRESS; Initial Catalog = BDTestCrud; Integrated Security = SSPI";
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from tblStudent ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        /// <summary>  
        /// Get student detail by Student id  
        /// </summary>  
        /// <param name="intStudentID"></param>  
        /// <returns></returns>  
        public DataTable GetStudentByID(int intStudentID)
        {
            DataTable dt = new DataTable();
        }
    }
}