namespace projectRest.Models;

public class Product
{
    [Key]
    public int Product_ID { get; set; }
    [Required(ErrorMessage = "Product Name is required")]
    public string Product_Name { get; set; }
    [Required(ErrorMessage = "Product Price is required")]
    public decimal Product_Price { get; set; }
    [Required(ErrorMessage = "Product Quantity is required")]
    public int Product_Quantity { get; set; }
    public int Category_ID { get; set; }
    public string Product_Description { get; set; }
    public string Product_Image { get; set; }
}