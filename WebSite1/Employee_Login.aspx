<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Employee_Login.aspx.cs" Inherits="Employee_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />

        <br />
        <br />

        
        Employee ID:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server">
        </asp:TextBox>
        
        <br />
        <br />
        
       Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <div style="text-align:right">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login"/>
        
         
        
        <br />
        <br />


    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    
</asp:Content>

