using System;
using System.Collections.Generic;
using System.Text;
using JImage.Server.Views.Views.Base;
using Microsoft.Extensions.DependencyInjection;


namespace JImage.Server.Views.Helpers
{
    public interface IUtilsViews
    {
        T CreateView<T>() where T : BaseView;
        T CreateModalView<T>() where T : BaseModalView;
    }

    public class UtilsViews : IUtilsViews
    {
        private readonly IServiceProvider _serviceProvider;

        public UtilsViews(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T CreateView<T>() where T : BaseView
        {
            return _serviceProvider.GetRequiredService<T>();
        }

        public T CreateModalView<T>() where T : BaseModalView
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
