﻿namespace projectRest.Models;

public class Department
{
    [Key]
    public int DepartmentID { get; set; }
    [Required(ErrorMessage = "Category Name is required")]
    public string Department_Name { get; set; }
    public int Department_Manager_ID { get; set; }
}
