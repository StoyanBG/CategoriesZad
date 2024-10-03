using Categories.Models;
using Microsoft.EntityFrameworkCore;

namespace Categories.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }

    }
}
