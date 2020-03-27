using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    public object txtFilter { get; private set; }
  

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

    

 


    protected void Button2_Click(object sender, EventArgs e)
    {
        int OrderNo;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int OrderNo;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("AnOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
   

    }




    protected void btnClear_Click(object sender, EventArgs e)
    {
     
    }
}