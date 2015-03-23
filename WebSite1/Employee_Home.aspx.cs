using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Employee_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String temp, name;
        temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();
        String eid = Session["useriD"].ToString();
        String qry = "select Name from Employee_details where Employee_id=" + eid;
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            name = rdr.GetString(0);

            Label1.Text =name ;
        }
    }
}