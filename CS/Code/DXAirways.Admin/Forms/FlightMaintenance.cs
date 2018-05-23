using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DXAirways.Business;
using DXAirways.Business.Orm;
using DXAirways.Windows.Controls;

namespace DXAirways.Windows.Forms
{
    public partial class FlightMaintenance : DevExpress.XtraEditors.XtraForm
    {
        public FlightMaintenance()
        {
            InitializeComponent();

            InitTree();
        }

        void InitTree()
        {
            treeFlights.ClearNodes();

            TreeListNode cityPairsNode = treeFlights.AppendNode(new object[] { null, "City-Pairs" }, null);

            XPCollection<CityPair> cityPairs = OrmFactory.GetCollection<CityPair>(uow);
            if (cityPairs != null)
            {
                foreach (CityPair cityPair in cityPairs)
                {
                    TreeListNode cityPairNode = treeFlights.AppendNode(new object[] { cityPair.Id, cityPair.DisplayCaption }, cityPairsNode, "city-pair");                   
                }
            }

            cityPairsNode.ExpandAll();

            XPCollection<FlightPair> flightPairs = OrmFactory.GetCollection<FlightPair>(uow);
            XPCollection<Flight> flights = OrmFactory.GetCollection<Flight>(uow);

            if (flightPairs != null && flights != null)
            {
                foreach (FlightPair flightPair in flightPairs)
                {
                    TreeListNode cityPairNode = treeFlights.FindNodeByKeyID(flightPair.CityPair.Id);
                    if (cityPairNode != null)
                    {
                        int flightPairCnt = cityPairNode.Nodes.Count + 1;
                        TreeListNode flightPairNode = treeFlights.AppendNode(new object[] { flightPair.Id, "FlightPair " + flightPairCnt.ToString() }, cityPairNode, "flight-pair");

                        TreeListNode flightNode1 = treeFlights.AppendNode(new object[] { flightPair.FirstLeg.Id, FlightCaption(flightPair.FirstLeg) }, flightPairNode, "flight");
                        TreeListNode flightNode2 = treeFlights.AppendNode(new object[] { flightPair.SecondLeg.Id, FlightCaption(flightPair.SecondLeg) }, flightPairNode, "flight");
                    }
                }
            }
        }
             
        string FlightCaption(Flight flight)
        {
            string caption = "Flight " + flight.FlightNumber + " departs " + 
                             flight.Origin.AirportCode + " for " + 
                             flight.Destination.AirportCode + " at " + 
                             flight.DepartureTime.ToShortTimeString();
            return caption;
        }

        private void treeFlights_MouseUp(object sender, MouseEventArgs e)
        {
            TreeList tree = sender as TreeList;
            Point point = tree.PointToClient(MousePosition);
            TreeListHitInfo info = tree.CalcHitInfo(point);
            if (info.HitInfoType == HitInfoType.Cell)
            {
                if (e.Button == MouseButtons.Left && ModifierKeys == Keys.None)
                {
                    Guid id = (Guid)(info.Node.GetValue("id"));
                    string tag = info.Node.Tag.ToString();
                    switch (tag)
                    {
                        case "flight-pair":
                            FlightLegsMaint ctlFlightLegMaint = new FlightLegsMaint(id, FlightLegsMaint.IdType.FlightPair);
                            ctlFlightLegMaint.Dock = DockStyle.Fill;
                            pnlWorkArea.Controls.Clear();
                            pnlWorkArea.Controls.Add(ctlFlightLegMaint);
                            break;
                        case "flight":

                            break;
                    }
                }
                else if(e.Button == MouseButtons.Right && ModifierKeys == Keys.None)
                {
                    tree.FocusedNode = info.Node;
                    string tag = info.Node.Tag.ToString();
                    switch (tag)
                    {
                        case "city-pair":
                            menuCityPair.ShowPopup(MousePosition);                            
                            break;
                        case "flight-pair":
                            menuFlightPair.ShowPopup(MousePosition);
                            break;
                        case "flight":

                            break;
                    }
                }
            }
        }

        private void itmAddFlightPair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TreeListNode currentNode = treeFlights.FocusedNode;
            Guid cityPairId = (Guid)(currentNode.GetValue("id"));
            FlightLegsMaint ctlFlightLegMaint = new FlightLegsMaint(cityPairId, FlightLegsMaint.IdType.CityPair);
            ctlFlightLegMaint.Dock = DockStyle.Fill;
            pnlWorkArea.Controls.Clear();
            pnlWorkArea.Controls.Add(ctlFlightLegMaint);
        }

        private void itmDeleteFlightPair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void pnlWorkArea_ControlAdded(object sender, ControlEventArgs e)
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void pnlWorkArea_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pnlWorkArea.Controls.Count == 1)
            {
                ISaveable control = pnlWorkArea.Controls[0] as ISaveable;
                if (control != null)
                {
                    bool ret = control.Save();
                    if (ret)
                        InitTree(); // future video will tap into event in user control to update only specific node
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlWorkArea.Controls.Clear();
        }
    }
}
