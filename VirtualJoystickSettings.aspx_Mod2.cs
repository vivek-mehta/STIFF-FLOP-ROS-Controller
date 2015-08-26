using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VirtualJoystickProperties : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Check if the acceleration settings exist
            if (Session["VJMaxX2Val"] != null && Session["VJMaxY2Val"] != null && Session["VJMaxZ2Val"] != null && Session["VJDivisorVal_XY2"] != null && Session["VJDivisorVal_Z2"] != null)
            {
                //Fill the textbox with the acceleration settings
                MaxX2Val.Value = Session["VJMaxX2Val"].ToString();
                MaxY2Val.Value = Session["VJMaxY2Val"].ToString();
                MaxZ2Val.Value = Session["VJMaxZ2Val"].ToString();
                DivisorVal_XY2.Value = Session["VJDivisorVal_XY2"].ToString();
                DivisorVal_Z2.Value = Session["VJDivisorVal_Z2"].ToString();
            }
        }
    }
    protected void SaveProperties(object sender, EventArgs e)
    {
        //Check if all the fields have been completed
        if (MaxX2Val.Value != "" && MaxY2Val.Value != "" && MaxZ2Val.Value != "" && DivisorVal_XY2.Value != "" && DivisorVal_Z2.Value != "")
        {
            //Save the acceleration settings
            Session["VJMaxX2Val"] = MaxX2Val.Value;
            Session["VJMaxY2Val"] = MaxY2Val.Value;
            Session["VJMaxZ2Val"] = MaxZ2Val.Value;
            Session["VJDivisorVal_XY2"] = DivisorVal_XY2.Value;
            Session["VJDivisorVal_Z2"] = DivisorVal_Z2.Value;
            Response.Redirect("VirtualJoystick_Mod2.aspx");
        }
        else
        {
            //Raise an error message if some fields are empty
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Materialize.toast('" + "All fields are mandatory" + "', 5000);", true);
        }
    }
}