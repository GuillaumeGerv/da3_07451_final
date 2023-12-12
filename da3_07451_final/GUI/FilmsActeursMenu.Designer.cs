namespace da3_07451_final.GUI
{
    partial class FilmsActeursMenu
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
            filmListBox = new ListBox();
            buttonsPanel = new Panel();
            buttonQuit = new Button();
            buttonDelete = new Button();
            buttonChange = new Button();
            buttonDetails = new Button();
            buttonCreate = new Button();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // filmListBox
            // 
            filmListBox.FormattingEnabled = true;
            filmListBox.ItemHeight = 15;
            filmListBox.Location = new Point(3, 3);
            filmListBox.Name = "filmListBox";
            filmListBox.Size = new Size(381, 259);
            filmListBox.TabIndex = 2;
            filmListBox.SelectedIndexChanged += filmListBox_SelectedIndexChanged;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(buttonQuit);
            buttonsPanel.Controls.Add(buttonDelete);
            buttonsPanel.Controls.Add(buttonChange);
            buttonsPanel.Controls.Add(buttonDetails);
            buttonsPanel.Controls.Add(buttonCreate);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(384, 461);
            buttonsPanel.TabIndex = 3;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(46, 419);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(280, 30);
            buttonQuit.TabIndex = 4;
            buttonQuit.Text = "Exit";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(46, 383);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(280, 30);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete a film";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(46, 347);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(280, 30);
            buttonChange.TabIndex = 2;
            buttonChange.Text = "Change a film";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonDetails
            // 
            buttonDetails.Location = new Point(46, 311);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(280, 30);
            buttonDetails.TabIndex = 1;
            buttonDetails.Text = "Details the film";
            buttonDetails.UseVisualStyleBackColor = true;
            buttonDetails.Click += buttonDetails_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(46, 275);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(280, 30);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create new film";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // FilmsActeursMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(filmListBox);
            Controls.Add(buttonsPanel);
            Name = "FilmsActeursMenu";
            Text = "FilmsActeursMenu";
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox filmListBox;
        private Panel buttonsPanel;
        private Button buttonQuit;
        private Button buttonDelete;
        private Button buttonChange;
        private Button buttonDetails;
        private Button buttonCreate;
    }
}