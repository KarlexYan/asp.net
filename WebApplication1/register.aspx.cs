using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication1
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string sqlstr = "insert into tb_student(userName,pwd,stuName,Sex,shoolName,birthday,Tel,email,createdate)" +
                " value('"+TextBox1.Text+"','"+TextBox2.Text+"'," +
                "'"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"'" +
                ",'"+TextBox6.Text+"','"+TextBox7.Text+"','"+TextBox8.Text+"',now())";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                con.Open();
                cmd.CommandText = sqlstr;
                cmd.Connection = con;
                if((TextBox1.Text != "") && cmd.ExecuteNonQuery() > 0)
                {
                    DialogResult dr = MessageBox.Show("注册成功！");
                    if (dr == DialogResult.OK)
                    {
                        Response.Redirect("~/index.aspx");
                    }
                }
            }
            catch(Exception ex)
            {
                string errstr = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                cmd.Dispose();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }
    }
}