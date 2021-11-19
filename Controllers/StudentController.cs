using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
           private readonly ApplicationDbContext db;
            public StudentController(ApplicationDbContext db)
            {
                this.db = db;
            }

            public IActionResult Index()
            {
            IEnumerable<Student> objList = db.students;
            return View(objList);
            }
        }
}
