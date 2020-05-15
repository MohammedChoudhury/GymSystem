using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            Displayfirstname();
        }
    }

    void Displayfirstname()
    {
        //craeta an instance of collection
        GymClasses.clsCustomerCollection firstname = new GymClasses.clsCustomerCollection();
        lstCustomerList.DataSource = firstname.CustomerList;
        //set the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerFirstName";
        //bind the data 
        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the seession object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirec to the data entry page
        Response.Redirect("AnCustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirec to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary value of the record to edit
        Int32 CustomerID;
        //if a record has been seleded from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key vlue of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirec to the edit page
            Response.Redirect("AnCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByLastName(txtFilter.Text);
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field of siplay
        lstCustomerList.DataTextField = "CustomerLastName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByLastName("");
        //clear any extinng filter to tidy up the interface
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field of display
        lstCustomerList.DataTextField = "CustomerFirstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}