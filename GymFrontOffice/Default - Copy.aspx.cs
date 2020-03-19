using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public object lstEquipmentList { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayEquipments();
        }

    }

    void DisplayEquipments()
    {
        GymClasses.clsEquipmentCollection Equipments = new GymClasses.clsEquipmentCollection();
        lstEquipments.DataSource = Equipments.EquipmentList;
        lstEquipments.DataValueField = "EquipmentNo";
        lstEquipments.DataTextField = "EquipmentDescription";
        lstEquipments.DataBind();
    }

}