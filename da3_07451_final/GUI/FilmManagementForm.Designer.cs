namespace da3_07451_final.GUI
{
    partial class FilmManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filmActeurListBox = new ListBox();
            labelFilmActeur = new Label();
            textBoxAnnee = new TextBox();
            labelAnnee = new Label();
            textBoxTitle = new TextBox();
            labelTitle = new Label();
            numericUpDownId = new NumericUpDown();
            labelId = new Label();
            buttonCancel = new Button();
            buttonAction = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // filmActeurListBox
            // 
            filmActeurListBox.FormattingEnabled = true;
            filmActeurListBox.ItemHeight = 15;
            filmActeurListBox.Location = new Point(319, 50);
            filmActeurListBox.Name = "filmActeurListBox";
            filmActeurListBox.Size = new Size(207, 169);
            filmActeurListBox.TabIndex = 21;
            // 
            // labelFilmActeur
            // 
            labelFilmActeur.AutoSize = true;
            labelFilmActeur.Location = new Point(318, 32);
            labelFilmActeur.Name = "labelFilmActeur";
            labelFilmActeur.Size = new Size(81, 15);
            labelFilmActeur.TabIndex = 20;
            labelFilmActeur.Text = "Films Acteurs:";
            // 
            // textBoxAnnee
            // 
            textBoxAnnee.Location = new Point(66, 129);
            textBoxAnnee.Name = "textBoxAnnee";
            textBoxAnnee.PlaceholderText = "Annee";
            textBoxAnnee.Size = new Size(207, 23);
            textBoxAnnee.TabIndex = 19;
            // 
            // labelAnnee
            // 
            labelAnnee.AutoSize = true;
            labelAnnee.Location = new Point(65, 113);
            labelAnnee.Name = "labelAnnee";
            labelAnnee.Size = new Size(44, 15);
            labelAnnee.TabIndex = 18;
            labelAnnee.Text = "Annee:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(67, 84);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Title";
            textBoxTitle.Size = new Size(207, 23);
            textBoxTitle.TabIndex = 17;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(66, 68);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 15);
            labelTitle.TabIndex = 16;
            labelTitle.Text = "Title:";
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(66, 42);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(208, 23);
            numericUpDownId.TabIndex = 15;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(66, 24);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 14;
            labelId.Text = "ID:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(183, 188);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(91, 31);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(65, 188);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(91, 31);
            buttonAction.TabIndex = 12;
            buttonAction.Text = "Action";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // FilmManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(filmActeurListBox);
            Controls.Add(labelFilmActeur);
            Controls.Add(textBoxAnnee);
            Controls.Add(labelAnnee);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Controls.Add(numericUpDownId);
            Controls.Add(labelId);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAction);
            Name = "FilmManagementForm";
            Text = "FilmManagementForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox filmActeurListBox;
        private Label labelFilmActeur;
        private TextBox textBoxAnnee;
        private Label labelAnnee;
        private TextBox textBoxTitle;
        private Label labelTitle;
        private NumericUpDown numericUpDownId;
        private Label labelId;
        private Button buttonCancel;
        private Button buttonAction;
    }
}