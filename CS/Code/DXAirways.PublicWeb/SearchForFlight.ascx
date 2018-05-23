<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchForFlight.ascx.cs" Inherits="DXAirways.Web.SearchForFlight" %>
<script language="javascript" type="text/javascript">
    function UpdateAirportText(airportType, airportCode) {
        if (airportType == 'origin') {
            flightOrigin.SetText(airportCode);
            originCallback.PerformCallback(airportCode);
            flightOrigin.SetCaretPosition(airportCode.length);
        }
        else {
            flightDestination.SetText(airportCode);
            destinationCallback.PerformCallback(airportCode);
            flightDestination.SetCaretPosition(airportCode.length);
        }
    }
</script>
<table>
    <tr>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel1" runat="server" 
                Text="From:" />
            <br />
            <dxe:ASPxLabel ID="ASPxLabel3" runat="server" 
                Text="(airport code or press ...)" Font-Italic="True" />
            <br />
            <dxe:ASPxButtonEdit ID="txtOrigin" runat="server" 
                ClientInstanceName="flightOrigin" EnableClientSideAPI="True" Width="100px">
                <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorText="" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="Airport of origin required" IsRequired="True" />
                </ValidationSettings>
                <Buttons>
                    <dxe:EditButton>
                    </dxe:EditButton>
                </Buttons>
                <ClientSideEvents ButtonClick="function(s, e)
{
	airportLookupPopup.SetHeaderText('Airport Lookup for airport of origin');
    airportLookupPopup.SetContentUrl('AirportLookup.aspx?airport=origin');
	airportLookupPopup.ShowAtElement(flightOrigin.GetMainElement());
}
" TextChanged="function(s, e) {
	s.SetText(s.GetText().toUpperCase());
	originCallback.PerformCallback(s.GetText());
}" />
            </dxe:ASPxButtonEdit>
            <dxe:ASPxLabel ID="lblOrigin" runat="server" 
                ClientInstanceName="origin" EnableClientSideAPI="True" 
                EncodeHtml="False" />
            <br />
            <br />
        </td>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel2" runat="server" 
                Text="To:" />
            <br />
            <dxe:ASPxLabel ID="ASPxLabel4" runat="server" 
                Text="(airport code or press ...)" Font-Italic="True" />
            <br />
            <dxe:ASPxButtonEdit ID="txtDestination" runat="server" 
                ClientInstanceName="flightDestination" Width="100px">
                <ValidationSettings CausesValidation="True" Display="Dynamic" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="Destination airport required" IsRequired="True" />
                </ValidationSettings>
                <Buttons>
                    <dxe:EditButton>
                    </dxe:EditButton>
                </Buttons>
                <ClientSideEvents ButtonClick="function(s, e)
{
	airportLookupPopup.SetHeaderText('Airport Lookup for airport of destination');
    airportLookupPopup.SetContentUrl('AirportLookup.aspx?airport=destination');
	airportLookupPopup.ShowAtElement(flightDestination.GetMainElement());
}
" TextChanged="function(s, e) {
	s.SetText(s.GetText().toUpperCase());
	destinationCallback.PerformCallback(s.GetText());
}" />
            </dxe:ASPxButtonEdit>
            <dxe:ASPxLabel ID="lblDestination" runat="server" 
                ClientInstanceName="destination" EnableClientSideAPI="True" 
                EncodeHtml="False" />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel5" runat="server" Text="Depart Date:" />
            <br />
            <dxe:ASPxDateEdit ID="dteDepartDate" runat="server" Width="150px" >
                <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorText="" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="Departure date required" IsRequired="True" />
                </ValidationSettings>
            </dxe:ASPxDateEdit>
            <br />
        </td>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel6" runat="server" Text="Time:" />
            <br />
            <dxe:ASPxComboBox ID="cmbDepartTime" runat="server" DataSourceID="dsTimeSlots" 
                TextField="Label" ValueField="Label" ValueType="System.String" 
                Width="150px" >
                <ValidationSettings CausesValidation="True" Display="Dynamic" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="Departure time required" IsRequired="True" />
                </ValidationSettings>
            </dxe:ASPxComboBox>
            <br />
        </td>
    </tr>
    <tr>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel7" runat="server" Text="Return Date:" />
            <br />
            <dxe:ASPxDateEdit ID="dteReturnDate" runat="server" Width="150px" >
                <ValidationSettings CausesValidation="True" Display="Dynamic" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="Return date required" IsRequired="True" />
                </ValidationSettings>
            </dxe:ASPxDateEdit>
            <br />
        </td>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel8" runat="server" Text="Time:" />
            <br />
            <dxe:ASPxComboBox ID="cmbReturnTime" runat="server" DataSourceID="dsTimeSlots" 
                TextField="Label" ValueField="Label" ValueType="System.String" 
                Width="150px" >
                <ValidationSettings CausesValidation="True" Display="Dynamic" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="Return time required" IsRequired="True" />
                </ValidationSettings>
            </dxe:ASPxComboBox>
            <br />
        </td>
    </tr>
    <tr>
        <td valign="top">
            <dxe:ASPxLabel ID="ASPxLabel9" runat="server" Text="Passengers:" />
            <br />
            <dxe:ASPxComboBox ID="cmbPassengers" runat="server" Width="75px" >
                <ValidationSettings CausesValidation="True" Display="Dynamic" 
                    ErrorTextPosition="Bottom" SetFocusOnError="True">
                    <RequiredField ErrorText="# of passengers required" IsRequired="True" />
                </ValidationSettings>
            </dxe:ASPxComboBox>
            <br />
        </td>
        <td valign="top">
        </td>
    </tr>
    <tr>
        <td valign="top" colspan="2">
            <dxe:ASPxLabel ID="ASPxLabel10" runat="server" Text="Cabin:" />
            <br />
            <dxe:ASPxRadioButtonList ID="optCabin" runat="server" ItemSpacing="20px" 
                RepeatDirection="Horizontal" SelectedIndex="0">
                <Border BorderStyle="None" />
                <Items>
                    <dxe:ListEditItem Text="Economy" Value="Economy" />
                    <dxe:ListEditItem Text="Business/First" Value="FirstClass" />
                </Items>
            </dxe:ASPxRadioButtonList>     
            <br />       
        </td>
    </tr>
    <tr>
        <td colspan="2" align="right" valign="top">
            <dxe:ASPxButton ID="btnSearch" runat="server" Text="Search For Flights" 
                Width="125px" onclick="btnSearch_Click" UseSubmitBehavior="False">
            </dxe:ASPxButton>
        </td>
    </tr>
