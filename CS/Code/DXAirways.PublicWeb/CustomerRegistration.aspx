<%@ Page Title="" Language="C#" MasterPageFile="~/DXAirways.Master" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="DXAirways.Web.CustomerRegistration" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <table class="">
        <tr class="">
            <td colspan="3">
                <asp:ValidationSummary ID="fvSummary" runat="server" 
                    ValidationGroup="registration" />
            </td>
        </tr>
        <tr class="">
            <td>
                <dxe:ASPxLabel runat="server" Text="First name:">
                </dxe:ASPxLabel>
            </td>
            <td>
                <dxe:ASPxTextBox runat="server" Width="170px" ID="txtFirstName">
                </dxe:ASPxTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="fvFirstNameReq" runat="server" 
                    ErrorMessage="First Name required" ControlToValidate="txtFirstName" 
                    ValidationGroup="registration" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="">
            <td>
                <dxe:ASPxLabel runat="server" Text="Last name:">
                </dxe:ASPxLabel>                
            </td>
            <td>
                <dxe:ASPxTextBox runat="server" Width="170px" ID="txtLastName">
                </dxe:ASPxTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="fvLastNameReq" runat="server" 
                    ErrorMessage="Last Name required" ControlToValidate="txtLastName" 
                    ValidationGroup="registration" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="">
            <td class="style1">
                <dxe:ASPxLabel runat="server" Text="Email:">
                </dxe:ASPxLabel>
            </td>
            <td class="style1">
                <dxe:ASPxTextBox runat="server" Width="170px" ID="txtEmail">
                </dxe:ASPxTextBox>
            </td>
            <td class="style1">
                <asp:RequiredFieldValidator ID="fvEmailReq" runat="server" 
                    ErrorMessage="Email required" ControlToValidate="txtEmail" 
                    ValidationGroup="registration" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="fvEmailRegEx" runat="server" 
                    ErrorMessage="Invalid Email format" Display="None" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ControlToValidate="txtEmail" ValidationGroup="registration"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr class="">
            <td>
                <dxe:ASPxLabel runat="server" Text="Password:">
                </dxe:ASPxLabel>
            </td>
            <td>
                <dxe:ASPxTextBox runat="server" Width="170px" ID="txtPassword" Password="True">
                </dxe:ASPxTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="fvPasswordReq" runat="server" 
                    ErrorMessage="Password required" ControlToValidate="txtPassword" 
                    ValidationGroup="registration" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="">
            <td>
                <dxe:ASPxLabel runat="server" Text="Confirm password:">
                </dxe:ASPxLabel>
            </td>
            <td>
                <dxe:ASPxTextBox runat="server" Width="170px" ID="txtPasswordConfirm" 
                    Password="True">
                </dxe:ASPxTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="fvPasswordConfirmReq" runat="server" 
                    ErrorMessage="Password confirmation required" ControlToValidate="txtPasswordConfirm" 
                    ValidationGroup="registration" Display="None"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="fvPasswordCompare" runat="server" 
                    ErrorMessage="Passwords do not match" ControlToCompare="txtPassword" 
                    ControlToValidate="txtPasswordConfirm" Display="None" 
                    ValidationGroup="registration"></asp:CompareValidator>
            </td>
        </tr>
        <tr class="">
            <td align="right" colspan="2">
                <asp:LinkButton ID="lnkSubmit" runat="server" onclick="lnkSubmit_Click" 
                    ValidationGroup="registration">Submit customer registration</asp:LinkButton>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
