using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Security_Question : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox3.Text = Session["sec_q"].ToString();
        Session["uname"]=Session["uname"].ToString();
        Session["sec_a"] = Session["sec_a"].ToString();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["sec_a"].ToString().Equals(TextBox2.Text))
        {
            Response.Redirect("Reset_Password.aspx");

        }
        else
        {
            Label2.Text = "Invalid answer";
        }
    }
}