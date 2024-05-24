using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required (ErrorMessage = "Name is Required")] public string  Name { get; set; }
    }
}
