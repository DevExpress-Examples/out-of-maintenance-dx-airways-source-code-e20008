<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountSummary.ascx.cs" Inherits="DXAirways.Web.AccountSummary" %>
<table class="" style="width=100%">
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="DX Miles Number:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxLabel runat="server" ID="lblMilesNumber" Text="">
            </dxe:ASPxLabel>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="Mileage Balance:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxLabel runat="server" ID="lblMilesBalance" Text="">
            </dxe:ASPxLabel>
        </td>
    </tr>
    <tr class="">
        <td colspan="2" align="right">
            <dxe:ASPxHyperLink ID="lnkAccountDetail" runat="server" 
                Text="Account Details" />
        </td>
    </tr>
</table>
