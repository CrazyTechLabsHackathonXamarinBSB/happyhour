using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.WindowsUWP.Platform;
using Cirrious.MvvmCross.ViewModels;
using Windows.UI.Xaml.Controls;

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
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}