﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using da3_07451_final.DataAccess.Context;

#nullable disable

namespace da3_07451_final.Migrations
{
    [DbContext(typeof(ContextAppDataBase))]
    partial class ContextAppDataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("da3_07451_final.DataAccess.DTOs.ActeursDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasColumnName("Nom");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasColumnName("Prenom");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.HasKey("Id");

                    b.ToTable("Acteur", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Freeman",
                            Prenom = "Morgan"
                        },
                        new
                        {
                            Id = 2,
                            Nom = "Damon",
                            Prenom = "Matte"
                        },
                        new
                        {
                            Id = 3,
                            Nom = "Robbins",
                            Prenom = "Tim"
                        });
                });

            modelBuilder.Entity("da3_07451_final.DataAccess.DTOs.FilmsDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Annee")
                        .HasColumnType("int")
                        .HasColumnName("Anne");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Title");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.HasKey("Id");

                    b.ToTable("Films", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Annee = 1994,
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 2,
                            Annee = 2008,
                            Title = "Invictus"
                        });
                });

            modelBuilder.Entity("da3_07451_final.DataAccess.Pivots.ActeurFilm", b =>
                {
                    b.Property<int>("ActeursId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsId")
                        .HasColumnType("int");

                    b.Property<int>("ActeursDTOId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsDTOId")
                        .HasColumnType("int");

                    b.HasKey("ActeursId", "FilmsId");

                    b.HasIndex("ActeursDTOId");

                    b.HasIndex("FilmsDTOId");

                    b.ToTable("ActeurFilm", (string)null);
                });

            modelBuilder.Entity("da3_07451_final.DataAccess.Pivots.ActeurFilm", b =>
                {
                    b.HasOne("da3_07451_final.DataAccess.DTOs.ActeursDTO", null)
                        .WithMany()
                        .HasForeignKey("ActeursDTOId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("da3_07451_final.DataAccess.DTOs.FilmsDTO", null)
                        .WithMany()
                        .HasForeignKey("FilmsDTOId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
