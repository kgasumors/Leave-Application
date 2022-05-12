using Leave_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Leave_Application.Data
{
    public class RequestsDbContext:DbContext
    {
        public RequestsDbContext(DbContextOptions options):base (options)
        {

        }
        public DbSet<Requests> Requests { get; set; }
    }
}