</table>
<dxpc:ASPxPopupControl ID="ctlAirportLookupPopup" runat="server" 
    AllowDragging="True" ClientInstanceName="airportLookupPopup" 
    HeaderText="Airport Lookup" Height="387px" Width="350px" 
    PopupAction="None" PopupHorizontalAlign="LeftSides" 
    PopupVerticalAlign="Below">
    <ContentCollection>
<dxpc:PopupControlContentControl runat="server"></dxpc:PopupControlContentControl>
</ContentCollection>
</dxpc:ASPxPopupControl>
<dxcb:ASPxCallback ID="originCallback" runat="server" ClientInstanceName="originCallback" 
    oncallback="ctlAirportCallback_Callback">
    <ClientSideEvents CallbackComplete="function(s, e) {
	if (e.result == '')
	{
		flightOrigin.SetText('');
		origin.SetText('&lt;br/&gt;');
	}
	else
		origin.SetText(e.result);
}" />
</dxcb:ASPxCallback>
<dxcb:ASPxCallback ID="destinationCallback" runat="server" 
    ClientInstanceName="destinationCallback" 
    oncallback="ctlAirportCallback_Callback">
    <ClientSideEvents CallbackComplete="function(s, e) {
	if (e.result == '')
	{
		flightDestination.SetText('');
		destination.SetText('&lt;br/&gt;');
	}
	else
		destination.SetText(e.result);
}" />
</dxcb:ASPxCallback>
<asp:ObjectDataSource ID="dsTimeSlots" runat="server" 
    SelectMethod="GetFlightSearchTimeSlots" TypeName="DXAirways.Business.TimeSlots">
</asp:ObjectDataSource>
