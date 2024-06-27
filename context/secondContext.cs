using Microsoft.EntityFrameworkCore;
using thirdProject.Model;

namespace thirdProject.context
{
    public class secondContext : DbContext
    {
        public secondContext(DbContextOptions<secondContext> options)
      : base(options)
        {
        }

        public virtual DbSet<Employee> employees { get; set; }
    }
}
