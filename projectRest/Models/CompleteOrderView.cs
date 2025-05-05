namespace projectRest.Models
{
    public class CompleteOrderView
    {
        public decimal Total { get; set; }
        public List<OrderProduct> Items { get; set; }
    }
}
