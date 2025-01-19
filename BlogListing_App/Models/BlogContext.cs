using Microsoft.EntityFrameworkCore;

namespace BlogListing_App.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Blog> BlogPosts { get; set; }
    }
}
