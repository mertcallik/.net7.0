using AspnetCoreMert.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreMert.Models
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
            
        }
        public DbSet<Student>Students { get; set; }
    }
}
