using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using NMCT.Resto.Core.ViewModels;

namespace NMCT.Resto.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TabInfoViewModel>();
        }
    }
}
