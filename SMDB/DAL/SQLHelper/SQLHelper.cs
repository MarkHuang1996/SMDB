using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;//Be used for app.config 


namespace DAL
{
   public class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// updata function return a number back;
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
             SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Get a single result 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object SingleRusult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// retrun an  array  result By DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }

        }
    }
}
