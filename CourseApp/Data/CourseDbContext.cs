using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseApp.Models;

namespace CourseApp.Data
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext (DbContextOptions<CourseDbContext> options)
            : base(options)
        {
        }

        public DbSet<CourseApp.Models.Course> Course { get; set; } = default!;
    }
}
