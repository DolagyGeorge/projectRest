namespace projectRest.Models;

public class Offer
{
    [Key]
    public int OfferID { get; set; }
    [Required(ErrorMessage = "Offer Name is required")]
    public string Offer_Name { get; set; }
    [Required(ErrorMessage = "Offer Price is required")]
    public float Offer_Price { get; set; }
    public string Offer_Description { get; set; }
    public string Offer_Image { get; set; }
}