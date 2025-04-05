using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice_1_ASP.Entities;

namespace Practice_1_ASP.Configurations;

public class ActorFilmConfig
{
    public void Configure(EntityTypeBuilder<ActorFilm> builder)
    {

        builder.HasKey(af => new { af.ActorId, af.FilmId });
    }
}
