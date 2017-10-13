<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Button ID="getInfo" runat="server" Text="Get Info" />
        </br>
       <asp:Label ID="lblBilling" runat="server" Text="Billing Information"></asp:Label>
        </br>
        <asp:TextBox ID="txtBillingInfo" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
        
    </div>
    <div class="jumbotron">
        <asp:Label ID="lblShipping" runat="server" Text="Shipping Information"></asp:Label>
        </br>
        <asp:TextBox ID="txtShippingInfo" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="jumbotron">
        <asp:Label ID="lblItemInfo" runat="server" Text="Item Information"></asp:Label>
        </br>
        <asp:TextBox ID="txtItemInfo" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
    </div>
     <div class="jumbotron">
        <asp:Label ID="lblNumItems" runat="server" Text="Number of Items"></asp:Label>
        </br>
        <asp:TextBox ID="txtNumItems" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="jumbotron">
        <asp:Label ID="lblTotalCost" runat="server" Text="Total Cost"></asp:Label>
        </br>
        <asp:TextBox ID="txtTotalCost" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
    </div>
</asp:Content>
