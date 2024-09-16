using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JImage.Server.ProviderContracts.Repositories.JImageX;
using JImage.Server.ViewModels.ViewModels.Base;
using static System.Net.Mime.MediaTypeNames;

namespace JImage.Server.ViewModels.ViewModels.JImageX
{
    public class JImageXViewModel : BaseViewModel
    {
        private readonly IJImageX _jImageX;
        private readonly SynchronizationContext _syncContext;

        public JImageXViewModel(IJImageX jImageX) 
        {
            this._jImageX = jImageX;
            this._syncContext = SynchronizationContext.Current;
        }

        private int _ProgressInstallationImage = 0;
        public int ProgressInstallationImage 
        {
            get=> _ProgressInstallationImage;
            set=> SetProperty(ref _ProgressInstallationImage, value);   
        }

        public async Task ApplyImage(string ImagePath)
        {
            try
            {
                _=this._jImageX.ApplyDummie();
                await MonitorProgressAsyncTask();
                this._jImageX.ResetProgress();
                FireSuccessfullySubmitted();
            }
            catch (Exception ex)
            {
                SendErrorMessage($"Error during applying image {ex.Message}");
            }           
        }
        public async Task CaptureImage()
        {
            try
            {
                _=this._jImageX.CaptureDummie();
                await MonitorProgressAsyncTask();
                this._jImageX.ResetProgress();
                FireSuccessfullySubmitted();
            }
            catch (Exception ex)
            {
                SendErrorMessage($"Error during capturing image {ex.Message}");
            }
        }
        public async Task MonitorProgressAsyncTask()
        {
            while (this._jImageX.ProgressInstallationImage() != 100)
            {
                this._syncContext.Post(_ =>
                {
                    ProgressInstallationImage = _jImageX.ProgressInstallationImage();
                }, null);

                await Task.Delay(100);
            }

            this._syncContext.Post(_ =>
            {
                ProgressInstallationImage = 100;
            }, null);

            await Task.Delay(2000);
        }
    }
}
