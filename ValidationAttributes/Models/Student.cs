using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required (ErrorMessage = "Name is Required")]
        [StringLength(15, MinimumLength = 3)]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(5,60,ErrorMessage ="Must be between 5 to 60")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$\"\r\n")]
        public string Password { get; set; }
    }
}
