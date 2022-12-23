using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CB20130106胡嘉希
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        String nickname ;
        String sex ;
        String age ;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"]== null)
            {
                DialogResult dr = MessageBox.Show("未登录!");

                if (dr == DialogResult.OK)
                {
                    Server.Transfer("login.aspx");
                }
            }
            else
            {

                string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
                SqlConnection con = new SqlConnection(sqlstr);

                int UserID = (int)Session["UserID"];


                String inquireSql = "select * from w_login Where id='" + UserID + "'";

                SqlCommand cmd = new SqlCommand(inquireSql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

                SqlDataReader sqldr = cmd.ExecuteReader();
                sqldr.Read();

                nickname = sqldr.GetString(3);
                sex = sqldr.GetString(4);
                age = sqldr.GetString(5);


                sqldr.Close();
                con.Close();
            }
        }
        protected void Submit_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text!="")
            {
                nickname = TextBox1.Text;
            }

            if (RadioButton1.Checked)
            {
                sex = "男";
            }
            else if (RadioButton2.Checked)
            {
                sex = "女";
            }

            if (TextBox2.Text != "")
            {
                age = TextBox2.Text;
            }

            string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlstr);

            int UserID = (int)Session["UserID"];


            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            String alterSql = "UPDATE w_login SET nickname = '" + nickname + "',sex = '" + sex + "',age = '" + age + "' WHERE id='" + UserID + "'";

            SqlCommand alterCmd = new SqlCommand(alterSql, con);


            if (Convert.ToInt32(alterCmd.ExecuteNonQuery()) > 0)
            {

                DialogResult dr = MessageBox.Show("修改成功!");

                if (dr == DialogResult.OK)
                {
                    Server.Transfer("index.aspx");
                }
            }

            con.Close();

        }
    }
}