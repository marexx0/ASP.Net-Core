using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Practice_1_ASP.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmModels",
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
                    table.PrimaryKey("PK_FilmModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FilmModels",
                columns: new[] { "Id", "Country", "Description", "DurationMinutes", "Genre", "Name", "Photo", "Year" },
                values: new object[,]
                {
                    { 1, "USA", "A thief who enters the dreams of others.", 148, "Sci-Fi", "Inception", "https://m.media-amazon.com/images/I/51oD6hAZQYL._AC_SY679_.jpg", 2010 },
                    { 2, "USA", "Batman faces the Joker in Gotham.", 152, "Action", "The Dark Knight", "https://m.media-amazon.com/images/I/71p8G+Lpt0L._AC_SY679_.jpg", 2008 },
                    { 3, "USA", "A tragic love story aboard the Titanic.", 195, "Drama", "Titanic", "https://m.media-amazon.com/images/I/71w-PqrXoXL._AC_SY679_.jpg", 1997 },
                    { 4, "USA", "A hacker discovers the nature of reality.", 136, "Sci-Fi", "The Matrix", "https://m.media-amazon.com/images/I/51EG732BV3L.jpg", 1999 },
                    { 5, "USA", "Intertwined stories of crime and redemption.", 154, "Crime", "Pulp Fiction", "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg", 1994 },
                    { 6, "USA", "A man imprisoned for a crime he didn't commit.", 142, "Drama", "The Shawshank Redemption", "https://m.media-amazon.com/images/I/51zUbui+gbL.jpg", 1994 },
                    { 7, "USA", "A man with a low IQ influences history.", 142, "Drama", "Forrest Gump", "https://m.media-amazon.com/images/I/71VXTI-XOQL._AC_SY679_.jpg", 1994 },
                    { 8, "USA", "A space mission to save humanity.", 169, "Sci-Fi", "Interstellar", "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SY679_.jpg", 2014 },
                    { 9, "USA", "An insomniac and a soap salesman start an underground fight club.", 139, "Drama", "Fight Club", "https://m.media-amazon.com/images/I/81sA2zAxL9L._AC_SY679_.jpg", 1999 },
                    { 10, "USA", "A betrayed general seeks revenge in Rome.", 155, "Action", "Gladiator", "https://m.media-amazon.com/images/I/51y-0gpiHCL.jpg", 2000 },
                    { 11, "USA", "A mafia family's rise and struggle.", 175, "Crime", "The Godfather", "https://m.media-amazon.com/images/I/51sl+4W5vIL.jpg", 1972 },
                    { 12, "New Zealand", "A hobbit sets out to destroy a powerful ring.", 178, "Fantasy", "The Lord of the Rings: The Fellowship of the Ring", "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg", 2001 },
                    { 13, "New Zealand", "The battle for Middle-earth intensifies.", 179, "Fantasy", "The Lord of the Rings: The Two Towers", "https://m.media-amazon.com/images/I/51GndkbMJDL._AC_.jpg", 2002 },
                    { 14, "New Zealand", "The final battle for Middle-earth.", 201, "Fantasy", "The Lord of the Rings: The Return of the King", "https://m.media-amazon.com/images/I/91kTZZKpxeL._AC_SY679_.jpg", 2003 },
                    { 15, "USA", "A marine on an alien planet must choose sides.", 162, "Sci-Fi", "Avatar", "https://m.media-amazon.com/images/I/41p+5VEzbIL._AC_.jpg", 2009 },
                    { 16, "USA", "Earth's mightiest heroes team up to stop Loki.", 143, "Action", "The Avengers", "https://m.media-amazon.com/images/I/71rXSVqETkL._AC_SY679_.jpg", 2012 },
                    { 17, "USA", "A failed comedian descends into madness.", 122, "Drama", "Joker", "https://m.media-amazon.com/images/I/71zWYYM4aFL._AC_SY679_.jpg", 2019 },
                    { 18, "USA", "Peter Parker deals with multiverse consequences.", 148, "Action", "Spider-Man: No Way Home", "https://m.media-amazon.com/images/I/71nz3cIcFOL._AC_SY679_.jpg", 2021 },
                    { 19, "USA", "A noble family fights for control of a desert planet.", 155, "Sci-Fi", "Dune", "https://m.media-amazon.com/images/I/81dGM9EEGHL._AC_SY679_.jpg", 2021 },
                    { 20, "USA", "The story of the man who built the atomic bomb.", 180, "Biography", "Oppenheimer", "https://m.media-amazon.com/images/I/71TqLRP8R3L._AC_SY679_.jpg", 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmModels");
        }
    }
}
