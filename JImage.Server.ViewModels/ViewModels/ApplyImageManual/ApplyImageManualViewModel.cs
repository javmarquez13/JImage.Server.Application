using System;
using System.Collections.Generic;
using System.Text;
using JImage.Server.ViewModels.ViewModels.Base;

namespace JImage.Server.ViewModels.ViewModels.ApplyImageManual
{
    public class ApplyImageManualViewModel : BaseViewModel
    {
        public ApplyImageManualViewModel() 
        {
        
        }


        private List<string> _ImageCatalog;
        public List<string> ImageCatalog
        {
            get=> _ImageCatalog;
            set => SetProperty(ref _ImageCatalog, value);   
        }
    }
}
