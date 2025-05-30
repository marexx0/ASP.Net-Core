﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practice_1_ASP.Data;

#nullable disable

namespace Practice_1_ASP.Migrations
{
    [DbContext(typeof(FilmDbContext))]
    [Migration("20250517062228_users")]
    partial class users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorFilmModel", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "FilmsId");

                    b.HasIndex("FilmsId");

                    b.ToTable("ActorFilmModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Practice_1_ASP.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 49,
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            Id = 2,
                            Age = 50,
                            FirstName = "Christian",
                            LastName = "Bale"
                        },
                        new
                        {
                            Id = 3,
                            Age = 48,
                            FirstName = "Kate",
                            LastName = "Winslet"
                        },
                        new
                        {
                            Id = 4,
                            Age = 59,
                            FirstName = "Keanu",
                            LastName = "Reeves"
                        },
                        new
                        {
                            Id = 5,
                            Age = 75,
                            FirstName = "Samuel",
                            LastName = "Jackson"
                        },
                        new
                        {
                            Id = 6,
                            Age = 86,
                            FirstName = "Morgan",
                            LastName = "Freeman"
                        },
                        new
                        {
                            Id = 7,
                            Age = 67,
                            FirstName = "Tom",
                            LastName = "Hanks"
                        },
                        new
                        {
                            Id = 8,
                            Age = 54,
                            FirstName = "Matthew",
                            LastName = "McConaughey"
                        },
                        new
                        {
                            Id = 9,
                            Age = 60,
                            FirstName = "Brad",
                            LastName = "Pitt"
                        },
                        new
                        {
                            Id = 10,
                            Age = 59,
                            FirstName = "Russell",
                            LastName = "Crowe"
                        });
                });

            modelBuilder.Entity("Practice_1_ASP.Entities.ActorFilm", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("ActorFilms");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            FilmId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            FilmId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            FilmId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            FilmId = 3
                        },
                        new
                        {
                            ActorId = 4,
                            FilmId = 4
                        },
                        new
                        {
                            ActorId = 5,
                            FilmId = 5
                        },
                        new
                        {
                            ActorId = 6,
                            FilmId = 6
                        },
                        new
                        {
                            ActorId = 7,
                            FilmId = 7
                        },
                        new
                        {
                            ActorId = 8,
                            FilmId = 8
                        },
                        new
                        {
                            ActorId = 9,
                            FilmId = 9
                        },
                        new
                        {
                            ActorId = 10,
                            FilmId = 10
                        });
                });

            modelBuilder.Entity("Practice_1_ASP.Entities.FilmModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "USA",
                            Description = "A thief who enters the dreams of others.",
                            DurationMinutes = 148,
                            Genre = "Sci-Fi",
                            Name = "Inception",
                            Photo = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                            Year = 2010
                        },
                        new
                        {
                            Id = 2,
                            Country = "USA",
                            Description = "Batman faces the Joker in Gotham.",
                            DurationMinutes = 152,
                            Genre = "Action",
                            Name = "The Dark Knight",
                            Photo = "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg",
                            Year = 2008
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            Description = "A tragic love story aboard the Titanic.",
                            DurationMinutes = 195,
                            Genre = "Drama",
                            Name = "Titanic",
                            Photo = "https://play-lh.googleusercontent.com/560-H8NVZRHk00g3RltRun4IGB-Ndl0I0iKy33D7EQ0cRRwH78-c46s90lZ1ho_F1so=w240-h480-rw",
                            Year = 1997
                        },
                        new
                        {
                            Id = 4,
                            Country = "USA",
                            Description = "A hacker discovers the nature of reality.",
                            DurationMinutes = 136,
                            Genre = "Sci-Fi",
                            Name = "The Matrix",
                            Photo = "https://m.media-amazon.com/images/I/51EG732BV3L.jpg",
                            Year = 1999
                        },
                        new
                        {
                            Id = 5,
                            Country = "USA",
                            Description = "Intertwined stories of crime and redemption.",
                            DurationMinutes = 154,
                            Genre = "Crime",
                            Name = "Pulp Fiction",
                            Photo = "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg",
                            Year = 1994
                        },
                        new
                        {
                            Id = 6,
                            Country = "USA",
                            Description = "A man imprisoned for a crime he didn't commit.",
                            DurationMinutes = 142,
                            Genre = "Drama",
                            Name = "The Shawshank Redemption",
                            Photo = "https://m.media-amazon.com/images/I/51zUbui+gbL.jpg",
                            Year = 1994
                        },
                        new
                        {
                            Id = 7,
                            Country = "USA",
                            Description = "A man with a low IQ influences history.",
                            DurationMinutes = 142,
                            Genre = "Drama",
                            Name = "Forrest Gump",
                            Photo = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            Year = 1994
                        },
                        new
                        {
                            Id = 8,
                            Country = "USA",
                            Description = "A space mission to save humanity.",
                            DurationMinutes = 169,
                            Genre = "Sci-Fi",
                            Name = "Interstellar",
                            Photo = "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SY679_.jpg",
                            Year = 2014
                        },
                        new
                        {
                            Id = 9,
                            Country = "USA",
                            Description = "An insomniac and a soap salesman start an underground fight club.",
                            DurationMinutes = 139,
                            Genre = "Drama",
                            Name = "Fight Club",
                            Photo = "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            Year = 1999
                        },
                        new
                        {
                            Id = 10,
                            Country = "USA",
                            Description = "A betrayed general seeks revenge in Rome.",
                            DurationMinutes = 155,
                            Genre = "Action",
                            Name = "Gladiator",
                            Photo = "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_.jpg",
                            Year = 2000
                        },
                        new
                        {
                            Id = 11,
                            Country = "USA",
                            Description = "A mafia family's rise and struggle.",
                            DurationMinutes = 175,
                            Genre = "Crime",
                            Name = "The Godfather",
                            Photo = "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_.jpg",
                            Year = 1972
                        },
                        new
                        {
                            Id = 12,
                            Country = "New Zealand",
                            Description = "A hobbit sets out to destroy a powerful ring.",
                            DurationMinutes = 178,
                            Genre = "Fantasy",
                            Name = "The Lord of the Rings: The Fellowship of the Ring",
                            Photo = "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg",
                            Year = 2001
                        },
                        new
                        {
                            Id = 13,
                            Country = "New Zealand",
                            Description = "The battle for Middle-earth intensifies.",
                            DurationMinutes = 179,
                            Genre = "Fantasy",
                            Name = "The Lord of the Rings: The Two Towers",
                            Photo = "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            Year = 2002
                        },
                        new
                        {
                            Id = 14,
                            Country = "New Zealand",
                            Description = "The final battle for Middle-earth.",
                            DurationMinutes = 201,
                            Genre = "Fantasy",
                            Name = "The Lord of the Rings: The Return of the King",
                            Photo = "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_.jpg",
                            Year = 2003
                        },
                        new
                        {
                            Id = 15,
                            Country = "USA",
                            Description = "A marine on an alien planet must choose sides.",
                            DurationMinutes = 162,
                            Genre = "Sci-Fi",
                            Name = "Avatar",
                            Photo = "https://upload.wikimedia.org/wikipedia/en/d/d6/Avatar_%282009_film%29_poster.jpg",
                            Year = 2009
                        },
                        new
                        {
                            Id = 16,
                            Country = "USA",
                            Description = "Earth's mightiest heroes team up to stop Loki.",
                            DurationMinutes = 143,
                            Genre = "Action",
                            Name = "The Avengers",
                            Photo = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
                            Year = 2012
                        },
                        new
                        {
                            Id = 17,
                            Country = "USA",
                            Description = "A failed comedian descends into madness.",
                            DurationMinutes = 122,
                            Genre = "Drama",
                            Name = "Joker",
                            Photo = "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_.jpg",
                            Year = 2019
                        },
                        new
                        {
                            Id = 18,
                            Country = "USA",
                            Description = "Peter Parker deals with multiverse consequences.",
                            DurationMinutes = 148,
                            Genre = "Action",
                            Name = "Spider-Man: No Way Home",
                            Photo = "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_.jpg",
                            Year = 2021
                        },
                        new
                        {
                            Id = 19,
                            Country = "USA",
                            Description = "A noble family fights for control of a desert planet.",
                            DurationMinutes = 155,
                            Genre = "Sci-Fi",
                            Name = "Dune",
                            Photo = "https://sm.ign.com/ign_nordic/cover/d/dune-2021/dune-2021_dcbx.jpg",
                            Year = 2021
                        },
                        new
                        {
                            Id = 20,
                            Country = "USA",
                            Description = "The story of the man who built the atomic bomb.",
                            DurationMinutes = 180,
                            Genre = "Biography",
                            Name = "Oppenheimer",
                            Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg",
                            Year = 2023
                        });
                });

            modelBuilder.Entity("ActorFilmModel", b =>
                {
                    b.HasOne("Practice_1_ASP.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Practice_1_ASP.Entities.FilmModel", null)
                        .WithMany()
                        .HasForeignKey("FilmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Practice_1_ASP.Entities.ActorFilm", b =>
                {
                    b.HasOne("Practice_1_ASP.Entities.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Practice_1_ASP.Entities.FilmModel", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });
#pragma warning restore 612, 618
        }
    }
}
