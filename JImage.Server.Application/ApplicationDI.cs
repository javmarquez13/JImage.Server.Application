using System;
using JImage.Server.ProviderContracts.Repositories.BaseBoard;
using JImage.Server.ProviderContracts.Repositories.Images;
using JImage.Server.ProviderContracts.Repositories.JImageX;
using JImage.Server.ProviderContracts.RepositoriesImplementation.BaseBoard;
using JImage.Server.ProviderContracts.RepositoriesImplementation.Images;
using JImage.Server.ProviderContracts.RepositoriesImplementation.JImageX;
using JImage.Server.ViewModels.ViewModels.ApplyImageAutomatic;
using JImage.Server.ViewModels.ViewModels.Base;
using JImage.Server.ViewModels.ViewModels.CaptureImageViewModel;
using JImage.Server.ViewModels.ViewModels.JImageX;
using JImage.Server.Views.Helpers;
using JImage.Server.Views.Views.BaseModal;
using JImage.Server.Views.Views.CaptureImage;
using JImage.Server.Views.Views.JImageX;
using Microsoft.Extensions.DependencyInjection;
using JImage.Server.Views;
using JImage.Server.Views.Views.Reboot;
using JImage.Server.ViewModels.ViewModels.Reboot;
using JImage.Server.Views.Views.Admin;
using JImage.Server.ViewModels.ViewModels.Admin;
using JImage.Server.Views.Views.ApplyImageAutomatic;
using JImage.Server.Views.Views.Menu;
using JImage.Server.ViewModels.ViewModels.Menu;
using JImage.Server.Views.Views.ApplyImageManual;
using JImage.Server.ViewModels.ViewModels.ApplyImageManual;

namespace JImage.Server.Application
{
    public static class ApplicationDI
    {
        private static IServiceProvider _serviceProvider;

        public static void BuildServiceProvider(ServiceCollection services)
        {
            _serviceProvider = services.BuildServiceProvider();
            ApplicationViewsDI._serviceProvider = _serviceProvider;
        }


        public static void ConfigureViews(ServiceCollection services)
        {
            services.AddTransient<BaseView>();
            services.AddTransient<ApplyImageAutomaticView>();
            services.AddTransient<CaptureImageView>();
            services.AddTransient<JImageXView>();
            services.AddTransient<RebootView>();
            services.AddTransient<AdminView>();
            services.AddTransient<MenuView>();
            services.AddTransient<ApplyImageManualView>();
        }

        public static void ConfigureViewModels(ServiceCollection services)
        {
            services.AddScoped<BaseViewModel>();
            services.AddScoped<ApplyImageAutomaticViewModel>();
            services.AddScoped<CaptureImageViewModel>();
            services.AddScoped<JImageXViewModel>();
            services.AddScoped<RebootViewModel>();
            services.AddScoped<AdminViewModel>();
            services.AddScoped<MenuViewModel>();
            services.AddScoped<ApplyImageManualViewModel>();

        }

        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IJImageX, JImageX>();
            services.AddScoped<IBaseBoard, BaseBoard>();
            services.AddScoped<IImages, Images>();
            services.AddScoped<IUtilsViews, UtilsViews>();  
        }
    }
}
