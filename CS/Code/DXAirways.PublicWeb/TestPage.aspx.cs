using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXAirways.Web
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SearchForFlight1.FlightSearch += SearchForFlight1_FlightSearch;
        }

        void SearchForFlight1_FlightSearch(object sender, FlightSearchEventArgs e)
        {
            //lblResults.Text = "searching for flights...";
            
            //Response.Redirect("~/FlightSearchResults.aspx");
        }
    }



}
