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
    public partial class farm : System.Web.UI.Page
    {
        private string stuID = "";
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
                stuID = Session["stuID"].ToString();
                //QuerySubject();
            }
        }
        private void QueryQuestions()
        {
            string sqlstr = "select a.QID,a.content,a.qoptions,a.score,'' as myanswer from tb_questions a,tb_paper b " +
                "where a.paperID=b.paperID ";
            if(TextBox1.Text.Trim() != "")
            {
                sqlstr = sqlstr + " and b.schoolname like '%"+TextBox1.Text+"%' ";
            }
            if(DropDownList1.Text.Trim() != "")
            {

                sqlstr = sqlstr + " and b.SID = " + DropDownList1.SelectedValue;
            }
            if(TextBox2.Text.Trim() != "")
            {
                sqlstr = sqlstr + " and b.testyear='" + TextBox2.Text + "'";
            }
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
                mda.Fill(ds,"question");
                GridView1.DataSource = ds.Tables["question"];
                GridView1.DataBind();
            }
            catch(Exception e)
            {
                string errstr = e.Message;
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
        }

        //private void QuerySubject()
        //{
        //    string sqlstr = "select sname,SID from tb_subject";
            
        //    MySqlConnection con = new MySqlConnection();
        //    con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
        //    MySqlCommand cmd = new MySqlCommand();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandText = sqlstr;
        //        MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
        //        mda.Fill(ds, "subject");
        //        DropDownList1.DataSource = ds.Tables["subject"];
        //        DropDownList1.DataTextField = "sname";
        //        DropDownList1.DataValueField = "SID";
        //        DropDownList1.DataBind();
        //    }
        //    catch (Exception e)
        //    {
        //        string errstr = e.Message;
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //        con.Dispose();
        //        cmd.Dispose();
        //    }
        //}

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            QueryQuestions();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            QueryQuestions();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            QueryQuestions();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string qid = GridView1.Rows[e.RowIndex].Cells[0].Text;
            string answer = ((System.Web.UI.WebControls.TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text;
            string sqlstr = "insert into tb_testRecord(stuID,QID,myScore,testtime,IsCorrect,myAnswer) "
                            + " values(" + stuID + "," + qid + ",0,now(),0,'"+answer+"')";
            //DialogResult dr = MessageBox.Show(sqlstr);
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.AppSettings["RemoteConnectionString"];
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                con.Open();
                cmd.CommandText = sqlstr;
                cmd.Connection = con;
                if ((answer != "") && cmd.ExecuteNonQuery() > 0)
                    {
                        Response.Write("<script>alert('答题成功！')</script>");
                    }

            }catch(Exception ex)
            {
                string errstr = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Dispose();
                cmd.Dispose();

                GridView1.EditIndex = -1;
                QueryQuestions();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            QueryQuestions();
        }
    }
}