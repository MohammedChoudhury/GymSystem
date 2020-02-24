﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnEquipment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void tbnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsEquipment
        clsEquipment AnEquipment = new clsEquipment();
        //capture the equipment id
        AnEquipment.EquipmentNo = int.Parse(txtEquipmentID.Text);
        //capture the equipment description 
        AnEquipment.EquipmentDescription = txtEquipmentDes.Text;
        //capture the equipment colour
        AnEquipment.EquipmentColour = txtEquipmentClr.Text;
        //capture date added
        AnEquipment.EquipmentDateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //capture the equipment price
        AnEquipment.EquipmentPrice = int.Parse(txtEquipmentPrice.Text);
        //store the address in the session object
        Session["AnEquipment"] = AnEquipment;
        //redirect to the viewer page
        Response.Redirect("EquipmentViewer.aspx");



    }

    protected void tbnCancel_Click(object sender, EventArgs e)
    {

    }
}