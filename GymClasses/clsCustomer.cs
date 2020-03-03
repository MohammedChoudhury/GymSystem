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
            DB.AddParameter("@customerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterBycustomerID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                mcustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mcustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["customerActive"]);
                mcustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["customerFirstName"]);
                mcustomerlastName = Convert.ToString(DB.DataTable.Rows[0]["customerlastName"]);
                mcustomerUserName = Convert.ToString(DB.DataTable.Rows[0]["customerUserName"]);
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
    }
}