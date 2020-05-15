using System;

namespace GymClasses
{
    public class clsCustomer
    {
        //customerID private member variable
        private int mcustomerID;
        //customerID public property
        public int customerID
        {
            get
            {
                //this line of code sends data out of the property
                return mcustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mcustomerID = value;
            }
        }
        //date added private member variable
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        //customer active private member variable
        private Boolean mcustomerActive;
        //customer active public property
        public bool customerActive
        {
            get
            {
                return mcustomerActive;
            }
            set
            {
                mcustomerActive = value;
            }
        }
        //customer active private member variable
        private String mcustomerlastName;
        //customer active public property
        public string customerlastName
        {
            get
            {
                return mcustomerlastName;
            }
            set
            {
                mcustomerlastName = value;
            }
        }
        //customer active private member variable
        private String mcustomerFirstName;
        //customer active public property
        public string customerFirstName
        {
            get
            {
                return mcustomerFirstName;
            }
            set
            {
                mcustomerFirstName = value;
            }
        }
        //customer active private member variable
        private String mcustomerUserName;
        //customer active public property
        public string customerUserName
        {
            get
            {
                return mcustomerUserName;
            }
            set
            {
                mcustomerUserName = value;
            }
        }

        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the customer id to search for 
            DB.AddParameter("@CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                mcustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Dateadded"]);
                mcustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mcustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mcustomerlastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mcustomerUserName = Convert.ToString(DB.DataTable.Rows[0]["CustomerUserName"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerFirstName, string customerLastName, string customerUserName, string dateadded)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temp variable to store the data value
            DateTime DateTemp;
            //if the customer first name is blank
            if (customerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The customer first name may not be blank: ";
            }
            //if the customer first name is greater then 30
            if (customerFirstName.Length > 30)
            {
                //record the error
                Error = Error + "The first name cant be greater the 30 characters";
            }
            try
            {            
            //copy the dateadded value to the datetemp vaariable
            DateTemp = Convert.ToDateTime(dateadded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the weeor 
                Error = Error + "The data cannot be past: ";
            }
            //check to see if the date is greater then todays date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future";
            } }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date";
            }
            //if the customer last name is blank
            if (customerLastName.Length == 0)
            {
                //record the error
                Error = Error + "The customer last name may not be blank: ";
            }
            //if the customer first name is greater then 30
            if (customerLastName.Length > 30)
            {
                //record the error
                Error = Error + "The last name cant be greater the 30 characters";
            }
            //if the customer user name is blank
            if (customerUserName.Length == 0)
            {
                //record the error
                Error = Error + "The customer username may not be blank: ";
            }
            //if the customer first name is greater then 30
            if (customerUserName.Length > 30)
            {
                //record the error
                Error = Error + "The username cant be greater the 30 characters";
            }
            //return the error message
            return Error; 
        }
    }
}