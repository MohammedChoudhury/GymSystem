using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Gym_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exits
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.customerActive = true;
            TestItem.customerID = 1;
            TestItem.customerFirstName = "Mohammed";
            TestItem.customerlastName = "Choudhury";
            TestItem.customerUserName = "Mohammed99";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the last list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the propert
            clsCustomer TestCustomer = new clsCustomer();
            //sett the propert of the test objects
            TestCustomer.customerActive = true;
            TestCustomer.customerID = 1;
            TestCustomer.customerFirstName = "Mohammed";
            TestCustomer.customerlastName = "Choudhury";
            TestCustomer.customerUserName = "Mohammed99";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the propert
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are teh same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the propert
            //in thos case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item of the test data 
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.customerActive = true;
            TestItem.customerID = 1;
            TestItem.customerFirstName = "Mohammed";
            TestItem.customerlastName = "Choudhury";
            TestItem.customerUserName = "Mohammed99";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assighn the data to the property 
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerActive = true;
            TestItem.customerID = 1;
            TestItem.customerUserName = "Dave99";
            TestItem.customerFirstName = "Dave";
            TestItem.customerlastName = "Nut";
            TestItem.DateAdded = DateTime.Now.Date;
            //set this customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.customerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerActive = true;
            TestItem.customerID = 1;
            TestItem.customerUserName = "Dave99";
            TestItem.customerFirstName = "Dave";
            TestItem.customerlastName = "Nut";
            TestItem.DateAdded = DateTime.Now.Date;
            //set this customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.customerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerActive = true;
            TestItem.customerUserName = "Dave99";
            TestItem.customerFirstName = "Dave";
            TestItem.customerlastName = "Nut";
            TestItem.DateAdded = DateTime.Now.Date;
            //set this customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.customerID = PrimaryKey;
            //modify the test
            TestItem.customerActive = false;
            TestItem.customerUserName = "Darran100";
            TestItem.customerFirstName = "Darran";
            TestItem.customerlastName = "Smith";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
           //test to see that thiscustomer mates the record
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
           //create an instance of the class containing unfiltered results
           clsCustomerCollection AllCustomer = new clsCustomerCollection();
           //create an instance of the filtered data
           clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
           //apply a blank string (should return all recors)
           FilteredCustomer.ReportByLastName("");
           //test to see that the two vlues are the same
           Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }

        [TestMethod]
       public void ReportByFirstNameNoneFound()
        {
           //create an instance of the filtered data
           clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
           FilteredCustomer.ReportByLastName("xxxxxx");
          //test to see that there are no recors
           Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByCustomerLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredCustomer.ReportByLastName("Slong");
            //check that the correct number of records are found
            if (FilteredCustomer.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCustomer.CustomerList[0].customerID != 93)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredCustomer.CustomerList[1].customerID != 94)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}