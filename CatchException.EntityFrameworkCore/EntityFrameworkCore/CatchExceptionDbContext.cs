using CatchException.Answerers;
using CatchException.Issues;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity.EntityFrameworkCore;

namespace CatchException.EntityFrameworkCore;

public class CatchExceptionDbContext
    : AbpDbContext<CatchExceptionDbContext>
{
    public DbSet<Issue> Issues { get; set; }

    public DbSet<Answerer> Answerers { get; set; }

    public CatchExceptionDbContext(DbContextOptions<CatchExceptionDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureIdentity();

        modelBuilder.Entity<Issue>(b =>
        {
            b.ToTable("Issues");

            b.ConfigureByConvention();
            b.Property(p => p.Title).HasMaxLength(128);
            b.Property(p => p.Description).HasMaxLength(2048);
        });

        modelBuilder.Entity<Answerer>(b =>
        {
            b.ToTable("Answerers");

            b.ConfigureByConvention();
        });
    }
}