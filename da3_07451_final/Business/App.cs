using da3_07451_final.DataAccess.Context;
using da3_07451_final.DataAccess.DAOs;
using da3_07451_final.DataAccess.DTOs;
using da3_07451_final.GUI;
using System;
using System.Collections.Generic;
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
        private FilmsActeursManagementForm filmsActeursForm;
        private FilmsActeursMenu menuForm;

        public App()
        {
            ApplicationConfiguration.Initialize();
            this.filmsDAO = new FilmsDAO(this.contextApp);
            this.acteursDAO = new ActeursDAO(this.contextApp);
            this.contextApp = new ContextAppDataBase();
            this.filmsActeursForm = new FilmsActeursManagementForm(this);
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

        public void GetAllFilms() 
        {
            return.this.filmsDAO.GetAll();
        }
    } 
}
