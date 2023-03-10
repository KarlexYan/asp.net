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
    public partial class top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["stuID"] == null)
            {
                DialogResult dr = MessageBox.Show("请先登录！");
                if (dr == DialogResult.OK)
                {
                    Response.Redirect("~/login.aspx");
                }
            }
            else
            {
                showQuetions();
            }
        }
        public void showQuetions()
        {
            string sqlstr = "select b.content,count(a.stuID) as rs from tb_testRecord a,tb_questions b "
                 + " where a.QID=b.QID and a.IsCorrect=0 group by b.content order by rs desc";
            //string sqlstr = "select content from tb_questions";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter(sqlstr, con);
                mda.Fill(ds, "ErrQuestions");
                GridView1.DataSource = ds.Tables["ErrQuestions"];
                GridView1.DataBind();
            }
            catch (Exception e)
            {
                string errmsg = e.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Dispose();
            }
        }
    }
}