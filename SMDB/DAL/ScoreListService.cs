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
    public class ScoreListService
    {
        /// <summary>
        /// Quary for Student Score List
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns>Score List</returns>
        public List<StudentExt> GetScoreList(string ClassName)
        {
            string sql = "select FirstName,LastName,StudentIdNo,ClassName,CSharp,SQLServerDB from Students ";
            sql += "inner join StudentClass on Students.ClassId = StudentClass.ClassId ";
            sql += "inner join ScoreList on Students.StudentId = ScoreList.StudentId ";
            if (ClassName != null && ClassName.Length != 0)
            {
                sql += "where ClassName = '{0}' ";
                sql = string.Format(sql, ClassName);
            }

            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            List<StudentExt> list = new List<StudentExt>();

            while (reader.Read())
            {
                list.Add(new StudentExt()
                {
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    StudentIdNo = Convert.ToInt32(reader["StudentIdNo"]),
                    ClassName = reader["ClassName"].ToString(),
                    CSharp = Convert.ToInt32(reader["CSharp"]),
                    SQLServerDB = Convert.ToInt32(reader["SQLServerDB"])
                });
            }
            reader.Close();
            return list;


        }

        public Dictionary<string, string> GetScoreInfo(string ClassId)
        {
            string sql = "";
            if (ClassId == null || ClassId.Length == 0)
            {
                sql += "select stuCount= count(*),avgCSharp = avg(CSharp),avgDB = avg(SQLServerDB) from ScoreList ;";
                sql += "select absentCount = count(*) from Students where StudentId not in (select StudentId from ScoreList)";
            }
            else // get by Classs
            {
                sql += "select stuCount= count(*),avgCSharp = avg(CSharp),avgDB = avg(SQLServerDB) from ScoreList ";
                sql += " inner join Students on Students.StudentId = ScoreList.StudentId where ClassId = {0};";
                sql += "select absentCount = count(*) from Students where StudentId not in (select StudentId from ScoreList) and ClassId={1} ";

            }
            sql = string.Format(sql,ClassId, ClassId);
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            Dictionary<string, string> scoreInfo = null;
            if (reader.Read())
            {
                scoreInfo = new Dictionary<string, string>();
                scoreInfo.Add("stuCount", reader["stuCount"].ToString());
                scoreInfo.Add("avgCsharp", reader["avgCSharp"].ToString());
                scoreInfo.Add("avgDB", reader["avgDB"].ToString());

            }
            if (reader.NextResult())
            {
                if (reader.Read())
                    scoreInfo.Add("absentCount", reader["absentCount"].ToString());
            }
            reader.Close();
            return scoreInfo;

        }

        public List<string> GetAbsentList(string ClassId)
        {

            string sql = "select FirstName, LastName  from Students where StudentId not in (select StudentId from ScoreList) ";
            if(ClassId !=null && ClassId.Length != 0)
            {
                sql += " and ClassId = " + ClassId;
            }
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader["FirstName"].ToString() + "  " + reader["LastName"].ToString());
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// search all Score BY dataset
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllScoreBySet()
        {
            string sql = "select Students.StudentId,FirstName,LastName,ClassName,CSharp,SQLServerDB from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId  = Students.ClassId "; 
            sql += "inner join ScoreList on ScoreList.StudentId = Students.StudentId";
            return SQLHelper.GetDataSet(sql);
        }
    }
}
