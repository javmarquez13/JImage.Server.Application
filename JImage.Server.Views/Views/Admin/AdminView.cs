using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JImage.Server.ViewModels.ViewModels.Admin;
using JImage.Server.Views.Views.BaseModal;
using JImage.Server.Views.Views.CaptureImage;

namespace JImage.Server.Views.Views.Admin
{
    public partial class AdminView : BaseView
    {
        private readonly AdminViewModel _viewModel;
        public AdminView(AdminViewModel viewModel) :
            base(Title: "Administrator",
                viewModel: viewModel)
        {
            InitializeComponent();

            this._viewModel = viewModel;
        }



        public async Task LoadUsers()
        {
            await this._viewModel.GetUsersAsync();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var createView = UtilsViews.CreateView<CaptureImageView>();

            createView.Shown += async (a, b) =>
            {
                
            };

            createView.ShowDialog();
        }
    }
}
