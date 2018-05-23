namespace DXAirways.Windows.Forms
{
    partial class AircraftList
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
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.xpcolAircraft = new DevExpress.Xpo.XPCollection();
            this.grdAircraft = new DevExpress.XtraGrid.GridControl();
            this.viewAircraft = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTailNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colInService = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEngineMiles = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDateOfService = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMilesAtService = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcolAircraft
            // 
            this.xpcolAircraft.DeleteObjectOnRemove = true;
            this.xpcolAircraft.ObjectType = typeof(DXAirways.Business.Orm.Aircraft);
            this.xpcolAircraft.Session = this.unitOfWork1;
            // 
            // grdAircraft
            // 
            this.grdAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAircraft.DataSource = this.xpcolAircraft;
            this.grdAircraft.Location = new System.Drawing.Point(-1, -1);
            this.grdAircraft.MainView = this.viewAircraft;
            this.grdAircraft.Name = "grdAircraft";
            this.grdAircraft.Size = new System.Drawing.Size(673, 339);
            this.grdAircraft.TabIndex = 0;
            this.grdAircraft.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAircraft});
            // 
            // viewAircraft
            // 
            this.viewAircraft.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.viewAircraft.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.gridColumn2,
            this.colTailNumber,
            this.colEngineMiles,
            this.colInService,
            this.colDateOfService,
            this.colMilesAtService,
            this.gridColumn4});
            this.viewAircraft.GridControl = this.grdAircraft;
            this.viewAircraft.Name = "viewAircraft";
            this.viewAircraft.OptionsBehavior.Editable = false;
            this.viewAircraft.OptionsCustomization.AllowFilter = false;
            this.viewAircraft.OptionsDetail.EnableMasterViewMode = false;
            this.viewAircraft.OptionsView.ShowBands = false;
            this.viewAircraft.OptionsView.ShowGroupPanel = false;
            this.viewAircraft.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colInService, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.viewAircraft.DoubleClick += new System.EventHandler(this.viewAircraft_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colId);
            this.gridBand1.Columns.Add(this.gridColumn2);
            this.gridBand1.Columns.Add(this.colTailNumber);
            this.gridBand1.Columns.Add(this.gridColumn4);
            this.gridBand1.Columns.Add(this.colInService);
            this.gridBand1.Columns.Add(this.colEngineMiles);
            this.gridBand1.Columns.Add(this.colDateOfService);
            this.gridBand1.Columns.Add(this.colMilesAtService);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 631;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Equipment Type";
            this.gridColumn2.FieldName = "AircraftType.MakeAndModel";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.Width = 166;
            // 
            // colTailNumber
            // 
            this.colTailNumber.FieldName = "TailNumber";
            this.colTailNumber.Name = "colTailNumber";
            this.colTailNumber.Visible = true;
            this.colTailNumber.Width = 121;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Home Airport";
            this.gridColumn4.FieldName = "HomeAirport.DisplayCaption";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.Width = 344;
            // 
            // colInService
            // 
            this.colInService.FieldName = "InService";
            this.colInService.Name = "colInService";
            this.colInService.RowIndex = 1;
            this.colInService.Visible = true;
            // 
            // colEngineMiles
            // 
            this.colEngineMiles.FieldName = "EngineMiles";
            this.colEngineMiles.Name = "colEngineMiles";
            this.colEngineMiles.RowIndex = 1;
            this.colEngineMiles.Visible = true;
            // 
            // colDateOfService
            // 
            this.colDateOfService.FieldName = "DateOfService";
            this.colDateOfService.Name = "colDateOfService";
            this.colDateOfService.RowIndex = 1;
            this.colDateOfService.Visible = true;
            // 
            // colMilesAtService
            // 
            this.colMilesAtService.FieldName = "MilesAtService";
            this.colMilesAtService.Name = "colMilesAtService";
            this.colMilesAtService.RowIndex = 1;
            this.colMilesAtService.Visible = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(553, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Aircraft";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AircraftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 380);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdAircraft);
            this.Name = "AircraftList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AircraftList";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpcolAircraft;
        private DevExpress.XtraGrid.GridControl grdAircraft;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView viewAircraft;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTailNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInService;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEngineMiles;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDateOfService;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMilesAtService;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}