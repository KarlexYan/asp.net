using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        string name = "";
        string role = "";
        string stuID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            if(Session["name"] != null)
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label1.Visible = true;
                Label2.Visible = true;
                name = Session["name"].ToString();
                role = Session["role"].ToString();
                Label1.Text = "欢迎回来，" + name + role;
                Label2.Text = "请从左侧菜单栏选择你想要去的页面";
            }
            if(Session["stuID"] != null)
            {
                stuID = Session["stuID"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/register.aspx");
        }
    }
}