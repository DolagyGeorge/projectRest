namespace Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Ticket_Subject{ get; set; }
        public string Ticket_Message { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}
