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
    public partial class SelectedFlights : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.DepartureFlight != string.Empty && this.ReturnFlight != string.Empty)
                {
                    Flight departureFlight = OrmFactory.GetEntity<Flight>(new Guid(this.DepartureFlight));
                    Flight returnFlight = OrmFactory.GetEntity<Flight>(new Guid(this.ReturnFlight));

                    if (departureFlight != null && returnFlight != null)
                    {
                        lblDepartureFlight.Text = "Departure Flight: " + departureFlight.FlightNumber;
                        lblReturnFlight.Text = "Return Flight: " + returnFlight.FlightNumber;
                    }
                }
            }
        }

        private string DepartureFlight
        {
            get
            {
                string value = Request.QueryString["departure_flight"];
                if (string.IsNullOrEmpty(value))
                    return string.Empty;
                else
                    return value;
            }
        }

        private string ReturnFlight
        {
            get
            {
                string value = Request.QueryString["return_flight"];
                if (string.IsNullOrEmpty(value))
                    return string.Empty;
                else
                    return value;
            }
        }
    }
}
