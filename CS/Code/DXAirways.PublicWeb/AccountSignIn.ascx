<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountSignIn.ascx.cs" Inherits="DXAirways.Web.AccountSignIn" %>
<asp:Login ID="secLogin" runat="server" 
    CreateUserText="Register as a new customer" 
    CreateUserUrl="~/CustomerRegistration.aspx" 
    TextLayout="TextOnTop">
</asp:Login>
