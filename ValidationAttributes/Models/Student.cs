using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required (ErrorMessage = "Name is Required")]
        [StringLength(15, MinimumLength = 3)]
        public string  Name { get; set; }
    }
}
