using BlogPersonal.Models;
using Microsoft.EntityFrameworkCore;
namespace BlogPersonal.Data
{
    public class BlogPersonalDbContext: DbContext
    {
        public BlogPersonalDbContext(DbContextOptions<BlogPersonalDbContext> options)
            : base(options)
        {
        }

        public DbSet<Publicacion> Publicacion { get; set; }

    }
}
