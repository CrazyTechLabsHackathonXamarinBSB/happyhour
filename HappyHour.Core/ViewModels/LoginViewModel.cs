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
        public MvxCommand EntrarCommand { get; private set; }

        public LoginViewModel()
        {
            CadastrarCommand = new MvxCommand(ExecuteCadastrarCommand);
            EntrarCommand = new MvxCommand(ExecuteEntrarCommand);
           
        }

        private void ExecuteEntrarCommand()
        {
            Database db = new Database();
            db.ExcluirDados();
            Task<int> a = db.GetLogin();

            if (a.Equals(0))
            {
                ShowViewModel<CadastroViewModel>();
            }
            else
            {
                ShowViewModel<MainViewModel>();
            }
            
        }

        private void ExecuteCadastrarCommand()
        {
            ShowViewModel<CadastroViewModel>();
        }
    }
}