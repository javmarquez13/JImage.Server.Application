using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JImage.Server.ProviderContracts.Repositories.BaseBoard;
using System.Management;

namespace JImage.Server.ProviderContracts.RepositoriesImplementation.BaseBoard
{
    public class BaseBoard : IBaseBoard
    {
        public string GetBaseBoard()
        {
            string result = string.Empty;
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject baseBoard in searcher.Get())
                {
                    result = baseBoard["Product"].ToString();
                    break;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
