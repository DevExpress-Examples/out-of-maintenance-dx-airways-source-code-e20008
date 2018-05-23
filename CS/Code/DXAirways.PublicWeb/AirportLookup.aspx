<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AirportLookup.aspx.cs" Inherits="DXAirways.Web.AirportLookup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return false;">
        <script language="javascript" type="text/javascript">
            function ReturnValue(airportCode) {
                var query = location.search;
                var airportType = query.substring(query.indexOf('airport=') + 8, query.length); // query.indexOf('&')
                var parentWindow = window.parent;
                parentWindow.UpdateAirportText(airportType, airportCode);
                parentWindow.airportLookupPopup.Hide();
            }
        </script>
        <table style="width: 300px">
            <tr>
                <td>
                    <dxe:ASPxLabel ID="ASPxLabel1" runat="server" 
                        Text="Enter a state abbrev. or enough letters<br/>to identify a city:" 
                        EncodeHtml="False">
                    </dxe:ASPxLabel>
                </td>
            </tr>
            <tr>
                <td>
                    <dxe:ASPxTextBox ID="txtLookup" runat="server" ClientInstanceName="lookupText" 
                        EnableClientSideAPI="True" Width="300px">
                        <ClientSideEvents KeyPress="function(s, e) {
	if (e.htmlEvent.keyCode == 13)
		searchButton.DoClick();
}" Init="function(s, e) {
	s.Focus();
}" />
                    </dxe:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <dxe:ASPxButton ID="btnLookup" runat="server" AutoPostBack="False" 
                        ClientInstanceName="searchButton" EnableClientSideAPI="True" 
                        Text="Lookup Airports" Width="118px" UseSubmitBehavior="False">
                        <ClientSideEvents Click="function(s, e) {
	resultsPanel.PerformCallback(lookupText.GetText());
}" />
                    </dxe:ASPxButton>
                </td>
            </tr>
        </table>
        <br />
        <dxcp:ASPxCallbackPanel ID="ctlResultsPanel" runat="server" Width="300px" 
            ClientInstanceName="resultsPanel" oncallback="ctlResultsPanel_Callback">
            <PanelCollection>
                <dxrp:PanelContent>
                    <dxrp:ASPxRoundPanel ID="pnlLookupResults" runat="server" Width="100%" 
                        HeaderText="Lookup Results" Visible="False">                   
                        <PanelCollection>
                            <dxp:PanelContent runat="server">
                                <div style="height:150px; overflow-y:auto; overflow-x: hidden;">
                                    <asp:PlaceHolder ID="phAirportList" runat="server"></asp:PlaceHolder>
                                </div>
                            </dxp:PanelContent>
                        </PanelCollection>
                    </dxrp:ASPxRoundPanel>
                </dxrp:PanelContent>
            </PanelCollection>
        </dxcp:ASPxCallbackPanel>
        <dxlp:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server">
        </dxlp:ASPxLoadingPanel>
    </form>
</body>
</html>
