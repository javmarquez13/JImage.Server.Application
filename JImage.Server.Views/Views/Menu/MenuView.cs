using JImage.Server.ViewModels.ViewModels.Menu;
using JImage.Server.Views.Views.ApplyImageAutomatic;
using JImage.Server.Views.Views.ApplyImageManual;
using JImage.Server.Views.Views.BaseModal;
using JImage.Server.Views.Views.CaptureImage;


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

        private void btnOpenCaptureImageModal_Click(object sender, System.EventArgs e)
        {
            var createView = UtilsViews.CreateView<CaptureImageView>();

            createView.Shown += async (a, b) =>
            {

            };

            createView.ShowDialog();
        }

        private void btnOpenApplyImageManualModal_Click(object sender, System.EventArgs e)
        {
            var createView = UtilsViews.CreateView<ApplyImageManualView>();

            createView.Shown += async (a, b) =>
            {

            };

            createView.ShowDialog();
        }

        private void btnOpenApplyImageAutomaticModal_Click(object sender, System.EventArgs e)
        {
            var createView = UtilsViews.CreateView<ApplyImageAutomaticView>();

            createView.Shown += async (a, b) =>
            {
                await createView.InitializingView();
            };

            createView.ShowDialog();
        }
    }
}
