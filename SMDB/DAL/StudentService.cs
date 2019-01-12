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
  public  class StudentService
    {

        public bool IsStudentIDExitsed(string studentId)
        {
            string sql = "select count(*) from Students where  StudentIdNo = {0} ";
            sql = string.Format(sql, Convert.ToInt32(studentId));
           int  result = Convert.ToInt32( SQLHelper.SingleRusult(sql));
            if (result == 1) return true;
            else return false;
        }
       
        /// <summary>
        /// Add a new Student Method
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns>reuslt</returns>
        public int AddStudent(Student objStudent)
        {
            string sql = "insert into Students (FirstName,LastName,Gender,Birthday,Age,StudentIdNo,PhoneNumber,StudentAddress,StuImage,ClassId) ";
            sql += " values('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}',{9}) ";
            sql = string.Format(sql, objStudent.FirstName, objStudent.LastName, objStudent.Gender, objStudent.Birthday, objStudent.Age, objStudent.StudentIdNo, objStudent.PhoneNumber, objStudent.Address, objStudent.StuImage, objStudent.ClassId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("Have some issuse  when save the Student Infomation " + ex.Message);
            }
        }
    }
}
