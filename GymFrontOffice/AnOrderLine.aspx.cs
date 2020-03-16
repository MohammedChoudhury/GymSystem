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
        clsOrderLine anOrderLine = new clsOrderLine();
        anOrderLine = (clsOrderLine)Session["AnOrderLine"];
        Response.Write(anOrderLine.OrderNo);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrderline
        clsOrderLine anOrderLine = new clsOrderLine();
        //capture the order no
        int OrderNo = int.Parse(txtOrderNo.Text);
        //capture the equipment ordered 
        string EquipmentOrdered = txtEquipmentOrdered.Text;
        //capture the total cost
        int TotalCost = int.Parse(txtTotalCost.Text);
        //capture customer name
        string CustomerName = txtCustomerName.Text;
        //capture date ordered
        string DateProcessed = txtDateAdded.Text;
        //store the address in the session object
        string Error = "";
        Error = anOrderLine.Valid(CustomerName, OrderNo, TotalCost, DateProcessed, EquipmentOrdered);
        if (Error == "")
        {
            anOrderLine.CustomerName = CustomerName;
            anOrderLine.OrderNo = OrderNo;
            anOrderLine.TotalCost = TotalCost;
            anOrderLine.DateProcessed = Convert.ToDateTime(DateProcessed);
            anOrderLine.EquipmentOrdered = EquipmentOrdered;

            Session["AnOrderLine"] = anOrderLine;
            //redirect to the viewer page
            Response.Write("OrderLineViwer.aspx");

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}