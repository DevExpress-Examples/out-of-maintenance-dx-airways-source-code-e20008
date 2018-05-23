using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Xpo;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Windows.Forms
{
    public partial class CrewMemberMaint : DevExpress.XtraEditors.XtraForm
    {
        public CrewMemberMaint()
        {
            InitializeComponent();

            _CrewMember = new CrewMember();
            BindUI();
        }

        public CrewMemberMaint(Guid crewMemberId)
        {
            InitializeComponent();

            _CrewMember = new CrewMemberEngine().GetCrewMember(crewMemberId);
            BindUI();
        }

        CrewMember _CrewMember = null;

        void BindUI()
        {
            XPCollection<Airport> airports = new FlightEngine().GetAirports();
            bsAirport.DataSource = airports;
            lookUpEdit1.EditValue = ((Airport)airports[0]).Id;

            bsCrewMember.DataSource = _CrewMember;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bsCrewMember.EndEdit();
            _CrewMember.Save();
        }
    }
}