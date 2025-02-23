using Microsoft.EntityFrameworkCore;
using Practice_1_ASP.Models;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Practice_1_ASP.Persistance;

public static class Extensions
{
    public static void SeedInitialData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FilmModel>().HasData(
            new FilmModel { Id = 1, Name = "Inception", Photo = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", Year = 2010, Description = "A thief who enters the dreams of others.", Genre = "Sci-Fi", Country = "USA", DurationMinutes = 148 },
            new FilmModel { Id = 2, Name = "The Dark Knight", Photo = "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg", Year = 2008, Description = "Batman faces the Joker in Gotham.", Genre = "Action", Country = "USA", DurationMinutes = 152 },
            new FilmModel { Id = 3, Name = "Titanic", Photo = "https://play-lh.googleusercontent.com/560-H8NVZRHk00g3RltRun4IGB-Ndl0I0iKy33D7EQ0cRRwH78-c46s90lZ1ho_F1so=w240-h480-rw", Year = 1997, Description = "A tragic love story aboard the Titanic.", Genre = "Drama", Country = "USA", DurationMinutes = 195 },
            new FilmModel { Id = 4, Name = "The Matrix", Photo = "https://m.media-amazon.com/images/I/51EG732BV3L.jpg", Year = 1999, Description = "A hacker discovers the nature of reality.", Genre = "Sci-Fi", Country = "USA", DurationMinutes = 136 },
            new FilmModel { Id = 5, Name = "Pulp Fiction", Photo = "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg", Year = 1994, Description = "Intertwined stories of crime and redemption.", Genre = "Crime", Country = "USA", DurationMinutes = 154 },
            new FilmModel { Id = 6, Name = "The Shawshank Redemption", Photo = "https://m.media-amazon.com/images/I/51zUbui+gbL.jpg", Year = 1994, Description = "A man imprisoned for a crime he didn't commit.", Genre = "Drama", Country = "USA", DurationMinutes = 142 },
            new FilmModel { Id = 7, Name = "Forrest Gump", Photo = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 1994, Description = "A man with a low IQ influences history.", Genre = "Drama", Country = "USA", DurationMinutes = 142 },
            new FilmModel { Id = 8, Name = "Interstellar", Photo = "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SY679_.jpg", Year = 2014, Description = "A space mission to save humanity.", Genre = "Sci-Fi", Country = "USA", DurationMinutes = 169 },
            new FilmModel { Id = 9, Name = "Fight Club", Photo = "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 1999, Description = "An insomniac and a soap salesman start an underground fight club.", Genre = "Drama", Country = "USA", DurationMinutes = 139 },
            new FilmModel { Id = 10, Name = "Gladiator", Photo = "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_.jpg", Year = 2000, Description = "A betrayed general seeks revenge in Rome.", Genre = "Action", Country = "USA", DurationMinutes = 155 },
            new FilmModel { Id = 11, Name = "The Godfather", Photo = "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_.jpg", Year = 1972, Description = "A mafia family's rise and struggle.", Genre = "Crime", Country = "USA", DurationMinutes = 175 },
            new FilmModel { Id = 12, Name = "The Lord of the Rings: The Fellowship of the Ring", Photo = "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg", Year = 2001, Description = "A hobbit sets out to destroy a powerful ring.", Genre = "Fantasy", Country = "New Zealand", DurationMinutes = 178 },
            new FilmModel { Id = 13, Name = "The Lord of the Rings: The Two Towers", Photo = "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2002, Description = "The battle for Middle-earth intensifies.", Genre = "Fantasy", Country = "New Zealand", DurationMinutes = 179 },
            new FilmModel { Id = 14, Name = "The Lord of the Rings: The Return of the King", Photo = "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_.jpg", Year = 2003, Description = "The final battle for Middle-earth.", Genre = "Fantasy", Country = "New Zealand", DurationMinutes = 201 },
            new FilmModel { Id = 15, Name = "Avatar", Photo = "https://upload.wikimedia.org/wikipedia/en/d/d6/Avatar_%282009_film%29_poster.jpg", Year = 2009, Description = "A marine on an alien planet must choose sides.", Genre = "Sci-Fi", Country = "USA", DurationMinutes = 162 },
            new FilmModel { Id = 16, Name = "The Avengers", Photo = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg", Year = 2012, Description = "Earth's mightiest heroes team up to stop Loki.", Genre = "Action", Country = "USA", DurationMinutes = 143 },
            new FilmModel { Id = 17, Name = "Joker", Photo = "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_.jpg", Year = 2019, Description = "A failed comedian descends into madness.", Genre = "Drama", Country = "USA", DurationMinutes = 122 },
            new FilmModel { Id = 18, Name = "Spider-Man: No Way Home", Photo = "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_.jpg", Year = 2021, Description = "Peter Parker deals with multiverse consequences.", Genre = "Action", Country = "USA", DurationMinutes = 148 },
            new FilmModel { Id = 19, Name = "Dune", Photo = "https://sm.ign.com/ign_nordic/cover/d/dune-2021/dune-2021_dcbx.jpg", Year = 2021, Description = "A noble family fights for control of a desert planet.", Genre = "Sci-Fi", Country = "USA", DurationMinutes = 155 },
            new FilmModel { Id = 20, Name = "Oppenheimer", Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg", Year = 2023, Description = "The story of the man who built the atomic bomb.", Genre = "Biography", Country = "USA", DurationMinutes = 180 }
        );
    }


}
