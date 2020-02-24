using System;

namespace GymClasses
{
    public class clsOrderLine
    {
        public DateTime DateOrdered { get; set; }
        public bool OrderProcessed { get; set; }
        public int TotalCost { get; set; }
        public int OrderNo { get; set; }
        public string EquipmentOrdered { get; set; }
        public string CustomerName { get; set; }
    }
}