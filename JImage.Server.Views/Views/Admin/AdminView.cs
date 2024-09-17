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
using JImage.Server.Views.Views.Menu;

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

        

        public async Task LoadCatalogsBindingDataAndCommands()
        {
            await this._viewModel.LoadCatalogs(); BindingData(); BindCommands();
        }


        private void BindingData()
        {       
            //cbBoxUser
            cbUsers.DataSource = _viewModel.UsersCatalog;
            cbUsers.DisplayMember = "Name";
            cbUsers.ValueMember = "Id";
            cbUsers.DataBindings.Add(
                "SelectedItem",
                this._viewModel,
                "Form.SelectedUser",
                true,
                DataSourceUpdateMode.OnPropertyChanged);


            //txtPassword
            txtPassowrd.DataBindings.Add(
                "Text", 
                this._viewModel, 
                "Form.SelectedPassword", 
                true, 
                DataSourceUpdateMode.OnPropertyChanged);
        }


        private void BindCommands()
        {
            btnLogin.Click += async(a, b)=> 
            {
                await LoggingCommand();
            };
        }



        private async Task LoggingCommand()
        {
            var result = await this._viewModel.LoginCommand();

            if (!result)
            {
                this._viewModel.SendErrorMessage("Login failed");
                return;
            }


            var createView = UtilsViews.CreateView<MenuView>();
            createView.Shown += async (a, b) =>
            {

            };

            createView.ShowDialog();
        }
    }
}
