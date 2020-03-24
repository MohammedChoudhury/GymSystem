using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();

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
        public clsOrderLine ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }
        

        public clsOrderLineCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {


                

                    clsOrderLine anOrderLine = new clsOrderLine();


                anOrderLine.OrderProcessed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                anOrderLine.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                anOrderLine.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                anOrderLine.DateProcessed = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateProcessed"]);
                anOrderLine.EquipmentOrdered = Convert.ToString(DB.DataTable.Rows[Index]["EquipmentOrdered"]);
                anOrderLine.TotalCost = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalCost"]);
                    mOrderLineList.Add(anOrderLine);
                Index++;
                }
            }

        public int Add()
        {
            mThisOrderLine.OrderNo = 1;
            return mThisOrderLine.OrderNo;
        }
    }

   




    }
