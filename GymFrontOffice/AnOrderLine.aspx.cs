using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrderline
        clsOrderLine AnOrderLine = new clsOrderLine();
        //capture the order no
        AnOrderLine.OrderNo = int.Parse(txtOrderNo.Text);
        //capture the equipment ordered 
        AnOrderLine.EquipmentOrdered = txtEquipmentOrdered.Text;
        //capture the total cost
        AnOrderLine.TotalCost = int.Parse(txtTotalCost.Text);
        //capture customer name
        AnOrderLine.CustomerName = txtCustomerName.Text;
        //capture date ordered
        AnOrderLine.DateOrdered = Convert.ToDateTime(txtDateAdded.Text);
        //store the address in the session object
        Session["AnOrderLine"] = AnOrderLine;
        //redirect to the viewer page
        Response.Redirect("OrderLineViwer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}