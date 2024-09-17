using JImage.Server.ProviderContracts.Repositories.Images;

namespace JImage.Server.ProviderContracts.RepositoriesImplementation.Images
{
    public class Images : IImages
    {
        //DummieFunction
        public string GetImageToInstallBasedOnBaseBoard(string BaseBoard)
        {
            return @"AmazonImage.v1.0.0.25.wim";
        }
    }
}
