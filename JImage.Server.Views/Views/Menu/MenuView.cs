using JImage.Server.ViewModels.ViewModels.Menu;
using JImage.Server.Views.Views.BaseModal;


namespace JImage.Server.Views.Views.Menu
{
    public partial class MenuView : BaseView
    {
        private readonly MenuViewModel _viewModel;

        public MenuView(MenuViewModel viewModel) : 
            base(Title: "Menu", viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;
            
            btnAdminMenu.Visible = false;
        }
    }
}
