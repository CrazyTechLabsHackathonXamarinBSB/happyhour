using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    public class Cadastrar_BarViewModel : MainViewModel
    {
        
        public MvxCommand CadastrarBarCommand { get; private set; }

        public Cadastrar_BarViewModel()
        {
            CadastrarBarCommand = new MvxCommand(ExecuteCadastrarBarCommand);
        }

        private void ExecuteCadastrarBarCommand()
        {
            Database db = new Database();

        }
    }
}
