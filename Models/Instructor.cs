using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
    }
}
