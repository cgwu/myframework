using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace MyFramework.Web.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (this.UserName.Text == "cg" && this.Password.Text == "00")
            {
                FormsAuthentication.RedirectFromLoginPage(this.UserName.Text, true);
            }
            else this.FailureText.Text = "用户名或密码错误";
        }
    }
}
