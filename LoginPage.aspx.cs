using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OLXResaleUserBLLLibrary;

namespace OLXResale
{
    public partial class LoginPage : System.Web.UI.Page
    {

        UserBLL ul = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string userid = ul.checkLogin(txtPhonenumber.Text, txtPassword.Text);
            if (userid != null)  
            {
                //e.Authenticated=true;
                Response.Redirect("HomePage.Master");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}