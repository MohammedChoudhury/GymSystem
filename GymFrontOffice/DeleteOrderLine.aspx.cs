using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    Int32 TotalCost;
    protected void Page_Load(object sender, EventArgs e)
    {
        TotalCost = Convert.ToInt32(Session["TotalCost"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection AddressBook = new clsOrderLineCollection():
        AddressBook.ThisOrderLine.Find(TotalCost);

        AddressBook.Delete();
        Response.Redirect("OrderLineList.aspx");
    }
}