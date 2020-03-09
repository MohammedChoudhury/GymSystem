using System;

namespace GymClasses
{
    public class clsEquipment
    {
        public bool Find(int EquipmentNo)
        {
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

        public string Valid(string equipmentDescription, string equipmentColour, string equipmentDateAdded, int equipmentPrice)
        {
            return "";
        }
    }
}
