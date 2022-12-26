using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication1
{
    public partial class homepage : System.Web.UI.Page
    {
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
            else{

            }
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            setVisible(false);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            setVisible(true);
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            setVisible(true);
        }

        private void setVisible(bool flag)
        {
            btnModify.Visible = flag;
            btnFinish.Visible = !flag;
            btnCancel.Visible = !flag;
            TextBox1.ReadOnly = flag;
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