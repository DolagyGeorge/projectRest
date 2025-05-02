using Models;

namespace projectRest.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string Customer_Name { get; set; }
        public string Product_Name { get; set; }
        public string Email { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        public int Rating { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
