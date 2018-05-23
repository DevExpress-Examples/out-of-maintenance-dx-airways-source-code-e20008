using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DXAirways.Business;
using DXAirways.Business.Orm;
using DXAirways.Windows.Controls;

namespace DXAirways.Windows.Forms
{
    public partial class CityPairMaint : DevExpress.XtraEditors.XtraForm
    {
        public CityPairMaint()
        {
            InitializeComponent();

            grdCityPairs.MainView = gridView1;
            grdCityPairs.UseEmbeddedNavigator = false;

            bsAirports.DataSource = OrmFactory.GetCollection<Airport>();
            bsEquipment.DataSource = OrmFactory.GetCollection<AircraftType>();

            RepositoryItemLookUpEdit lookupEditFirstCity = (RepositoryItemLookUpEdit)(colFirstCity.ColumnEdit);
            RepositoryItemLookUpEdit lookupEditSecondCity = (RepositoryItemLookUpEdit)(colSecondCity.ColumnEdit);
            RepositoryItemLookUpEdit lookupEditEquipment = (RepositoryItemLookUpEdit)(colEquipment.ColumnEdit);

            lookupEditFirstCity.ButtonClick += lookupEditCity_ButtonClick;
            lookupEditSecondCity.ButtonClick += lookupEditCity_ButtonClick;
            lookupEditSecondCity.ButtonClick += lookupEditEquipment_ButtonClick;
        }
        
        void lookupEditCity_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag != null && e.Button.Tag.ToString() == "airports")
            {
                AirportMaint frmAirportMaint = new AirportMaint();
                frmAirportMaint.ShowDialog();
                bsAirports.DataSource = OrmFactory.GetCollection<Airport>();
            }
        }

        void lookupEditEquipment_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag != null && e.Button.Tag.ToString() == "equipment")
            {
                AircraftTypeMaint frmAircraftTypeMaint = new AircraftTypeMaint();
                frmAircraftTypeMaint.ShowDialog();
                bsEquipment.DataSource = OrmFactory.GetCollection<AircraftType>();
            }
        }

        private void stdButtons1_StdButtonClicked(object sender, StdButtonClickedEventArgs e)
        {
            if (e.ButtonType != StdButtons.ButtonType.Cancel)
                MessageBox.Show("City-Pair records saved.");
        }

        private void ValidateField(ColumnView view, EditorInfo e)
        {
            if (e.Value == null)
            {
                e.Valid = false;
                e.ErrorText = "Value cannot be null.";
            }
            else
            {
                Guid currentId = (Guid)(view.GetRowCellValue(view.FocusedRowHandle, "Id"));

                if (e.FieldName == "FirstCity!Key" || e.FieldName == "SecondCity!Key")
                {
                    Guid city1 = (Guid)(e.Value);
                    object city2Key;
                    if (e.FieldName == "colFirstCity")
                        city2Key = view.GetRowCellValue(view.FocusedRowHandle, "SecondCity!Key");
                    else
                        city2Key = view.GetRowCellValue(view.FocusedRowHandle, "FirstCity!Key");

                    if (city2Key != null)
                    {
                        Guid city2 = (Guid)city2Key;

                        CityPair cityPair = new FlightEngine().GetCityPair(city1, city2);

                        if (cityPair != null && cityPair.Id != currentId)
                        {
                            e.Valid = false;
                            e.ErrorText = "This city-pair combination already exists";
                        }
                    }
                }
            }
        }

        private void btnMaintainFlightPairs_Click(object sender, EventArgs e)
        {
            using (FlightMaintenance frmFlightMaintenance = new FlightMaintenance())
                frmFlightMaintenance.ShowDialog();
        }
    }
}
