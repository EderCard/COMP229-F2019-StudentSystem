using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_F2019_StudentSystem.Models;

namespace COMP229_F2019_StudentSystem.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Student student = new Student
            {
                FirstName = "Ederson",
                LastName = "Cardoso"
            };

            return View(student);
        }
        public ViewResult ListStudents() {
            List<Student> studentsList = new List<Student>
            {
                new Student
                {
                    FirstName = "Ederson",
                    LastName = "Cardoso",
                    CourseCode = "COMP229",
                    Email = "edersoncard@gmail.com",
                    FullTime = true,
                    Gpa = 4.0,
                    StudentId = 301033332
                },
                new Student
                {
                    FirstName = "Joe",
                    LastName = "Doe",
                    CourseCode = "COMP100",
                    Email = "joedoe@gmail.com",
                    FullTime = false,
                    Gpa = 3.0,
                    StudentId = 30504009
                },
                new Student
                {
                    FirstName = "Susan",
                    LastName = "Mac",
                    CourseCode = "COMP123",
                    Email = "susanmace@gmail.com",
                    FullTime = true,
                    Gpa = 1.8,
                    StudentId = 30504444
                },
                new Student
                {
                    FirstName = "Richard",
                    LastName = "Dog",
                    CourseCode = "COMP225",
                    Email = "richarddog@gmail.com",
                    FullTime = true,
                    Gpa = 4.2,
                    StudentId = 30807777
                }
            };
            return View(studentsList);
        }
    }
}
