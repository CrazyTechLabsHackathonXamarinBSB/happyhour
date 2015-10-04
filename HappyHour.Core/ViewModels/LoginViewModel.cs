using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _hello = "Amigos de Bar!";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }

        public MvxCommand CadastrarCommand { get; private set; }

        public LoginViewModel()
        {
            CadastrarCommand = new MvxCommand(ExecuteCadastrarCommand);
        }

        private void ExecuteCadastrarCommand()
        {
            Debug.WriteLine("Teste");
        }
    }
}
