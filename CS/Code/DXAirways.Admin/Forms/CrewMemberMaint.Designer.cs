namespace DXAirways.Windows.Forms
{
    partial class CrewMemberMaint
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label label1;
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.bsCrewMember = new System.Windows.Forms.BindingSource(this.components);
            this.bsAirport = new System.Windows.Forms.BindingSource(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCrewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(113, 51);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(62, 13);
            firstNameLabel.TabIndex = 18;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(114, 77);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 19;
            lastNameLabel.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(114, 217);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 13);
            label1.TabIndex = 21;
            label1.Text = "Home Airport:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(202, 214);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AirportCode", "Airport Code", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Airport Name")});
            this.lookUpEdit1.Properties.DataSource = this.bsAirport;
            this.lookUpEdit1.Properties.DisplayMember = "DisplayCaption";
            this.lookUpEdit1.Properties.ValueMember = "Id";
            this.lookUpEdit1.Size = new System.Drawing.Size(200, 20);
            this.lookUpEdit1.TabIndex = 17;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(373, 298);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCrewMember, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(202, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCrewMember, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(202, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // bsCrewMember
            // 
            this.bsCrewMember.DataSource = typeof(DXAirways.Business.Orm.CrewMember);
            // 
            // bsAirport
            // 
            this.bsAirport.DataSource = typeof(DXAirways.Business.Orm.Airport);
            // 
            // CrewMemberMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 594);
            this.Controls.Add(label1);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lookUpEdit1);
            this.Name = "CrewMemberMaint";
            this.Text = "Crew Member Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCrewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAirport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource bsAirport;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private System.Windows.Forms.BindingSource bsCrewMember;
    }
}