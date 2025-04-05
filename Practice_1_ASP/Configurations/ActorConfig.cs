using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice_1_ASP.Entities;

public class ActorConfig : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {

        builder.HasKey(a => a.Id);

        builder.HasMany(a => a.Films)
               .WithMany(f => f.Actors);
    }
}
