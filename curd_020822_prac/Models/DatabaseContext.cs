using Microsoft.EntityFrameworkCore;

namespace curd_020822_prac.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {

        }
        public DbSet<TblEmployee> tblEmployees { get; set; }
    }
}
