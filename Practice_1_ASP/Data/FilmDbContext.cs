using Practice_1_ASP.Models;
using Microsoft.EntityFrameworkCore;
using Practice_1_ASP.Persistance;
using Practice_1_ASP.Entities;

namespace Practice_1_ASP.Data;

public class FilmDbContext:DbContext
{
    public DbSet<FilmModel> Films { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<ActorFilm> ActorFilms { get; set; }

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
        modelBuilder.Entity<ActorFilm>()
                .HasKey(af => new { af.ActorId, af.FilmId });
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FilmDbContext).Assembly);
        modelBuilder.SeedInitialData();
    }
}
