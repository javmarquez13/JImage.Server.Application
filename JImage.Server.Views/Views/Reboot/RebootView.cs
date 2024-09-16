using JImage.Server.ViewModels.ViewModels.Reboot;
using JImage.Server.Views.Views.BaseModal;

namespace JImage.Server.Views.Views.Reboot
{
    public partial class RebootView : BaseView
    {
        private readonly RebootViewModel _viewModel;
        public RebootView(RebootViewModel viewModel) : 
            base(Title: "Rebooting machine please wait...", viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;

            btnAdminMenu.Visible = false;
        }



        public void WaitToReboot()
        {
            this._viewModel.ExecuteRebootSystem();
        }
    }
}
