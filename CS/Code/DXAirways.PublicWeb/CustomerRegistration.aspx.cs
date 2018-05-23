using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void lnkSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = PersonnelManager.RegisterNewCustomer(
            txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text);

            // Log in and redirect back to home page which will now display customer information

            if (customer != null)
            {
                FormsAuthentication.SetAuthCookie(txtEmail.Text, false);
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}
