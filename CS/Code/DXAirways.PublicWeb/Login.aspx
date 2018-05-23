<%@ Page Title="" Language="C#" MasterPageFile="~/DXAirways.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DXAirways.Web.Login" %>
<%@ Register src="AccountSignIn.ascx" tagname="AccountSignIn" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <uc1:AccountSignIn ID="AccountSignIn1" runat="server" />
</asp:Content>
