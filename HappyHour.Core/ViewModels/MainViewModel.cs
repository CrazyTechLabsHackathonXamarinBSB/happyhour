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
    public class MainViewModel : MvxViewModel
    {

        public ObservableCollection<GenericContact> Contacts { get; private set; }

        public MainViewModel()
        {
            var contacts = Mvx.Resolve<IContacts>();
            var contactsList = contacts.GetContacts();
            Contacts = new ObservableCollection<GenericContact>(contactsList);

         

            VamosBeberCommand = new MvxCommand(ExecuteVamosBeberCommand);
        }

        public MvxCommand VamosBeberCommand { get; private set; }



        private void ExecuteVamosBeberCommand()
        {
            ShowViewModel<Cadastrar_BarViewModel>();
        }

    }
}
