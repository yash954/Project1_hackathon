using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class firstpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        btn1.Visible = true;
        drp1.Items.Add("  ");
        drp1.Items.Add("Mumbai");
        drp1.Items.Add("Bangalore");
        //drp2.Items.Add("PVR");
     //   drp2.Items.Add("IONOX");
    }
    public void hello(object sender, EventArgs e)
    {
       
        Session["Place"] = drp1.SelectedItem.Value;
     
    }

    public void hell(object sender, EventArgs e)
    {
        

        Response.Redirect("2ndpage.aspx");

    }
}