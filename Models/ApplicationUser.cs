using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class ApplicationUser:IdentityUser
    {
        public String Name { get; set; }
    }
}
