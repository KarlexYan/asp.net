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
                    Server.Transfer("login.aspx");
                }
            }
            else{

            }
        }
    }
}