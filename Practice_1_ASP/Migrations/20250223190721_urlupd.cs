using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice_1_ASP.Migrations
{
    /// <inheritdoc />
    public partial class urlupd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "https://play-lh.googleusercontent.com/560-H8NVZRHk00g3RltRun4IGB-Ndl0I0iKy33D7EQ0cRRwH78-c46s90lZ1ho_F1so=w240-h480-rw");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 11,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 13,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 14,
                column: "Photo",
                value: "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/51oD6hAZQYL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71p8G+Lpt0L._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71w-PqrXoXL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/71VXTI-XOQL._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 9,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/81sA2zAxL9L._AC_SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 10,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/51y-0gpiHCL.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 11,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/51sl+4W5vIL.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 13,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/51GndkbMJDL._AC_.jpg");

            migrationBuilder.UpdateData(
                table: "FilmModels",
                keyColumn: "Id",
                keyValue: 14,
                column: "Photo",
                value: "https://m.media-amazon.com/images/I/91kTZZKpxeL._AC_SY679_.jpg");
        }
    }
}
