using Microsoft.AspNetCore.Mvc;
using DanaosMVCApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DanaosMVCApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public JsonResult GetStudentAverages() {
            var students = new List<Student> {
                new Student { Id = 1, Name = "Alice" },
                new Student { Id = 2, Name = "Bob" }
            };
            var grades = new List<Grade> {
                new Grade { Student_Id = 1, Course_Id = 1, Course_Name = "Math", GradeValue = 80 },
                new Grade { Student_Id = 1, Course_Id = 2, Course_Name = "Science", GradeValue = 90 },
                new Grade { Student_Id = 2, Course_Id = 1, Course_Name = "Math", GradeValue = 70 }
            };

            var averages = students.Select(s => new {
                Name = s.Name,
                Average = grades.Where(g => g.Student_Id == s.Id).Select(g => g.GradeValue).DefaultIfEmpty(0).Average()
            });

            return Json(averages);
        }
    }
}