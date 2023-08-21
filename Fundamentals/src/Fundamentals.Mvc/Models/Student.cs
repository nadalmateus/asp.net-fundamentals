using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundamentals.Mvc.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Field {0} must be between {2} and {1} characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [DataType(DataType.DateTime, ErrorMessage = "Field {0} is in incorrect format")]
        [Display(Name = "Date of birth")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(60, ErrorMessage = "Field {0} must have a maximum of {1} characters")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name = "Confirm the email")]
        [Compare("Email", ErrorMessage = "The e-mails entered are not identical.")]
        [NotMapped]
        public string? EmailConfirmation { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Range(1, 5, ErrorMessage = "Field {0} must be between {1} and {2}")]
        public int Grade { get; set; }

        public bool Active { get; set; }
    }
}