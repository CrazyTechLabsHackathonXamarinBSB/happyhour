using System;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.ViewModels;

namespace HappyHour.Core
{
    internal class App : IMvxApplication
    {
        public IMvxViewModelLocator FindViewModelLocator(MvxViewModelRequest request)
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void LoadPlugins(IMvxPluginManager pluginManager)
        {
            throw new NotImplementedException();
        }
    }
}