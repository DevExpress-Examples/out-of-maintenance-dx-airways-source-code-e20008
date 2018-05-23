namespace DXAirways.Windows.Forms
{
    partial class CityPairMaint
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.uow = new DevExpress.Xpo.UnitOfWork();
            this.xpcolCityPairs = new DevExpress.Xpo.XPCollection();
            this.bsAirports = new System.Windows.Forms.BindingSource(this.components);
            this.bsEquipment = new System.Windows.Forms.BindingSource(this.components);
            this.grdCityPairs = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFirstCity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.lookupEditFirstCity = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSecondCity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.lookupEditSecondCity = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutViewField_layoutViewColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colEquipment = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.lookupEditEquipment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutViewField_layoutViewColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stdButtons1 = new DXAirways.Windows.Controls.StdButtons();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridToggleButton1 = new DXAirways.Windows.Controls.GridToggleButton();
            this.columnViewValidationHelper1 = new DXAirways.Windows.ColumnViewValidationHelper();
            this.embeddedNavigatorHelper1 = new DXAirways.Windows.EmbeddedNavigatorHelper();
            this.btnMaintainFlightPairs = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolCityPairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCityPairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditFirstCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditSecondCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcolCityPairs
            // 
            this.xpcolCityPairs.DeleteObjectOnRemove = true;
            this.xpcolCityPairs.ObjectType = typeof(DXAirways.Business.Orm.CityPair);
            this.xpcolCityPairs.Session = this.uow;
            // 
            // bsAirports
            // 
            this.bsAirports.DataSource = typeof(DXAirways.Business.Orm.Airport);
            // 
            // bsEquipment
            // 
            this.bsEquipment.DataSource = typeof(DXAirways.Business.Orm.AircraftType);
            // 
            // grdCityPairs
            // 
            this.grdCityPairs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCityPairs.DataSource = this.xpcolCityPairs;
            this.grdCityPairs.Location = new System.Drawing.Point(0, 1);
            this.grdCityPairs.MainView = this.layoutView1;
            this.grdCityPairs.Name = "grdCityPairs";
            this.grdCityPairs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupEditFirstCity,
            this.lookupEditSecondCity,
            this.lookupEditEquipment});
            this.grdCityPairs.Size = new System.Drawing.Size(524, 339);
            this.grdCityPairs.TabIndex = 0;
            this.grdCityPairs.UseEmbeddedNavigator = true;
            this.grdCityPairs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(413, 101);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colFirstCity,
            this.colSecondCity,
            this.colEquipment});
            this.layoutView1.GridControl = this.grdCityPairs;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsCustomization.AllowFilter = false;
            this.layoutView1.OptionsCustomization.AllowSort = false;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 130;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(354, 81);
            this.layoutViewField_colId.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colFirstCity
            // 
            this.colFirstCity.ColumnEdit = this.lookupEditFirstCity;
            this.colFirstCity.FieldName = "FirstCity!Key";
            this.colFirstCity.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.colFirstCity.Name = "colFirstCity";
            // 
            // lookupEditFirstCity
            // 
            this.lookupEditFirstCity.AutoHeight = false;
            this.lookupEditFirstCity.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupEditFirstCity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "airports", null)});
            this.lookupEditFirstCity.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AirportCode", 5, "Airport Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 5, "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityState", 5, "Location")});
            this.lookupEditFirstCity.DataSource = this.bsAirports;
            this.lookupEditFirstCity.DisplayMember = "CityState";
            this.lookupEditFirstCity.Name = "lookupEditFirstCity";
            this.lookupEditFirstCity.NullText = "Select an airport/city";
            this.lookupEditFirstCity.ValueMember = "Id";
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 312;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(394, 27);
            this.layoutViewField_layoutViewColumn2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colSecondCity
            // 
            this.colSecondCity.ColumnEdit = this.lookupEditSecondCity;
            this.colSecondCity.FieldName = "SecondCity!Key";
            this.colSecondCity.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.colSecondCity.Name = "colSecondCity";
            // 
            // lookupEditSecondCity
            // 
            this.lookupEditSecondCity.AutoHeight = false;
            this.lookupEditSecondCity.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupEditSecondCity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "airports", null)});
            this.lookupEditSecondCity.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AirportCode", 5, "Airport Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 5, "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityState", 5, "Location")});
            this.lookupEditSecondCity.DataSource = this.bsAirports;
            this.lookupEditSecondCity.DisplayMember = "CityState";
            this.lookupEditSecondCity.Name = "lookupEditSecondCity";
            this.lookupEditSecondCity.NullText = "Select an airport/city";
            this.lookupEditSecondCity.ValueMember = "Id";
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 312;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(394, 27);
            this.layoutViewField_layoutViewColumn4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colEquipment
            // 
            this.colEquipment.ColumnEdit = this.lookupEditEquipment;
            this.colEquipment.FieldName = "Equipment!Key";
            this.colEquipment.LayoutViewField = this.layoutViewField_layoutViewColumn6;
            this.colEquipment.Name = "colEquipment";
            // 
            // lookupEditEquipment
            // 
            this.lookupEditEquipment.AutoHeight = false;
            this.lookupEditEquipment.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupEditEquipment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "equipment", null)});
            this.lookupEditEquipment.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Make", 5, "Make"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", 5, "Model")});
            this.lookupEditEquipment.DataSource = this.bsEquipment;
            this.lookupEditEquipment.DisplayMember = "MakeAndModel";
            this.lookupEditEquipment.Name = "lookupEditEquipment";
            this.lookupEditEquipment.NullText = "Select an aircraft type";
            this.lookupEditEquipment.ValueMember = "Id";
            // 
            // layoutViewField_layoutViewColumn6
            // 
            this.layoutViewField_layoutViewColumn6.EditorPreferredWidth = 312;
            this.layoutViewField_layoutViewColumn6.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_layoutViewColumn6.Name = "layoutViewField_layoutViewColumn6";
            this.layoutViewField_layoutViewColumn6.Size = new System.Drawing.Size(394, 27);
            this.layoutViewField_layoutViewColumn6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_layoutViewColumn6.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn6});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.gridColumn8,
            this.gridColumn10,
            this.gridColumn12});
            this.gridView1.GridControl = this.grdCityPairs;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "First City";
            this.gridColumn8.FieldName = "FirstCity.CityState";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Second City";
            this.gridColumn10.FieldName = "SecondCity.CityState";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Equipment Type";
            this.gridColumn12.FieldName = "Equipment.MakeAndModel";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            // 
            // stdButtons1
            // 
            this.stdButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stdButtons1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stdButtons1.Appearance.Options.UseBackColor = true;
            this.stdButtons1.ButtonOrientation = DXAirways.Windows.Controls.StdButtons.Orientation.Horizontal;
            this.stdButtons1.Location = new System.Drawing.Point(282, 346);
            this.stdButtons1.Name = "stdButtons1";
            this.stdButtons1.Size = new System.Drawing.Size(242, 29);
            this.stdButtons1.TabIndex = 1;
            this.stdButtons1.UnitOfWork = this.uow;
            this.stdButtons1.StdButtonClicked += new System.EventHandler<DXAirways.Windows.Controls.StdButtonClickedEventArgs>(this.stdButtons1_StdButtonClicked);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "FirstCity!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "FirstCity!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "SecondCity!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "SecondCity!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Equipment!";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Equipment!Key";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridToggleButton1
            // 
            this.gridToggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridToggleButton1.Grid = this.grdCityPairs;
            this.gridToggleButton1.ListView = this.gridView1;
            this.gridToggleButton1.Location = new System.Drawing.Point(9, 348);
            this.gridToggleButton1.MaintView = this.layoutView1;
            this.gridToggleButton1.Name = "gridToggleButton1";
            this.gridToggleButton1.Size = new System.Drawing.Size(75, 23);
            this.gridToggleButton1.TabIndex = 2;
            this.gridToggleButton1.Text = "Toggle View";
            // 
            // columnViewValidationHelper1
            // 
            this.columnViewValidationHelper1.ValidateEntireRowOnly = false;
            this.columnViewValidationHelper1.View = this.layoutView1;
            this.columnViewValidationHelper1.ValidateField += new DXAirways.Windows.ValidateFieldDelegate(this.ValidateField);
            // 
            // embeddedNavigatorHelper1
            // 
            this.embeddedNavigatorHelper1.Navigator = this.grdCityPairs.EmbeddedNavigator;
            // 
            // btnMaintainFlightPairs
            // 
            this.btnMaintainFlightPairs.Location = new System.Drawing.Point(91, 348);
            this.btnMaintainFlightPairs.Name = "btnMaintainFlightPairs";
            this.btnMaintainFlightPairs.Size = new System.Drawing.Size(110, 23);
            this.btnMaintainFlightPairs.TabIndex = 3;
            this.btnMaintainFlightPairs.Text = "Maintain Flight-Pairs";
            this.btnMaintainFlightPairs.Click += new System.EventHandler(this.btnMaintainFlightPairs_Click);
            // 
            // CityPairMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 380);
            this.Controls.Add(this.btnMaintainFlightPairs);
            this.Controls.Add(this.gridToggleButton1);
            this.Controls.Add(this.stdButtons1);
            this.Controls.Add(this.grdCityPairs);
            this.Name = "CityPairMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City-Pair Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolCityPairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCityPairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditFirstCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditSecondCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork uow;
        private DevExpress.Xpo.XPCollection xpcolCityPairs;
        private System.Windows.Forms.BindingSource bsAirports;
        private System.Windows.Forms.BindingSource bsEquipment;
        private DevExpress.XtraGrid.GridControl grdCityPairs;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFirstCity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSecondCity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colEquipment;
        private DXAirways.Windows.Controls.StdButtons stdButtons1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupEditFirstCity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupEditSecondCity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupEditEquipment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DXAirways.Windows.Controls.GridToggleButton gridToggleButton1;
        private ColumnViewValidationHelper columnViewValidationHelper1;
        private EmbeddedNavigatorHelper embeddedNavigatorHelper1;
        private DevExpress.XtraEditors.SimpleButton btnMaintainFlightPairs;
    }
}