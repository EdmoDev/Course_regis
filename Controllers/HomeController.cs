using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_App.Models;

namespace Web_App.Controllers
{
    public class HomeController : Controller
    {
        List<Instructor> instructors = null;
        List<Student> students = null;
        List<Course> courses = null;

        public HomeController()
        {
            instructors = new List<Instructor>()
{
new Instructor()
{
InstructorId = 101,
FirstName = "Johan" ,
LastName = "Smith" ,
Email = "Johan@robersoncollege.com" ,
Course = "Java" ,
},
new Instructor()
{
InstructorId = 102,
FirstName = "Hanna" ,
LastName = "Johnson" ,
Email = "Johnson@robersoncollege.com" ,
Course = "C" ,
},
new Instructor()
{
InstructorId = 103,
FirstName = "Kyle" ,
LastName = "Derrek" ,
Email = "Derrek@robersoncollege.com" ,
Course = "C++" ,
},
new Instructor()
{
InstructorId = 104,
FirstName = "Dier" ,
LastName = "Oddy" ,
Email = "Oddy@robersoncollege.com" ,
Course = ".Net" ,
},
new Instructor()
{
InstructorId = 105,
FirstName = "Oddete" ,
LastName = "Dockson" ,
Email = "Dockson@robersoncollege.com" ,
Course = "SQL" ,
}
};
            students = new List<Student>()
{
new Student()
{
StudentId = 201,
FirstName = "Odoi",
LastName = "Mcphee",
Email = "Mcphee@robersoncollege.com",
Phone = "305-758-0674",
Course = "Java"
},
new Student()
{
StudentId = 202,
FirstName = "Deann",
LastName = "Jays",
Email = "Jays@robersoncollege.com",
Phone = "305-325-3425",
Course = "Java"
},
new Student()
{
StudentId = 203,
FirstName = "brianna",
LastName = "Handson",
Email = "Handson@robersoncollege.com",
Phone = "305-532-3522",
Course = "SQL"
},
new Student()
{
StudentId = 204,
FirstName = "James",
LastName = "Charlie",
Email = "Charlie@robersoncollege.com",
Phone = "305-462-3521",
Course = "C++"
},
new Student()
{
StudentId = 205,
FirstName = "Jordan",
LastName = "Edmunds",
Email = "Edmunds@robersoncollege.com",
Phone = "305-555-0876",
Course = ".Net"
},
};
            courses = new List<Course>()
{
new Course()
{
CourseId = 301,
CourseName = "Java",
CourseNumber = 10,
Description = "To Learn Java",
},
new Course()
{
CourseId = 302,
CourseName = "C",
CourseNumber = 11,
Description = "To Learn C",
},
new Course()
{
CourseId = 303,
CourseName = "C++",
CourseNumber = 12,
Description = "To Learn C++",
},
new Course()
{
CourseId = 304,
CourseName = ".Net",
CourseNumber = 13,
Description = "To Learn Asp.Net",
},
new Course()
{
CourseId = 305,
CourseName = "SQL",
CourseNumber = 14,
Description = "To Learn SQL",
}
};
        }

        public IActionResult Index()
        {
            return View();
        }

        //Action method

        //instructor
        public IActionResult Instructor()
        {
            ViewBag.Instructors = instructors;
            return View();
        }
        //student
        public IActionResult Student()
        {
            ViewBag.Students = students;
            return View();
        }
        // course
        public IActionResult Course()
        {
            ViewBag.Courses = courses;
            return View();
        }
        
        public JsonResult GetStudentByCourse(string course)
        {
            var studentData = students.FindAll(s => s.Course == course).ToList();
            return Json(new { studentData });
        }

    }
}
