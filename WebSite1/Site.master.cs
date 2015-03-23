using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    Int64 userID;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        try
        {
            userID = Int64.Parse(Session["userID"].ToString());
            Session["userID"] = userID;
        }
        catch (Exception)
        {
            Session["userID"] = -1;
            userID = -1;
            
        }
        if (userID > 0)
        {
            Button1.Text = "Logout";
        }
        else
        {
            Button1.Text = "Login";
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (Button1.Text.Equals("Login"))
        {
            Response.Redirect("Citizen_Login.aspx");
            
        }
        else
        {
            Button1.Text = "Login";
            Session["userID"] = -1;
            Response.Redirect("Home.aspx"); 

        }
        Session["userID"] = -1;

    }

    protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
