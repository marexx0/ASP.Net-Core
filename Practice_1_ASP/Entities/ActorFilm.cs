namespace Practice_1_ASP.Entities;

public class ActorFilm
{
    public int ActorId { get; set; }
    public Actor Actor { get; set; }

    public int FilmId { get; set; }
    public FilmModel Film { get; set; }
}
