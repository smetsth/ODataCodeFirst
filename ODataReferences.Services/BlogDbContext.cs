using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ODataReferences.Contracts;

namespace ODataReferences.Services
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext()
            : base("BlogDbConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        // Disable creation of the EdmMetadata table. 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }

        public DbSet<BlogPost> Posts { get; set; }
    }
}