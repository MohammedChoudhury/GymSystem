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
}