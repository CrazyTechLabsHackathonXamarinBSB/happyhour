using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using HappyHour.Core.Models;
using HappyHour.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    public class CadastroViewModel : MvxViewModel
    {
        public ObservableCollection<GenericContact> Contacts { get; private set; }
        public ObservableCollection<long> _Contacts { get; private set; }
        public Login Login { get; set; }

        public MvxCommand CadastrarCommand { get; private set; }

        public CadastroViewModel()
        {
            var contacts = Mvx.Resolve<IContacts>();
            var contactsList = contacts.GetContacts();
            Contacts = new ObservableCollection<GenericContact>(contactsList);

            foreach (GenericContact item in Contacts)
            {
                long a;
                a = Convert.ToInt64(item.Numero);

                if (a != 0)
                {
                    _Contacts.Add(a);
                }
            }

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
