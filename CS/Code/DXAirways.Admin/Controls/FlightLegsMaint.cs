using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Xpo;
using DXAirways.Business;
using DXAirways.Business.Orm;
using DXAirways.Windows;

namespace DXAirways.Windows.Controls
{
    public partial class FlightLegsMaint : DevExpress.XtraEditors.XtraUserControl, ISaveable
    {
        public enum IdType
        {
            FlightPair,
            CityPair
        };

        public FlightLegsMaint()
        {
            InitializeComponent();
        }

        public FlightLegsMaint(Guid id, IdType idType)
        {
            InitializeComponent();

            FlightPair flightPair = null;

            if (idType == IdType.FlightPair)
                flightPair = OrmFactory.GetEntity<FlightPair>(unitOfWork1, id);
            else
                flightPair = new FlightEngine(unitOfWork1).GetNewFlightsForCityPair(id);

            BindUI(flightPair);
            InitValidationRules();
        }

        void BindUI(FlightPair flightPair)
        {
            lblFirstLeg.Text = string.Format("{0} - {1}", 
                flightPair.FirstLeg.Origin.AirportCode, flightPair.FirstLeg.Destination.AirportCode);
            lblSecondLeg.Text = string.Format("{0} - {1}", 
                flightPair.SecondLeg.Origin.AirportCode, flightPair.SecondLeg.Destination.AirportCode);

            XPCollection firstLeg = OrmFactory.GetBindingCollection<Flight>(unitOfWork1);
            XPCollection secondLeg = OrmFactory.GetBindingCollection<Flight>(unitOfWork1);

            firstLeg.LoadingEnabled = false;
            secondLeg.LoadingEnabled = false;

            firstLeg.Add(flightPair.FirstLeg);
            secondLeg.Add(flightPair.SecondLeg);

            bsFirstLeg.DataSource = firstLeg;
            bsSecondLeg.DataSource = secondLeg;
        }

        void InitValidationRules()
        {
            FlightNumberValidationRule flightNumberValidationRule = new FlightNumberValidationRule();
            flightNumberValidationRule.ErrorText = "Flight Number must be a three-digit numeric.";
            flightNumberValidationRule.ErrorType = ErrorType.Critical;

            FlightTimeValidationRule flightTimeValidationRule = new FlightTimeValidationRule();
            flightTimeValidationRule.ErrorText = "Flight Time must be either in #.## or ##:## format.";
            flightTimeValidationRule.ErrorType = ErrorType.Critical;

            dxValidationProvider1.SetValidationRule(txtFirstLegFlightNumber, flightNumberValidationRule);
            dxValidationProvider1.SetValidationRule(txtSecondLegFlightNumber, flightNumberValidationRule);
            dxValidationProvider1.SetValidationRule(txtFirstLegFlightTime, flightTimeValidationRule);
            dxValidationProvider1.SetValidationRule(txtSecondLegFlightTime, flightTimeValidationRule);
        }

        private void txtFirstLegFlightTime_Validating(object sender, CancelEventArgs e)
        {
            FlightTimeValidationRule rule = new FlightTimeValidationRule();
            bool ret = rule.Validate(txtFirstLegFlightTime, txtFirstLegFlightTime.EditValue);
            if (!ret)
                e.Cancel = true;
        }

        private void txtSecondLegFlightTime_Validating(object sender, CancelEventArgs e)
        {
            FlightTimeValidationRule rule = new FlightTimeValidationRule();
            bool ret = rule.Validate(txtSecondLegFlightTime, txtSecondLegFlightTime.EditValue);
            if (!ret)
                e.Cancel = true;
        }

        #region ISaveable Members

        bool ISaveable.Save()
        {
            bool ret = false;

            try
            {
                if (dxValidationProvider1.Validate())
                {
                    unitOfWork1.CommitChanges();
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error trying to commit changes.");
            }

            return ret;
            
        }

        #endregion
    }
}
