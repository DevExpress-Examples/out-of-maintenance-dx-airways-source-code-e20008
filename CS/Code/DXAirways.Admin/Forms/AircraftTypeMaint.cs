using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Windows.Forms
{
    public partial class AircraftTypeMaint : DevExpress.XtraEditors.XtraForm
    {
        public AircraftTypeMaint()
        {
            InitializeComponent();

            grdAircraftTypes.MainView = viewAircraftTypes;
            grdAircraftTypes.UseEmbeddedNavigator = false;
        }

        int _CurrentRowHandle = -1;

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
                    case "Make":

                        if (e.Value.ToString() == string.Empty)
                        {
                            e.Valid = false;
                            e.ErrorText = "Aircraft Make is a required field.";
                        }

                        break;

                    case "Model":

                        if (e.Value.ToString() == string.Empty)
                        {
                            e.Valid = false;
                            e.ErrorText = "Aircraft Model is a required field.";
                        }

                        break;
                }
            }
        }

        private void viewAircraft_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            int rowHandle = view.FocusedRowHandle;
            Guid aircraftId = (Guid)(view.GetRowCellValue(rowHandle, "Id"));

            using (AircraftMaint frmAircraft = new AircraftMaint(aircraftId, AircraftMaint.IdType.Aircraft))
                frmAircraft.ShowDialog();
        }

        private void viewAircraftTypes_RowClick(object sender, RowClickEventArgs e)
        {
            _CurrentRowHandle = e.RowHandle;
            btnAddAircraft.Visible = true;
        }

        private void unitOfWork1_ObjectsLoaded(object sender, ObjectsManipulationEventArgs e)
        {
            btnAddAircraft.Visible = (e.Objects.Count > 0);
            _CurrentRowHandle = 0;
        }

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            Guid aircraftTypeId = (Guid)(this.viewAircraftTypes.GetRowCellValue(_CurrentRowHandle, "Id"));
            using (AircraftMaint frmAircraftMaint = new AircraftMaint(aircraftTypeId, AircraftMaint.IdType.AircraftType))
                frmAircraftMaint.ShowDialog();
        }

    }
}
