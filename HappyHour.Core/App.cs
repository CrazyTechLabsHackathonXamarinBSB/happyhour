using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;

namespace HappyHour.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            var database = new Database();
            database.InitDB();
            Mvx.RegisterSingleton(database);

            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}