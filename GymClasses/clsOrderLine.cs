using System;

namespace GymClasses
{
    public class clsOrderLine
    {
        private String mEquipmentOrdered;
        public String EquipmentOrdered
        {
            get
            {
                return mEquipmentOrdered;
            }

            set
            {
                mEquipmentOrdered = value;
            }
        }


        private String mCustomerName;
        public String CustomerName
        {

            get
            {
                return mCustomerName;
            }

            set
            {
                mCustomerName = value;
            }
        }


        private bool mOrderProcessed;
        public bool OrderProcessed
        {
            get
            {
                return mOrderProcessed;
            }
            set
            {

                mOrderProcessed = value;

            }
        }


        private DateTime mDateProcessed;
        public DateTime DateProcessed
        {
            get
            {
                return mDateProcessed;
            }
            set
            {

                mDateProcessed = value;

            }
        }




        private Int32 mOrderNo;
        public int OrderNo
        {

            get

            {
                return mOrderNo;

            }

            set
            {
                mOrderNo = value;


            }
        }
        private int mTotalCost;
        public int TotalCost
        {

            get
            {
                return mTotalCost;
            }

            set
            {
                mTotalCost = value;

            }
        }



        public bool Find(int OrderNo)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineNo");
            if (DB.Count == 1)
            {

                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mEquipmentOrdered = Convert.ToString(DB.DataTable.Rows[0]["EquipmentOrdered"]);
                mTotalCost = Convert.ToInt16(DB.DataTable.Rows[0]["TotalCost"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mOrderProcessed = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderProcessed]);
                mDateProcessed = Convert.ToDateTime(DB.DataTable.Rows[0]["16/09/2019"]);

                return true;
            }
            else
            {
                return false;
            }
        }

      
        public string Valid(string customerName, string equipmentOrdered, bool orderProcessed, string orderNo, DateTime dateProcessed)
{
            String Error = "";
                if (orderNo.Equals(0))
                {
                Error = Error + "The order no may not be blank: ";
                }
            return Error;
            }

        
    }


    }

        













    
