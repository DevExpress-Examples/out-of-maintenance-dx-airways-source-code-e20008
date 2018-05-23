namespace DXAirways.Windows.Forms
{
    partial class AircraftMaint
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
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.bsAircraft = new System.Windows.Forms.BindingSource(this.components);
            this.xpcolAircraft = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ThisTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbAircraftType = new DevExpress.XtraEditors.LookUpEdit();
            this.bsAircraftType = new System.Windows.Forms.BindingSource(this.components);
            this.txtTailNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtEngineMiles = new DevExpress.XtraEditors.TextEdit();
            this.InServiceCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.DateOfServiceDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.MilesAtServiceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmbHomeAirport = new DevExpress.XtraEditors.LookUpEdit();
            this.bsAirport = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForThis = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTailNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEngineMiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForInService = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDateOfService = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMilesAtService = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThisTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAircraftType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAircraftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTailNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEngineMiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InServiceCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfServiceDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfServiceDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilesAtServiceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHomeAirport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAirport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForThis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTailNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEngineMiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateOfService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMilesAtService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(252, 42);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "Save && New";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(252, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bsAircraft
            // 
            this.bsAircraft.DataSource = this.xpcolAircraft;
            // 
            // xpcolAircraft
            // 
            this.xpcolAircraft.DeleteObjectOnRemove = true;
            this.xpcolAircraft.LoadingEnabled = false;
            this.xpcolAircraft.ObjectType = typeof(DXAirways.Business.Orm.Aircraft);
            this.xpcolAircraft.Session = this.unitOfWork1;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dataLayoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.dataLayoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dataLayoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.dataLayoutControl1.Controls.Add(this.ThisTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.lookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.cmbAircraftType);
            this.dataLayoutControl1.Controls.Add(this.txtTailNumber);
            this.dataLayoutControl1.Controls.Add(this.txtEngineMiles);
            this.dataLayoutControl1.Controls.Add(this.InServiceCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.DateOfServiceDateEdit);
            this.dataLayoutControl1.Controls.Add(this.MilesAtServiceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.Controls.Add(this.cmbHomeAirport);
            this.dataLayoutControl1.DataSource = this.bsAircraft;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForThis,
            this.ItemForId,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.dataLayoutControl1.Location = new System.Drawing.Point(13, 13);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(233, 219);
            this.dataLayoutControl1.TabIndex = 7;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ThisTextEdit
            // 
            this.ThisTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "This", true));
            this.ThisTextEdit.Location = new System.Drawing.Point(0, 0);
            this.ThisTextEdit.Name = "ThisTextEdit";
            this.ThisTextEdit.Size = new System.Drawing.Size(0, 20);
            this.ThisTextEdit.StyleController = this.dataLayoutControl1;
            this.ThisTextEdit.TabIndex = 4;
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "Id", true));
            this.IdTextEdit.Location = new System.Drawing.Point(0, 0);
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Size = new System.Drawing.Size(0, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 5;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "AircraftType!", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(0, 0);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(0, 20);
            this.lookUpEdit1.StyleController = this.dataLayoutControl1;
            this.lookUpEdit1.TabIndex = 6;
            // 
            // cmbAircraftType
            // 
            this.cmbAircraftType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "AircraftType!Key", true));
            this.cmbAircraftType.Location = new System.Drawing.Point(88, 7);
            this.cmbAircraftType.Name = "cmbAircraftType";
            this.cmbAircraftType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbAircraftType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAircraftType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Make", 15, "Make"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", 15, "Model")});
            this.cmbAircraftType.Properties.DataSource = this.bsAircraftType;
            this.cmbAircraftType.Properties.DisplayMember = "MakeAndModel";
            this.cmbAircraftType.Properties.NullText = "";
            this.cmbAircraftType.Properties.NullValuePrompt = "Select an aircraft type";
            this.cmbAircraftType.Properties.ValueMember = "Id";
            this.cmbAircraftType.Size = new System.Drawing.Size(139, 20);
            this.cmbAircraftType.StyleController = this.dataLayoutControl1;
            this.cmbAircraftType.TabIndex = 7;
            // 
            // bsAircraftType
            // 
            this.bsAircraftType.DataSource = typeof(DXAirways.Business.Orm.AircraftType);
            // 
            // txtTailNumber
            // 
            this.txtTailNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "TailNumber", true));
            this.txtTailNumber.Location = new System.Drawing.Point(88, 38);
            this.txtTailNumber.Name = "txtTailNumber";
            this.txtTailNumber.Size = new System.Drawing.Size(139, 20);
            this.txtTailNumber.StyleController = this.dataLayoutControl1;
            this.txtTailNumber.TabIndex = 8;
            // 
            // txtEngineMiles
            // 
            this.txtEngineMiles.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "EngineMiles", true));
            this.txtEngineMiles.Location = new System.Drawing.Point(88, 69);
            this.txtEngineMiles.Name = "txtEngineMiles";
            this.txtEngineMiles.Size = new System.Drawing.Size(139, 20);
            this.txtEngineMiles.StyleController = this.dataLayoutControl1;
            this.txtEngineMiles.TabIndex = 9;
            // 
            // InServiceCheckEdit
            // 
            this.InServiceCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "InService", true));
            this.InServiceCheckEdit.Location = new System.Drawing.Point(88, 100);
            this.InServiceCheckEdit.Name = "InServiceCheckEdit";
            this.InServiceCheckEdit.Properties.Caption = "In Service";
            this.InServiceCheckEdit.Size = new System.Drawing.Size(139, 19);
            this.InServiceCheckEdit.TabIndex = 10;
            // 
            // DateOfServiceDateEdit
            // 
            this.DateOfServiceDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "DateOfService", true));
            this.DateOfServiceDateEdit.EditValue = null;
            this.DateOfServiceDateEdit.Location = new System.Drawing.Point(88, 130);
            this.DateOfServiceDateEdit.Name = "DateOfServiceDateEdit";
            this.DateOfServiceDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateOfServiceDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateOfServiceDateEdit.Size = new System.Drawing.Size(139, 20);
            this.DateOfServiceDateEdit.TabIndex = 11;
            // 
            // MilesAtServiceTextEdit
            // 
            this.MilesAtServiceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "MilesAtService", true));
            this.MilesAtServiceTextEdit.Location = new System.Drawing.Point(88, 161);
            this.MilesAtServiceTextEdit.Name = "MilesAtServiceTextEdit";
            this.MilesAtServiceTextEdit.Size = new System.Drawing.Size(139, 20);
            this.MilesAtServiceTextEdit.TabIndex = 12;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "HomeAirport!", true));
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(0, 20);
            this.textEdit1.TabIndex = 13;
            // 
            // cmbHomeAirport
            // 
            this.cmbHomeAirport.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAircraft, "HomeAirport!Key", true));
            this.cmbHomeAirport.Location = new System.Drawing.Point(88, 192);
            this.cmbHomeAirport.Name = "cmbHomeAirport";
            this.cmbHomeAirport.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbHomeAirport.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbHomeAirport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHomeAirport.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AirportCode", "Airport Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityState", "Location")});
            this.cmbHomeAirport.Properties.DataSource = this.bsAirport;
            this.cmbHomeAirport.Properties.DisplayMember = "DisplayCaption";
            this.cmbHomeAirport.Properties.NullText = "";
            this.cmbHomeAirport.Properties.NullValuePrompt = "Select a home airport";
            this.cmbHomeAirport.Properties.ValueMember = "Id";
            this.cmbHomeAirport.Size = new System.Drawing.Size(139, 20);
            this.cmbHomeAirport.TabIndex = 14;
            // 
            // bsAirport
            // 
            this.bsAirport.DataSource = typeof(DXAirways.Business.Orm.Airport);
            // 
            // ItemForThis
            // 
            this.ItemForThis.Control = this.ThisTextEdit;
            this.ItemForThis.CustomizationFormText = "This";
            this.ItemForThis.Location = new System.Drawing.Point(0, 0);
            this.ItemForThis.Name = "ItemForThis";
            this.ItemForThis.Size = new System.Drawing.Size(0, 0);
            this.ItemForThis.Text = "This";
            this.ItemForThis.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForThis.TextSize = new System.Drawing.Size(50, 20);
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.CustomizationFormText = "Id";
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(0, 0);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForId.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Aircraft Type";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "ItemForAircraftType!";
            this.layoutControlItem1.Size = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.Text = "Aircraft Type";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit1;
            this.layoutControlItem3.CustomizationFormText = "Home Airport";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "ItemForHomeAirport!";
            this.layoutControlItem3.Size = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.Text = "Home Airport";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.ItemForTailNumber,
            this.ItemForEngineMiles,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(233, 219);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbAircraftType;
            this.layoutControlItem2.CustomizationFormText = "Aircraft Type";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "ItemForAircraftType!Key";
            this.layoutControlItem2.Size = new System.Drawing.Size(231, 31);
            this.layoutControlItem2.Text = "Aircraft Type";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForTailNumber
            // 
            this.ItemForTailNumber.Control = this.txtTailNumber;
            this.ItemForTailNumber.CustomizationFormText = "Tail Number";
            this.ItemForTailNumber.Location = new System.Drawing.Point(0, 31);
            this.ItemForTailNumber.Name = "ItemForTailNumber";
            this.ItemForTailNumber.Size = new System.Drawing.Size(231, 31);
            this.ItemForTailNumber.Text = "Tail Number";
            this.ItemForTailNumber.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForTailNumber.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForEngineMiles
            // 
            this.ItemForEngineMiles.Control = this.txtEngineMiles;
            this.ItemForEngineMiles.CustomizationFormText = "Engine Miles";
            this.ItemForEngineMiles.Location = new System.Drawing.Point(0, 62);
            this.ItemForEngineMiles.Name = "ItemForEngineMiles";
            this.ItemForEngineMiles.Size = new System.Drawing.Size(231, 31);
            this.ItemForEngineMiles.Text = "Engine Miles";
            this.ItemForEngineMiles.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForEngineMiles.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForInService,
            this.ItemForDateOfService,
            this.ItemForMilesAtService,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 93);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(231, 124);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            // 
            // ItemForInService
            // 
            this.ItemForInService.Control = this.InServiceCheckEdit;
            this.ItemForInService.CustomizationFormText = "In Service";
            this.ItemForInService.Location = new System.Drawing.Point(0, 0);
            this.ItemForInService.Name = "ItemForInService";
            this.ItemForInService.Size = new System.Drawing.Size(231, 30);
            this.ItemForInService.Text = "In Service";
            this.ItemForInService.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForInService.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForDateOfService
            // 
            this.ItemForDateOfService.Control = this.DateOfServiceDateEdit;
            this.ItemForDateOfService.CustomizationFormText = "Date Of Service";
            this.ItemForDateOfService.Location = new System.Drawing.Point(0, 30);
            this.ItemForDateOfService.Name = "ItemForDateOfService";
            this.ItemForDateOfService.Size = new System.Drawing.Size(231, 31);
            this.ItemForDateOfService.Text = "Date Of Service";
            this.ItemForDateOfService.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForDateOfService.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForMilesAtService
            // 
            this.ItemForMilesAtService.Control = this.MilesAtServiceTextEdit;
            this.ItemForMilesAtService.CustomizationFormText = "Miles At Service";
            this.ItemForMilesAtService.Location = new System.Drawing.Point(0, 61);
            this.ItemForMilesAtService.Name = "ItemForMilesAtService";
            this.ItemForMilesAtService.Size = new System.Drawing.Size(231, 31);
            this.ItemForMilesAtService.Text = "Miles At Service";
            this.ItemForMilesAtService.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForMilesAtService.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbHomeAirport;
            this.layoutControlItem4.CustomizationFormText = "Home Airport";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem4.Name = "ItemForHomeAirport!Key";
            this.layoutControlItem4.Size = new System.Drawing.Size(231, 32);
            this.layoutControlItem4.Text = "Home Airport";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(76, 13);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AircraftMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 242);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "AircraftMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AircraftMaint";
            ((System.ComponentModel.ISupportInitialize)(this.bsAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcolAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThisTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAircraftType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAircraftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTailNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEngineMiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InServiceCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfServiceDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfServiceDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilesAtServiceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHomeAirport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAirport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForThis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTailNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEngineMiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateOfService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMilesAtService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaveNew;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource bsAircraft;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpcolAircraft;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit ThisTextEdit;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtTailNumber;
        private DevExpress.XtraEditors.TextEdit txtEngineMiles;
        private DevExpress.XtraLayout.LayoutControlItem ItemForThis;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTailNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEngineMiles;
        private System.Windows.Forms.BindingSource bsAircraftType;
        private DevExpress.XtraEditors.LookUpEdit cmbAircraftType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit InServiceCheckEdit;
        private DevExpress.XtraEditors.DateEdit DateOfServiceDateEdit;
        private DevExpress.XtraEditors.TextEdit MilesAtServiceTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit cmbHomeAirport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInService;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDateOfService;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMilesAtService;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bsAirport;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}