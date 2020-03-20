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
        clsOrderLine anOrderLine = new clsOrderLine();
        anOrderLine = (clsOrderLine)Session["anOrderLine"];
        Response.Write(anOrderLine.OrderNo);
        Response.Write(anOrderLine.CustomerName);
        Response.Write(anOrderLine.EquipmentOrdered);
        Response.Write(anOrderLine.OrderProcessed);
        Response.Write(anOrderLine.DateProcessed);
        Response.Write(anOrderLine.TotalCost);
    }

    




}