using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models.ModelView
{
    public class Register
    {
        [Required]
        public String Name { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be atleast {1} characters long", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage ="The password and confirmation password do not match")]
        [DataType(DataType.Password)]
        public String Confirmpassword { get; set; }
        [Required]
        public String Course { get; set; }
        [Required]
        [Display(Name ="Rank")]
        public String Role { get; set; }
    }
}
