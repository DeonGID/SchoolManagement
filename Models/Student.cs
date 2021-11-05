using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="MONDAY")]
        public String Monday { get; set; }
        [Display(Name = "TUESDAY")]

        public String Tuesday { get; set; }
        [Display(Name = "WEDNESDAY")]

        public String Wednesday { get; set; }
        [Display(Name = "THURSDAY")]

        public String Thursday { get; set; }
        [Display(Name = "FRIDAY")]

        public String Friday { get; set; }
    }
}
