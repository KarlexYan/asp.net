using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Trim().Length == 0)
            {
                Response.Write("<script>alert('用户名不能为空！')</script>");
                return;
            }
            else if (TextBox2.Text.Trim() == string.Empty)
            {
                Response.Write("<script>alert('密码不能为空！')</script>");
                return;
            }
            else
            {
                string msg = "";
                UserManage umObj = new UserManage();
                if(umObj.LoginSys(TextBox1.Text.Trim(), TextBox2.Text.Trim(), out msg)){
                    Session["name"] = TextBox1.Text;
                    Session["pwd"] = TextBox2.Text;
                    Session["stuID"] = msg;
                    Session["role"] = "学生";
                    Response.Redirect("~/index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('" + msg+"')</script>");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }
    }
}