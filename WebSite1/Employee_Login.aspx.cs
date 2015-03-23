using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Employee_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String pwd;
        Int64 empID;
        empID = Int64.Parse(TextBox1.Text);
        pwd = TextBox2.Text;

        String temp;
        temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();

       SqlCommand cmd = new SqlCommand("EMPLOYEE_Login", con);
       cmd.CommandType = CommandType.StoredProcedure;
       cmd.Parameters.AddWithValue("@eid", empID);
       cmd.Parameters.AddWithValue("@pwd", pwd);
       cmd.Parameters.AddWithValue("@flag", 0);
       cmd.Parameters["flag"].Direction = ParameterDirection.Output;
       cmd.ExecuteNonQuery();
       if (Int64.Parse(cmd.Parameters["@flag"].Value.ToString()) > 0)
       {
           Session["userID"] = empID;
           con.Close();
           Response.Redirect("Employee_Home.aspx");
       }
       else
       {
           Label1.Text = "Invalid Employee ID or Password";
           TextBox2.Text = "";
        }

    }
}