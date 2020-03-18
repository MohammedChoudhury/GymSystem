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
       
        //capture the equipment ordered 
        string EquipmentOrdered = txtEquipmentOrdered.Text;
        
        
        //capture customer name
        string CustomerName = txtCustomerName.Text;
        //capture date ordered
        string DateProcessed = txtDateProcessed.Text;
        //store the address in the session object
        string Error = "";
        Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
        if (Error == "")
        {
            anOrderLine.CustomerName = CustomerName;
          
          
            anOrderLine.DateProcessed = Convert.ToDateTime(DateProcessed);
            anOrderLine.EquipmentOrdered = EquipmentOrdered;

            Session["AnOrderLine"] = anOrderLine;
            //redirect to the viewer page
            Response.Write("OrderLineViwer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = anOrderLine.Find(OrderNo);
        if (Found == true)
        {
            txtOrderNo.Text = anOrderLine.OrderNo.ToString();
            txtCustomerName.Text = anOrderLine.CustomerName;
            txtDateProcessed.Text = anOrderLine.DateProcessed.ToString();
            txtEquipmentOrdered.Text = anOrderLine.EquipmentOrdered;
            txtTotalCost.Text = anOrderLine.TotalCost.ToString();
        }
    }

    protected void chkProcessed_CheckedChanged(object sender, EventArgs e)
    {

    }
}