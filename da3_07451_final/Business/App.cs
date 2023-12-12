using da3_07451_final.DataAccess.Context;
using da3_07451_final.DataAccess.DAOs;
using da3_07451_final.DataAccess.DTOs;
using da3_07451_final.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_07451_final.Business
{
    internal class App
    {
        private FilmsDAO filmsDAO;
        private ActeursDAO acteursDAO;
        private ContextAppDataBase contextApp;
        private FilmManagementForm filmsActeursForm;
        private FilmsActeursMenu menuForm;

        public App()
        {
            ApplicationConfiguration.Initialize();
            this.filmsDAO = new FilmsDAO(this.contextApp);
            this.acteursDAO = new ActeursDAO(this.contextApp);
            this.contextApp = new ContextAppDataBase();
            this.filmsActeursForm = new FilmManagementForm(this);
            this.menuForm = new FilmsActeursMenu(this);
        }

        public void StartApp()
        {
            Application.Run(this.menuForm);
        }

        public void ShutDown() 
        {
            Application.Exit();
        }

        public List<FilmsDTO> GetAllFilms() 
        {
            return this.filmsDAO.GetAll();
        }

        public FilmsDTO? DeleteFilm(FilmsDTO film) 
        {
            DialogResult result = this.filmsActeursForm.OpenForDelete(film);
            return null;
        }
        public FilmsDTO EditFilm(FilmsDTO film)
        {
            DialogResult resultat = this.filmsActeursForm.OpenForEdit(film);
            if (resultat == DialogResult.OK)
            {
                _ = this.filmsDAO.Update(film);
                return film;
            }
            else
            {
                return film;
            }
        }
        public FilmsDTO? CreateNewFilm()
        {
            FilmsDTO newFilm = new FilmsDTO();
            DialogResult resultat = this.filmsActeursForm.OpenForCreate(newFilm);
            if (resultat == DialogResult.OK)
            {
                _ = this.filmsDAO.Create(newFilm);
                return newFilm;
            }
            else
            {
                return null;
            }
        }
        public FilmsDTO? DeleteUser(FilmsDTO user)
        {
            DialogResult resultat = this.filmsActeursForm.OpenForDelete(user);
            if (resultat == DialogResult.OK)
            {
                _ = this.filmsDAO.Delete(user);
                return user;
            }
            else
            {
                return null;
            }
        }
        public List<ActeursDTO> GetAllActeurs()
        {
            return this.acteursDAO.GetAll();
        }
        public FilmsDTO ViewFilmDetails(FilmsDTO film)
        {
            _ = this.filmsActeursForm.OpenForView(film);
            return film;
        }
    } 
}
