using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DXAirways.Business.Orm;

namespace DXAirways.Windows.Forms
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        public TestForm()
        {
            InitializeComponent();

            XPCollection<Airport> airports = OrmFactory.GetCollection<Airport>();
            bindingSource1.DataSource = airports;

            //RepositoryItemLookUpEdit airportLookup = new RepositoryItemLookUpEdit();

            //
            //airportLookup.Properties.DisplayMember = "DisplayCaption";
            //airportLookup.Properties.ValueMember = "Id";

            //// build the LookupEdit control programmatically

            //airportLookup.Properties.Columns.Add(new LookUpColumnInfo("AirportCode", "Airport", 0));
            //airportLookup.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 0));

            //airportLookup.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //airportLookup.Properties.SearchMode = SearchMode.AutoComplete;
            //airportLookup.Properties.AutoSearchColumnIndex = 1;

            //airportLookup.Properties.DataSource = bindingSource1;

            //gridControl1.RepositoryItems.Add(airportLookup);
            //colFirstCity.ColumnEdit = airportLookup;


            lookUpEdit1.Properties.DisplayMember = "DisplayCaption";
            lookUpEdit1.Properties.ValueMember = "Id";

            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("AirportCode", "Airport", 0));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 0));

            lookUpEdit1.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lookUpEdit1.Properties.SearchMode = SearchMode.AutoComplete;
            lookUpEdit1.Properties.AutoSearchColumnIndex = 1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            layoutView1.ShowCustomizationForm();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            unitOfWork1.CommitChanges();
        }
    }
}
