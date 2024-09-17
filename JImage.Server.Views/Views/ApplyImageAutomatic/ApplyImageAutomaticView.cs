using JImage.Server.ViewModels.ViewModels.ApplyImageAutomatic;
using JImage.Server.Views.Views.BaseModal;
using JImage.Server.Views.Views.JImageX;
using JImage.Server.Views.Views.Reboot;
using System.Threading.Tasks;

namespace JImage.Server.Views.Views.ApplyImageAutomatic
{
    public partial class ApplyImageAutomaticView : BaseView
    {
        private readonly ApplyImageAutomaticViewModel _viewModel;

        public ApplyImageAutomaticView(ApplyImageAutomaticViewModel viewModel) 
            : base(Title: "Apply Image", 
                  viewModel: viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;
            btnApplyImage.Click += BtnApplyImage_Click;
        }

   
        public async Task InitializingView()
        {
            this._viewModel.IsBusy = true;
            await Task.Delay(2000);
            this._viewModel.IsBusy = false;
        }

        private async void BtnApplyImage_Click(object sender, System.EventArgs e)
        {
            await this._viewModel.InitialTest();
           
            UpdateGUI();
            ApplyImageService();
            RebootingService();
        }

        private void UpdateGUI()
        {
            lblBaseBoard.Text = $"Base board: {this._viewModel.BaseBoardResult}";
            lblImageToInstall.Text = $"Image to install: {this._viewModel.ImageToInstalResult}";
        }

        private void ApplyImageService()
        {
            var createView = UtilsViews.CreateView<JImageXView>();

            createView.Shown += async (a, b) =>
            {
                await createView.ApplyImage();
            };

            createView.ShowDialog();
        }

        private void RebootingService()
        {
            var createView = UtilsViews.CreateView<RebootView>();


            createView.Shown += (a, b) =>
            {
                createView.WaitToReboot();
            };

            createView.ShowDialog();
        }
    }
}
