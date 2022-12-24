using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class UserManage
    {
        internal bool LoginSys(string username,string pwd,out string errmsg)
        {
            bool result = false;
            errmsg = "登录失败";
            string sqlstr = "select pwd,stuID from tb_student where userName = '" + username + "'";
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            return result;
        }
    }
}