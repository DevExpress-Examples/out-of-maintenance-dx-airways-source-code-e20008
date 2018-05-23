namespace DXAirways.Windows.Forms
{
    partial class AirportMaint
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
            this.uow = new DevExpress.Xpo.UnitOfWork();
            this.xpcolAirports = new DevExpress.Xpo.XPCollection();
            this.grdAirports = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAirportCode = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAirportCode = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUtcOffset = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.layoutViewField_colUtcOffset = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colState = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsStates = new System.Windows.Forms.BindingSource(this.components);
            this.layoutViewField_colState = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDisplayCaption = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDisplayCaption = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stdButtons1 = new DXAirways.Windows.Controls.StdButtons();
            this.gridToggleButton1 = new DXAirways.Windows.Controls.GridToggleButton();
            this.embeddedNavigatorHelper1 = new DXAirways.Windows.EmbeddedNavigatorHelper();
            this.columnViewValidationHelper1 = new DXAirways.Windows.ColumnViewValidationHelper();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAirportCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUtcOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDisplayCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcolAirports
            // 
            this.xpcolAirports.DeleteObjectOnRemove = true;
            this.xpcolAirports.ObjectType = typeof(DXAirways.Business.Orm.Airport);
            this.xpcolAirports.Session = this.uow;
            // 
            // grdAirports
            // 
            this.grdAirports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAirports.DataSource = this.xpcolAirports;
            this.grdAirports.Location = new System.Drawing.Point(0, 0);
            this.grdAirports.MainView = this.layoutView1;
            this.grdAirports.Name = "grdAirports";
            this.grdAirports.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemLookUpEdit1});
            this.grdAirports.Size = new System.Drawing.Size(471, 309);
            this.grdAirports.TabIndex = 0;
            this.grdAirports.UseEmbeddedNavigator = true;
            this.grdAirports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(359, 157);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colAirportCode,
            this.colUtcOffset,
            this.colName,
            this.colCity,
            this.colState,
            this.colDisplayCaption});
            this.layoutView1.GridControl = this.grdAirports;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId,
            this.layoutViewField_colDisplayCaption});
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
            this.layoutViewField_colId.EditorPreferredWidth = 113;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(301, 135);
            this.layoutViewField_colId.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colAirportCode
            // 
            this.colAirportCode.FieldName = "AirportCode";
            this.colAirportCode.LayoutViewField = this.layoutViewField_colAirportCode;
            this.colAirportCode.Name = "colAirportCode";
            // 
            // layoutViewField_colAirportCode
            // 
            this.layoutViewField_colAirportCode.EditorPreferredWidth = 276;
            this.layoutViewField_colAirportCode.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colAirportCode.Name = "layoutViewField_colAirportCode";
            this.layoutViewField_colAirportCode.Size = new System.Drawing.Size(357, 27);
            this.layoutViewField_colAirportCode.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colAirportCode.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colUtcOffset
            // 
            this.colUtcOffset.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colUtcOffset.FieldName = "UtcOffset";
            this.colUtcOffset.LayoutViewField = this.layoutViewField_colUtcOffset;
            this.colUtcOffset.Name = "colUtcOffset";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // layoutViewField_colUtcOffset
            // 
            this.layoutViewField_colUtcOffset.EditorPreferredWidth = 276;
            this.layoutViewField_colUtcOffset.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_colUtcOffset.Name = "layoutViewField_colUtcOffset";
            this.layoutViewField_colUtcOffset.Size = new System.Drawing.Size(357, 27);
            this.layoutViewField_colUtcOffset.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colUtcOffset.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.LayoutViewField = this.layoutViewField_colName;
            this.colName.Name = "colName";
            // 
            // layoutViewField_colName
            // 
            this.layoutViewField_colName.EditorPreferredWidth = 276;
            this.layoutViewField_colName.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_colName.Name = "layoutViewField_colName";
            this.layoutViewField_colName.Size = new System.Drawing.Size(357, 27);
            this.layoutViewField_colName.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colName.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.LayoutViewField = this.layoutViewField_colCity;
            this.colCity.Name = "colCity";
            // 
            // layoutViewField_colCity
            // 
            this.layoutViewField_colCity.EditorPreferredWidth = 276;
            this.layoutViewField_colCity.Location = new System.Drawing.Point(0, 81);
            this.layoutViewField_colCity.Name = "layoutViewField_colCity";
            this.layoutViewField_colCity.Size = new System.Drawing.Size(357, 27);
            this.layoutViewField_colCity.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colCity.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colState
            // 
            this.colState.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colState.FieldName = "State";
            this.colState.LayoutViewField = this.layoutViewField_colState;
            this.colState.Name = "colState";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abbrev", 5, "Abbrev"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 5, "Name")});
            this.repositoryItemLookUpEdit1.DataSource = this.bsStates;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "Select a state";
            this.repositoryItemLookUpEdit1.ValueMember = "Abbrev";
            // 
            // bsStates
            // 
            this.bsStates.DataSource = typeof(DXAirways.Business.States);
            // 
            // layoutViewField_colState
            // 
            this.layoutViewField_colState.EditorPreferredWidth = 276;
            this.layoutViewField_colState.Location = new System.Drawing.Point(0, 108);
            this.layoutViewField_colState.Name = "layoutViewField_colState";
            this.layoutViewField_colState.Size = new System.Drawing.Size(357, 27);
            this.layoutViewField_colState.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colState.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colDisplayCaption
            // 
            this.colDisplayCaption.FieldName = "DisplayCaption";
            this.colDisplayCaption.LayoutViewField = this.layoutViewField_colDisplayCaption;
            this.colDisplayCaption.Name = "colDisplayCaption";
            this.colDisplayCaption.OptionsColumn.ReadOnly = true;
            // 
            // layoutViewField_colDisplayCaption
            // 
            this.layoutViewField_colDisplayCaption.EditorPreferredWidth = 113;
            this.layoutViewField_colDisplayCaption.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colDisplayCaption.Name = "layoutViewField_colDisplayCaption";
            this.layoutViewField_colDisplayCaption.Size = new System.Drawing.Size(301, 135);
            this.layoutViewField_colDisplayCaption.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colDisplayCaption.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colAirportCode,
            this.layoutViewField_colUtcOffset,
            this.layoutViewField_colName,
            this.layoutViewField_colCity,
            this.layoutViewField_colState});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7});
            this.gridView1.GridControl = this.grdAirports;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "AirportCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn3.FieldName = "UtcOffset";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "City & State";
            this.gridColumn7.FieldName = "DisplayCaption";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // stdButtons1
            // 
            this.stdButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stdButtons1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stdButtons1.Appearance.Options.UseBackColor = true;
            this.stdButtons1.Location = new System.Drawing.Point(229, 315);
            this.stdButtons1.Name = "stdButtons1";
            this.stdButtons1.Size = new System.Drawing.Size(242, 29);
            this.stdButtons1.TabIndex = 1;
            this.stdButtons1.UnitOfWork = this.uow;
            this.stdButtons1.StdButtonClicked += new System.EventHandler<DXAirways.Windows.Controls.StdButtonClickedEventArgs>(this.stdButtons1_StdButtonClicked);
            // 
            // gridToggleButton1
            // 
            this.gridToggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridToggleButton1.Grid = this.grdAirports;
            this.gridToggleButton1.ListView = this.gridView1;
            this.gridToggleButton1.Location = new System.Drawing.Point(12, 315);
            this.gridToggleButton1.MaintView = this.layoutView1;
            this.gridToggleButton1.Name = "gridToggleButton1";
            this.gridToggleButton1.Size = new System.Drawing.Size(75, 23);
            this.gridToggleButton1.TabIndex = 4;
            this.gridToggleButton1.Text = "Toggle View";
            // 
            // embeddedNavigatorHelper1
            // 
            this.embeddedNavigatorHelper1.Navigator = this.grdAirports.EmbeddedNavigator;
            // 
            // columnViewValidationHelper1
            // 
            this.columnViewValidationHelper1.View = this.layoutView1;
            this.columnViewValidationHelper1.ValidateField += new DXAirways.Windows.ValidateFieldDelegate(this.ValidateField);
            // 
            // AirportMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 345);
            this.Controls.Add(this.gridToggleButton1);
            this.Controls.Add(this.stdButtons1);
            this.Controls.Add(this.grdAirports);
            this.Name = "AirportMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airport Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAirportCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUtcOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDisplayCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork uow;
        private DevExpress.Xpo.XPCollection xpcolAirports;
        private DevExpress.XtraGrid.GridControl grdAirports;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAirportCode;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUtcOffset;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colState;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDisplayCaption;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.BindingSource bsStates;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DXAirways.Windows.Controls.StdButtons stdButtons1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAirportCode;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUtcOffset;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colState;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDisplayCaption;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DXAirways.Windows.Controls.GridToggleButton gridToggleButton1;
        private EmbeddedNavigatorHelper embeddedNavigatorHelper1;
        private ColumnViewValidationHelper columnViewValidationHelper1;
    }
}