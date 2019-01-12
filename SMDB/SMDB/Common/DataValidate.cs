
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace SMDB

{
    /// <summary>
    /// 通用验证类
    /// </summary>
   public class DataValidate
    {
        /// <summary>
        /// Isinteger
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsInteger(string txt)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// IsEmail
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsEmail(string txt)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsIdentityStudentID(string txt)
        {
            Regex objReg = new Regex(@"^\d{10}$");
            return objReg.IsMatch(txt);
        }
    }
}
