using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JImage.Server.ViewModels.ViewModels.CaptureImageViewModel;
using JImage.Server.Views.Helpers;
using JImage.Server.Views.Views.Base;
using JImage.Server.Views.Views.JImageX;

namespace JImage.Server.Views.Views.CaptureImage
{
    public partial class CaptureImageView : BaseView
    {
        private readonly CaptureImageViewModel _viewModel;
        public CaptureImageView(CaptureImageViewModel viewModel)
            : base(Title: "Capture Image",
                  viewModel)
        {
            InitializeComponent();

            this._viewModel = viewModel;
            btnAdminMenu.Visible = false;
        }

        private void CaptureImageService()
        {
            var createView = UtilsViews.CreateModalView<JImageXView>();

            createView.Shown += async (a, b) =>
            {
                await createView.CaptgureImage();
            };

            createView.ShowDialog();
        }

        private void BtnCaptureImage_Click(object sender, EventArgs e)
        {
            CaptureImageService();

            MessageBox.Show("Image was captured successfully", "Image", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
