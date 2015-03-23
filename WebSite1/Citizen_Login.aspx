<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Citizen_Login.aspx.cs" MasterPageFile="~/Site.master" Inherits="Citizen_Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">


</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
        
        <br />
        <br />
        <br />

        
        Login Id
        <asp:TextBox ID="TextBox1" runat="server">
        </asp:TextBox>
        
        <br />
        <br />
        
       Password
       <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
        <br />
       <br />
         
        
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#3366FF" 
            NavigateUrl="~/Forgot_Password.aspx">Forgot Password? Click here</asp:HyperLink>
         
        
        <br />
        <br />


    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    
        
</asp:Content>
