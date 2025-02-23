using Practice_1_ASP.Models;
using Microsoft.EntityFrameworkCore;
using Practice_1_ASP.Persistance;

namespace Practice_1_ASP.Data;

public class FilmDbContext:DbContext
{
    public DbSet<FilmModel> FilmModels { get; set; }

    public FilmDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            var str = "Server=(localdb)\\mssqllocaldb;Database=CinemaDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(str);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FilmDbContext).Assembly);
        modelBuilder.SeedInitialData();
    }
}
