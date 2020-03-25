using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteEquipment : System.Web.UI.Page
{
    Int32 EquipmentNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        EquipmentNo = Convert.ToInt32(Session["EquipmentNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsEquipmentCollection AddressBook = new clsEquipmentCollection();
        AddressBook.ThisEquipment.Find(EquipmentNo);
        AddressBook.Delete();
        Response.Redirect("EquipmentList.aspx");
    }

    

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}