<%@ Page Title="" Language="C#" MasterPageFile="~/DXAirways.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DXAirways.Web.Default" %>
<%@ Register src="SearchForFlight.ascx" tagname="SearchForFlight" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <table class="" width="100%" cellspacing="6" border="1">
        <tr class="">
            <td rowspan="3" valign="top" style="width: 45%">
                <dxrp:aspxroundpanel ID="ASPxRoundPanel1" runat="server" 
                    Width="100%" ContentHeight="390px" HeaderText="Search For Flights">
                    <PanelCollection>
                        <dxp:PanelContent runat="server">

                            <uc1:SearchForFlight ID="SearchForFlight1" runat="server" />

                        </dxp:PanelContent>
                    </PanelCollection>
                </dxrp:aspxroundpanel>
            </td>
            <td colspan="2" valign="top" style="width: 55%">
                <asp:AdRotator ID="AdRotator1" runat="server" Width="99%" Height="60" 
                    AdvertisementFile="~/App_Data/HomePageAds.xml" />
            </td>
        </tr>
        <tr class="">
            <td valign="top" style="width: 30%">
                <dxtc:aspxtabcontrol ID="ASPxTabControl1" runat="server" ActiveTabIndex="0" 
                    Height="160px" Width="100%">
                    <Tabs>
                        <dxtc:Tab Text="Check-in">
                        </dxtc:Tab>
                        <dxtc:Tab Text="Check Flight Status">
                        </dxtc:Tab>
                    </Tabs>
                </dxtc:aspxtabcontrol>
            </td>
            <td rowspan="2" valign="top" style="width: 25%">
                <dxrp:aspxroundpanel ID="ASPxRoundPanel2" runat="server" 
                    Width="100%" ContentHeight="320px" HeaderText="Account Summary or Sign-in">
                    <PanelCollection>
                        <dxp:PanelContent runat="server">
                            <asp:PlaceHolder ID="phAccountSummary" runat="server"></asp:PlaceHolder>
                        </dxp:PanelContent>
                    </PanelCollection>
                </dxrp:aspxroundpanel>
            </td>
        </tr>
        <tr class="">
            <td valign="top">
                <dxrp:aspxroundpanel 
                    ID="ASPxRoundPanel3" runat="server" 
                    Width="100%" ContentHeight="145px" HeaderText="View Current Reservations or Find Reservation">
                    <PanelCollection>
                        <dxp:PanelContent runat="server">

                        </dxp:PanelContent>
                    </PanelCollection>
                </dxrp:aspxroundpanel>
            </td>
        </tr>
        <tr>
            <td colspan="3" valign="top" style="width=100%">
                <dxrp:aspxroundpanel ID="ASPxRoundPanel4" runat="server" 
                    Width="100%" ContentHeight="100px" HeaderText="DX Airways News">
                    <PanelCollection>
                        <dxp:PanelContent runat="server">
                            <dxnc:ASPxNewsControl ID="ASPxNewsControl1" runat="server" Height="100px" 
                                Width="100%">
                                <Items>
                                    <dxnc:NewsItem>
                                    </dxnc:NewsItem>
                                </Items>
                            </dxnc:ASPxNewsControl>
                        </dxp:PanelContent>
                    </PanelCollection>
                </dxrp:aspxroundpanel>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphFooter" runat="server">
</asp:Content>
