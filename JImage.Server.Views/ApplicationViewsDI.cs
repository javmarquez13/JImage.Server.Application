using System;
using System.Collections.Generic;
using System.Text;
using JImage.Server.Views.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace JImage.Server.Views
{
    
    public static class ApplicationViewsDI
    {
        public static IServiceProvider _serviceProvider;

        public static IUtilsViews ResolveUtilsViews()
        {       
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException("Service provider is not built. Call BuildServiceProvider() first.");
            }
            return _serviceProvider.GetRequiredService<IUtilsViews>();
        }
    }
}
