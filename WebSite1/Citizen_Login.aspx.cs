using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Citizen_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String un, pwd;
        un = TextBox1.Text;
        pwd = TextBox2.Text;

        String temp;
        temp=ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();

        if (un.Equals("employee") != true)
        {
            SqlCommand cmd = new SqlCommand("USER_Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", un);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@c_id", 0);
            cmd.Parameters["@c_id"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            if (Int64.Parse(cmd.Parameters["@c_id"].Value.ToString()) > 0)
            {
                Session["userID"] = Int64.Parse(cmd.Parameters["@c_id"].Value.ToString());
                con.Close();
                Response.Redirect("Citizen_Home.aspx");
            }
            else
            {
                Label1.Text = "Invalid Username or Password";
                TextBox2.Text = "";
            }
        }
        else if (un.Equals("employee") == true && pwd.Equals("password") == true)
        {
            Response.Redirect("Employee_Login.aspx");
        }

        else
        {
            Label1.Text = "Invalid Username or Password";
            TextBox2.Text = "";
        }



    }
}