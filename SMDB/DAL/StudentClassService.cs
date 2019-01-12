using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    /// <summary>
    /// StudentClassService Class
    /// </summary>
    public class StudentClassService
    {
        public List<StudentClass> GetAllClasses()
        {
            string sql = "select ClassId ,ClassName from StudentClass";
            SqlDataReader objReader = SQLHelper.GetDataReader(sql);
            List<StudentClass> list = new List<StudentClass>();
            while (objReader.Read())
            {
                list.Add(new StudentClass()
                {
                    ClassId = Convert.ToInt32(objReader["ClassId"]),
                    ClassName = objReader["ClassName"].ToString()
                }
                    );
            }
            return list;
        }
    }
}
