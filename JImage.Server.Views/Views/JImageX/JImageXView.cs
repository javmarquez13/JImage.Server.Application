using System;
using System.Threading.Tasks;
using JImage.Server.Views.Views.BaseModal;
using JImage.Server.ViewModels.ViewModels.JImageX;
using JImage.Server.Views.Helpers;

namespace JImage.Server.Views.Views.JImageX
{
    public partial class JImageXView : BaseView
    {
        private readonly JImageXViewModel _viewModel;
        public JImageXView(JImageXViewModel viewModel) 
            : base(Title: "JImageX Service", viewModel)

        {
            InitializeComponent();
            this._viewModel = viewModel;
            this._viewModel.PropertyChanged += ViewModel_PropertyChanged;

            btnAdminMenu.Visible = false;
        }


        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(this._viewModel.ProgressInstallationImage))
            {
                UpdateUI(this._viewModel.ProgressInstallationImage);
            }
        }


        private void UpdateUI(int Progress)
        {           
            if (pBarInstallation.InvokeRequired)
            {
                pBarInstallation.Invoke(new Action(() => pBarInstallation.Value = Progress));
            }
            else
            {
                pBarInstallation.Value = Progress;  
            }

            if (lblProgressInstallationImage.InvokeRequired) 
            {
                lblProgressInstallationImage.Invoke(new Action(() => lblProgressInstallationImage.Text = $"Installing {Progress}%"));
            }
            else
            {
                lblProgressInstallationImage.Text = $"Installing {Progress}%";
            }
                  
        }

        public async Task ApplyImage()
        {
            await this._viewModel.ApplyImage("Example path");    
        }

        public async Task CaptgureImage()
        {
            await this._viewModel.CaptureImage();
        }
    }
}
