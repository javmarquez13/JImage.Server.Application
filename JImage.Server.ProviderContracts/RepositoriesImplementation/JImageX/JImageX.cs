using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JImage.Server.ProviderContracts.Repositories.JImageX;

namespace JImage.Server.ProviderContracts.RepositoriesImplementation.JImageX
{
    public class JImageX : IJImageX
    {
        public JImageX() 
        {
            
        }

        public int ProgressInstallationResult { get; set; } = 0;

        public async Task<bool> ApplyImage(string pathImage)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CaptureImage(string pootPath)
        {
            throw new NotImplementedException(); 
        }

        public int ProgressInstallationImage()
        {
            return ProgressInstallationResult;
        }

        public void ResetProgress()
        {
            ProgressInstallationResult = 0;
        }



        public async Task ApplyDummie()
        {
            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;
        }

        public async Task CaptureDummie()
        {
            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;

            await Task.Delay(1000);
            ProgressInstallationResult += 10;
        }
    }
}
