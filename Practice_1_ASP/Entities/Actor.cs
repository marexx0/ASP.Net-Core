namespace Practice_1_ASP.Entities;

public class Actor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public ICollection<FilmModel> Films { get; set; }
}
