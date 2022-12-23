using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CB20130106胡嘉希
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlstr);


            string inquireSql = "SELECT top(5) nickname AS '昵称' , mistakes_num AS '错题数' FROM mistakes, w_login WHERE mistakes.uid = w_login.id ORDER BY mistakes_num DESC ";

            SqlCommand comm = new SqlCommand(inquireSql, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            SqlDataReader sqldr = comm.ExecuteReader();
            GridView1.DataSource = sqldr;
            GridView1.DataBind();
            sqldr.Close();


            con.Close();
        }
    }
}