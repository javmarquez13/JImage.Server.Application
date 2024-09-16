using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JImage.Server.ProviderContracts.Repositories.Images
{
    public interface IImages
    {
        string GetImageToInstallBasedOnBaseBoard(string BaseBoard);
    }
}
