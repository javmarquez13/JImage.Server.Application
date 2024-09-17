using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JImage.Server.ViewModels.ViewModels.FilesExplorer;
using JImage.Server.Views.Views.BaseModal;

namespace JImage.Server.Views.Views.FilesExplorer
{
    public partial class FilesExplorerView : BaseView
    {
        private readonly FilesExplorerViewModel _viewModel;
        public FilesExplorerView(FilesExplorerViewModel viewModel)
            : base(Title: "Files Explorer",
                  viewModel) 
        {
            InitializeComponent();
            this._viewModel = viewModel;
        }
    }
}
