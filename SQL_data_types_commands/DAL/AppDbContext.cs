using Microsoft.EntityFrameworkCore;
using SQL_data_types_commands.Models;

namespace SQL_data_types_commands.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Blog>Blogs { get; set; }
    }
}
