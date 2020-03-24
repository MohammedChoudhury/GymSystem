using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderLines();
        }
    }

    void DisplayOrderLines()
    {
        GymClasses.clsOrderLineCollection OrderLines = new GymClasses.clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderNo";
        lstOrderLineList.DataTextField = "Customer Name";
        lstOrderLineList.DataBind();
    }



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("AnOrderKinw.aspx");
    }
}