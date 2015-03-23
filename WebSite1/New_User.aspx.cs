using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class New_User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String uname, pwd;
        Boolean flag_uname=true,flag_pwd=true,flag_pan=true;
        uname = TextBox10.Text;
        pwd = TextBox11.Text;

        String temp;
        temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();
        String query="select * from Citizen_reroute where Username='" + uname + "'";

        SqlCommand cmd=new SqlCommand(query,con);


        SqlDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            Label1.Text = "This username is not available"; flag_uname=false;
        }
        rdr.Close();
        query="select * from Pan_no_verify where Pan_no='" + TextBox9.Text + "' and Name='" + TextBox1.Text +"'";
        cmd=new SqlCommand(query,con);
         rdr = cmd.ExecuteReader();
        if (!rdr.Read())
        {
            Label2.Text = "Invalid Pan Number";
            flag_pan = false;
        }
        rdr.Close();
        cmd = new SqlCommand("New_User", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@uname", uname);
        cmd.Parameters.AddWithValue("@pwd", pwd);
        cmd.Parameters.AddWithValue("@sec_Q", DropDownList2.Text);
            
        cmd.Parameters.AddWithValue("@sec_a", TextBox15.Text);
        
        cmd.Parameters.AddWithValue("@flag", 0);
        
        cmd.Parameters.AddWithValue("@name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@dob", TextBox2.Text);
        cmd.Parameters.AddWithValue("@gender", RadioButtonList1.Text);
        cmd.Parameters.AddWithValue("@add", TextBox3.Text);
        cmd.Parameters.AddWithValue("@city", TextBox5.Text);
        cmd.Parameters.AddWithValue("@pin", Int64.Parse(TextBox4.Text));
        cmd.Parameters.AddWithValue("@mobile", Int64.Parse(TextBox6.Text));
        cmd.Parameters.AddWithValue("@landline",Int64.Parse(TextBox7.Text));
        cmd.Parameters.AddWithValue("@guardian", TextBox8.Text);
        cmd.Parameters.AddWithValue("@pan", TextBox9.Text);
        cmd.Parameters.AddWithValue("@email", TextBox14.Text);

            cmd.Parameters["@flag"].Direction = ParameterDirection.Output;

        if(flag_pan==true && flag_pwd==true && flag_uname==true)
            cmd.ExecuteNonQuery();

        

    }
}