using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    public class CadastroViewModel : MvxViewModel
    {

        public Login Login { get; set; }

        public MvxCommand CadastrarCommand { get; private set; }

        public CadastroViewModel()
        {
            CadastrarCommand = new MvxCommand(ExecuteCadastroCommand);

            Login = new Login();
        }

        private void ExecuteCadastroCommand()
        {
            Database db = new Database();
            
            db.InserirLogin(Login);
        }
    }
}
