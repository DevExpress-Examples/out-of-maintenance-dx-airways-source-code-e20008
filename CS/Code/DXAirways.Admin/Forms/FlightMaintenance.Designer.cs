namespace DXAirways.Windows.Forms
{
    partial class FlightMaintenance
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeFlights = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCaption = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnlWorkArea = new DevExpress.XtraEditors.PanelControl();
            this.uow = new DevExpress.Xpo.UnitOfWork();
            this.menuCityPair = new DevExpress.XtraBars.PopupMenu(this.components);
            this.itmAddFlightPair = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.itmDeleteFlightPair = new DevExpress.XtraBars.BarButtonItem();
            this.menuFlightPair = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlWorkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCityPair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuFlightPair)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeFlights);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.pnlWorkArea);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(657, 423);
            this.splitContainerControl1.SplitterPosition = 330;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeFlights
            // 
            this.treeFlights.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colCaption});
            this.treeFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFlights.KeyFieldName = "id";
            this.treeFlights.Location = new System.Drawing.Point(0, 0);
            this.treeFlights.Name = "treeFlights";
            this.treeFlights.OptionsView.ShowColumns = false;
            this.treeFlights.OptionsView.ShowIndicator = false;
            this.treeFlights.Size = new System.Drawing.Size(330, 423);
            this.treeFlights.TabIndex = 0;
            this.treeFlights.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeFlights_MouseUp);
            // 
            // colId
            // 
            this.colId.FieldName = "id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colCaption
            // 
            this.colCaption.FieldName = "caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.OptionsColumn.AllowEdit = false;
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(234, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(153, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkArea.Location = new System.Drawing.Point(0, 0);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(318, 375);
            this.pnlWorkArea.TabIndex = 0;
            this.pnlWorkArea.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlWorkArea_ControlAdded);
            this.pnlWorkArea.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlWorkArea_ControlRemoved);
            // 
            // menuCityPair
            // 
            this.menuCityPair.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itmAddFlightPair)});
            this.menuCityPair.Manager = this.barManager1;
            this.menuCityPair.Name = "menuCityPair";
            // 
            // itmAddFlightPair
            // 
            this.itmAddFlightPair.Caption = "Add Flight Pair";
            this.itmAddFlightPair.CategoryGuid = new System.Guid("291d8674-5030-41ff-bfcc-cf72851b586d");
            this.itmAddFlightPair.Id = 0;
            this.itmAddFlightPair.Name = "itmAddFlightPair";
            this.itmAddFlightPair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itmAddFlightPair_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("City-Pairs", new System.Guid("291d8674-5030-41ff-bfcc-cf72851b586d")),
            new DevExpress.XtraBars.BarManagerCategory("Flight-Pairs", new System.Guid("4ab00bc5-6d60-4276-8218-9623ead8ddb1"))});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itmAddFlightPair,
            this.itmDeleteFlightPair});
            this.barManager1.MaxItemId = 3;
            // 
            // itmDeleteFlightPair
            // 
            this.itmDeleteFlightPair.Caption = "Delete Flight Pair";
            this.itmDeleteFlightPair.CategoryGuid = new System.Guid("4ab00bc5-6d60-4276-8218-9623ead8ddb1");
            this.itmDeleteFlightPair.Id = 2;
            this.itmDeleteFlightPair.Name = "itmDeleteFlightPair";
            this.itmDeleteFlightPair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itmDeleteFlightPair_ItemClick);
            // 
            // menuFlightPair
            // 
            this.menuFlightPair.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itmDeleteFlightPair)});
            this.menuFlightPair.Manager = this.barManager1;
            this.menuFlightPair.Name = "menuFlightPair";
            // 
            // FlightMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 423);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FlightMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlWorkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCityPair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuFlightPair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeFlights;
        private DevExpress.Xpo.UnitOfWork uow;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCaption;
        private DevExpress.XtraBars.PopupMenu menuCityPair;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem itmAddFlightPair;
        private DevExpress.XtraBars.BarButtonItem itmDeleteFlightPair;
        private DevExpress.XtraBars.PopupMenu menuFlightPair;
        private DevExpress.XtraEditors.PanelControl pnlWorkArea;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}