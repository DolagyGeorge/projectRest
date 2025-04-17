using Models;

namespace projectRest.Models
{
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        public string Comment { get; set; }
    }
}
