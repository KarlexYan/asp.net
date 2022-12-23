using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CB20130106胡嘉希
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] == null)
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
                
                Label1.Text = sqldr.GetString(3);
                Label2.Text = sqldr.GetString(1);
                Label3.Text = sqldr.GetString(4);
                Label4.Text = sqldr.GetString(5);


                sqldr.Close();
                con.Close();
            }
        }
        protected void Amend_Click(object sender, EventArgs e)
        {
            Server.Transfer("alterUser.aspx");
        }
        
    }
}