<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reset_Password_Citizen.aspx.cs" Inherits="Reset_Password_Citizen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <br />
        Current Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"  
            TextMode="Password"></asp:TextBox>
        <br />
        New Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"  
            TextMode="Password"></asp:TextBox>
        <br />
        Reenter new Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"  
            TextMode="Password"></asp:TextBox>
        <br />
        <br />
        
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Reset Password" 
            onclick="Button1_Click" />
    </p>
</asp:Content>

