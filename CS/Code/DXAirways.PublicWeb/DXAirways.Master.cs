using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXAirways.Web
{
    public partial class DXAirways : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Page.User.Identity.IsAuthenticated)
                {
                    
                }
            }
        }

    }
}
