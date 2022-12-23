using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CB20130106胡嘉希
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string answer = null;
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
                Next_Problem();
            }

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            RadioButton1.Checked = false;
            if (RadioButton1.Checked && answer == "A")
            {
                MessageBox.Show("回答正确!");
                Next_Problem();
            }
            else if (RadioButton2.Checked && answer == "B")
            {
                MessageBox.Show("回答正确!");
            }
            else if (RadioButton3.Checked && answer == "C")
            {
                MessageBox.Show("回答正确!");
            }
            else if (RadioButton4.Checked && answer == "D")
            {
                MessageBox.Show("回答正确!");
            }
            else
            {
                MessageBox.Show("回答错误!");


                string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
                SqlConnection con = new SqlConnection(sqlstr);

                int UserID = (int)Session["UserID"];


                String inquireSql = "select mistakes_num from mistakes Where uid='" + UserID+"'";

                SqlCommand cmd = new SqlCommand(inquireSql, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

                SqlDataReader sqldr = cmd.ExecuteReader();
                sqldr.Read();

                int mistakes = sqldr.GetInt32(0);
                mistakes++;

                sqldr.Close();

                String alterSql = "UPDATE mistakes SET mistakes_num = '"+mistakes+"' WHERE uid='"+ UserID + "'";
                SqlCommand alterCmd = new SqlCommand(alterSql, con);

                if (Convert.ToInt32(alterCmd.ExecuteNonQuery()) > 0)
                {
                    Next_Problem();
                }

                sqldr.Close();
                con.Close();

            }
        }


        protected void Next_Click(object sender, EventArgs e)
        {
            Next_Problem();
        }

        private void Next_Problem()
        {
            string sqlstr = "server=HalleyAllen;DataBase=work;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlstr);

            String sql = "select top(1) * from question_bank order by newid()";

            SqlCommand cmd = new SqlCommand(sql, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            SqlDataReader sqldr = cmd.ExecuteReader();
            sqldr.Read();
            Label1.Text = sqldr.GetString(1);

            Label2.Text = sqldr.GetString(2);
            Label3.Text = sqldr.GetString(3);
            Label4.Text = sqldr.GetString(4);
            Label5.Text = sqldr.GetString(5);

            answer = sqldr.GetString(6);

            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked=false;

            sqldr.Close();

        }
    }
}