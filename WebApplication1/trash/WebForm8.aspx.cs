using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Karlex
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender,EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            string sqlstr = "server=OBITO;uid=sa;Pwd=Karlex1238;Database=account;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlstr);

            string sql = "select count(1) from userInfo where username=@username and password =@password";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            SqlParameter p1 = new SqlParameter("@username", username);
            SqlParameter p2 = new SqlParameter("@password", password);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("登录成功！");
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
            catch
            {
                
            }
            
        }
    }
}