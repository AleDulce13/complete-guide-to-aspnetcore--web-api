using Libreria_DALS.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace Libreria_DALS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
