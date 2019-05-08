using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OLXResaleUserBLLLibrary;
using OLXResale;
using OLXResaleAddressBLLLibrary;

namespace OLXResale
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        UserBLL ubl = new UserBLL();
        AddressBLL abl = new AddressBLL();

        protected void btnSave_Click(object sender, EventArgs e)
        {
            OLXModel om = new OLXModel();

            om.First = txtFirstname.Text;
            om.Last = txtLastname.Text;
            om.Age = Convert.ToInt32(txtAge.Text);
            om.Gender = ddlGender.SelectedItem.Value;
            om.Cn = txtContactnumber.Text;
            om.Usid = txtUserid.Text;
            om.Pswrd = txtPassword.Text;
            om.Email = txtEmail.Text;
            om.Adrs = txtAddress.Text;
            om.City = txtCity.Text;
            om.Sublocation = txtSublocation.Text;
            om.State = Convert.ToInt32(txtState.Text);
            om.Pincode = txtPincode.Text;
            om.Country = txtCountry.Text;
            om.Street = txtStreet.Text;
            if (abl.InsertAddress(om) & ubl.InsertUser(om))
                lblMssg.Text = "Uploaded Successfully";
        }

   
    }
}