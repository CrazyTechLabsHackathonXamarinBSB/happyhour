using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        public MvxCommand VamosBeberCommand { get; private set; }

        public MainViewModel()
        {
            VamosBeberCommand = new MvxCommand(ExecuteVamosBeberCommand);
        }

        private void ExecuteVamosBeberCommand()
        {
            ShowViewModel<Cadastrar_BarViewModel>();
        }
        
    }
}
