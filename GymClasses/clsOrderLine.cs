﻿using System;

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
                mOrderProcessed = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderProcessed"]);
                mDateProcessed = Convert.ToDateTime(DB.DataTable.Rows[0]["16/09/2019"]);

                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string customerName, int orderNo, int totalCost, string dateProcessed, string equipmentOrdered)
        {
            String Error = "";
            DateTime DateTemp;



            if (orderNo.Equals(0))
            {
                Error = Error + "The order no may not be blank: ";
            }

            if (orderNo.Equals(7))
            {
                Error = Error + "The order no must not be more than 6 numbers: ";


            }

            if (totalCost.Equals(0))
            {
                Error = Error + "The totalCost may not be blank: ";
            }

            if (orderNo.Equals(7))
            {
                Error = Error + "The order no must not be more than 6 numbers: ";


            }

            try
            {
                DateTemp = Convert.ToDateTime(dateProcessed);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }


            }

            catch


            {
                Error = Error + "The date was not a valid date";
            }
                if (equipmentOrdered.Length == 0)
                {
                    //record the error
                    Error = Error + "The customer name may not be blank : ";
                }
                //if the town is too long
                if (equipmentOrdered.Length > 50)
                {
                    //record the error
                    Error = Error + "The customer name must be less than 50 characters : ";



                }

                if (customerName.Length == 0)
                {
                    //record the error
                    Error = Error + "The customer name may not be blank : ";
                }
                //if the town is too long
                if (customerName.Length > 50)
                {
                    //record the error
                    Error = Error + "The customer name must be less than 50 characters : ";



                }
                return Error;
            

        }

    }

}
    

        













    
