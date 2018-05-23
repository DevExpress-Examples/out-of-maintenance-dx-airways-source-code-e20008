using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXAirways.Business.Orm;

namespace DXAirways.Windows.Forms
{
    public partial class CrewMembers : DevExpress.XtraEditors.XtraForm
    {
        public CrewMembers()
        {
            InitializeComponent();

            BindUI();
        }

        void BindUI()
        {
            
        }

        private void viewCrew_DoubleClick(object sender, EventArgs e)
        {
            int selectedRow = viewCrew.GetSelectedRows()[0];
            Person selectedPerson = (Person)xpcolCrewMembers[selectedRow];

            using (CrewMemberMaint frmMaint = new CrewMemberMaint(selectedPerson.Id))
                frmMaint.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (CrewMemberMaint frmMaint = new CrewMemberMaint())
                frmMaint.ShowDialog();
        }


    }
}