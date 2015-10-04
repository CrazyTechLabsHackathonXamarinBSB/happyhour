using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using HappyHour.Core.Models;
using HappyHour.Core.Plugins;
using System.Collections.ObjectModel;

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
        }
    }
}
