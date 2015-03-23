using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Reset_Password_Citizen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String current_pwd, new_pwd;
        current_pwd = TextBox1.Text;
        if (TextBox2.Text.Equals(TextBox3.Text))
        {
            new_pwd = TextBox3.Text;
            String temp;
            temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
            SqlConnection con = new SqlConnection(temp);
            con.Open();
            String cid=Session["userID"].ToString();
            String qry="select * from citizen_reroute where citizen_id="+cid+" and password='" + current_pwd + "'";

            SqlCommand cmd=new SqlCommand(qry,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                qry = "update citizen_reroute set password='"+new_pwd +"' where citizen_id=" + cid;
                rdr.Close();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                Label1.Text = "Your password has been reset.";
            }
            else
            {
                Label1.Text = "Invalid password";
            }
        }
        else
        {
            Label1.Text = "Passwords do not match. Please retry.";
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";


        }


    }
}