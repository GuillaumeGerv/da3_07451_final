using da3_07451_final.Business;
using da3_07451_final.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da3_07451_final.GUI
{
    internal partial class FilmManagementForm : Form
    {
        private enum ViewIntentEnum
        {
            VIEW,
            CREATE,
            EDIT,
            DELETE
        }
        private ViewIntentEnum viewIntentEnum;
        private App parentApp;
        private FilmsDTO currentFilm = null!;

        public FilmManagementForm(App parentApp)
        {
            this.parentApp = parentApp;
            InitializeComponent();
            this.currentFilm = new FilmsDTO();
            this.ReloadFilmList();
        }
        private void ReloadFilmList()
        {
            this.filmActeurListBox.Items.Clear();
            this.filmActeurListBox.DataSource = parentApp.GetAllFilms();
        }
        private void DeactivatesControls()
        {
            this.numericUpDownId.Enabled = true;
            this.textBoxTitle.Enabled = false;
            this.textBoxAnnee.Enabled = false;
            this.filmActeurListBox.Enabled = false;
        }
        private void ActivateControls()
        {
            this.numericUpDownId.Enabled = false;
            this.textBoxTitle.Enabled = true;
            this.textBoxAnnee.Enabled = true;
            this.filmActeurListBox.Enabled = true;
        }
        public DialogResult OpenForView(FilmsDTO film)
        {
            this.viewIntentEnum = ViewIntentEnum.VIEW;
            this.buttonAction.Text = "Close";
            this.currentFilm = film;
            this.DeactivatesControls();
            this.LoadUsersDataInControls(film);
            return this.ShowDialog();
        }
        public DialogResult OpenForCreate(FilmsDTO film)
        {
            this.viewIntentEnum = ViewIntentEnum.CREATE;
            this.buttonAction.Text = "Create";
            this.currentFilm = film;
            this.ActivateControls();
            this.LoadUsersDataInControls(film);
            return this.ShowDialog();
        }
        public DialogResult OpenForDelete(FilmsDTO film)
        {
            this.viewIntentEnum = ViewIntentEnum.DELETE;
            this.buttonAction.Text = "Delete";
            this.currentFilm = film;
            this.DeactivatesControls();
            this.LoadUsersDataInControls(film);
            return this.ShowDialog();
        }
        public DialogResult OpenForEdit(FilmsDTO film)
        {
            this.viewIntentEnum = ViewIntentEnum.EDIT;
            this.buttonAction.Text = "Edit";
            this.currentFilm = film;
            this.ActivateControls();
            this.LoadUsersDataInControls(film);
            return this.ShowDialog();
        }
        private void LoadUsersDataInControls(FilmsDTO film)
        {
            if (film != null)
            {
                this.numericUpDownId.Value = film.Id;
                this.textBoxTitle.Text = film.Title;
                this.textBoxAnnee.Text = film.Annee.ToString();

                if (film.ActeursDTO != null)
                {
                    this.filmActeurListBox.SelectedItems.Clear();

                    foreach (ActeursDTO role in film.ActeursDTO)
                    {
                        if (role != null)
                        {
                            this.filmActeurListBox.SelectedItems.Add(role);
                        }
                    }
                }
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.viewIntentEnum)
                {
                    case ViewIntentEnum.CREATE:
                    case ViewIntentEnum.EDIT:
                        this.UpdateInstanceWithData();
                        break;
                    case ViewIntentEnum.VIEW:
                    case ViewIntentEnum.DELETE:
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }
        private void UpdateInstanceWithData()
        {
            if (this.currentFilm == null)
            {
                throw new Exception("Current user is not initialized.");
            }
            if (this.textBoxTitle.Text.Length > FilmsDTO.MAX_TITLE_LENGTH)
            {
                throw new Exception($"TITLE too long, {this.textBoxTitle.Text.Length} enter caracters. The maximum is {FilmsDTO.MAX_TITLE_LENGTH}.");
            }
            this.currentFilm.Title = this.textBoxTitle.Text;
            //this.currentFilm.Annee = this.textBoxAnnee.Text.ToString();
            List<ActeursDTO> selectedActeur = new List<ActeursDTO>();
            foreach (object? selectedActeurs in this.filmActeurListBox.SelectedItems)
            {
                selectedActeur.Add((ActeursDTO)selectedActeurs);
            }
            this.currentFilm.ActeursDTO = selectedActeur;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
