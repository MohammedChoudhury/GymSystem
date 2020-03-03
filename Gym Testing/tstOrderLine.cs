using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class tstOrderLine
    {

        int OrderNo = 5;
        string CustomerName = "Mary Jones";
        string EquipmentOrdered = "Protein powder";
        int TotalCost = 20;
        bool OrderProcessed = true;
        DateTime DateProcessed = DateTime.Now.Date;


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
            Error = anOrderLine.Valid(OrderNo, CustomerName, EquipmentOrdered, OrderProcessed, DateProcessed, TotalCost);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void OrderNoMinLessOne()
        {

            clsOrderLine anOrderLine = new clsOrderLine();
            string Error = "";
            int OrderNo = 0;
            Error = anOrderLine.Valid(OrderNo, CustomerName, EquipmentOrdered, OrderProcessed, DateProcessed, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
            public void OrderNoMin()
            {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            int OrderNo = 1;
            Error = anOrderLine.Valid(OrderNo, CustomerName, EquipmentOrdered, OrderProcessed, DateProcessed, TotalCost);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            int OrderNo = 11;
            Error = anOrderLine.Valid(OrderNo, CustomerName, EquipmentOrdered, OrderProcessed, DateProcessed, TotalCost);
            Assert.AreEqual(Error, "");

        }




    }









    }

}










