using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the customer id for this entry
        Response.Write(AnCustomer.customerID);  
        //disply the customer username for this entry
        Response.Write(AnCustomer.customerUserName);
        //disply the customer first name
        Response.Write(AnCustomer.customerFirstName);
        //disply the customer last name
        Response.Write(AnCustomer.customerlastName);
        //disply the customer date added
        Response.Write(AnCustomer.DateAdded);
        //siplay customer active
        Response.Write(AnCustomer.customerActive);

    }
}