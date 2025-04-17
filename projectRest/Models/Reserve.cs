using Models;

namespace projectRest.Models
{
    public class Reserve
    {
        [Key]
        public int ReserveID { get; set; }
        public int TableID { get; set; }
        public Table Table { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime Reserved_Date { get; set; }
        public DateTime Reserved_Time { get; set; }
    }
}
