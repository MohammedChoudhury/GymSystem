using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class tstCustomer
    {
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
            if (Ancustomer.DateAdded != Convert.ToDateTime("03/03/2020"))
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
    }
}
