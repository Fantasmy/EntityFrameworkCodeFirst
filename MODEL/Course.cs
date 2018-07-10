using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }
        public int Id { get; set; }
        //public int TeacherId { get; set; }
        //public int StudentId { get; set; }

        public ICollection<Student> Students { get; set; }
        public Subject Subjects { get; set; }
        public Teacher Teachers { get; set; }

    }
}
