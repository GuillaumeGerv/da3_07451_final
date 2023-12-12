using da3_07451_final.DataAccess.DTOs;
using da3_07451_final.DataAccess.Pivots;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da3_07451_final.DataAccess.Pivots;

namespace da3_07451_final.DataAccess.Context
{
    internal class ContextAppDataBase : DbContext
    {
        public DbSet<FilmsDTO> Films { get; set; }
        public DbSet<ActeursDTO> Acteurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            _ = optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["Connexion"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<FilmsDTO>()
                .ToTable("Films")
                .HasKey(film => film.Id);

            _ = modelBuilder.Entity<FilmsDTO>()
                .Property(film => film.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            _ = modelBuilder.Entity<FilmsDTO>()
                .Property(film => film.Title)
                .HasColumnName("Title")
                .HasColumnType($"nvarchar({FilmsDTO.MAX_TITLE_LENGTH})");
            _ = modelBuilder.Entity<FilmsDTO>()
                .Property(film => film.Annee)
                .HasColumnName("Anne")
                .HasColumnType("int");
            _ = modelBuilder.Entity<FilmsDTO>()
                .Property(film => film.Version)
                .HasColumnName("Version")
                .IsRowVersion();

            _ = modelBuilder.Entity<ActeursDTO>()
                .ToTable("Acteur")
                .HasKey(acteur => acteur.Id);

            _ = modelBuilder.Entity<ActeursDTO>()
                .Property(acteur => acteur.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            _ = modelBuilder.Entity<ActeursDTO>()
                .Property(acteur => acteur.Prenom)
                .HasColumnName("Prenom")
                .HasColumnType($"nvarchar({ActeursDTO.MAX_PRENOM_LENGTH})");
            _ = modelBuilder.Entity<ActeursDTO>()
                .Property(acteur => acteur.Nom)
                .HasColumnName("Nom")
                .HasColumnType($"nvarchar({ActeursDTO.MAX_NOM_LENGTH})");
            _ = modelBuilder.Entity<ActeursDTO>()
                .Property(acteur => acteur.Version)
                .HasColumnName("Version")
                .IsRowVersion();

            _ = modelBuilder.Entity<FilmsDTO>()
                .HasMany(acteur => acteur.ActeursDTO)
                .WithMany(acteur => acteur.FilmsDTO)
                .UsingEntity<ActeurFilm>().ToTable("ActeurFilm")
                .HasKey(filmActeur => new { filmActeur.ActeursId, filmActeur.FilmsId });


            _ = modelBuilder.Entity<FilmsDTO>().HasData(
                new FilmsDTO() { Id = 1, Title = "The Shawshank Redemption", Annee = 1994 },
                new FilmsDTO() { Id = 2, Title = "Invictus", Annee = 2008 });

            _ = modelBuilder.Entity<ActeursDTO>().HasData(
                new ActeursDTO() { Id = 1, Prenom = "Morgan", Nom = "Freeman" },
                new ActeursDTO() { Id = 2, Prenom = "Matte", Nom = "Damon" },
                new ActeursDTO() { Id = 3, Prenom = "Tim", Nom = "Robbins" });

        }
    }
}
