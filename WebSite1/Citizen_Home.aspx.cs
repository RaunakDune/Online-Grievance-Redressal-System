﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Citizen_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String temp,name;
        temp = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        SqlConnection con = new SqlConnection(temp);
        con.Open();
        String cid=Session["useriD"].ToString();
        String qry = "select Name from citizen_details where citizen_id=" + cid;
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            name = rdr.GetString(0);
            
            Label1.Text = "Welcome, " + name +"!";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("New_Complaint.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("View_Complaints_Citizen.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Reset_Password_Citizen.aspx");
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}