using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public partial class AccountSummary : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Page.User.IsInRole(SecurityEngine.Roles.Customer))
                {
                    Customer customer = new CustomerEngine().GetCustomerByEmail(Page.User.Identity.Name);
                    
                    if (customer == null)
                        throw new ApplicationException(Properties.Resources.CustomerNotFound);

                    lblMilesNumber.Text = customer.DxMilesNumber;
                    lblMilesBalance.Text = customer.FlyerMiles.ToString("#,###");
                }
            }
        }

    }
}