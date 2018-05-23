using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXAirways.Windows.Forms
{
    public partial class DXAirwaysMain : DevExpress.XtraEditors.XtraForm
    {
        public DXAirwaysMain()
        {
            InitializeComponent();
        }

        private void navMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            switch (e.Link.Item.Tag.ToString().ToLower())
            {
                case "airports" :

                    AirportMaint frmAirportMaint = new AirportMaint();
                    frmAirportMaint.Show();

                    break;

                case "city-pairs" :

                    CityPairMaint frmCityPairMaint = new CityPairMaint();
                    frmCityPairMaint.Show();

                    break;

                case "flights" :

                    FlightMaintenance frmFlightMaintenance = new FlightMaintenance();
                    frmFlightMaintenance.Show();

                    break;

                case "aircraft-types" :

                    AircraftTypeMaint frmAircraftTypeMaint = new AircraftTypeMaint();
                    frmAircraftTypeMaint.Show();
                    break;

                case "aircraft" :

                    AircraftList frmAircraft = new AircraftList();
                    frmAircraft.Show();
                    break;
                    
                case "customers" :

                    MessageBox.Show("This feature has not been implemented.");
                    break;

                case "crew" :

                    MessageBox.Show("This feature has not been implemented.");
                    break;

                case "help" :

                    MessageBox.Show("This feature has not been implemented.");
                    break;

                case "exit" :
                    Application.Exit();
                    break;
            }
        }

        private void DXAirwaysMain_Load(object sender, EventArgs e)
        {

        }
    }
}