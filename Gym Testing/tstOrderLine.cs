using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class tstOrderLine
    {
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
        public void DateOrderedPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            DateTime TestData = DateTime.Now.Date;

            anOrderLine.DateOrdered = TestData;
            Assert.AreEqual(anOrderLine.DateOrdered, TestData);
        }
    }
}
