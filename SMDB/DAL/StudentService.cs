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
    public class StudentService
    {

        public bool IsStudentIDExitsed(string studentId)
        {
            string sql = "select count(*) from Students where  StudentIdNo = {0} ";
            sql = string.Format(sql, Convert.ToInt32(studentId));
            int result = Convert.ToInt32(SQLHelper.SingleRusult(sql));
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

        /// <summary>
        /// Get StudentList by ClassID
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public List<StudentExt> GetStudentByClassId(string classId)
        {
            string sql = "select StudentId,StudentIdNo,FirstName,LastName,Gender,Birthday,ClassName from Students ";
            sql += " inner join StudentClass on Students.ClassId = StudentClass.ClassId";
            sql += " where Students.ClassId  =  " + classId;
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            List<StudentExt> list = new List<StudentExt>();
            while (reader.Read())
            {
                list.Add(new StudentExt()
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    StudentIdNo = Convert.ToInt32(reader["StudentIdNo"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    ClassName = reader["ClassName"].ToString()
                });
            }
            reader.Close();
            return list;
        }

        public StudentExt GetStudentByStudentNo(string StudentNo)
        {
            string sql = "  select StudentId, StudentIdNo, FirstName, LastName, Gender, Birthday,Age,PhoneNumber,StudentAddress,StuImage,ClassName from Students ";
            sql += " inner join StudentClass on Students.ClassId = StudentClass.ClassId";
            sql += " where StudentIdNo = " + StudentNo;
            StudentExt objStudentExt = null;
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            if (reader.Read())
            {
                objStudentExt = new StudentExt()
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    StudentIdNo = Convert.ToInt32(reader["StudentIdNo"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    Age = Convert.ToInt32(reader["Age"]),
                    ClassName = reader["ClassName"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    Address = reader["StudentAddress"].ToString(),
                    StuImage = reader["StuImage"] is DBNull ? "" : reader["StuImage"].ToString()

                };
               
            }
            reader.Close();
            return objStudentExt;

        }

        public int EditStudentInfo(Student objStudent)
        {
            string sql = "Update Students set FirstName ='{0}',LastName='{1}',Gender='{2}',Birthday='{3}',PhoneNumber= '{4}',StudentAddress ='{5}',ClassId = {6}";
            sql += "where StudentIdNo = {7}";
            sql = string.Format(sql, objStudent.FirstName, objStudent.LastName, objStudent.Gender, objStudent.Birthday, objStudent.PhoneNumber,
                objStudent.Address, objStudent.ClassId, objStudent.StudentIdNo);
            try
            {
                return Convert.ToInt32(SQLHelper.Update(sql));
            }
            catch (Exception ex)
            {

                throw new Exception("Update Funcation Error !! detail :" +ex.Message);
            }
        }
    }
}
