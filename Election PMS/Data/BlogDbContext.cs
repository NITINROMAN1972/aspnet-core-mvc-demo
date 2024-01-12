using Election_PMS.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Election_PMS.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {

        }

        // creating entitiy
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
