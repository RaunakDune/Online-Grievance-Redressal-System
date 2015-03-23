using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Complaints_Citizen : System.Web.UI.Page
{
    Int64 cid;
    protected void Page_Load(object sender, EventArgs e)
    {
        cid = Int64.Parse(Session["userID"].ToString());

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}