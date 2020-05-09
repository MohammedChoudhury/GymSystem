using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnOrderLine : System.Web.UI.Page
{
   Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            if (OrderNo != -1)
            {
                DisplayOrderLines();
            }
        }
    }
    void DisplayOrderLines()
    {
        clsOrderLineCollection AddressBook = new clsOrderLineCollection();
        AddressBook.ThisOrderLine.Find(OrderNo);
        txtOrderNo.Text = AddressBook.ThisOrderLine.OrderNo.ToString();
        txtCustomerName.Text = AddressBook.ThisOrderLine.CustomerName;
        txtEquipmentOrdered.Text = AddressBook.ThisOrderLine.EquipmentOrdered;
        txtTotalCost.Text = AddressBook.ThisOrderLine.TotalCost.ToString();
        chkProcessed.Checked = AddressBook.ThisOrderLine.OrderProcessed;
        txtDateProcessed.Text = AddressBook.ThisOrderLine.DateProcessed.ToString();

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
            anOrderLine.OrderNo = OrderNo;
            anOrderLine.CustomerName = CustomerName;
            anOrderLine.DateProcessed = Convert.ToDateTime(DateProcessed);
            anOrderLine.EquipmentOrdered = EquipmentOrdered;
            anOrderLine.OrderProcessed = chkProcessed.Checked;
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();

            if (OrderNo == -1)
            {
                OrderLineList.ThisOrderLine = anOrderLine;
                OrderLineList.Add();
            }

            else 
            {
                OrderLineList.ThisOrderLine.Find(OrderNo);
                OrderLineList.ThisOrderLine = anOrderLine;
                OrderLineList.Update();
            }
            
            Response.Redirect("OrderLineList.aspx");

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
