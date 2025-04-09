namespace Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Ticket_Subject{ get; set; }
        public string Ticket_Message { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
