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
            string sqlstr = "select pwd,stuID from tb_student where userName = '" + username + "'";
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];

            try
            {
                con.Open();
                cmd.CommandText = sqlstr;
                cmd.Connection = con;
                MySqlDataReader mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    if (mdr[0].ToString().Equals(pwd))
                    {
                        result = true;
                        errmsg = mdr[1].ToString();
                    }
                    else
                    {
                        errmsg = "密码错误";
                    }
                }
                else
                {
                    errmsg = "用户名错误";
                }
            }
            catch(Exception e)
            {
                errmsg = e.Message;
            }
            finally
            {
                if(con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    cmd.Dispose();
                    con.Dispose();

                }
            }
            return result;
        }
    }
}