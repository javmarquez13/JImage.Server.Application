using System;
using System.Windows.Forms;
using JImage.Server.ViewModels.ViewModels.ApplyImageAutomatic;
using JImage.Server.ViewModels.ViewModels.Base;
using JImage.Server.Views.Helpers;
using JImage.Server.Views.Views.Admin;
using MaterialSkinGT;
using MaterialSkinGT.Controls;

namespace JImage.Server.Views.Views.BaseModal
{
    public partial class BaseView : MaterialForm
    {
        private readonly BaseViewModel _viewModel;
        private readonly string _Title;

        protected readonly IUtilsViews UtilsViews;

        public string Title { get; }
        public ApplyImageAutomaticViewModel ViewModel { get; }

        protected BaseView(string Title, BaseViewModel viewModel)
        {
            InitializeComponent();
            SetTheme();

            this._viewModel = viewModel;
            this.UtilsViews = ApplicationViewsDI.ResolveUtilsViews();
            this._Title = Title;

            this.Load += BaseView_Load;
            this.Shown += BaseView_Shown;
            BindBasicProperties();


            pBoxLoadIndicator.Image = Properties.Resources.LoadIndicator;
            pBoxLoadIndicator.Visible = true;
        }

        private void BaseView_Load(object sender, EventArgs e)
        {

        }

        private void BaseView_Shown(object sender, EventArgs e)
        {
            this.Text = this._Title;
            pBoxLoadIndicator.Visible = false;
        }

        private void SetTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.BLUE;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800,
                Primary.Indigo900,
                Primary.Indigo500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void BindBasicProperties()
        {
            if (this._viewModel is null)
                throw new Exception("ViewModel has not been initialized for this page.");


            this._viewModel.PropertyChanged += (sender, args) =>
            {
                switch (args.PropertyName)
                {
                    case nameof(this._viewModel.IsBusy):
                        ReactToBusyChange();
                        break;
                }
            };

            this._viewModel.ErrorMessageWasSent += (sender, args) =>
            {
                MessageBox.Show(args.Message,
                                "Critical Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            };

            this._viewModel.SuccessMessageWasSent += (sender, args) =>
            {
                //When the operation was successfully executed
                //change the component to show only a couple of seconds then close automatically
                //This is only for testing propouse
                MessageBox.Show(args.Message,
                                "Successfully operation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            };

            this._viewModel.SuccessfullySubmitted += (sender, args) =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => this.Close()));
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
            };

            this._viewModel.CriticalFailiureHasOcurred += (sender, args) =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => this.Close()));
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
            };
        }

        protected void ReactToBusyChange()
        {
            if (this._viewModel.IsBusy)
            {
                pBoxLoadIndicator.Image = Properties.Resources.LoadIndicator;
                pBoxLoadIndicator.Visible = true;
            }
            else
            {
                pBoxLoadIndicator.Image = null;
                pBoxLoadIndicator.Visible = false;
            }
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            var createView = UtilsViews.CreateView<AdminView>();

            createView.Shown += async (a, b) =>
            {
                await createView.LoadCatalogsBindingDataAndCommands();
            };

            this.Hide();
            createView.ShowDialog();
            this.Show();
        }
    }
}
