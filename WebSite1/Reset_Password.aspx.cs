using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Reset_Password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Equals(TextBox2.Text))
        {
            String pwd = TextBox2.Text;
            String qry = "Update Citizen_reroute set password='" + pwd + "'where Username='" + Session["uname"] + "'";
            String temp;
            temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
            SqlConnection con = new SqlConnection(temp);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("Home.aspx");
        }
        else
        {
            Label1.Text = "Passwords do not match. Please retry";
            String un = Session["uname"].ToString();
            Session["uname"] = un;
        }

    }
}