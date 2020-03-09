using System;
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
        public void EquipmentDescriptionOK()
        {
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            string TestData = "this is a test";
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



        public int EquipmentNo { get; private set; }

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
            Int32 EquipmentNo = 21;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestEquipmentDateAdded()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 21;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentDateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;

            }

        }
        [TestMethod]
        public void TestEquipmentDescription()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentDescription != "black")
            {
                OK = false;
            }
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestEquipmentColour()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentColour != "black")
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
            if (AnEquipment.EquipmentPrice != 2500)
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
    }
}




