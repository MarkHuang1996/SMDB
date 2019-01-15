using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
  public   class AttendanceService
    {
        /// <summary>
        /// get the count of the student 
        /// </summary>
        /// <returns></returns>
       public int  GetAllStudent()
        {
            string sql = "Select Count(*) from Students";
            try
            {
                return Convert.ToInt32(SQLHelper.SingleRusult(sql));
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// get attendce student count
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="isToday"></param>
        /// <returns></returns>
       public int GetAttendStudents(DateTime dt,bool isToday)
        {
            DateTime dt1;
            if (isToday)
            {
                dt1 = Convert.ToDateTime(SQLHelper.GetServerTime());
            }
            else dt1 = dt;

            DateTime dt2 = dt1.AddDays(1.0); //search 1-1    1-1  ~ 1-2 

            string sql = "select  count(distinct StudentIdNo) from Attendance where DTime between '{0}' and '{1}' ";
            sql = string.Format(sql, dt1, dt2);
            try
            {
                return Convert.ToInt32(SQLHelper.SingleRusult(sql));
            }
            catch (Exception)
            {

                throw new Exception("Can't get Count of Students");
            }

        }


        /// <summary>
        /// Add attendance record
        /// </summary>
        /// <param name="StudentIdNo"></param>
        /// <returns></returns>
        public  string  AddRecord(string StudentIdNo)
        {
            string sql = "insert into Attendance(StudentIdNo) VALUES('{0}')";
            sql = string.Format(sql, StudentIdNo);
            try
            {
                SQLHelper.Update(sql);
                return "success" ;
            }
            catch (Exception ex)
            {

                return "打卡失败 :" + ex.Message;
            }
        }



       public List<StudentExt>  GetStudentsByDate(DateTime beginTime , DateTime endDate ,String FirstName)
        {
            string sql = "select Students.StudentIdNo,FirstName,LastName,Gender,DTime,ClassName from Students ";
            sql += "inner join StudentClass on Students.ClassId = StudentClass.ClassId ";
            sql += " inner join Attendance on Students.StudentIdNo = Attendance.StudentIdNo ";
            sql += "where DTime between '{0}' and '{1} '";
            sql = string.Format(sql, beginTime, endDate);
            if (FirstName != null && FirstName.Length != 0) 
            {
                sql += string.Format("and FirstName = '{0}' ",FirstName);
            }
            sql += "Order by DTime ASC";

            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            List<StudentExt> list = new List<StudentExt>();
            while (reader.Read())
            {
                list.Add(new StudentExt()
                {

                    StudentIdNo = Convert.ToInt32(reader["StudentIdNo"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    ClassName =reader["ClassName"].ToString(),
                   DTime =  Convert.ToDateTime(reader["DTime"])
                   
                });
            }
            reader.Close();
            return list;

        }
    }
}
