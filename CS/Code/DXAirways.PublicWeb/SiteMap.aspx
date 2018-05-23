<%@ Page Title="" Language="C#" MasterPageFile="~/DXAirways.Master" AutoEventWireup="true" CodeBehind="SiteMap.aspx.cs" Inherits="DXAirways.Web.SiteMap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <dxsm:ASPxSiteMapControl ID="navSiteMap" runat="server">
    </dxsm:ASPxSiteMapControl>
</asp:Content>
