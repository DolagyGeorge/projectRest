public class Contact
{
    [Key]
    public int ContactID { get; set; }

    [Required(ErrorMessage = "Subject is required")]
    public string Ticket_Subject { get; set; }

    [Required(ErrorMessage = "Message is required")]
    public string Ticket_Message { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Customer_Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Customer_Email { get; set; }
}