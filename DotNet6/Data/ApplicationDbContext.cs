using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace DotNet6.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<Customer>()
            .ToTable("Customers", b => b.IsTemporal());

        base.OnModelCreating(builder);
    }

    public DbSet<Customer> Customer { get; set; }
}
