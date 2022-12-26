using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class homepage : System.Web.UI.Page
    {
        private string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["stuID"] == null)
            {
                DialogResult dr = MessageBox.Show("请先登录！");
                if(dr == DialogResult.OK)
                {
                    Response.Redirect("~/login.aspx");
                }
            }
            if (!IsPostBack)
            {
                username = Session["name"].ToString();
                getUserData();
            }
        }
        private void getUserData()
        {
            string sqlstr = "select userName,pwd,stuName,Sex,shoolName,birthday,Tel,email " +
                " from tb_student " +
                " where userName = '"+username+"'";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sqlstr;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Label1.Text = username;
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();
                    TextBox5.Text = dr[4].ToString();
                    TextBox6.Text = dr[5].ToString();
                    TextBox7.Text = dr[6].ToString();
                    TextBox8.Text = dr[7].ToString();
                }
                dr.Close();
                dr.Dispose();


            }catch(Exception ex)
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

        protected void btnModify_Click(object sender, EventArgs e)
        {
            setVisible(false);
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            setVisible(true);
            getUserData();
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            string sqlstr = "update tb_student set pwd ='"+TextBox2.Text.Trim()+"' ,stuName ='"+TextBox3.Text.Trim() + "' ," +
                " Sex ='"+TextBox4.Text.Trim() + "' ,shoolName = '"+TextBox5.Text.Trim() + "',birthday ='"+TextBox6.Text.Trim() + "' ," +
                " Tel = '"+TextBox7.Text.Trim() + "',email = '"+TextBox8.Text.Trim() + "' where userName = '"+username+"'";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            MySqlCommand cmd = new MySqlCommand();
            DialogResult dr = MessageBox.Show(sqlstr);
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sqlstr;
                if(cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>alert('修改完成！')</script>");
                }
            }
            catch(Exception ex)
            {
                string errstr = ex.Message;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                cmd.Dispose();
            }
            setVisible(true);
        }

        private void setVisible(bool flag)
        {
            btnModify.Visible = flag;
            btnFinish.Visible = !flag;
            btnCancel.Visible = !flag;
            TextBox2.ReadOnly = flag;
            TextBox3.ReadOnly = flag;
            TextBox4.ReadOnly = flag;
            TextBox5.ReadOnly = flag;
            TextBox6.ReadOnly = flag;
            TextBox7.ReadOnly = flag;
            TextBox8.ReadOnly = flag;

        }
    }
}