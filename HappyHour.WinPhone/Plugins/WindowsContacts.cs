using HappyHour.Core.Models;
using HappyHour.Core.Plugins;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.Contacts;

namespace HappyHour.WinPhone.Plugins
{
    public class WindowsContacts : IContacts
    {
        public List<GenericContact> GetContacts()
        {
            var contactsStore = ContactManager.RequestStoreAsync().GetResults();
            var contacts = contactsStore.FindContactsAsync().GetResults();

            var genericContacts = new List<GenericContact>();
            foreach (var contact in contacts)
            {
                var genericContact = new GenericContact
                {
                    Nome = contact.FullName,
                    Numero = contact.Phones?.FirstOrDefault()?.Number ?? string.Empty
                };
                genericContacts.Add(genericContact);
            }
            return genericContacts;
        }
    }
}