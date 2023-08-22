using Microsoft.EntityFrameworkCore;
using SchoolConnect.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolConnect.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options)
        {

        }
        DbSet<Department> departments { get; set; }
        DbSet<Student> students { get; set; } 
        DbSet<DepartmentSubject> departmentSubjects { get; set; }
        DbSet<Subjects> subjects { get; set; }
        DbSet<StudentSubject> studentSubjects { get; set; }


    }
}
