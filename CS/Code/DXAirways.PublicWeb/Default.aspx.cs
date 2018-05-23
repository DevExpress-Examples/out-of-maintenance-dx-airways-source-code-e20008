using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DXAirways.Business;

namespace DXAirways.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Build home page dynamically here.  Notice that we are not
            // doing a postback check, since the Controls collection
            // (in this case, inside placeholders) do not persist in ViewState.

            string controlToLoad = "~/AccountSignIn.ascx";

            if (Page.User.IsInRole(SecurityEngine.Roles.Customer))
                controlToLoad = "~/AccountSummary.ascx";

            UserControl ctl = (UserControl)LoadControl(controlToLoad);

            phAccountSummary.Controls.Add(ctl);
        }
    }
}
