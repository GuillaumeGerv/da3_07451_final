using da3_07451_final.Business;
using da3_07451_final.DataAccess.DTOs;

namespace da3_07451_final
{
    public partial class FilmsActeursManagementForm : Form
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
        private FilmsDTO currentfilm = null!;
        public FilmsActeursManagementForm()
        {
            this.parentApp = parentApp;
            InitializeComponent();
            this.currentfilm = new FilmsDTO();
            this.ReloadFilmList();
        }
        private void ReloadFilmList() 
        {
        }
    }
}