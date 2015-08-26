using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ext : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["Name"] == null || Session["ServerAddress"] == null || Session["Port"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                //Check if the acceleration settings exist
                if (Session["VJMaxX1Val"] == null || Session["VJMaxY1Val"] == null || Session["VJMaxZ1Val"] == null || Session["VJDivisorVal_XY1"] == null || Session["VJDivisorVal_Z1"] == null)
                {
                    //Set default settings
                    Session["VJMaxX1Val"] = "0.0001";
                    Session["VJMaxY1Val"] = "0.0001";
                    Session["VJMaxZ1Val"] = "0.0001";
                    Session["VJDivisorVal_XY1"] = "145000";
                    Session["VJDivisorVal_Z1"] = "145000";
                }

                //Pass properties from code behind to the webpage
                HiddenElements.Text = @"<input type=""text"" id=""Name"" value=" + Session["Name"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""ServerAddress"" value=" + Session["ServerAddress"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""Port"" value=" + Session["Port"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""MaxX1Val"" value=" + Session["VJMaxX1Val"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""MaxY1Val"" value=" + Session["VJMaxY1Val"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""MaxZ1Val"" value=" + Session["VJMaxZ1Val"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""DivisorVal_XY1"" value=" + Session["VJDivisorVal_XY1"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""DivisorVal_Z1"" value=" + Session["VJDivisorVal_Z1"].ToString() + " style='display: none;'/>";
            }
        }
    }
}