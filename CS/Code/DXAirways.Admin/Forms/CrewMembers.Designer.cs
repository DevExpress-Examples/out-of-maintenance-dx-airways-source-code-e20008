namespace DXAirways.Windows.Forms
{
    partial class CrewMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.viewFlights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlightNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartureTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlightTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xpcolCrewMembers = new DevExpress.Xpo.XPCollection();
            this.grdCrew = new DevExpress.XtraGrid.GridControl();
            this.viewCrew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfHire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomeAirport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolCrewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // viewFlights
            // 
            this.viewFlights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFlightNumber,
            this.colDepartureTime,
            this.colFlightTime,
            this.colDistance});
            this.viewFlights.GridControl = this.gridControl1;
            this.viewFlights.Name = "viewFlights";
            this.viewFlights.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colFlightNumber
            // 
            this.colFlightNumber.FieldName = "FlightNumber";
            this.colFlightNumber.Name = "colFlightNumber";
            this.colFlightNumber.Visible = true;
            this.colFlightNumber.VisibleIndex = 0;
            // 
            // colDepartureTime
            // 
            this.colDepartureTime.FieldName = "DepartureTime";
            this.colDepartureTime.Name = "colDepartureTime";
            this.colDepartureTime.Visible = true;
            this.colDepartureTime.VisibleIndex = 1;
            // 
            // colFlightTime
            // 
            this.colFlightTime.FieldName = "FlightTime";
            this.colFlightTime.Name = "colFlightTime";
            this.colFlightTime.Visible = true;
            this.colFlightTime.VisibleIndex = 2;
            // 
            // colDistance
            // 
            this.colDistance.FieldName = "Distance";
            this.colDistance.Name = "colDistance";
            this.colDistance.Visible = true;
            this.colDistance.VisibleIndex = 3;
            // 
            // gridControl1
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(48, 26);
            this.gridControl1.MainView = this.viewFlights;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(570, 270);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewFlights,
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // xpcolCrewMembers
            // 
            this.xpcolCrewMembers.DisplayableProperties = "Id;FirstName;LastName;Email;Position;DateOfHire;HomeAirport";
            this.xpcolCrewMembers.ObjectType = typeof(DXAirways.Business.Orm.CrewMember);
            // 
            // grdCrew
            // 
            this.grdCrew.DataSource = this.xpcolCrewMembers;
            this.grdCrew.Location = new System.Drawing.Point(29, 32);
            this.grdCrew.MainView = this.viewCrew;
            this.grdCrew.Name = "grdCrew";
            this.grdCrew.Size = new System.Drawing.Size(577, 249);
            this.grdCrew.TabIndex = 0;
            this.grdCrew.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCrew});
            // 
            // viewCrew
            // 
            this.viewCrew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPosition,
            this.colDateOfHire,
            this.colHomeAirport});
            this.viewCrew.GridControl = this.grdCrew;
            this.viewCrew.Name = "viewCrew";
            this.viewCrew.OptionsBehavior.Editable = false;
            this.viewCrew.DoubleClick += new System.EventHandler(this.viewCrew_DoubleClick);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            // 
            // colDateOfHire
            // 
            this.colDateOfHire.FieldName = "DateOfHire";
            this.colDateOfHire.Name = "colDateOfHire";
            this.colDateOfHire.Visible = true;
            this.colDateOfHire.VisibleIndex = 4;
            // 
            // colHomeAirport
            // 
            this.colHomeAirport.FieldName = "HomeAirport";
            this.colHomeAirport.Name = "colHomeAirport";
            this.colHomeAirport.Visible = true;
            this.colHomeAirport.VisibleIndex = 5;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(407, 301);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add new crew member";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // CrewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 360);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grdCrew);
            this.Name = "CrewMembers";
            this.Text = "Crew Members";
            ((System.ComponentModel.ISupportInitialize)(this.viewFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolCrewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCrew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView viewFlights;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFlightNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartureTime;
        private DevExpress.XtraGrid.Columns.GridColumn colFlightTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDistance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Xpo.XPCollection xpcolCrewMembers;
        private DevExpress.XtraGrid.GridControl grdCrew;
        private DevExpress.XtraGrid.Views.Grid.GridView viewCrew;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfHire;
        private DevExpress.XtraGrid.Columns.GridColumn colHomeAirport;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
    }
}