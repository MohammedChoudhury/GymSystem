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

   

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["EquipmentNo"] = -1;
        Response.Redirect("AnEquipment.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 EquipmentNo;
        if (lstEquipmentList.SelectedIndex != -1)
        {
            EquipmentNo = Convert.ToInt32(lstEquipmentList.SelectedValue);
            Session["EquipmentNo"] = EquipmentNo;
            Response.Redirect("DeleteEquipment.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }
}