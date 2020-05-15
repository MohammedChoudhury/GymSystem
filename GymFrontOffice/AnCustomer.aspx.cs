using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnCustomer : System.Web.UI.Page
{
    //variable to store the primary keye with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customerid to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record to be proccessed
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        //create an instance of the customerbook
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = CustomerBook.ThisCustomer.customerID.ToString();
        txtCustomerUN.Text = CustomerBook.ThisCustomer.customerUserName;
        txtCustomerFN.Text = CustomerBook.ThisCustomer.customerFirstName;
        txtCustomerLN.Text = CustomerBook.ThisCustomer.customerlastName;
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        checkActive.Checked = CustomerBook.ThisCustomer.customerActive;

    }

    protected void tbnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        string CustomerFirstName = txtCustomerFN.Text;
        //capture the last name
        string CustomerLastName = txtCustomerLN.Text;
        //capture the user name
        string CustomerUserName = txtCustomerUN.Text;
        //capture the date added
        string Dateadded = txtDateAdded.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
        if (Error == "")
        {
            //capture the customer id
            AnCustomer.customerID = CustomerID;
            //capture the customer username
            AnCustomer.customerUserName = CustomerUserName;
            //capture the customer first name
            AnCustomer.customerFirstName = CustomerFirstName;
            //capture the customer last name
            AnCustomer.customerlastName = CustomerLastName;
            //capture date added
            AnCustomer.DateAdded = Convert.ToDateTime(Dateadded);
            //capture active
            AnCustomer.customerActive = checkActive.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is anew record i.e customerID i.e CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the thiscustomer propewrty
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //ptherwise it must be an update
            else
            {
                //find the record
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the thiscustomer propety
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
               // CustomerList.Update();
            }
            //redirec back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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