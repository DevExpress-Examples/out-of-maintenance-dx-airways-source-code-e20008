namespace DXAirways.Windows.Forms
{
    partial class AircraftTypeMaint
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.viewAircraft = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTailNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEngineMiles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdAircraftTypes = new DevExpress.XtraGrid.GridControl();
            this.xpcolAircraftTypes = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMake1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMake1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colModel1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colModel1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFirstClassSeats1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFirstClassSeats1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCoachSeats1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCoachSeats1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMilesPerGallon1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMilesPerGallon1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMinorServiceMiles1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMinorServiceMiles1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMinorServiceOutage1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMinorServiceOutage1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMajorServiceMiles1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMajorServiceMiles1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMajorServiceOutage1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMajorServiceOutage1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.viewAircraftTypes = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMake = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFirstClassSeats = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCoachSeats = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMilesPerGallon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMajorServiceMiles = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMajorServiceOutage = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMinorServiceMiles = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMinorServiceOutage = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.stdButtons1 = new DXAirways.Windows.Controls.StdButtons();
            this.gridToggleButton1 = new DXAirways.Windows.Controls.GridToggleButton();
            this.embeddedNavigatorHelper1 = new DXAirways.Windows.EmbeddedNavigatorHelper();
            this.columnViewValidationHelper1 = new DXAirways.Windows.ColumnViewValidationHelper();
            this.btnAddAircraft = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAircraftTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAircraftTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMake1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colModel1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstClassSeats1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCoachSeats1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMilesPerGallon1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMinorServiceMiles1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMinorServiceOutage1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMajorServiceMiles1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMajorServiceOutage1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAircraftTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAircraft
            // 
            this.viewAircraft.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colTailNumber,
            this.colEngineMiles,
            this.layoutViewColumn4});
            this.viewAircraft.GridControl = this.grdAircraftTypes;
            this.viewAircraft.Name = "viewAircraft";
            this.viewAircraft.OptionsCustomization.AllowColumnMoving = false;
            this.viewAircraft.OptionsCustomization.AllowFilter = false;
            this.viewAircraft.OptionsCustomization.AllowSort = false;
            this.viewAircraft.OptionsDetail.EnableMasterViewMode = false;
            this.viewAircraft.OptionsView.ShowDetailButtons = false;
            this.viewAircraft.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.viewAircraft.OptionsView.ShowGroupPanel = false;
            this.viewAircraft.DoubleClick += new System.EventHandler(this.viewAircraft_DoubleClick);
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.OptionsColumn.AllowEdit = false;
            // 
            // colTailNumber
            // 
            this.colTailNumber.FieldName = "TailNumber";
            this.colTailNumber.Name = "colTailNumber";
            this.colTailNumber.OptionsColumn.AllowEdit = false;
            this.colTailNumber.Visible = true;
            this.colTailNumber.VisibleIndex = 0;
            this.colTailNumber.Width = 264;
            // 
            // colEngineMiles
            // 
            this.colEngineMiles.FieldName = "EngineMiles";
            this.colEngineMiles.Name = "colEngineMiles";
            this.colEngineMiles.OptionsColumn.AllowEdit = false;
            this.colEngineMiles.Visible = true;
            this.colEngineMiles.VisibleIndex = 1;
            this.colEngineMiles.Width = 312;
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Home Airport";
            this.layoutViewColumn4.FieldName = "HomeAirport.DisplayCaption";
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.OptionsColumn.AllowEdit = false;
            this.layoutViewColumn4.Visible = true;
            this.layoutViewColumn4.VisibleIndex = 2;
            this.layoutViewColumn4.Width = 1152;
            // 
            // grdAircraftTypes
            // 
            this.grdAircraftTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAircraftTypes.DataSource = this.xpcolAircraftTypes;
            gridLevelNode1.LevelTemplate = this.viewAircraft;
            gridLevelNode1.RelationName = "Aircraft";
            this.grdAircraftTypes.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdAircraftTypes.Location = new System.Drawing.Point(0, 1);
            this.grdAircraftTypes.MainView = this.layoutView1;
            this.grdAircraftTypes.Name = "grdAircraftTypes";
            this.grdAircraftTypes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemLookUpEdit5,
            this.repositoryItemLookUpEdit6});
            this.grdAircraftTypes.Size = new System.Drawing.Size(639, 367);
            this.grdAircraftTypes.TabIndex = 0;
            this.grdAircraftTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.viewAircraftTypes,
            this.viewAircraft});
            // 
            // xpcolAircraftTypes
            // 
            this.xpcolAircraftTypes.DeleteObjectOnRemove = true;
            this.xpcolAircraftTypes.ObjectType = typeof(DXAirways.Business.Orm.AircraftType);
            this.xpcolAircraftTypes.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.ObjectsLoaded += new DevExpress.Xpo.ObjectsManipulationEventHandler(this.unitOfWork1_ObjectsLoaded);
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId1,
            this.colMake1,
            this.colModel1,
            this.colFirstClassSeats1,
            this.colCoachSeats1,
            this.colMilesPerGallon1,
            this.colMinorServiceMiles1,
            this.colMinorServiceOutage1,
            this.colMajorServiceMiles1,
            this.colMajorServiceOutage1});
            this.layoutView1.GridControl = this.grdAircraftTypes;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId1_1});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsCustomization.AllowFilter = false;
            this.layoutView1.OptionsCustomization.AllowSort = false;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.LayoutViewField = this.layoutViewField_colId1_1;
            this.colId1.Name = "colId1";
            // 
            // layoutViewField_colId1_1
            // 
            this.layoutViewField_colId1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colId1_1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId1_1.Name = "item0";
            this.layoutViewField_colId1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colId1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colId1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colMake1
            // 
            this.colMake1.FieldName = "Make";
            this.colMake1.LayoutViewField = this.layoutViewField_colMake1_1;
            this.colMake1.Name = "colMake1";
            // 
            // layoutViewField_colMake1_1
            // 
            this.layoutViewField_colMake1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colMake1_1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colMake1_1.Name = "layoutViewField_colMake1_1";
            this.layoutViewField_colMake1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colMake1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colMake1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colModel1
            // 
            this.colModel1.FieldName = "Model";
            this.colModel1.LayoutViewField = this.layoutViewField_colModel1_1;
            this.colModel1.Name = "colModel1";
            // 
            // layoutViewField_colModel1_1
            // 
            this.layoutViewField_colModel1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colModel1_1.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_colModel1_1.Name = "layoutViewField_colModel1_1";
            this.layoutViewField_colModel1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colModel1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colModel1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colFirstClassSeats1
            // 
            this.colFirstClassSeats1.FieldName = "FirstClassSeats";
            this.colFirstClassSeats1.LayoutViewField = this.layoutViewField_colFirstClassSeats1_1;
            this.colFirstClassSeats1.Name = "colFirstClassSeats1";
            // 
            // layoutViewField_colFirstClassSeats1_1
            // 
            this.layoutViewField_colFirstClassSeats1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colFirstClassSeats1_1.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_colFirstClassSeats1_1.Name = "layoutViewField_colFirstClassSeats1_1";
            this.layoutViewField_colFirstClassSeats1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colFirstClassSeats1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colFirstClassSeats1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colCoachSeats1
            // 
            this.colCoachSeats1.FieldName = "CoachSeats";
            this.colCoachSeats1.LayoutViewField = this.layoutViewField_colCoachSeats1_1;
            this.colCoachSeats1.Name = "colCoachSeats1";
            // 
            // layoutViewField_colCoachSeats1_1
            // 
            this.layoutViewField_colCoachSeats1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colCoachSeats1_1.Location = new System.Drawing.Point(0, 81);
            this.layoutViewField_colCoachSeats1_1.Name = "layoutViewField_colCoachSeats1_1";
            this.layoutViewField_colCoachSeats1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colCoachSeats1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colCoachSeats1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colMilesPerGallon1
            // 
            this.colMilesPerGallon1.FieldName = "MilesPerGallon";
            this.colMilesPerGallon1.LayoutViewField = this.layoutViewField_colMilesPerGallon1_1;
            this.colMilesPerGallon1.Name = "colMilesPerGallon1";
            // 
            // layoutViewField_colMilesPerGallon1_1
            // 
            this.layoutViewField_colMilesPerGallon1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colMilesPerGallon1_1.Location = new System.Drawing.Point(0, 108);
            this.layoutViewField_colMilesPerGallon1_1.Name = "layoutViewField_colMilesPerGallon1_1";
            this.layoutViewField_colMilesPerGallon1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colMilesPerGallon1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colMilesPerGallon1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colMinorServiceMiles1
            // 
            this.colMinorServiceMiles1.FieldName = "MinorServiceMiles";
            this.colMinorServiceMiles1.LayoutViewField = this.layoutViewField_colMinorServiceMiles1_1;
            this.colMinorServiceMiles1.Name = "colMinorServiceMiles1";
            // 
            // layoutViewField_colMinorServiceMiles1_1
            // 
            this.layoutViewField_colMinorServiceMiles1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colMinorServiceMiles1_1.Location = new System.Drawing.Point(0, 135);
            this.layoutViewField_colMinorServiceMiles1_1.Name = "layoutViewField_colMinorServiceMiles1_1";
            this.layoutViewField_colMinorServiceMiles1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colMinorServiceMiles1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colMinorServiceMiles1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colMinorServiceOutage1
            // 
            this.colMinorServiceOutage1.FieldName = "MinorServiceOutage";
            this.colMinorServiceOutage1.LayoutViewField = this.layoutViewField_colMinorServiceOutage1_1;
            this.colMinorServiceOutage1.Name = "colMinorServiceOutage1";
            // 
            // layoutViewField_colMinorServiceOutage1_1
            // 
            this.layoutViewField_colMinorServiceOutage1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colMinorServiceOutage1_1.Location = new System.Drawing.Point(0, 162);
            this.layoutViewField_colMinorServiceOutage1_1.Name = "layoutViewField_colMinorServiceOutage1_1";
            this.layoutViewField_colMinorServiceOutage1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colMinorServiceOutage1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colMinorServiceOutage1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colMajorServiceMiles1
            // 
            this.colMajorServiceMiles1.FieldName = "MajorServiceMiles";
            this.colMajorServiceMiles1.LayoutViewField = this.layoutViewField_colMajorServiceMiles1_1;
            this.colMajorServiceMiles1.Name = "colMajorServiceMiles1";
            // 
            // layoutViewField_colMajorServiceMiles1_1
            // 
            this.layoutViewField_colMajorServiceMiles1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colMajorServiceMiles1_1.Location = new System.Drawing.Point(0, 189);
            this.layoutViewField_colMajorServiceMiles1_1.Name = "layoutViewField_colMajorServiceMiles1_1";
            this.layoutViewField_colMajorServiceMiles1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colMajorServiceMiles1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colMajorServiceMiles1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // colMajorServiceOutage1
            // 
            this.colMajorServiceOutage1.FieldName = "MajorServiceOutage";
            this.colMajorServiceOutage1.LayoutViewField = this.layoutViewField_colMajorServiceOutage1_1;
            this.colMajorServiceOutage1.Name = "colMajorServiceOutage1";
            // 
            // layoutViewField_colMajorServiceOutage1_1
            // 
            this.layoutViewField_colMajorServiceOutage1_1.EditorPreferredWidth = 83;
            this.layoutViewField_colMajorServiceOutage1_1.Location = new System.Drawing.Point(0, 216);
            this.layoutViewField_colMajorServiceOutage1_1.Name = "layoutViewField_colMajorServiceOutage1_1";
            this.layoutViewField_colMajorServiceOutage1_1.Size = new System.Drawing.Size(207, 27);
            this.layoutViewField_colMajorServiceOutage1_1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colMajorServiceOutage1_1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colMake1_1,
            this.layoutViewField_colModel1_1,
            this.layoutViewField_colFirstClassSeats1_1,
            this.layoutViewField_colCoachSeats1_1,
            this.layoutViewField_colMilesPerGallon1_1,
            this.layoutViewField_colMinorServiceMiles1_1,
            this.layoutViewField_colMinorServiceOutage1_1,
            this.layoutViewField_colMajorServiceMiles1_1,
            this.layoutViewField_colMajorServiceOutage1_1});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            // 
            // repositoryItemLookUpEdit6
            // 
            this.repositoryItemLookUpEdit6.AutoHeight = false;
            this.repositoryItemLookUpEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit6.Name = "repositoryItemLookUpEdit6";
            // 
            // viewAircraftTypes
            // 
            this.viewAircraftTypes.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.viewAircraftTypes.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colMake,
            this.colModel,
            this.colFirstClassSeats,
            this.colCoachSeats,
            this.colMilesPerGallon,
            this.colMinorServiceMiles,
            this.colMinorServiceOutage,
            this.colMajorServiceMiles,
            this.colMajorServiceOutage});
            this.viewAircraftTypes.GridControl = this.grdAircraftTypes;
            this.viewAircraftTypes.Name = "viewAircraftTypes";
            this.viewAircraftTypes.OptionsBehavior.Editable = false;
            this.viewAircraftTypes.OptionsCustomization.AllowFilter = false;
            this.viewAircraftTypes.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.viewAircraftTypes.OptionsView.ShowBands = false;
            this.viewAircraftTypes.OptionsView.ShowGroupPanel = false;
            this.viewAircraftTypes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewAircraftTypes_RowClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colId);
            this.gridBand1.Columns.Add(this.colMake);
            this.gridBand1.Columns.Add(this.colModel);
            this.gridBand1.Columns.Add(this.colFirstClassSeats);
            this.gridBand1.Columns.Add(this.colCoachSeats);
            this.gridBand1.Columns.Add(this.colMilesPerGallon);
            this.gridBand1.Columns.Add(this.colMajorServiceMiles);
            this.gridBand1.Columns.Add(this.colMajorServiceOutage);
            this.gridBand1.Columns.Add(this.colMinorServiceMiles);
            this.gridBand1.Columns.Add(this.colMinorServiceOutage);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 600;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colMake
            // 
            this.colMake.FieldName = "Make";
            this.colMake.Name = "colMake";
            this.colMake.Visible = true;
            this.colMake.Width = 169;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.Width = 162;
            // 
            // colFirstClassSeats
            // 
            this.colFirstClassSeats.FieldName = "FirstClassSeats";
            this.colFirstClassSeats.Name = "colFirstClassSeats";
            this.colFirstClassSeats.Visible = true;
            this.colFirstClassSeats.Width = 129;
            // 
            // colCoachSeats
            // 
            this.colCoachSeats.FieldName = "CoachSeats";
            this.colCoachSeats.Name = "colCoachSeats";
            this.colCoachSeats.Visible = true;
            this.colCoachSeats.Width = 140;
            // 
            // colMilesPerGallon
            // 
            this.colMilesPerGallon.FieldName = "MilesPerGallon";
            this.colMilesPerGallon.Name = "colMilesPerGallon";
            this.colMilesPerGallon.RowIndex = 1;
            this.colMilesPerGallon.Visible = true;
            this.colMilesPerGallon.Width = 106;
            // 
            // colMajorServiceMiles
            // 
            this.colMajorServiceMiles.FieldName = "MajorServiceMiles";
            this.colMajorServiceMiles.Name = "colMajorServiceMiles";
            this.colMajorServiceMiles.RowIndex = 1;
            this.colMajorServiceMiles.Visible = true;
            this.colMajorServiceMiles.Width = 119;
            // 
            // colMajorServiceOutage
            // 
            this.colMajorServiceOutage.FieldName = "MajorServiceOutage";
            this.colMajorServiceOutage.Name = "colMajorServiceOutage";
            this.colMajorServiceOutage.RowIndex = 1;
            this.colMajorServiceOutage.Visible = true;
            this.colMajorServiceOutage.Width = 119;
            // 
            // colMinorServiceMiles
            // 
            this.colMinorServiceMiles.FieldName = "MinorServiceMiles";
            this.colMinorServiceMiles.Name = "colMinorServiceMiles";
            this.colMinorServiceMiles.RowIndex = 1;
            this.colMinorServiceMiles.Visible = true;
            this.colMinorServiceMiles.Width = 119;
            // 
            // colMinorServiceOutage
            // 
            this.colMinorServiceOutage.FieldName = "MinorServiceOutage";
            this.colMinorServiceOutage.Name = "colMinorServiceOutage";
            this.colMinorServiceOutage.RowIndex = 1;
            this.colMinorServiceOutage.Visible = true;
            this.colMinorServiceOutage.Width = 137;
            // 
            // stdButtons1
            // 
            this.stdButtons1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stdButtons1.Appearance.Options.UseBackColor = true;
            this.stdButtons1.ButtonOrientation = DXAirways.Windows.Controls.StdButtons.Orientation.Horizontal;
            this.stdButtons1.Location = new System.Drawing.Point(397, 368);
            this.stdButtons1.Name = "stdButtons1";
            this.stdButtons1.Size = new System.Drawing.Size(242, 29);
            this.stdButtons1.TabIndex = 4;
            this.stdButtons1.UnitOfWork = this.unitOfWork1;
            // 
            // gridToggleButton1
            // 
            this.gridToggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridToggleButton1.Grid = this.grdAircraftTypes;
            this.gridToggleButton1.ListView = this.viewAircraftTypes;
            this.gridToggleButton1.Location = new System.Drawing.Point(7, 371);
            this.gridToggleButton1.MaintView = this.layoutView1;
            this.gridToggleButton1.Name = "gridToggleButton1";
            this.gridToggleButton1.Size = new System.Drawing.Size(75, 23);
            this.gridToggleButton1.TabIndex = 5;
            this.gridToggleButton1.Text = "Toggle View";
            // 
            // embeddedNavigatorHelper1
            // 
            this.embeddedNavigatorHelper1.Navigator = this.grdAircraftTypes.EmbeddedNavigator;
            // 
            // columnViewValidationHelper1
            // 
            this.columnViewValidationHelper1.ValidateEntireRowOnly = false;
            this.columnViewValidationHelper1.View = this.layoutView1;
            this.columnViewValidationHelper1.ValidateField += new DXAirways.Windows.ValidateFieldDelegate(this.ValidateField);
            // 
            // btnAddAircraft
            // 
            this.btnAddAircraft.Location = new System.Drawing.Point(88, 371);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(75, 23);
            this.btnAddAircraft.TabIndex = 6;
            this.btnAddAircraft.Text = "Add Aircraft";
            this.btnAddAircraft.Click += new System.EventHandler(this.btnAddAircraft_Click);
            // 
            // AircraftTypeMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 400);
            this.Controls.Add(this.btnAddAircraft);
            this.Controls.Add(this.gridToggleButton1);
            this.Controls.Add(this.stdButtons1);
            this.Controls.Add(this.grdAircraftTypes);
            this.Name = "AircraftTypeMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aircraft Equipment Type Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.viewAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAircraftTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAircraftTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMake1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colModel1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstClassSeats1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCoachSeats1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMilesPerGallon1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMinorServiceMiles1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMinorServiceOutage1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMajorServiceMiles1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMajorServiceOutage1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAircraftTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpcolAircraftTypes;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.GridControl grdAircraftTypes;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView viewAircraftTypes;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMake;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFirstClassSeats;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCoachSeats;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMilesPerGallon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMinorServiceMiles;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMinorServiceOutage;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMajorServiceMiles;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMajorServiceOutage;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMake1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colModel1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFirstClassSeats1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCoachSeats1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMilesPerGallon1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMinorServiceMiles1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMinorServiceOutage1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMajorServiceMiles1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMajorServiceOutage1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit6;
        private DevExpress.XtraGrid.Views.Grid.GridView viewAircraft;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colTailNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEngineMiles;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMake1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colModel1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFirstClassSeats1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCoachSeats1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMilesPerGallon1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMinorServiceMiles1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMinorServiceOutage1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMajorServiceMiles1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMajorServiceOutage1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DXAirways.Windows.Controls.StdButtons stdButtons1;
        private DXAirways.Windows.Controls.GridToggleButton gridToggleButton1;
        private EmbeddedNavigatorHelper embeddedNavigatorHelper1;
        private ColumnViewValidationHelper columnViewValidationHelper1;
        private DevExpress.XtraEditors.SimpleButton btnAddAircraft;
    }
}