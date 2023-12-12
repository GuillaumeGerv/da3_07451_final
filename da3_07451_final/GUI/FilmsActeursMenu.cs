using da3_07451_final.Business;
using da3_07451_final.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da3_07451_final.GUI
{
    internal partial class FilmsActeursMenu : Form
    {
        private App parentApp;
        private FilmsDTO? filmselected;

        public FilmsActeursMenu(App parentApp)
        {
            this.parentApp = parentApp;
            this.InitializeComponent();
            this.ReloadFilmList();
        }
        public void ReloadFilmList()
        {
            this.filmListBox.SelectedItem = null;
            this.filmListBox.DataSource = parentApp.GetAllFilms();
        }
        private void ButtonsFilmsActivated()
        {
            this.buttonDetails.Enabled = true;
            this.buttonChange.Enabled = true;
            this.buttonDelete.Enabled = true;
        }
        private void ButtonsFilmsDesactivated()
        {
            this.buttonDetails.Enabled = false;
            this.buttonChange.Enabled = false;
            this.buttonDelete.Enabled = false;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FilmsDTO? newFilm = this.parentApp.CreateNewFilm();
            this.ReloadFilmList();
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (this.filmselected is not null)
            {
                _ = this.parentApp.ViewFilmDetails(this.filmselected);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (this.filmselected is not null)
            {
                _ = this.parentApp.EditFilm(this.filmselected);
                this.ReloadFilmList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.filmselected is not null)
            {
                FilmsDTO? deletedFilm = this.parentApp.DeleteFilm(this.filmselected);
                if (deletedFilm is not null)
                {
                    this.ReloadFilmList();
                    this.filmselected = null;
                    this.ButtonsFilmsDesactivated();
                }
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.parentApp.ShutDown();
        }

        private void filmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filmselected = this.filmListBox.SelectedItem as FilmsDTO;
            this.ButtonsFilmsActivated();
        }
    }
}
