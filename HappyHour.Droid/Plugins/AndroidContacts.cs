using Android.Content;
using Android.Provider;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Droid.Platform;
using HappyHour.Core.Models;
using HappyHour.Core.Plugins;
using System.Collections.Generic;

namespace HappyHour.Droid.Plugins
{
    /// <summary>
    ///Contatos do Android
    /// </summary>
    public class AndroidContacts : IContacts
    {
        public List<GenericContact> GetContacts()
        {
            var genericContacts = new List<GenericContact>();

            var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
            var cr = activity.ContentResolver;
            var cur = cr.Query(ContactsContract.Contacts.ContentUri, null, null, null, null);
            if (cur.Count > 0)
            {
                while (cur.MoveToNext())
                {
                    // read id
                    var id = cur.GetString(cur.GetColumnIndex(ContactsContract.Contacts.InterfaceConsts.Id));
                    // read names 
                    var displayName = cur.GetString(cur.GetColumnIndex(ContactsContract.Contacts.InterfaceConsts.DisplayName));
                    // Phone Numbers 
                    var pCur = cr.Query(ContactsContract.CommonDataKinds.Phone.ContentUri, null,
                            ContactsContract.CommonDataKinds.Phone.InterfaceConsts.ContactId + " = ?", new string[] { id }, null);

                    while (pCur.MoveToNext())
                    {
                        var number = pCur.GetString(pCur.GetColumnIndex(ContactsContract.CommonDataKinds.Phone.Number));
                        //var typeStr = pCur.GetString(pCur.GetColumnIndex(ContactsContract.CommonDataKinds.Phone.ContentType));
                        var genericContact = new GenericContact
                        {
                            Nome = displayName,
                            Numero = number
                        };
                        genericContacts.Add(genericContact);
                    }
                    pCur.Close();
                }
            }

            return genericContacts;
        }
    }
}