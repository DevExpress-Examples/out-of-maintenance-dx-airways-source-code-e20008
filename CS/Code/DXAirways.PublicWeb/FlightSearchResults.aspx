<%@ Page Title="" Language="C#" MasterPageFile="~/DXAirways.Master" AutoEventWireup="true" CodeBehind="FlightSearchResults.aspx.cs" Inherits="DXAirways.Web.FlightSearchResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">

    <dxrp:ASPxRoundPanel ID="pnlSelectedFlight" runat="server" Width="100%" 
        Visible="False" HeaderText="Selected Departure Flight">
        <PanelCollection>
<dxp:PanelContent runat="server">
    <asp:PlaceHolder ID="phSelectedFlight" runat="server"></asp:PlaceHolder>
            </dxp:PanelContent>
</PanelCollection>
    </dxrp:ASPxRoundPanel>
    
    <dxcp:ASPxCallbackPanel ID="ctlResultsPanel" runat="server" Width="100%" 
        ClientInstanceName="searchResultsPanel" 
        oncallback="ctlResultsPanel_Callback">
        <PanelCollection>
<dxp:PanelContent ID="PanelContent1" runat="server">
    <br />
    <dxp:ASPxPanel ID="pnlResults" runat="server" Visible="False" Width="706px" 
        Height="80px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <dxe:ASPxLabel ID="lblTest" runat="server" 
                    Text="These are the flight search results">
                </dxe:ASPxLabel>
                <br />
                <br />
            </dxp:PanelContent>
        </PanelCollection>
    </dxp:ASPxPanel>
            </dxp:PanelContent>
</PanelCollection>
        <ClientSideEvents Init="function(s, e) {
	searchResultsPanel.PerformCallback('test string');
}" />
    </dxcp:ASPxCallbackPanel>
    <dxlp:ASPxLoadingPanel ID="ctlLoading" runat="server" 
        ContainerElementID="searchResultsPanel" 
        Text="Searching for available flights&amp;hellip;">
    </dxlp:ASPxLoadingPanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphFooter" runat="server">
</asp:Content>
