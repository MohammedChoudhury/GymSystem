using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EquipmentList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayEquipment();
        }
    }

    void DisplayEquipment()
    {
        GymClasses.clsEquipmentCollection Equipment = new GymClasses.clsEquipmentCollection();
        lstEquipmentList.DataSource = Equipment.EquipmentList;
        lstEquipmentList.DataValueField = "EquipmentNo";
        lstEquipmentList.DataTextField = "EquipmentDescription";
        lstEquipmentList.DataBind();
    }

    protected void lstEquipmentList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}