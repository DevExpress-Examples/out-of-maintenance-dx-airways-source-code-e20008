using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public partial class SearchForFlight : System.Web.UI.UserControl
    {
        public event EventHandler<FlightSearchEventArgs> FlightSearch;

        protected virtual void OnFlightSearch(FlightSearchEventArgs e)
        {
            if (this.FlightSearch != null)
                this.FlightSearch(this, e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i < 9; i++)
                    cmbPassengers.Items.Add(i.ToString(), i);

                lblOrigin.Text = "<br/>";
                lblDestination.Text = "<br/>";
            }
        }

        protected void ctlAirportCallback_Callback(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
        {
            if (e.Parameter != string.Empty && e.Parameter.Length == 3)
            {
                Airport airport = new FlightEngine().GetAirportByCode(e.Parameter);
                if (airport != null)
                    e.Result = airport.Name + "<br/><i>" + airport.City + ", " + airport.State + "</i>";
                else
                    e.Result = string.Empty;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            TimeSlots slots = TimeSlots.GetFlightSearchTimeSlots();

            TimeSlot departureSlot = slots.FindByLabel(cmbDepartTime.Value.ToString());
            TimeSlot returnSlot = slots.FindByLabel(cmbReturnTime.Value.ToString());

            CabinSeating seating = (CabinSeating)(Enum.Parse(typeof(CabinSeating), (string)(optCabin.Value)));

            int passengers = Convert.ToInt16(cmbPassengers.Value);

            FlightSearchEventArgs args =
                new FlightSearchEventArgs(txtOrigin.Text, txtDestination.Text, dteDepartDate.Date, dteReturnDate.Date, departureSlot, returnSlot, seating, passengers);

            OnFlightSearch(args);

            Session["FlightSearch"] = args; // this is just the quickest technique
            // other techniques can involve querystring, cookies, or temporary storage using a guid
            Response.Redirect("~/FlightSearchResults.aspx");
        }
    }
}