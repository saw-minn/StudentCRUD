using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Xml.Linq;

namespace StudentCRUD.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string Address { get; set; }

        public Student(string address)
        {
            Address = address;
        }

        public string Phone { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }
        public object Courses { get; internal set; }
    }
        
}
