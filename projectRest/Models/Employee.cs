namespace projectRest.Models;

public class Employee
{
    [Key]
    public int EmployeeID { get; set; }
    [Required(ErrorMessage = "Your Name is required")]
    public string Employee_Name { get; set; }
    [Required(ErrorMessage = "Your Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address Format")]
    public string Email { get; set; }
    public string Salary { get; set; }
    public int DepartmentID { get; set; }
    public Department Department { get; set; }

}
