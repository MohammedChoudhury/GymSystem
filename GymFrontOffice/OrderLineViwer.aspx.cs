using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class OrderLineViwer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrderline
        clsOrderLine AnOrderLine = new clsOrderLine();
        //get the data from the session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //display the order no for this entry
        Response.Write(AnOrderLine.OrderNo);
        //display the equipment ordered
        Response.Write(AnOrderLine.EquipmentOrdered);
        //display the total cost
        Response.Write(AnOrderLine.TotalCost);
        //display the customer name
        Response.Write(AnOrderLine.CustomerName);
        //display the date ordered
        Response.Write(AnOrderLine.DateOrdered);
        //display if ordered proccessed
        Response.Write(AnOrderLine.OrderProcessed);



    }
}