using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void tbnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the customer id
        AnCustomer.customerID = int.Parse(txtCustomerID.Text);
        //capture the customer username
        AnCustomer.customerUserName = txtCustomerUN.Text;
        //capture the customer first name
        AnCustomer.customerFirstName = txtCustomerFN.Text;
        //capture the customer last name
        AnCustomer.customerlastName = txtCustomerLN.Text;
        //capture date added
        AnCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //store the id in the session objct
        Session["AnCustomer"] = AnCustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
           

    }

    protected void tbnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primry key
        Int32 customerID;
        //variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key enterred by the user
        customerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(customerID);
        //if found
        if (Found == true)
        {
            //display the values of the propertiy in the form
            txtCustomerFN.Text = AnCustomer.customerFirstName;
            txtCustomerLN.Text = AnCustomer.customerlastName;
            txtCustomerUN.Text = AnCustomer.customerUserName;
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
        }
    }
}