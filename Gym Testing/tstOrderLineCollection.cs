using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Gym_Testing
{
    [TestClass]
    public class tstOrderLineCollection
    {
        

        [TestMethod]
        public void InstanceOK()
        
            { 
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);
         }

        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.CustomerName = "Julie Mitchell";
            TestItem.EquipmentOrdered = "Protein powder";
            TestItem.OrderNo = 5;
            TestItem.DateProcessed = DateTime.Now.Date;
            TestItem.OrderProcessed = true;
            TestItem.TotalCost = 20;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }

       

        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.CustomerName = "Julie Mitchell";
            TestOrderLine.EquipmentOrdered = "Protein powder";
            TestOrderLine.OrderNo = 5;
            TestOrderLine.DateProcessed = DateTime.Now.Date;
            TestOrderLine.OrderProcessed = true;
            TestOrderLine.TotalCost = 20;
            AllOrderLines.ThisOrderLine = TestOrderLine;
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);

        }

    [TestMethod]
    public void ListandCountOK()
        {
            
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.CustomerName = "Julie Mitchell";
            TestItem.EquipmentOrdered = "Protein powder";
            TestItem.OrderNo = 5;
            TestItem.DateProcessed = DateTime.Now.Date;
            TestItem.OrderProcessed = true;
            TestItem.TotalCost = 20;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);

    }

       
        }
        }
    
    

