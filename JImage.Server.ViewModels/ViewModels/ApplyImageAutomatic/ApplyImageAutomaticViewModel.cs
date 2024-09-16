using JImage.Server.ProviderContracts.Repositories.BaseBoard;
using JImage.Server.ProviderContracts.Repositories.Images;
using JImage.Server.ProviderContracts.Repositories.JImageX;
using System;
using System.Threading.Tasks;
using JImage.Server.ViewModels.ViewModels.Base;

namespace JImage.Server.ViewModels.ViewModels.ApplyImageAutomatic
{
    public class ApplyImageAutomaticViewModel : BaseViewModel
    {
        private readonly IBaseBoard _baseBoard;
        private readonly IImages _images;
        private readonly IJImageX _jImageX;
        public ApplyImageAutomaticViewModel(IBaseBoard baseBoard,
            IImages images,
            IJImageX jImageX) 
        {
            this._baseBoard = baseBoard;
            this._images = images;
            this._jImageX = jImageX;
        }

        public string BaseBoardResult { get; set; } 
        public string ImageToInstalResult { get; set; } 

        public async Task InitialTest()
        {
            IsBusy = true;
            await Task.Delay(1500);
            try
            {
                BaseBoardResult = this._baseBoard.GetBaseBoard();
                ImageToInstalResult = this._images.GetImageToInstallBasedOnBaseBoard(BaseBoardResult);
            }
            catch(Exception ex)
            {
                SendErrorMessage(
                    $"Applying image has failed see error logs {ex.Message} \n {ex.StackTrace}");
            }
            finally
            {
                IsBusy = false;
            }   
        }
    }
}
