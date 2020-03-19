using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Gym_Testing
{
    [TestClass]
    public class tstEquipmentCollection
    {

        [TestMethod]
        public void InstanceOK()
        
            { 
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            Assert.IsNotNull(AllEquipments);
         }

        [TestMethod]
        public void EquipmentListOK()
        {
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            List<clsEquipment> TestList = new List<clsEquipment>();
            clsEquipment TestEquipment = new clsEquipment();
            TestEquipment.EquipmentNo = 1;
            TestEquipment.EquipmentAvailable = true;
            TestEquipment.EquipmentColour = "Black";
            TestEquipment.EquipmentDateAdded = DateTime.Now.Date;
            TestEquipment.EquipmentPrice = 100;
            TestList.Add(TestEquipment);
            AllEquipments.EquipmentList = TestList;
            Assert.AreEqual(AllEquipments.EquipmentList, TestList);
        }

       

        [TestMethod]
        public void ThisEquipmentPropertyOK()
        {
            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            clsEquipment TestEquipment= new clsEquipment();
            TestEquipment.EquipmentNo = 1;
            TestEquipment.EquipmentAvailable = true;
            TestEquipment.EquipmentColour = "Black";
            TestEquipment.EquipmentDateAdded = DateTime.Now.Date;
            TestEquipment.EquipmentPrice = 100;
            AllEquipments.ThisEquipment = TestEquipment;
            Assert.AreEqual(AllEquipments.ThisEquipment, TestEquipment);

        }

        [TestMethod]
        public void ListandCountOK()
        {

            clsEquipmentCollection AllEquipments = new clsEquipmentCollection();
            List<clsEquipment> TestList = new List<clsEquipment>();
            clsEquipment TestEquipment = new clsEquipment();
            TestEquipment.EquipmentNo = 1;
            TestEquipment.EquipmentAvailable = true;
            TestEquipment.EquipmentColour = "Black";
            TestEquipment.EquipmentDateAdded = DateTime.Now.Date;
            TestEquipment.EquipmentPrice = 100;
            TestList.Add(TestEquipment);
            AllEquipments.EquipmentList = TestList;
            Assert.AreEqual(AllEquipments.Count, TestList.Count);
        



    }
 
        






    }
    }

