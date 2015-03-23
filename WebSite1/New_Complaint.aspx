<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New_Complaint.aspx.cs" MasterPageFile="~/Site.master" Inherits="New_Complaint" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="border-style: solid; border-color: #FF0000; text-align:right; height: 301px; width: 624px;">
    
        
        Title:
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="417px"></asp:TextBox>
        <br /> 
        Description:
        <br />

        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="93px" 
            Width="420px"></asp:TextBox>
    
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    
    </div>

</asp:Content>