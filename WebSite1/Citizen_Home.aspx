<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Citizen_Home.aspx.cs" Inherits="Citizen_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Menu ID="Menu1" runat="server" CssClass="menu" Orientation="Horizontal" 
    onmenuitemclick="Menu1_MenuItemClick">
    <Items>
        <asp:MenuItem NavigateUrl="~/Citizen_Home.aspx" Text="My Home" Value="My Home">
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/View_Complaints_Citizen.aspx" 
            Text="View my complaints" Value="View my complaints"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/New_Complaint.aspx" Text="New complaint" 
            Value="New complaint"></asp:MenuItem>
    </Items>
</asp:Menu>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
    <br />
    <br />
    <br /><br />

    <asp:Button ID="Button1" runat="server" Text="New Complaint" 
        onclick="Button1_Click" />
    <br /><br />

    <asp:Button ID="Button2" runat="server" Text="View my Complaints" 
        onclick="Button2_Click" />
    <br /><br />

    <asp:Button ID="Button3" runat="server" Text="Reset password" 
        onclick="Button3_Click" />
</asp:Content>

