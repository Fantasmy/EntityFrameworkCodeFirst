using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Student
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
