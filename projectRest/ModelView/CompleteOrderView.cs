namespace projectRest.ModelView
{
    public class CompleteOrderView
    {
        public decimal Total { get; set; }
        public List<OrderProduct> Items { get; set; }
    }
}
