using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsEquipmentCollection
    {
        public List<clsEquipment> EquipmentList
        {
            get
            {
                return mEquipmentList;
            }
            set
            {
                mEquipmentList = value;
            }
        }

        public int Count
        {
            get
            {
                return mEquipmentList.Count;
            }


            set
            {

            }
        }
        public clsEquipment ThisEquipment { get; set; }
        public List<clsEquipment> mEquipmentList { get; private set; }
        public List<clsEquipment> DataSource { get; set; }

        public clsEquipmentCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEquipment_SelectAll");
            RecordCount = DB.Count;
            mEquipmentList = new List<clsEquipment>();
            while (Index < RecordCount)
            {

                
                clsEquipment AnEquipment = new clsEquipment();
                AnEquipment.EquipmentNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EquipmentNo"]);
                AnEquipment.EquipmentPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["EquipmentPrice"]);
                AnEquipment.EquipmentDescription = Convert.ToString(DB.DataTable.Rows[Index]["EquipmentDescription"]);
                AnEquipment.EquipmentColour = Convert.ToString(DB.DataTable.Rows[Index]["EquipmentColour"]);
                AnEquipment.EquipmentDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["EquipmentDateAdded"]);
                AnEquipment.EquipmentAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["EquipmentAvailable"]);
                mEquipmentList.Add(AnEquipment);
                Index++;
            }
        }








    }
}