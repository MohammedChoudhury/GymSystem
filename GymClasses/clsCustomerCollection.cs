using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //reurn the count of the list
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructer for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_selectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database on the values of mthisCustimer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("CustomerUserName", mThisCustomer.customerUserName);
            DB.AddParameter("CustomerFirstName", mThisCustomer.customerFirstName);
            DB.AddParameter("CustomerLastName", mThisCustomer.customerlastName);
            DB.AddParameter("DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("Active", mThisCustomer.customerActive);
            //execute the quary returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by the thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fot the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an exiting record based on the values of thiscustomer
            //conenct to the data base
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("CustomerID", mThisCustomer.customerID);
            DB.AddParameter("CustomerUserName", mThisCustomer.customerUserName);
            DB.AddParameter("CustomerFirstName", mThisCustomer.customerFirstName);
            DB.AddParameter("CustomerLastName", mThisCustomer.customerlastName);
            DB.AddParameter("DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("Active", mThisCustomer.customerActive);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByLastName(string CustomerLastName)
        {
            //filters the record based on a first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parmaeter to teh database
            DB.AddParameter("@CustomerLastName", CustomerLastName);
            //execute the procedure
            DB.Execute("sproc_tblCustomer_FilteredByCustomerLastName");
            //populate the array list with in the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are no records to proccess 
            while (Index < RecordCount)
            {
                //create a blanl address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.customerActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.customerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCustomer.customerUserName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUserName"]);
                AnCustomer.customerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                AnCustomer.customerlastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
}