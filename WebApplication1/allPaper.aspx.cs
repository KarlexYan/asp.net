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
    public partial class allPaper : System.Web.UI.Page
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
                showList();
            }
        }

        public void showList()
        {
            string sqlstr = "select papername,SID,schoolname,testyear from tb_paper";
            //string sqlstr = "select content from tb_questions";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter(sqlstr, con);
                mda.Fill(ds, "PaperList");
                GridView1.DataSource = ds.Tables["PaperList"];
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

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}