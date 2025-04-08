namespace Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string? Email { get; set; }
        public DateTime Datecreated { get; set; }
        public string Password { get; set; }
        public string? Location { get; set; }

    }
}
