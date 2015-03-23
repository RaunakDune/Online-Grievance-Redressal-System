using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class New_Complaint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String title, desc;
        title = TextBox1.Text;
        desc = TextBox2.Text;

        String temp;
        temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();

        SqlCommand cmd = new SqlCommand("new_complaint", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@c_id", Int64.Parse(Session["userID"].ToString()));
        cmd.Parameters.AddWithValue("@tit", title);
        cmd.Parameters.AddWithValue("@desc", desc);
        cmd.Parameters.AddWithValue("@flag", 0);
        cmd.Parameters["@flag"].Direction = ParameterDirection.Output;
        cmd.ExecuteNonQuery();
        int flag = int.Parse(cmd.Parameters["@flag"].Value.ToString());

        if (flag == 1)
        {
            Label1.Text = "Your complaint has been registered.";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        else
        {
            Label1.Text = "Error";
        }


    }
}