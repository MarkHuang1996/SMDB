using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;


namespace DAL
{
 public   class AdminService
    {
        /// <summary>
        /// Login by Uid and PWD
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public Admin AdminLogin(Admin objAdmin)
        {
            string sql = "select AdminName from Admins where LoginId ={0} and LoginPwd='{1}' ";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            try
            {
                SqlDataReader objReader = SQLHelper.GetDataReader(sql);

                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                }
                else
                {
                    objAdmin = null;
                }
                objReader.Close();
                return objAdmin;
            }
            catch (Exception ex)
            {

                throw new Exception("Data access exception"+ ex.Message);
            }
           

        }

        /// <summary>
        /// Change the Pwd by LoginId
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public int PsswordChange(string loginId ,string newPwd)
        {
            string sql = "Update Admins set LoginPwd ='{0}' where  LoginId ={1}";
            sql = string.Format(sql, newPwd, loginId);
            return SQLHelper.Update(sql);
        }
    }
}
