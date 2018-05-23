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
    public partial class FlightSearchResultItem : System.Web.UI.UserControl
    {
        private Flight _DataSource = null;
        private string _SelectNavigateUrl;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Flight DataSource
        {
            set
            {
            	_DataSource = value;
            }
        }

        public string SelectNavigateUrl
        {
            set
            {
            	_SelectNavigateUrl = value;
            }
        }

        public override void DataBind()
        {
            if (_DataSource != null)
            {
                AircraftType equipment = new FlightEngine().GetEquipmentForFlight(_DataSource);
                
                if (equipment != null)
                {
                    lblFlightNumber.Text = _DataSource.FlightNumber;
                    lblDepartTime.Text = _DataSource.DepartureTime.ToShortTimeString();
                    lblArrivalTime.Text = "";
                    lblTravelTime.Text = _DataSource.FlightTime;
                    lblDXMiles.Text = _DataSource.Distance.ToString("#,###");
                    lblAircraft.Text = equipment.MakeAndModel;

                    string url = _SelectNavigateUrl;
                    if (_SelectNavigateUrl.IndexOf("{0}") > -1)
                        url = string.Format(_SelectNavigateUrl, _DataSource.Id.ToString());

                    lnkSelect.NavigateUrl = url;
                }
                else
                {
                    // TODO: equipment not found so need to report this as a data integrity error
                }
            }
        }
    }
}