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
    public partial class AircraftList : DevExpress.XtraEditors.XtraForm
    {
        public AircraftList()
        {
            InitializeComponent();
        }

        private void viewAircraft_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = viewAircraft.FocusedRowHandle;
            Guid aircraftId = (Guid)(viewAircraft.GetRowCellValue(rowHandle, "Id"));

            using (AircraftMaint frmAircraftMaint = new AircraftMaint(aircraftId, AircraftMaint.IdType.Aircraft))
            {
                frmAircraftMaint.RecordUpdated += frmAircraftMaint_RecordUpdated;
                frmAircraftMaint.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AircraftMaint frmAircraftMaint = new AircraftMaint())
            {
                frmAircraftMaint.RecordUpdated += frmAircraftMaint_RecordUpdated;
                frmAircraftMaint.ShowDialog();
            }
        }

        private void frmAircraftMaint_RecordUpdated(object sender, EventArgs e)
        {
            xpcolAircraft.Reload();
            grdAircraft.RefreshDataSource();
        }
    }
}