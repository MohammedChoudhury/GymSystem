﻿using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class tstEquipment
    {

        string EquipmentDescription = "Weights";
        string EquipmentColour = "Black";
        int EquipmentPrice = 100;
        string EquipmentDateAdded = DateTime.Now.Date.ToString();




        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            Assert.IsNotNull(AnEquipment);
        }
        [TestMethod]
        public void EquipmentDateAddedOK()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            DateTime TestData = DateTime.Now.Date;
            AnEquipment.EquipmentDateAdded = TestData;
            Assert.AreEqual(AnEquipment.EquipmentDateAdded, TestData);

        }

        [TestMethod]
        public void EquipmentNoOK()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            Int32 TestData = 1;
            AnEquipment.EquipmentNo = TestData;
            Assert.AreEqual(AnEquipment.EquipmentNo, TestData);

        }

        [TestMethod]
        public void EquipmentColourOK()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            string TestData = "Black";
            AnEquipment.EquipmentColour = TestData;
            Assert.AreEqual(AnEquipment.EquipmentColour, TestData);

        }

        [TestMethod]
        public void EquipmentDescriptionOK()
        {
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            string TestData = "Black";
            AnEquipment.EquipmentDescription = TestData;
            Assert.AreEqual(AnEquipment.EquipmentDescription, TestData);
        }

        [TestMethod]
        public void EquipmentPriceOK()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            int TestData = 100;
            AnEquipment.EquipmentPrice = TestData;
            Assert.AreEqual(AnEquipment.EquipmentPrice, TestData);
        }

        [TestMethod]
        public void EquipmentAvailable()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //create some test data to assign to the table 
            Boolean TestData = true;
            //assign the data to the table
            AnEquipment.EquipmentAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEquipment.EquipmentAvailable, TestData);
        }





        [TestMethod]
        public void FindMethodTest()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestEquipmentNoFound()
        {

            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEquipmentDateAdded()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentDateAdded != Convert.ToDateTime("01/01/2020"))
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEquipmentDescription()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentDescription != "Weights")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEquipmentColour()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentColour != "Black")
            {
                OK = false;
            }
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestEquipmentPrice()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentPrice != 100)
            {
                OK = false;
            }
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EquipmentDescriptionMinLessOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            string EquipmentDescription = "0";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
        }

        [TestMethod]
        public void EquipmentDescriptionMin()
        {
            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "a";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);

        }

        [TestMethod]
        public void EquipmentDescriptionMinPlusOne()
        {
            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "aa";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);

        }
        [TestMethod]
        public void EquipmentDescriptionMaxLessOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "";
            EquipmentDescription.PadRight(49, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentDescriptionExtremeMax()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "";
            EquipmentDescription.PadRight(500, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentDescriptionMax()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "";
            EquipmentDescription.PadRight(50, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentDescriptionMaxPlusOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "";
            EquipmentDescription.PadRight(51, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentDescriptionMid()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "";
            EquipmentDescription.PadRight(25, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EquipmentDateAddedMin()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string EquipmentDateAdded = TestDate.ToString();
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EquipmentDateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsEquipment anEquipment = new clsEquipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string EquipmentDateAdded = TestDate.ToString();
            //invoke the method
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EquipmentDateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsEquipment anEquipment = new clsEquipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string EquipmentDateAdded = TestDate.ToString();
            //invoke the method
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentColourMinLessOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            string EquipmentColour = "";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
        }

        [TestMethod]
        public void EquipmentColourMin()
        {
            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentColour = "a";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);

        }
        [TestMethod]
        public void EquipmentColourMinPlusOne()
        {
            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentColour = "aa";
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
        }
        [TestMethod]
        public void EquipmentColourMaxLessOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentColour = "";
            EquipmentColour.PadRight(19, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentColourExtremeMax()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentColour = "";
            EquipmentColour.PadRight(500, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentColourMax()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentColour = "";
            EquipmentColour.PadRight(20, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentColourMaxPlusOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentDescription = "";
            EquipmentDescription.PadRight(21, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EquipmentColourMid()
        {

            clsEquipment anEquipment = new clsEquipment();
            String Error = "";
            string EquipmentColour = "";
            EquipmentColour.PadRight(10, 'a');

            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void EquipmentPriceMinLessOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 0;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void EquipmentPriceMin()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 1;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }

        public void EquipmentPriceMinPlusOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 101;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        public void EquipmentPriceMaxLessOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 899;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        public void EquipmentPriceMax()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 900;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        public void EquipmentPriceMaxPlusOne()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 901;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        public void EquipmentPriceMid()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 450;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        public void EquipmentPriceExtremeMax()
        {

            clsEquipment anEquipment = new clsEquipment();
            string Error = "";
            int EquipmentPrice = 1000;
            Error = anEquipment.Valid(EquipmentDescription, EquipmentColour, EquipmentDateAdded, EquipmentPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            clsEquipment TestItem = new clsEquipment();
            Int32 PrimaryKey = 0;
            TestItem.EquipmentAvailable = true;
            TestItem.EquipmentDateAdded = DateTime.Now.Date;
            TestItem.EquipmentNo = 1;
            TestItem.EquipmentDescription = "Weights";
            TestItem.EquipmentColour = "Black";
            TestItem.EquipmentPrice = 525;
            AllEquipments.ThisEquipment = TestItem;
            PrimaryKey = AllEquipments.Add();
            TestItem.EquipmentNo = PrimaryKey;
            AllEquipments.ThisEquipment.Find(PrimaryKey);
            Assert.AreEqual(AllEquipments.ThisEquipment, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            clsEquipment TestItem = new clsEquipment();
            Int32 PrimaryKey = 0;
            TestItem.EquipmentNo = 1;
            TestItem.EquipmentColour = "White";
            TestItem.EquipmentDateAdded = DateTime.Now.Date;
            TestItem.EquipmentDescription = "Weights";
            TestItem.EquipmentPrice = 525;
            TestItem.EquipmentAvailable = true;
            AllEquipments.ThisEquipment = TestItem;
            PrimaryKey = AllEquipments.Add();
            TestItem.EquipmentNo = PrimaryKey;
            AllEquipments.ThisEquipment.Find(PrimaryKey);
            AllEquipments.Delete();
            Boolean Found = AllEquipments.ThisEquipment.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            clsEquipment TestItem = new clsEquipment();
            Int32 PrimaryKey = 0;
            TestItem.EquipmentAvailable = true;
            TestItem.EquipmentColour = "black";
            TestItem.EquipmentDateAdded = DateTime.Now.Date;
            TestItem.EquipmentDescription = "Weights";
            TestItem.EquipmentPrice = 100;
            AllEquipments.ThisEquipment = TestItem;
            PrimaryKey = AllEquipments.Add();
            TestItem.EquipmentNo = PrimaryKey;
            TestItem.EquipmentAvailable = false;
            TestItem.EquipmentColour = "white";
            TestItem.EquipmentDateAdded = DateTime.Now.Date;
            TestItem.EquipmentDescription = "Treadmill";
            TestItem.EquipmentPrice = 150;
            AllEquipments.ThisEquipment = TestItem;
            AllEquipments.Update();
            AllEquipments.ThisEquipment.Find(PrimaryKey);
            Assert.AreEqual(AllEquipments.ThisEquipment, TestItem);

        }

        [TestMethod]
        public void ReportByEquipmentDescriptionMethodOL()
        {
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            clsEquipmentCollection FilteredEquipments = new clsEquipmentCollection();
            FilteredEquipments.ReportByEquipmentDescription("");
            Assert.AreEqual(AllEquipments.Count, FilteredEquipments.Count);
        }
        [TestMethod]
        public void ReportByEquipmentDescriptionNoneFound()
        {
            clsEquipmentCollection FilteredEquipments = new clsEquipmentCollection();
            FilteredEquipments.ReportByEquipmentDescription("leg machine");
            Assert.AreEqual(0, FilteredEquipments.Count);
        }
        [TestMethod]
        public void ReportByEquipmentDescriptionTestDataFound()
        {
            clsEquipmentCollection FilteredEquipments = new clsEquipmentCollection();
            Boolean OK = true;
            FilteredEquipments.ReportByEquipmentDescription("rope");
            if (FilteredEquipments.Count == 2)
            {
                if (FilteredEquipments.EquipmentList[0].EquipmentNo != 36)
                {
                    OK = false;
                }
                if (FilteredEquipments.EquipmentList[1].EquipmentNo != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }

}










