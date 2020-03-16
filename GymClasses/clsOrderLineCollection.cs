using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsOrderLineCollection
    {
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }
                
        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }


            set
            {

            }
        }
        public clsOrderLine ThisOrderLine { get; set; }
        public List<clsOrderLine> mOrderLineList { get; private set; }

        public clsOrderLineCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {




                clsOrderLine TestItem = new clsOrderLine();


                TestItem.CustomerName = "Julie Mitchell";
                TestItem.EquipmentOrdered = "Protein powder";
                TestItem.OrderNo = 5;
                TestItem.DateProcessed = DateTime.Now.Date;
                TestItem.OrderProcessed = true;
                TestItem.TotalCost = 20;
                mOrderLineList.Add(TestItem);
                TestItem = new clsOrderLine();
                TestItem.CustomerName = "Bill Joyce";
                TestItem.EquipmentOrdered = "Weights";
                TestItem.OrderNo = 3;
                TestItem.DateProcessed = DateTime.Now.Date;
                TestItem.OrderProcessed = true;
                TestItem.TotalCost = 30;
                mOrderLineList.Add(TestItem);
            }
        }








    }
}