using System;
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
using DXAirways.Business;
using DXAirways.Business.Orm;
using System.Collections;
using DXAirways.Windows.Controls;

namespace DXAirways.Windows.Forms
{
    public partial class AirportMaint : DevExpress.XtraEditors.XtraForm
    {
        public AirportMaint()
        {
            InitializeComponent();

            grdAirports.MainView = gridView1;
            grdAirports.UseEmbeddedNavigator = false;

            bsStates.DataSource = States.Load();
        }

        private void stdButtons1_StdButtonClicked(object sender, StdButtonClickedEventArgs e)
        {
            if (e.ButtonType != StdButtons.ButtonType.Cancel)
                MessageBox.Show("Airport records saved.");
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
                switch (e.FieldName)
                {
                    case "AirportCode":

                        string newAirportCode = e.Value.ToString().ToUpper();

                        if (newAirportCode == string.Empty)
                        {
                            e.Valid = false;
                            e.ErrorText = "Airport code is a required field.";
                        }
                        else if (newAirportCode.Length != 3)
                        {
                            e.Valid = false;
                            e.ErrorText = "Airport code must be 3 characters.";
                        }
                        else
                        {
                            Guid currentId = (Guid)(view.GetRowCellValue(view.FocusedRowHandle, "Id"));

                            // check database for existing airport code and that it is not the current record
                            Airport airport = new FlightEngine().GetAirportByCode(newAirportCode);

                            if (airport != null && airport.Id != currentId)
                            {
                                e.Valid = false;
                                e.ErrorText = "Airport code '" + e.Value.ToString().ToUpper() + "' already exists";
                            }
                            else
                                e.Value = newAirportCode;
                        }

                        break;

                    case "Name":

                        if (e.Value.ToString() == string.Empty)
                        {
                            e.Valid = false;
                            e.ErrorText = "Airport name is a required field.";
                        }

                        break;

                    case "City":

                        if (e.Value.ToString() == string.Empty)
                        {
                            e.Valid = false;
                            e.ErrorText = "City is a required field.";
                        }

                        break;
                }
            }
        }
    }
}