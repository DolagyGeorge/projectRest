using Models;
using System;

namespace projectRest.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime Order_Date { get; set; } = DateTime.Now;
        public int? EmployeeID { get; set; } // will be activated after making the login and credintials
        public Employee? Employee { get; set; }
        public float Total { get; set; }
        public int status { get; set; } = 0;
    }
}
