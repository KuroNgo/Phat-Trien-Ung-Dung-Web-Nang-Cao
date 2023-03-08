using Microsoft.EntityFrameworkCore;
using TagBlog.Core.Entities;
using TagBlog.Data.Mappings;

namespace TagBlog.Data.Contexts
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KRU45S6\\MSSQLSERVER01;Initial Catalog=TatBlog;Trusted_Connection=True;Integrated Security=True");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-KRU45S6;Database=TagBlog;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-KRU45S6;Database=TagBlog;Trusted_Connection=True;MultipleActiveResultSets=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(CategoryMap).Assembly);
        }
      
    }   
}
