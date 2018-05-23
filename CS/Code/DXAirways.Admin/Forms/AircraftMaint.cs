using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Windows.Forms
{
    public partial class AircraftMaint : DevExpress.XtraEditors.XtraForm
    {
        public enum IdType
        {
            Aircraft,
            AircraftType
        };

        public AircraftMaint()
        {
            InitializeComponent();

            Aircraft aircraft = new Aircraft(unitOfWork1);
            BindUI(aircraft);
            InitValidationRules();
        }

        public AircraftMaint(Guid id, IdType idType)
        {
            InitializeComponent();

            Aircraft aircraft = null;
            if (idType == IdType.Aircraft)
                aircraft = OrmFactory.GetEntity<Aircraft>(unitOfWork1, id);
            else
            {
                AircraftType aircraftType = OrmFactory.GetEntity<AircraftType>(unitOfWork1, id);
                aircraft = new Aircraft(unitOfWork1);
                aircraft.AircraftType = aircraftType;
            }

            BindUI(aircraft);
            InitValidationRules();
        }

        public event EventHandler RecordUpdated;

        protected virtual void OnRecordUpdated(EventArgs e)
        {
            if (this.RecordUpdated != null)
                this.RecordUpdated(this, e);
        }

        private void BindUI(Aircraft aircraft)
        {
            bsAircraftType.DataSource = OrmFactory.GetCollection<AircraftType>();
            bsAirport.DataSource = OrmFactory.GetCollection<Airport>();

            XPCollection aircrafts = OrmFactory.GetBindingCollection<Aircraft>(unitOfWork1);
            aircrafts.Add(aircraft);

            bsAircraft.DataSource = aircrafts;
        }

        private void InitValidationRules()
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
                this.Close();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Aircraft aircraft = new Aircraft(unitOfWork1);
                BindUI(aircraft);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Save()
        {
            bool ret = false;

            if (dxValidationProvider1.Validate())
            {
                unitOfWork1.CommitChanges();
                OnRecordUpdated(EventArgs.Empty);
                ret = true;
            }

            return ret;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Aircraft aircraft = (Aircraft)xpcolAircraft[0];
            xpcolAircraft.Remove(aircraft);
            unitOfWork1.CommitChanges();
            OnRecordUpdated(EventArgs.Empty);
            this.Close();
        }
    }
}