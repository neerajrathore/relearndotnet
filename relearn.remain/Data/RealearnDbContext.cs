using Microsoft.EntityFrameworkCore;
using relearn.remain.Models.Domain;

namespace relearn.remain.Data
{
    public class RealearnDbContext : DbContext
    {
        public RealearnDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
