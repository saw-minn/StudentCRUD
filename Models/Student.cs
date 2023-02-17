using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Xml.Linq;

namespace StudentCRUD.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public DateTime Accesstime { get; set; }
    }

}
