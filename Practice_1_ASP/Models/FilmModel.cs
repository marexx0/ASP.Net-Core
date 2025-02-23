using System.ComponentModel.DataAnnotations.Schema;

public class FilmModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Photo { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public string Genre { get; set; }
    public string Country { get; set; }

    public int DurationMinutes { get; set; }

    [NotMapped]
    public TimeSpan Duration
    {
        get => TimeSpan.FromMinutes(DurationMinutes);
        set => DurationMinutes = (int)value.TotalMinutes;
    }
}
