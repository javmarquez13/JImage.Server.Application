using System;
using System.Collections.Generic;
using System.Text;
using JImage.Server.ViewModels.ViewModels.Base;

namespace JImage.Server.ViewModels.ViewModels.Reboot
{
    public class RebootViewModel : BaseViewModel
    {
        public RebootViewModel() 
        {
        
        }



        public void ExecuteRebootSystem()
        {
            IsBusy = true;
        }
    }
}
