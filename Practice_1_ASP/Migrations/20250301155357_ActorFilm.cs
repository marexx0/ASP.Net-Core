using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Practice_1_ASP.Migrations
{
    /// <inheritdoc />
    public partial class ActorFilm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmModels");

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorFilmModel",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilmModel", x => new { x.ActorsId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_ActorFilmModel_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilmModel_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorFilms",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilms", x => new { x.ActorId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_ActorFilms_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 49, "Leonardo", "DiCaprio" },
                    { 2, 50, "Christian", "Bale" },
                    { 3, 48, "Kate", "Winslet" },
                    { 4, 59, "Keanu", "Reeves" },
                    { 5, 75, "Samuel", "Jackson" },
                    { 6, 86, "Morgan", "Freeman" },
                    { 7, 67, "Tom", "Hanks" },
                    { 8, 54, "Matthew", "McConaughey" },
                    { 9, 60, "Brad", "Pitt" },
                    { 10, 59, "Russell", "Crowe" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "Description", "DurationMinutes", "Genre", "Name", "Photo", "Year" },
                values: new object[,]
                {
                    { 1, "USA", "A thief who enters the dreams of others.", 148, "Sci-Fi", "Inception", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", 2010 },
                    { 2, "USA", "Batman faces the Joker in Gotham.", 152, "Action", "The Dark Knight", "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg", 2008 },
                    { 3, "USA", "A tragic love story aboard the Titanic.", 195, "Drama", "Titanic", "https://play-lh.googleusercontent.com/560-H8NVZRHk00g3RltRun4IGB-Ndl0I0iKy33D7EQ0cRRwH78-c46s90lZ1ho_F1so=w240-h480-rw", 1997 },
                    { 4, "USA", "A hacker discovers the nature of reality.", 136, "Sci-Fi", "The Matrix", "https://m.media-amazon.com/images/I/51EG732BV3L.jpg", 1999 },
                    { 5, "USA", "Intertwined stories of crime and redemption.", 154, "Crime", "Pulp Fiction", "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg", 1994 },
                    { 6, "USA", "A man imprisoned for a crime he didn't commit.", 142, "Drama", "The Shawshank Redemption", "https://m.media-amazon.com/images/I/51zUbui+gbL.jpg", 1994 },
                    { 7, "USA", "A man with a low IQ influences history.", 142, "Drama", "Forrest Gump", "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 1994 },
                    { 8, "USA", "A space mission to save humanity.", 169, "Sci-Fi", "Interstellar", "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SY679_.jpg", 2014 },
                    { 9, "USA", "An insomniac and a soap salesman start an underground fight club.", 139, "Drama", "Fight Club", "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 1999 },
                    { 10, "USA", "A betrayed general seeks revenge in Rome.", 155, "Action", "Gladiator", "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_.jpg", 2000 },
                    { 11, "USA", "A mafia family's rise and struggle.", 175, "Crime", "The Godfather", "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_.jpg", 1972 },
                    { 12, "New Zealand", "A hobbit sets out to destroy a powerful ring.", 178, "Fantasy", "The Lord of the Rings: The Fellowship of the Ring", "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg", 2001 },
                    { 13, "New Zealand", "The battle for Middle-earth intensifies.", 179, "Fantasy", "The Lord of the Rings: The Two Towers", "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 2002 },
                    { 14, "New Zealand", "The final battle for Middle-earth.", 201, "Fantasy", "The Lord of the Rings: The Return of the King", "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_.jpg", 2003 },
                    { 15, "USA", "A marine on an alien planet must choose sides.", 162, "Sci-Fi", "Avatar", "https://upload.wikimedia.org/wikipedia/en/d/d6/Avatar_%282009_film%29_poster.jpg", 2009 },
                    { 16, "USA", "Earth's mightiest heroes team up to stop Loki.", 143, "Action", "The Avengers", "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg", 2012 },
                    { 17, "USA", "A failed comedian descends into madness.", 122, "Drama", "Joker", "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_.jpg", 2019 },
                    { 18, "USA", "Peter Parker deals with multiverse consequences.", 148, "Action", "Spider-Man: No Way Home", "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_.jpg", 2021 },
                    { 19, "USA", "A noble family fights for control of a desert planet.", 155, "Sci-Fi", "Dune", "https://sm.ign.com/ign_nordic/cover/d/dune-2021/dune-2021_dcbx.jpg", 2021 },
                    { 20, "USA", "The story of the man who built the atomic bomb.", 180, "Biography", "Oppenheimer", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg", 2023 }
                });

            migrationBuilder.InsertData(
                table: "ActorFilms",
                columns: new[] { "ActorId", "FilmId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilmModel_FilmsId",
                table: "ActorFilmModel",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilms_FilmId",
                table: "ActorFilms",
                column: "FilmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorFilmModel");

            migrationBuilder.DropTable(
                name: "ActorFilms");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.CreateTable(
                name: "FilmModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FilmModels",
                columns: new[] { "Id", "Country", "Description", "DurationMinutes", "Genre", "Name", "Photo", "Year" },
                values: new object[,]
                {
                    { 1, "USA", "A thief who enters the dreams of others.", 148, "Sci-Fi", "Inception", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", 2010 },
                    { 2, "USA", "Batman faces the Joker in Gotham.", 152, "Action", "The Dark Knight", "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg", 2008 },
                    { 3, "USA", "A tragic love story aboard the Titanic.", 195, "Drama", "Titanic", "https://play-lh.googleusercontent.com/560-H8NVZRHk00g3RltRun4IGB-Ndl0I0iKy33D7EQ0cRRwH78-c46s90lZ1ho_F1so=w240-h480-rw", 1997 },
                    { 4, "USA", "A hacker discovers the nature of reality.", 136, "Sci-Fi", "The Matrix", "https://m.media-amazon.com/images/I/51EG732BV3L.jpg", 1999 },
                    { 5, "USA", "Intertwined stories of crime and redemption.", 154, "Crime", "Pulp Fiction", "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg", 1994 },
                    { 6, "USA", "A man imprisoned for a crime he didn't commit.", 142, "Drama", "The Shawshank Redemption", "https://m.media-amazon.com/images/I/51zUbui+gbL.jpg", 1994 },
                    { 7, "USA", "A man with a low IQ influences history.", 142, "Drama", "Forrest Gump", "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 1994 },
                    { 8, "USA", "A space mission to save humanity.", 169, "Sci-Fi", "Interstellar", "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SY679_.jpg", 2014 },
                    { 9, "USA", "An insomniac and a soap salesman start an underground fight club.", 139, "Drama", "Fight Club", "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 1999 },
                    { 10, "USA", "A betrayed general seeks revenge in Rome.", 155, "Action", "Gladiator", "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_.jpg", 2000 },
                    { 11, "USA", "A mafia family's rise and struggle.", 175, "Crime", "The Godfather", "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_.jpg", 1972 },
                    { 12, "New Zealand", "A hobbit sets out to destroy a powerful ring.", 178, "Fantasy", "The Lord of the Rings: The Fellowship of the Ring", "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg", 2001 },
                    { 13, "New Zealand", "The battle for Middle-earth intensifies.", 179, "Fantasy", "The Lord of the Rings: The Two Towers", "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 2002 },
                    { 14, "New Zealand", "The final battle for Middle-earth.", 201, "Fantasy", "The Lord of the Rings: The Return of the King", "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_.jpg", 2003 },
                    { 15, "USA", "A marine on an alien planet must choose sides.", 162, "Sci-Fi", "Avatar", "https://upload.wikimedia.org/wikipedia/en/d/d6/Avatar_%282009_film%29_poster.jpg", 2009 },
                    { 16, "USA", "Earth's mightiest heroes team up to stop Loki.", 143, "Action", "The Avengers", "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg", 2012 },
                    { 17, "USA", "A failed comedian descends into madness.", 122, "Drama", "Joker", "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_.jpg", 2019 },
                    { 18, "USA", "Peter Parker deals with multiverse consequences.", 148, "Action", "Spider-Man: No Way Home", "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_.jpg", 2021 },
                    { 19, "USA", "A noble family fights for control of a desert planet.", 155, "Sci-Fi", "Dune", "https://sm.ign.com/ign_nordic/cover/d/dune-2021/dune-2021_dcbx.jpg", 2021 },
                    { 20, "USA", "The story of the man who built the atomic bomb.", 180, "Biography", "Oppenheimer", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg", 2023 }
                });
        }
    }
}
