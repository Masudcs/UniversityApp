using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNO { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
}