using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Xpo;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public partial class FlightSearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["FlightSearch"] != null)
                {
                    // This session var is set form the SearchForFlight.ascx only
                    // so navigating to this page without a search should fail.


                    if (this.DepartureFlight != string.Empty)
                    {
                        // Since we've already selected the departure flight, show it now
                        Flight departureFlight = OrmFactory.GetEntity<Flight>(new Guid(this.DepartureFlight));

                        phSelectedFlight.Controls.Add(new LiteralControl("You selected departure flight " + departureFlight.FlightNumber));
                        pnlSelectedFlight.Visible = true; 
                    }
                }
                else
                    Response.Redirect("~/Default.aspx");
            }
        }

        protected void ctlResultsPanel_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            System.Threading.Thread.Sleep(3000);

            // Perform flight search here using _SearchArgs

            FlightSearchEventArgs searchArgs = (FlightSearchEventArgs)Session["FlightSearch"];

            XPCollection<Flight> allFlights = null;
            List<Flight> availableFlights = null;
            TimeSlot timeSlot = null;

            if (this.DepartureFlight == string.Empty)
            {
                // obtain all flghts that service the departure leg
                allFlights = new FlightEngine().GetAllFlightsBetweenAirports(searchArgs.OriginAirport, searchArgs.DestinationAirport);
                availableFlights = new List<Flight>();
                timeSlot = searchArgs.DepartureTime;
            }
            else
            {
                // obtain all flights that service the return leg
                allFlights = new FlightEngine().GetAllFlightsBetweenAirports(searchArgs.DestinationAirport, searchArgs.OriginAirport);
                availableFlights = new List<Flight>();
                timeSlot = searchArgs.ReturnTime;
            }

            // obtain the flights that meet the time requirements
            foreach (Flight flight in allFlights)
            {
                if (flight.DepartureTime.TimeOfDay >= timeSlot.BeginRange.TimeOfDay && flight.DepartureTime.TimeOfDay <= timeSlot.EndRange.TimeOfDay)
                    availableFlights.Add(flight);
            }

            // TODO: find aircraft that are available for these flights on the required dates

            foreach (Flight flight in availableFlights)
            {
                FlightSearchResultItem ucFlight = (FlightSearchResultItem)(LoadControl("~/FlightSearchResultItem.ascx"));
                if (ucFlight != null)
                {
                    // If the departure_flight querystring variable is empty, then we're in this page displaying the available departure flights,
                    // otherwise we're in this page showing the selected departure flight and the available return flights
                    if (this.DepartureFlight == string.Empty)
                        ucFlight.SelectNavigateUrl = "FlightSearchResults.aspx?departure_flight={0}";
                    else
                        ucFlight.SelectNavigateUrl = "SelectedFlights.aspx?departure_flight=" + this.DepartureFlight + "&return_flight={0}";
                    
                    ucFlight.DataSource = flight;
                    ucFlight.DataBind();
                    
                    pnlResults.Controls.Add(ucFlight);
                    pnlResults.Controls.Add(new LiteralControl("<br/>"));
                }
            }

            ctlResultsPanel.Height = Unit.Pixel(availableFlights.Count * 80);
            pnlResults.Height = Unit.Percentage(100);
            pnlResults.Visible = true;

            //Session.Remove("FlightSearch");
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
