namespace DXAirways.Windows.Forms
{
    partial class DXAirwaysMain
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
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.ngrpFlights = new DevExpress.XtraNavBar.NavBarGroup();
            this.nitmAirports = new DevExpress.XtraNavBar.NavBarItem();
            this.nitmCityPairs = new DevExpress.XtraNavBar.NavBarItem();
            this.nitmFlights = new DevExpress.XtraNavBar.NavBarItem();
            this.ngrpEquipment = new DevExpress.XtraNavBar.NavBarGroup();
            this.nitmAircraftTypes = new DevExpress.XtraNavBar.NavBarItem();
            this.nitmAircraft = new DevExpress.XtraNavBar.NavBarItem();
            this.ngrpPersonnel = new DevExpress.XtraNavBar.NavBarGroup();
            this.nitmCrew = new DevExpress.XtraNavBar.NavBarItem();
            this.nitmCustomers = new DevExpress.XtraNavBar.NavBarItem();
            this.ngrpMisc = new DevExpress.XtraNavBar.NavBarGroup();
            this.ngrpHelp = new DevExpress.XtraNavBar.NavBarGroup();
            this.nitmHelp = new DevExpress.XtraNavBar.NavBarItem();
            this.nitmExit = new DevExpress.XtraNavBar.NavBarItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // navMain
            // 
            this.navMain.ActiveGroup = this.ngrpFlights;
            this.navMain.ContentButtonHint = null;
            this.navMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.ngrpFlights,
            this.ngrpEquipment,
            this.ngrpPersonnel,
            this.ngrpMisc,
            this.ngrpHelp});
            this.navMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nitmFlights,
            this.nitmCrew,
            this.nitmCustomers,
            this.nitmHelp,
            this.nitmExit,
            this.nitmAircraft,
            this.nitmAircraftTypes,
            this.nitmCityPairs,
            this.nitmAirports});
            this.navMain.Location = new System.Drawing.Point(0, 72);
            this.navMain.Name = "navMain";
            this.navMain.OptionsNavPane.ExpandedWidth = 196;
            this.navMain.Size = new System.Drawing.Size(268, 465);
            this.navMain.TabIndex = 0;
            this.navMain.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Lilian");
            this.navMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMain_LinkClicked);
            // 
            // ngrpFlights
            // 
            this.ngrpFlights.Caption = "Flights";
            this.ngrpFlights.Expanded = true;
            this.ngrpFlights.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmAirports),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmCityPairs),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmFlights)});
            this.ngrpFlights.Name = "ngrpFlights";
            // 
            // nitmAirports
            // 
            this.nitmAirports.Caption = "Airports (Cities)";
            this.nitmAirports.Hint = "Maintain the list of airports serviced by DX Airways";
            this.nitmAirports.Name = "nitmAirports";
            this.nitmAirports.Tag = "airports";
            // 
            // nitmCityPairs
            // 
            this.nitmCityPairs.Caption = "City-Pairs";
            this.nitmCityPairs.Name = "nitmCityPairs";
            this.nitmCityPairs.Tag = "city-pairs";
            // 
            // nitmFlights
            // 
            this.nitmFlights.Caption = "Flights";
            this.nitmFlights.Hint = "View or maintain all DX Airways flights";
            this.nitmFlights.Name = "nitmFlights";
            this.nitmFlights.Tag = "flights";
            // 
            // ngrpEquipment
            // 
            this.ngrpEquipment.Caption = "Equipment";
            this.ngrpEquipment.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmAircraftTypes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmAircraft)});
            this.ngrpEquipment.Name = "ngrpEquipment";
            // 
            // nitmAircraftTypes
            // 
            this.nitmAircraftTypes.Caption = "Aircraft Types";
            this.nitmAircraftTypes.Name = "nitmAircraftTypes";
            this.nitmAircraftTypes.Tag = "aircraft-types";
            // 
            // nitmAircraft
            // 
            this.nitmAircraft.Caption = "Aircraft";
            this.nitmAircraft.Hint = "View or maintain DX Airways aircraft";
            this.nitmAircraft.Name = "nitmAircraft";
            this.nitmAircraft.Tag = "aircraft";
            // 
            // ngrpPersonnel
            // 
            this.ngrpPersonnel.Caption = "Personnel";
            this.ngrpPersonnel.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmCrew),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmCustomers)});
            this.ngrpPersonnel.Name = "ngrpPersonnel";
            // 
            // nitmCrew
            // 
            this.nitmCrew.Caption = "Crew Members";
            this.nitmCrew.Hint = "View or maintain all DX Airways crew members";
            this.nitmCrew.Name = "nitmCrew";
            this.nitmCrew.Tag = "crew";
            // 
            // nitmCustomers
            // 
            this.nitmCustomers.Caption = "Customers";
            this.nitmCustomers.Hint = "View DX Airways customer information";
            this.nitmCustomers.Name = "nitmCustomers";
            this.nitmCustomers.Tag = "customers";
            // 
            // ngrpMisc
            // 
            this.ngrpMisc.Caption = "Miscellaneous";
            this.ngrpMisc.Name = "ngrpMisc";
            // 
            // ngrpHelp
            // 
            this.ngrpHelp.Caption = "Help";
            this.ngrpHelp.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmHelp),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nitmExit)});
            this.ngrpHelp.Name = "ngrpHelp";
            // 
            // nitmHelp
            // 
            this.nitmHelp.Caption = "Help";
            this.nitmHelp.Hint = "Get help with this administration application";
            this.nitmHelp.Name = "nitmHelp";
            this.nitmHelp.Tag = "help";
            // 
            // nitmExit
            // 
            this.nitmExit.Caption = "Exit";
            this.nitmExit.Hint = "Exit the DX Airways administrator application";
            this.nitmExit.Name = "nitmExit";
            this.nitmExit.Tag = "exit";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::DXAirways.Windows.Properties.Resources.DXairways_SharpWings_Duotone_version2;
            this.picLogo.Location = new System.Drawing.Point(0, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(268, 63);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // DXAirwaysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 535);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.navMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DXAirwaysMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DX Airways Administrator";
            this.Load += new System.EventHandler(this.DXAirwaysMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navMain;
        private DevExpress.XtraNavBar.NavBarGroup ngrpFlights;
        private DevExpress.XtraNavBar.NavBarGroup ngrpPersonnel;
        private DevExpress.XtraNavBar.NavBarGroup ngrpHelp;
        private DevExpress.XtraNavBar.NavBarItem nitmFlights;
        private DevExpress.XtraNavBar.NavBarItem nitmCrew;
        private DevExpress.XtraNavBar.NavBarItem nitmCustomers;
        private DevExpress.XtraNavBar.NavBarItem nitmHelp;
        private DevExpress.XtraNavBar.NavBarItem nitmExit;
        private DevExpress.XtraNavBar.NavBarItem nitmAircraft;
        private System.Windows.Forms.PictureBox picLogo;
        private DevExpress.XtraNavBar.NavBarGroup ngrpMisc;
        private DevExpress.XtraNavBar.NavBarItem nitmAircraftTypes;
        private DevExpress.XtraNavBar.NavBarGroup ngrpEquipment;
        private DevExpress.XtraNavBar.NavBarItem nitmAirports;
        private DevExpress.XtraNavBar.NavBarItem nitmCityPairs;
    }
}