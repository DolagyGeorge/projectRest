namespace Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Ticket_Subject{ get; set; }
        public string Ticket_Message { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Email { get; set; }

    }
}
