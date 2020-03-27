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

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderLineList = new List<clsOrderLine>();
            while (Index < RecordCount)
            {
                clsOrderLine anOrderLine = new clsOrderLine();

                anOrderLine.OrderProcessed = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderProcessed"]);
                anOrderLine.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                anOrderLine.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                anOrderLine.DateProcessed = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateProcessed"]);
                anOrderLine.EquipmentOrdered = Convert.ToString(DB.DataTable.Rows[Index]["EquipmentOrdered"]);
                anOrderLine.TotalCost = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalCost"]);
                mOrderLineList.Add(anOrderLine);
                Index++;
            }
        }
        public clsOrderLineCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            PopulateArray(DB);
            }

        public void ReportByCustomerName(object text)
        {
            throw new NotImplementedException();
        }

        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EquipmentOrdered", mThisOrderLine.EquipmentOrdered);
            DB.AddParameter("@CustomerName", mThisOrderLine.CustomerName);
            DB.AddParameter("@DateProcessed", mThisOrderLine.OrderProcessed);
            DB.AddParameter("@TotalCost", mThisOrderLine.TotalCost);
            DB.AddParameter("@OrderProcessed", mThisOrderLine.OrderProcessed);
            return DB.Execute("sproc_tblAddress_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrderLine.OrderNo);
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrderLine.OrderNo);
            DB.AddParameter("@EquipmentOrdered", mThisOrderLine.EquipmentOrdered);
            DB.AddParameter("@CustomerName", mThisOrderLine.CustomerName);
            DB.AddParameter("@DateProcessed", mThisOrderLine.OrderProcessed);
            DB.AddParameter("@TotalCost", mThisOrderLine.TotalCost);
            DB.AddParameter("@OrderProcessed", mThisOrderLine.OrderProcessed);
            DB.Execute("sproc_tblAddress_Update");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", CustomerName);
            DB.Execute("sproc_tblOrderLine_FilterByCustomerName");
            PopulateArray(DB);

        }

        




    }



   




    }
