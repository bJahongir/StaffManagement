using System.ComponentModel.DataAnnotations;

namespace StaffManagement.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="FirstName")]
        [MaxLength(50)]
        public string FirstName { get; set; } 

        [Required]
        [Display(Name ="LastName")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
 
        [Required]
        [Display(Name ="Department")]
        public Departments? Department { get; set; }

        public string PhotoFilePath { get; set; }
    }
}
