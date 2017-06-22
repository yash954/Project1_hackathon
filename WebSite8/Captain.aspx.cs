using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Captain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        drp1.Items.Add("1");
        drp1.Items.Add("2");
        drp1.Items.Add("3");
        drp1.Items.Add("4");
        drp1.Items.Add("5");
        drp1.Items.Add("6");
        drp1.Items.Add("7");
        drp1.Items.Add("8");
        drp1.Items.Add("9");
    }
    protected void hello(object sender, EventArgs e)
    {

        Session["numberofseats"] = drp1.SelectedItem.Value;
        Response.Redirect("Seats1pm.aspx");

    }
    protected void hell(object sender, EventArgs e)
    {
    }
    protected void hel(object sender, EventArgs e)
    {
    }
    protected void world(object sender, EventArgs e)
    {
    }
    protected void worl(object sender, EventArgs e)
    {
    }
    protected void wor(object sender, EventArgs e)
    {
    }
}