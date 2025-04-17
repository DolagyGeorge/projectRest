using System.ComponentModel.DataAnnotations;
namespace projectRest.Models;

public class Category
{
    [Key]
    public int CategoryID { get; set; }
    [Required(ErrorMessage = "Category Name is required")]
    public string Category_Name { get; set; }
}
