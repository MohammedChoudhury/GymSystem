using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gym_Testing
{
    [TestClass]
    public class tstEquipment
    {
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
            int TestData = 1;
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
        public void EquipmentDescription()
        {
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            string TestData = "this is a test";
            AnEquipment.EquipmentDescription = TestData;
            Assert.AreEqual(AnEquipment.EquipmentDescription, TestData);
        }

        [TestMethod]
        public void EquipmentPrice()
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

    }
}
