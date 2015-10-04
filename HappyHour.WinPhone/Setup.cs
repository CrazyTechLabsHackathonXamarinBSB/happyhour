using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.WindowsUWP.Platform;
using Cirrious.MvvmCross.ViewModels;
using Windows.UI.Xaml.Controls;
using Cirrious.CrossCore.Plugins;
using Cirrious.CrossCore;
using HappyHour.Core.Plugins;
using HappyHour.WinPhone.Plugins;

namespace HappyHour.WinPhone
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame frame) : base(frame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            base.LoadPlugins(pluginManager);
            Mvx.RegisterType<IContacts, WindowsContacts>();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}