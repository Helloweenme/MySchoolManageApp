using SchoolManagementApp.User.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.User
{
    public class UserService
    {
        /// <summary>
        /// 根据账号和密码比对用户信息
        /// </summary>
        /// <param name="objUser">包含用户名和密码的用户对象</param>
        /// <returns>返回用户对象信息（若无用户信息则对象为null）</returns>
        public user_infoModel UserLogin(user_infoModel objUser)
        {
            String sql = "SELECT * FROM user_info where userno=@userno and password=@password";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@userno",objUser.userno),
                new SqlParameter("@password", objUser.password)
            };
            SqlDataReader objReader = SqlHelper.getReader(sql, param);
            if (objReader.Read())
            {
                objUser.userid = (Guid)objReader["userid"];
                objUser.role = objReader["role"].ToString();
            }
            else
            {
                objUser = null;
            }
            objReader.Close();
            return objUser;
        }
    }
}
