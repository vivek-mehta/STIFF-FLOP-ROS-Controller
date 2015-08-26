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
                if (Session["VJMaxX2Val"] == null || Session["VJMaxY2Val"] == null || Session["VJMaxZ2Val"] == null || Session["VJDivisorVal_XY2"] == null || Session["VJDivisorVal_Z2"] == null)
                {
                    //Set default settings
                    Session["VJMaxX2Val"] = "0.0001";
                    Session["VJMaxY2Val"] = "0.0001";
                    Session["VJMaxZ2Val"] = "0.0001";
                    Session["VJDivisorVal_XY2"] = "145000";
                    Session["VJDivisorVal_Z2"] = "145000";
                }

                //Pass properties from code behind to the webpage
                HiddenElements.Text = @"<input type=""text"" id=""Name"" value=" + Session["Name"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""ServerAddress"" value=" + Session["ServerAddress"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""Port"" value=" + Session["Port"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""MaxX2Val"" value=" + Session["VJMaxX2Val"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""MaxY2Val"" value=" + Session["VJMaxY2Val"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""MaxZ2Val"" value=" + Session["VJMaxZ2Val"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""DivisorVal_XY2"" value=" + Session["VJDivisorVal_XY2"].ToString() + " style='display: none;'/>";
                HiddenElements.Text = HiddenElements.Text + @"<input type=""text"" id=""DivisorVal_Z2"" value=" + Session["VJDivisorVal_Z2"].ToString() + " style='display: none;'/>";
            }
        }
    }
}