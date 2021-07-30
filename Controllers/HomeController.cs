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
FirstName = "John" ,
LastName = "Darth" ,
Email = "john@test.com" ,
Course = "Java" ,
},
new Instructor()
{
InstructorId = 102,
FirstName = "Hile" ,
LastName = "Atlas" ,
Email = "Atlas@test.com" ,
Course = "C" ,
},
new Instructor()
{
InstructorId = 103,
FirstName = "Jack" ,
LastName = "Connor" ,
Email = "jack@test.com" ,
Course = "C++" ,
},
new Instructor()
{
InstructorId = 104,
FirstName = "Harry" ,
LastName = "Callum" ,
Email = "Callum@test.com" ,
Course = ".Net" ,
},
new Instructor()
{
InstructorId = 105,
FirstName = "Jacob" ,
LastName = "Seth" ,
Email = "Jacob@test.com" ,
Course = "SQL" ,
}
};
            students = new List<Student>()
{
new Student()
{
StudentId = 201,
FirstName = "Charlie",
LastName = "Kyle",
Email = "Kyle@test.com",
Phone = "202-555-0158",
Course = "Java"
},
new Student()
{
StudentId = 202,
FirstName = "George",
LastName = "Reece",
Email = "Reecee@test.com",
Phone = "202-555-0117",
Course = "Java"
},
new Student()
{
StudentId = 203,
FirstName = "Oscar",
LastName = "Rhys",
Email = "Rhys@test.com",
Phone = "202-555-0189",
Course = "SQL"
},
new Student()
{
StudentId = 204,
FirstName = "James",
LastName = "Charlie",
Email = "Charlie@test.com",
Phone = "202-555-0426",
Course = "C++"
},
new Student()
{
StudentId = 205,
FirstName = "William",
LastName = "Damian",
Email = "Damian@test.com",
Phone = "202-555-0876",
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
        public IActionResult Instructor()
        {
            ViewBag.Instructors = instructors;
            return View();
        }
        //Student
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
