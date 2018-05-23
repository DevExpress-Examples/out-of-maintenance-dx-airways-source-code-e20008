<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="DXAirways.Web.TestPage" %>

<%@ Register src="SearchForFlight.ascx" tagname="SearchForFlight" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <uc1:SearchForFlight ID="SearchForFlight1" runat="server" />

    <br />
    <dxe:ASPxLabel ID="lblResults" runat="server">
    </dxe:ASPxLabel>

    <br />
    <br />
    <dxe:ASPxTextBox ID="ASPxTextBox1" runat="server" ClientInstanceName="donText" 
        EnableClientSideAPI="True" Width="170px">
    </dxe:ASPxTextBox>
    <dxe:ASPxButton ID="ASPxButton1" runat="server" ClientInstanceName="donButton" 
        EnableClientSideAPI="True" Text="ASPxButton">
        <ClientSideEvents Click="function(s, e) {
	var text = donText.GetText();
	donLabel.SetText(text);
}" />
    </dxe:ASPxButton>
    <dxe:ASPxLabel ID="ASPxLabel1" runat="server" ClientInstanceName="donLabel" 
        EnableClientSideAPI="True" Text="ASPxLabel">
    </dxe:ASPxLabel>
    <br />


    </form>
</body>
</html>
