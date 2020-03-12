using System;

namespace GymClasses
{
    public class clsEquipment
    {
        public bool Find(int EquipmentNo)
        {
            mEquipmentNo = 1;
            mEquipmentDateAdded = Convert.ToDateTime("01 / 01 / 2020");
            mEquipmentDescription = "Weights";
            mEquipmentColour = "Black";
            mEquipmentPrice = 100;
            return true;

        }
        private Int32 mEquipmentNo;
        public Int32 EquipmentNo
        {
            get
            {
                return mEquipmentNo;
            }

            set
            {
                mEquipmentNo = value;
            }
        }
        private String mEquipmentDescription;
        public String EquipmentDescription
        {
            get
            {
                return mEquipmentDescription;
            }

            set
            {
                mEquipmentDescription = value;
            }
        }

        

        private DateTime mEquipmentDateAdded;
        public DateTime EquipmentDateAdded
        {
            get
            {
                return mEquipmentDateAdded;
            }

            set
            {
                mEquipmentDateAdded = value;
            }
        }
        private Int32 mEquipmentPrice;
        public int EquipmentPrice
        {
            get
            {
                return mEquipmentPrice;
            }

            set
            {
                mEquipmentPrice = value;
            }
        }

        private Boolean mEquipmentAvailable;
        private string mEquipmentColour;

        public Boolean EquipmentAvailable
        {
            get
            {
                return mEquipmentAvailable;
            }

            set
            {
                mEquipmentAvailable = value;
            }
        }

        public string EquipmentColour
        {
            get
            {
                return mEquipmentColour;
            }
            set
            {
                mEquipmentColour = value;



            }

        }

        public bool Find2(int EquipmentNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EquipmentNo", EquipmentNo);
            DB.Execute("sproc_tblEquipment_FilterByEquipmentNo");
            if (DB.Count == 1)
            {
                mEquipmentNo = Convert.ToInt32(DB.DataTable.Rows[0]["EquipmentNo"]);
                mEquipmentPrice = Convert.ToInt32(DB.DataTable.Rows[0]["EquipmentPrice"]);
                mEquipmentDescription = Convert.ToString(DB.DataTable.Rows[0]["EquipmentDescription"]);
                mEquipmentColour = Convert.ToString(DB.DataTable.Rows[0]["EquipmentColour"]);
                mEquipmentDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["EquipmentDateAdded"]);
                mEquipmentAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["EquipmentAvailable"]);

                return true;
            }
            else
            {
                return false;
            }
        }


        

        public string Valid(string EquipmentDescription, string EquipmentColour, string EquipmentDateAdded, int EquipmentPrice)
        {
            string Error = "";
            DateTime DateTemp;
            if (EquipmentDescription.Length == 0)
            {
                Error = Error + "The Equipment Number may not be blank : ";
            
            }
            if(EquipmentDescription.Length > 51)
            {
                Error = Error + "The Equipment Number must be less than 51 : ";
            }
            DateTemp = Convert.ToDateTime(EquipmentDateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            if (EquipmentColour.Length == 0)
            {
                Error = Error + "The Equipment Number may not be blank : ";

            }
            if (EquipmentColour.Length > 21)
            {
                Error = Error + "The Equipment Number must be less than 21 : ";
            }
            if (EquipmentPrice == 0)
            {
                Error = Error + "The Equipment Number may not be blank : ";

            }
            if (EquipmentPrice > 901)
            {
                Error = Error + "The Equipment Number must be less than 901 : ";
            }
            return Error;
        }


    }
}