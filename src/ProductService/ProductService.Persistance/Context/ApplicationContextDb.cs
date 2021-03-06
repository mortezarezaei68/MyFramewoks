using Framework.Context;
using Microsoft.EntityFrameworkCore;
using ProductService.Domain;
using ProductService.Persistance.DomainConfiguration;

namespace ProductService.Persistance.Context
{
    public class ApplicationContextDb : CoreDbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}