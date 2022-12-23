using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CB20130106胡嘉希
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {

            String uname = TextBox1.Text;
            String pwd = TextBox2.Text;


            string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlstr);

            String sql = "select id from w_login where uname=@name and pwd=@pwd";


            SqlCommand cmd = new SqlCommand(sql, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            SqlParameter p1 = new SqlParameter("@name", uname);
            SqlParameter p2 = new SqlParameter("@pwd", pwd);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (count > 0 && sqldr.Read())
                {
                    DialogResult dr = MessageBox.Show("登录成功!");

                    Session["UserID"] = sqldr.GetInt32(0);

                    if (dr == DialogResult.OK)
                    {
                        Server.Transfer("doExercise.aspx");
                    }
                }
                else
                {

                    MessageBox.Show("登录失败!");
                }

            }
            finally
            {
                con.Close();
            }


            con.Close();


        }
        protected void Enroll_Click(object sender, EventArgs e)
        {
            Server.Transfer("register.aspx");

        }
    }
}