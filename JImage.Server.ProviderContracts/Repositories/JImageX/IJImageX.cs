
using System.Threading.Tasks;

namespace JImage.Server.ProviderContracts.Repositories.JImageX
{
    public interface IJImageX
    {
        int ProgressInstallationImage();
        void ResetProgress();    
        Task<bool> ApplyImage(string imagePath);
        Task<bool> CaptureImage(string rootPath);


        Task ApplyDummie();
        Task CaptureDummie();
    }
}
