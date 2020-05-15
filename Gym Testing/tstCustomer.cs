using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CustomerFirstName = "Mohammed";
        string CustomerLastName = "Choudhury";
        string CustomerUserName = "Mohammed99";
        string Dateadded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exits
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void customerID()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 1;
            //assign the data to the table
            AnCustomer.customerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.customerID, TestData);
        }

        [TestMethod]
        public void customerUserName()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the table 
            string TestData = "Mohammed99";
            //assign the data to the table
            AnCustomer.customerUserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.customerUserName, TestData);
        }

        [TestMethod]
        public void customerFirstName()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the table 
            string TestData = "Mohammed";
            //assign the data to the table
            AnCustomer.customerFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.customerFirstName, TestData);
        }

        [TestMethod]
        public void customerlastName()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the table 
            string TestData = "Choudhury";
            //assign the data to the table
            AnCustomer.customerlastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.customerlastName, TestData);
        }

        [TestMethod]
        public void customerActive()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the table 
            Boolean TestData = true;
            //assign the data to the table
            AnCustomer.customerActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.customerActive, TestData);
        }

        [TestMethod]
        public void DateAdded()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the table 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the table
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instnce of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = AnCustomer.Find(customerID);
            //test to see that the results is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instnce of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //boolean variable to record the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = Ancustomer.Find(customerID);
            //check the address no
            if (Ancustomer.customerID != 1)
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instnce of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //boolean variable to record the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = Ancustomer.Find(customerID);
            //check the property
            if (Ancustomer.DateAdded != Convert.ToDateTime("11/05/2020"))
            {
                OK = false;
            }
            //test to see that the resutls is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerUserNameFound()
        {
            //create an instnce of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //boolean variable to record the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = Ancustomer.Find(customerID);
            //check the property
            if (Ancustomer.customerUserName != "Mohammed99")
            {
                OK = false;
            }
            //test to see that the resutls is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instnce of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //boolean variable to record the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = Ancustomer.Find(customerID);
            //check the property
            if (Ancustomer.customerFirstName != "Mohammed")
            {
                OK = false;
            }
            //test to see that the resutls is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instnce of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //boolean variable to record the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = Ancustomer.Find(customerID);
            //check the property
            if (Ancustomer.customerlastName != "Choudhury")
            {
                OK = false;
            }
            //test to see that the resutls is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerActiveFound()
        {
            //create an instnce of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //boolean variable to record the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = Ancustomer.Find(customerID);
            //check the property
            if (Ancustomer.customerActive != true)
            {
                OK = false;
            }
            //test to see that the resutls is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "a";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFNExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "";//this should trigger an error
            CustomerFirstName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateaddedExtremeMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string Dateadded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateaddedMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the data variable to a string variable
            string Dateadded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateaddedMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string Dateadded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateaddedMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string Dateadded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateaddedExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string Dateadded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateaddedInvalidDate()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the date added to a non date value
            string Dateadded = "this is not a date";
            //invoke the method
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "a";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLNExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "";//this should trigger an error
            CustomerLastName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "a";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "aa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "aaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUNExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerUserName = "";//this should trigger an error
            CustomerUserName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerUserName, Dateadded);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
