using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class EquipmentViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsequipment
        clsEquipment AnEquipment = new clsEquipment();
        //get the data from session object 
        AnEquipment = (clsEquipment)Session["AnEquipment"];
        //display the equipment id
        Response.Write(AnEquipment.EquipmentNo);
        //display the equipment descritopn
        Response.Write(AnEquipment.EquipmentDescription);
        //display the equipment colour
        Response.Write(AnEquipment.EquipmentColour);
        //display te date added
        Response.Write(AnEquipment.EquipmentDateAdded);
        //display the equipment price
        Response.Write(AnEquipment.EquipmentPrice);
        //dislay the equipment availablilty 
        Response.Write(AnEquipment.EquipmentAvailable);

    }
}