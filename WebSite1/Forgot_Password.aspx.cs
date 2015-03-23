using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Forgot_Password : System.Web.UI.Page
{
    
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
            Label2.Text = "Invalid credentials";
        }
        return a;
    }
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
         

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String ans = verify(TextBox3.Text, TextBox2.Text);
        if (ans.Equals("") == false)
        {
            Session["uname"] = TextBox3.Text;
            Session["sec_q"] = Label2.Text;
            Session["sec_a"] = ans;
            Response.Redirect("Security_Question.aspx");
        }
        
    }
    
}
