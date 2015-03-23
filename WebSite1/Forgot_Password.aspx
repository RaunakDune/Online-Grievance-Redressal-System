<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Forgot_Password.aspx.cs" Inherits="Forgot_Password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
<script type="text/C#" id="getSecretQ">
protected String verify(String uname, String pan)
    {
        String q, a="", qry;
        qry = "Select secret_Q, secret_A from Citizen_reroute where username='" + uname + "' and citizen_id in(select citizen_id from citizen_details where pan_no='" + pan + "')";
        String temp;
        temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            q = rdr.GetString(0);
            a = rdr.GetString(1);
            Label2.Text = q;
        }
        else
        {
            Label1.Text = "Invalid credentials";
        }
        return a;
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server" TextMode="Password">
    Username:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
&nbsp;&nbsp;<br />
&nbsp;&nbsp;PAN card Number:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox3_TextChanged" ></asp:TextBox>

<br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />

    <asp:Button ID="Button1" runat="server" Text="Get Security Question" 
        onclick="Button1_Click" />
    
    <br />

    <br />

<br />
    

</asp:Content>

