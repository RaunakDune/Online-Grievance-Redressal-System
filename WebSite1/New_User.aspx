<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New_User.aspx.cs" Debug="true" MasterPageFile="~/Site.master" Inherits="New_User" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">


</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="text-align:left">
    
    &nbsp;User Name:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;Password:&nbsp;
        <asp:TextBox ID="TextBox11" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;Choose a security question&nbsp;&nbsp;&nbsp; :<asp:DropDownList 
        ID="DropDownList2" runat="server">
            <asp:ListItem>mother&#39;s maiden name</asp:ListItem>
            <asp:ListItem>What was the name of your first school?</asp:ListItem>
        </asp:DropDownList>
        <br />
        &nbsp;&nbsp;<br />
&nbsp;Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        <br />
    <br />
    Name :&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="230px"></asp:TextBox>
        <br />
        <br />
    &nbsp;&nbsp;Date Of Birth :&nbsp;
         <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>


        <br /><br />

    Gender

    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        RepeatDirection="Horizontal" CellPadding="3" CellSpacing="3" CssClass="five" >
        
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
&nbsp;<br />
<br /><br />

        <br />
&nbsp; Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Height="56px" 
        Width="229px"></asp:TextBox>
        <br />
        <br />
        &nbsp;Pin Code:&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
    &nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
        <br />
        <br />
&nbsp;Mobile Number:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server" 
             TextMode="Phone"></asp:TextBox>
        <br />
        &nbsp;&nbsp;<br />
    &nbsp;Landline Number:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Height="22px" TextMode="Phone" 
            Width="135px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;
        Father&#39;s/Guardian&#39;s/Husband&#39;s Name:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;Pan Card Number:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        &nbsp;&nbsp;<br />
    &nbsp;
    <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        Email ID:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox14" runat="server" Width="271px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" 
        onclick="Button1_Click" />
        <br />
   
   </div>
</asp:Content>
