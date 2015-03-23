<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Security_Question.aspx.cs" Inherits="Security_Question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    Security Question:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" 
        style="margin-left: 0px" Width="338px" ></asp:TextBox>
&nbsp;&nbsp;<br />
<br />

&nbsp;&nbsp;Security answer&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>

<br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />

    <asp:Button ID="Button1" runat="server" Text="Reset my password" 
        onclick="Button1_Click" />
    
    <br />

    <br />

</asp:Content>

