using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsEquipmentCollection
    {
        List<clsEquipment> mEquipmentList = new List<clsEquipment>();
        clsEquipment mThisEquipment = new clsEquipment();

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

        public clsEquipment ThisEquipment
        {
            get
            {
                return mThisEquipment;
            }
            set
            {
                mThisEquipment = value;
            }
        }


        public List<clsEquipment> DataSource { get; set; }

        public clsEquipmentCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEquipment_SelectAll");
            PopulateArray(DB);

        }
        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EquipmentPrice", mThisEquipment.EquipmentPrice);
            DB.AddParameter("@EquipmentDescription", mThisEquipment.EquipmentDescription);
            DB.AddParameter("@EquipmentColour", mThisEquipment.EquipmentColour);
            DB.AddParameter("@EquipmentDateAdded", mThisEquipment.EquipmentDateAdded);
            DB.AddParameter("@EquipmentAvailable", mThisEquipment.EquipmentPrice);
            return DB.Execute("sproc_tblEquipment_Insert");


        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EquipmentNo", mThisEquipment.EquipmentNo);
            DB.Execute("sproc_tblEquipment_Delete");

        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EquipmentPrice", mThisEquipment.EquipmentPrice);
            DB.AddParameter("@EquipmentDescription", mThisEquipment.EquipmentDescription);
            DB.AddParameter("@EquipmentColour", mThisEquipment.EquipmentColour);
            DB.AddParameter("@EquipmentDateAdded", mThisEquipment.EquipmentDateAdded);
            DB.AddParameter("@EquipmentAvailable", mThisEquipment.EquipmentPrice);
            DB.Execute("sproc_tblEquipment_Update");
        }



        public void ReportByEquipmentDescription(string EquipmentDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EquipmentDescription", EquipmentDescription);
            DB.Execute("sproc_tblEquipment_FilterByEquipmentDescription");
            PopulateArray(DB);
        }
    }
}
