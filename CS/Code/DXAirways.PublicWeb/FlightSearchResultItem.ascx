<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FlightSearchResultItem.ascx.cs" Inherits="DXAirways.Web.FlightSearchResultItem" %>

<table style="width: 100%; height: 80px;">
    <tr>
        <td style="vertical-align: top; text-align: center;">
            <dxe:ASPxLabel ID="lblFare" runat="server" Text="$258" />
            <br />
            <dxe:ASPxHyperLink ID="lnkSelect" runat="server" Text="Select Flight" />            
        </td>
        <td style="vertical-align: top; text-align: left;">
            <dxe:ASPxLabel ID="ASPxLabel1" runat="server" Text="Depart:" />
            <br />
            <dxe:ASPxLabel ID="lblDepartTime" runat="server" />
            <br />
            <dxe:ASPxLabel ID="lblDepartDate" runat="server" />
            <br />
            <dxe:ASPxLabel ID="lblDeparture" runat="server" />
        </td>
        <td style="vertical-align: top; text-align: left;">
            <dxe:ASPxLabel ID="ASPxLabel2" runat="server" Text="Arrive:" />
            <br />
            <dxe:ASPxLabel ID="lblArrivalTime" runat="server" />
            <br />
            <dxe:ASPxLabel ID="lblArrivalDate" runat="server" />
            <br />
            <dxe:ASPxLabel ID="lblArrival" runat="server" />
        </td>
        <td style="vertical-align: top; text-align: left;">
            <dxe:ASPxLabel ID="ASPxLabel3" runat="server" Text="Travel Time:" />
            <br />
            <dxe:ASPxLabel ID="lblTravelTime" runat="server" />
        </td>
        <td style="vertical-align: top; text-align: left;">
            <dxe:ASPxLabel ID="ASPxLabel4" runat="server" Text="DX Miles:" />
            <br />
            <dxe:ASPxLabel ID="lblDXMiles" runat="server" />
        </td>
        <td style="vertical-align: top; text-align: left;">
            <dxe:ASPxLabel ID="ASPxLabel5" runat="server" Text="Flight: " />
            <dxe:ASPxLabel ID="lblFlightNumber" runat="server"/>
            <br />
            <dxe:ASPxLabel ID="ASPxLabel7" runat="server" Text="Aircraft: " />
            <dxe:ASPxLabel ID="lblAircraft" runat="server"/>
            <br />
            <dxe:ASPxLabel ID="ASPxLabel6" runat="server" Text="Meal: " />
            <dxe:ASPxLabel ID="lblMeal" runat="server"/>
            <br />
            <dxe:ASPxHyperLink ID="lnkViewSeats" runat="server" Text="View Seats" />            
        </td>
    </tr>
</table>

