using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice_1_ASP.Migrations
{
    /// <inheritdoc />
    public partial class urlUpd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 15,
                column: "Photo",
                value: "https://upload.wikimedia.org/wikipedia/en/d/d6/Avatar_%282009_film%29_poster.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 16,
                column: "Photo",
                value: "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 17,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 18,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 19,
                column: "Photo",
                value: "https://sm.ign.com/ign_nordic/cover/d/dune-2021/dune-2021_dcbx.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 20,
                column: "Photo",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 15,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/41p+5VEzbIL._AC_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 16,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71rXSVqETkL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 17,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71zWYYM4aFL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 18,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71nz3cIcFOL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 19,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/81dGM9EEGHL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 20,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71TqLRP8R3L._AC_SY679_.jpg");
        }
    }
}
