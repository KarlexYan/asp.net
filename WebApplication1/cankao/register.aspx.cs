using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Drawing;

namespace CB20130106胡嘉希
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Enroll_Click(object sender, EventArgs e)
        {

            String uname = TextBox1.Text;
            String pwd = TextBox2.Text;
            String nickname = TextBox3.Text;




            if (uname != "" && pwd != "" && nickname != "")
            {
                string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
                SqlConnection con = new SqlConnection(sqlstr);

                string importSql = "insert into w_login(uname,pwd,nickname,sex,age) values( @name , @pwd , '"+ nickname + "','男','18')";

                String referSql = "select id from w_login where uname='" + uname + "'";

                SqlCommand comm = new SqlCommand(importSql, con);
                SqlCommand comm02 = new SqlCommand(referSql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }


                SqlParameter p1 = new SqlParameter("@name", uname);
                SqlParameter p2 = new SqlParameter("@pwd", pwd);

                comm.Parameters.Add(p1);
                comm.Parameters.Add(p2);



                int count = Convert.ToInt32(comm02.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("账号已注册!");

                }
                else if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                {

                    DialogResult dr = MessageBox.Show("注册成功!");
                    if (dr == DialogResult.OK)
                    {

                        con.Close();
                        found_mistakes(uname);
                    }
                }
                else
                {
                    MessageBox.Show("注册失败!");
                }


                con.Close();
            }
            else
            {
                MessageBox.Show("内容不能为空！");
            }

        }

        private void found_mistakes(string uname)
        {

            string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlstr);
            String sql = "select id from w_login where uname='"+ uname + "'";

            SqlCommand cmd = new SqlCommand(sql, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (count > 0 && sqldr.Read())
                {

                    int Uid = sqldr.GetInt32(0);
                    sqldr.Close();

                    string importSql = "insert into mistakes values( '"+ Uid + "' , '"+ Uid + "' , 0)";

                    SqlCommand comm = new SqlCommand(importSql, con);

                    if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                    {
                        DialogResult dr = MessageBox.Show("登录成功!");

                        Session["UserID"] = Uid;

                        con.Close();
                        if (dr == DialogResult.OK)
                        {
                            Server.Transfer("doExercise.aspx");
                        }
                    }
                    else { MessageBox.Show("错题本建立失败!"); }
                }
                else
                {

                    con.Close();
                    MessageBox.Show("登录失败!");
                    Server.Transfer("login.aspx");
                }

            }
            finally
            {
                con.Close();
            }


            con.Close();
        }
    }
}