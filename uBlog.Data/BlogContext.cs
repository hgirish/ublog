using Microsoft.EntityFrameworkCore;

namespace uBlog.Data
{
    public class BlogContext: DbContext, IBlogContext
    {
        private readonly string connectionString;
        public BlogContext(string dbPath)
        {
            connectionString = $"Data Source={dbPath}";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // entity
            base.OnModelCreating(modelBuilder);
        }

        public bool EnsureCreated()
        {
            return Database.EnsureCreated();
        }
    }
}
