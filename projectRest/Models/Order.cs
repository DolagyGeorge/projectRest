using Models;
using System;

namespace projectRest.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime Order_Date { get; set; }
        public int? CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }
        public float Total { get; set; }
        public int status { get; set; } = 0;


    }
}
