using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace JImage.Server.ViewModels.ViewModels.ApplyImageManual.FormFields
{
    public class ApplyImageManualFormFields : ObservableObject
    {
        private string _SelectedImage;
        public string SelectedImage
        {
            get => _SelectedImage;
            set => SetProperty(ref _SelectedImage, value);
        }

        private string _SelectedRootPath;
        public string SelectedRootPath
        {
            get => _SelectedRootPath;
            set => SetProperty(ref _SelectedRootPath, value);
        }
    }
}
