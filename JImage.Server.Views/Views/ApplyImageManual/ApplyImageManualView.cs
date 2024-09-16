using JImage.Server.ViewModels.ViewModels.ApplyImageManual;
using JImage.Server.Views.Views.Base;

namespace JImage.Server.Views.Views.ApplyImageManual
{
    public partial class ApplyImageManualView : BaseView
    {
        private readonly ApplyImageManualViewModel _viewModel;
        public ApplyImageManualView(ApplyImageManualViewModel viewModel) 
            : base(Title: "Apply Image Manual", 
                   viewModel: viewModel) 
        {
            InitializeComponent();
            this._viewModel = viewModel;
        }
    }
}
