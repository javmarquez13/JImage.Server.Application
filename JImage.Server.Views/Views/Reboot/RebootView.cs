using JImage.Server.ViewModels.ViewModels.Reboot;
using JImage.Server.Views.Views.Base;

namespace JImage.Server.Views.Views.Reboot
{
    public partial class RebootView : BaseModalView
    {
        private readonly RebootViewModel _viewModel;
        public RebootView(RebootViewModel viewModel) : 
            base(Title: "Rebooting machine please wait...", viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;
        }



        public void WaitToReboot()
        {
            this._viewModel.ExecuteRebootSystem();
        }
    }
}
