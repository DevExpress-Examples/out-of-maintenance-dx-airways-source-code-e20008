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
    public partial class PersonName : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Page.User.Identity.Name != string.Empty)
                {
                    Person person = new SecurityEngine().FetchPerson(Page.User.Identity.Name);
                    if (person != null)
                        lblPersonName.Text = person.FullName;
                    else
                        lblPersonName.Text = "{Error: Personnel record not found}";
                }
            }
        }
    }
}