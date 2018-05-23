using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Web.ASPxEditors;
using DXAirways;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public partial class AirportLookup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ctlResultsPanel_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            string lookup = e.Parameter;
            XPCollection<Airport> airports = new FlightEngine().GetAirportsByCityOrState(lookup);
            if (airports != null && airports.Count > 0)
            {
                foreach (Airport airport in airports)
                {
                    ASPxHyperLink lnkAirport = new ASPxHyperLink();
                    lnkAirport.Text = airport.AirportCode;
                    lnkAirport.EnableClientSideAPI = true;
                    lnkAirport.ClientSideEvents.Click = "function(s, e) { ReturnValue('" + airport.AirportCode + "'); }";
                    lnkAirport.NavigateUrl = "#";
                    ASPxLabel lblAirportName = new ASPxLabel();
                    lblAirportName.Text = airport.Name;
                    ASPxLabel lblLocation = new ASPxLabel();
                    lblLocation.EncodeHtml = false;
                    lblLocation.Text = "&nbsp;&nbsp;(" + airport.City + ", " + airport.State + ")";

                    phAirportList.Controls.Add(lnkAirport);
                    phAirportList.Controls.Add(new LiteralControl("&nbsp;-&nbsp;"));
                    phAirportList.Controls.Add(lblAirportName);
                    phAirportList.Controls.Add(new LiteralControl("<br/>"));
                    phAirportList.Controls.Add(lblLocation);
                    phAirportList.Controls.Add(new LiteralControl("<br/><br/>"));
                }
            }
            else
            {
                ASPxLabel lblNoRecords = new ASPxLabel();
                lblNoRecords.Text = "No airports found.";
                phAirportList.Controls.Add(lblNoRecords);
            }

            pnlLookupResults.Visible = true;
        }

    }
}
