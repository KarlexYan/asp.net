using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CB20130106胡嘉希
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {

            Server.Transfer("login.aspx");
        }
        protected void Enroll_Click(object sender, EventArgs e)
        {

            Server.Transfer("register.aspx");
        }
    }
}