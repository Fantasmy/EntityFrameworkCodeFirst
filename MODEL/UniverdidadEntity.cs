using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace MODEL
{
    public class UniverdidadEntity : DbContext
    {
        public UniverdidadEntity()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<UniverdidadEntity>()); // dice a la base de datos que tiene un inicializador
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

    }
}
