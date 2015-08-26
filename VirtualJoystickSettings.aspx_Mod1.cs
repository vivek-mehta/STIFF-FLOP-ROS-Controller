﻿using System;
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
            if (Session["VJMaxX1Val"] != null && Session["VJMaxY1Val"] != null && Session["VJMaxZ1Val"] != null && Session["VJDivisorVal_XY1"] != null && Session["VJDivisorVal_Z1"] != null)
            {
                //Fill the textbox with the acceleration settings
                MaxX1Val.Value = Session["VJMaxX1Val"].ToString();
                MaxY1Val.Value = Session["VJMaxY1Val"].ToString();
                MaxZ1Val.Value = Session["VJMaxZ1Val"].ToString();
                DivisorVal_XY1.Value = Session["VJDivisorVal_XY1"].ToString();
                DivisorVal_Z1.Value = Session["VJDivisorVal_Z1"].ToString();
            }
        }
    }
    protected void SaveProperties(object sender, EventArgs e)
    {
        //Check if all the fields have been completed
        if (MaxX1Val.Value != "" && MaxY1Val.Value != "" && MaxZ1Val.Value != "" && DivisorVal_XY1.Value != "" && DivisorVal_Z1.Value != "")
        {
            //Save the acceleration settings
            Session["VJMaxX1Val"] = MaxX1Val.Value;
            Session["VJMaxY1Val"] = MaxY1Val.Value;
            Session["VJMaxZ1Val"] = MaxZ1Val.Value;
            Session["VJDivisorVal_XY1"] = DivisorVal_XY1.Value;
            Session["VJDivisorVal_Z1"] = DivisorVal_Z1.Value;
            Response.Redirect("VirtualJoystick_Mod1.aspx");
        }
        else
        {
            //Raise an error message if some fields are empty
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Materialize.toast('" + "All fields are mandatory" + "', 5000);", true);
        }
    }
}