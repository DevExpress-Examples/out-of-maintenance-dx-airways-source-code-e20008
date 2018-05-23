<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressMaint.ascx.cs" Inherits="DXAirways.Web.AddressMaint" %>
<table class="">
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="Address Type:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtAddressType">
            </dxe:ASPxTextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="fvAddressType" runat="server" 
                ErrorMessage="Address Type required" ControlToValidate="txtAddressType" 
                ValidationGroup="address" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="Address 1:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtAddress1">
            </dxe:ASPxTextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="fvAddress1" runat="server" 
                ErrorMessage="Address 1 required" ControlToValidate="txtAddress1" 
                ValidationGroup="address" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="Address 2:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtAddress2">
            </dxe:ASPxTextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="City:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtCity">
            </dxe:ASPxTextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="fvCity" runat="server" 
                ErrorMessage="City required" ControlToValidate="txtCity" 
                ValidationGroup="address" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="State/Province:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtState">
            </dxe:ASPxTextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="fvState" runat="server" 
                ErrorMessage="State/Province required" ControlToValidate="txtState" 
                ValidationGroup="address" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="Postal Code:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtPostalCode">
            </dxe:ASPxTextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="fvPostalCode" runat="server" 
                ErrorMessage="Postal Code required" ControlToValidate="txtPostalCode" 
                ValidationGroup="address" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="">
        <td>
            <dxe:ASPxLabel runat="server" Text="Country:">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox runat="server" Width="170px" ID="txtCountry">
            </dxe:ASPxTextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="fvCountry" runat="server" 
                ErrorMessage="Country required" ControlToValidate="txtCountry" 
                ValidationGroup="address" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
</table>
