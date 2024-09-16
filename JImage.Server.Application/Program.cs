using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms.Design;
using System.Windows.Input;
using JImage.Server.Views.Views.ApplyImageAutomatic;


namespace JImage.Server.Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ApplicationDI.ConfigureViews(services);
            ApplicationDI.ConfigureServices(services);
            ApplicationDI.ConfigureViewModels(services);
            ApplicationDI.BuildServiceProvider(services);

            var serviceProvider = services.BuildServiceProvider();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var homeView = serviceProvider.GetRequiredService<ApplyImageAutomaticView>();

            homeView.Shown += async (a, b) =>
            {
                await homeView.InitializingView();
            };

            System.Windows.Forms.Application.Run(homeView);
        }
    }
}
