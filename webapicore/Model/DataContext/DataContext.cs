using Microsoft.EntityFrameworkCore;

namespace webapicore.Model.DataContext
{
    public class DataContext:DbContext
    {

        public  DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User>? users { get; set; } 
    }
}
