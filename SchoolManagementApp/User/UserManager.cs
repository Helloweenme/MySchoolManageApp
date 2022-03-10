using SchoolManagementApp.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.User
{
    public class UserManager
    {
        //创建数据访问对象
        private UserService objUserService = new UserService();

        public user_infoModel UserLogin(user_infoModel objUser)
        {
            return objUserService.UserLogin(objUser);
        }
    }
}
