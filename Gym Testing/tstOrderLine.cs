using System;
using System.Collections.Generic;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class TstOrderLine
    {

        string CustomerName = "Emma Wang";
        string EquipmentOrdered = "Weights";
        string DateProcessed = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Assert.IsNotNull(anOrderLine);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Int32 TestData = 1;

            anOrderLine.OrderNo = TestData;
            Assert.AreEqual(anOrderLine.OrderNo, TestData);
        }


        [TestMethod]
        public void EquipmentOrderedPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            String TestData = "Protein powder";

            anOrderLine.EquipmentOrdered = TestData;
            Assert.AreEqual(anOrderLine.EquipmentOrdered, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            String TestData = "Emily Brown";

            anOrderLine.CustomerName = TestData;
            Assert.AreEqual(anOrderLine.CustomerName, TestData);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            int TestData = 20;

            anOrderLine.TotalCost = TestData;
            Assert.AreEqual(anOrderLine.TotalCost, TestData);
        }


        [TestMethod]
        public void OrderProcessedPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean TestData = true;

            anOrderLine.OrderProcessed = TestData;
            Assert.AreEqual(anOrderLine.OrderProcessed, TestData);
        }

        [TestMethod]
        public void DateProcessedPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            DateTime TestData = DateTime.Now.Date;

            anOrderLine.DateProcessed = TestData;
            Assert.AreEqual(anOrderLine.DateProcessed, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            if (anOrderLine.OrderNo != 5)
            {

                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateProcessedFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            if (anOrderLine.DateProcessed != Convert.ToDateTime("16/09/2019"))
            {

                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalCostFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            if (anOrderLine.TotalCost != 20)
            {

                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            if (anOrderLine.CustomerName != "Mary Jones")
            {

                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEquipmentOrderedFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            if (anOrderLine.EquipmentOrdered != "Protein powder")
            {

                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOrderProcessedFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = anOrderLine.Find(OrderNo);
            if (anOrderLine.OrderProcessed != true)
            {

                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateProcessedExtremeMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateProcessed = TestDate.ToString();
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateProcessedMinLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            String DateProcessed = TestDate.ToString();
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateProcessedMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateProcessed = TestDate.ToString();
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateProcessedMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DateProcessed = TestDate.ToString();
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateProcessedExtremeMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateProcessed = TestDate.ToString();
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateProcessedInvalidData()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string DateProcessed = "this is not a date!";
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "";

            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void CustomerNameMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "a";

            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "aa";

            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "";
  
        CustomerName = CustomerName.PadRight(49, 'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "";
     
        CustomerName = CustomerName.PadRight(50, 'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "";

        CustomerName = CustomerName.PadRight(51, 'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void CustomerNameMid()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string CustomerName = "";

            CustomerName = CustomerName.PadRight(25, 'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]


        public void EquipmentOrderedMinLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "";
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void EquipmentOrderedMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "a";
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EquipmentOrderedMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "aa";
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EquipmentOrderedMaxLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "";
            EquipmentOrdered = EquipmentOrdered.PadRight(49, 'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void EquipmentOrderedMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "";
            EquipmentOrdered = EquipmentOrdered.PadRight(50,  'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void EquipmentOrderedMaxPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "";
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void EquipmentOrderedMid()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string EquipmentOrdered = "";
            EquipmentOrdered = EquipmentOrdered.PadRight(25, 'a');
            Error = anOrderLine.Valid(CustomerName, DateProcessed, EquipmentOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ListAndCountOK ()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderNo = 1;
            TestItem.CustomerName = "Emma Wang";
            TestItem.TotalCost = 5;
            TestItem.EquipmentOrdered = "Weights";
            TestItem.OrderProcessed = true;
            TestItem.DateProcessed = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);






        }



    }









}












