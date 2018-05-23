namespace DXAirways.Windows.Forms
{
    partial class TestForm
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
            this.xpCollection1 = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFirstCity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.layoutViewField_gridColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(DXAirways.Business.Orm.CityPair);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(715, 505);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.gridColumn1,
            this.colFirstCity,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
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
            this.layoutViewField_colId.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_colId.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(136, 13);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "FirstCity.AirportCode";
            this.gridColumn1.LayoutViewField = this.layoutViewField_gridColumn1;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // layoutViewField_gridColumn1
            // 
            this.layoutViewField_gridColumn1.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn1.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_gridColumn1.Name = "layoutViewField_gridColumn1";
            this.layoutViewField_gridColumn1.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_gridColumn1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_gridColumn1.TextSize = new System.Drawing.Size(136, 13);
            // 
            // colFirstCity
            // 
            this.colFirstCity.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colFirstCity.FieldName = "FirstCity!Key";
            this.colFirstCity.LayoutViewField = this.layoutViewField_gridColumn2;
            this.colFirstCity.Name = "colFirstCity";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AirportCode", 5, "Airport"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 5, "Name")});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSource1;
            this.repositoryItemLookUpEdit1.DisplayMember = "DisplayCaption";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "Select an airport";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DXAirways.Business.Orm.Airport);
            // 
            // layoutViewField_gridColumn2
            // 
            this.layoutViewField_gridColumn2.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn2.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_gridColumn2.Name = "layoutViewField_gridColumn2";
            this.layoutViewField_gridColumn2.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_gridColumn2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_gridColumn2.TextSize = new System.Drawing.Size(136, 13);
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "SecondCity.AirportCode";
            this.gridColumn3.LayoutViewField = this.layoutViewField_gridColumn3;
            this.gridColumn3.Name = "gridColumn3";
            // 
            // layoutViewField_gridColumn3
            // 
            this.layoutViewField_gridColumn3.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn3.Location = new System.Drawing.Point(0, 81);
            this.layoutViewField_gridColumn3.Name = "layoutViewField_gridColumn3";
            this.layoutViewField_gridColumn3.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_gridColumn3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_gridColumn3.TextSize = new System.Drawing.Size(136, 13);
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "SecondCity!Key";
            this.gridColumn4.LayoutViewField = this.layoutViewField_gridColumn4;
            this.gridColumn4.Name = "gridColumn4";
            // 
            // layoutViewField_gridColumn4
            // 
            this.layoutViewField_gridColumn4.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn4.Location = new System.Drawing.Point(0, 108);
            this.layoutViewField_gridColumn4.Name = "layoutViewField_gridColumn4";
            this.layoutViewField_gridColumn4.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_gridColumn4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_gridColumn4.TextSize = new System.Drawing.Size(136, 13);
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Equipment.MakeAndModel";
            this.gridColumn5.LayoutViewField = this.layoutViewField_gridColumn5;
            this.gridColumn5.Name = "gridColumn5";
            // 
            // layoutViewField_gridColumn5
            // 
            this.layoutViewField_gridColumn5.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn5.Location = new System.Drawing.Point(0, 135);
            this.layoutViewField_gridColumn5.Name = "layoutViewField_gridColumn5";
            this.layoutViewField_gridColumn5.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_gridColumn5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_gridColumn5.TextSize = new System.Drawing.Size(136, 13);
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Equipment!Key";
            this.gridColumn6.LayoutViewField = this.layoutViewField_gridColumn6;
            this.gridColumn6.Name = "gridColumn6";
            // 
            // layoutViewField_gridColumn6
            // 
            this.layoutViewField_gridColumn6.EditorPreferredWidth = 130;
            this.layoutViewField_gridColumn6.Location = new System.Drawing.Point(0, 162);
            this.layoutViewField_gridColumn6.Name = "layoutViewField_gridColumn6";
            this.layoutViewField_gridColumn6.Size = new System.Drawing.Size(282, 27);
            this.layoutViewField_gridColumn6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_gridColumn6.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewCard1";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId,
            this.layoutViewField_gridColumn1,
            this.layoutViewField_gridColumn2,
            this.layoutViewField_gridColumn3,
            this.layoutViewField_gridColumn4,
            this.layoutViewField_gridColumn5,
            this.layoutViewField_gridColumn6});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.Text = "layoutViewTemplateCard";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 523);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "customize";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(177, 526);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.bindingSource1;
            this.lookUpEdit1.Properties.NullText = "Select an airport";
            this.lookUpEdit1.Size = new System.Drawing.Size(252, 20);
            this.lookUpEdit1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(647, 522);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Save";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 558);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFirstCity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn5;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;









    }
}