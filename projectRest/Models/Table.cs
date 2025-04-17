using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace projectRest.Models
{
    public class Table
    {
       [Key]
        public int TableID { get; set; }
        public bool IsAvailable { get; set; }
    }
}
