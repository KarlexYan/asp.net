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
            initList();
        }
    
        private void initList()
        {
            string sqlstr = "select a.papername,b.sname,a.schoolname,a.testyear from tb_paper a ,tb_subject b" +
                " where a.SID = b.SID ";
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sqlstr;
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                mda.Fill(ds, "list");
                GridView1.DataSource = ds.Tables["list"];
                GridView1.DataBind();
            }
            catch (Exception e)
            {
                string errstr = e.Message;
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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            initList();
        }
    }
}