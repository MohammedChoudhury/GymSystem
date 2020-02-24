using System;

namespace GymClasses
{
    public class clsCustomer
    {
        public int customerID { get; set; }
        public DateTime DateAdded { get; set; }
        public bool customerActive { get; set; }
        public string customerlastName { get; set; }
        public string customerFirstName { get; set; }
        public string customerUserName { get; set; }
    }
}