using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Database;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LinphoneXamarin.Entities;
using static Android.Provider.ContactsContract.CommonDataKinds;

namespace LinphoneXamarin.Android
{
    class ContactServiceImplementation : IContactService
    {
        public Task<List<PhoneBookContact>> GetContactListAsync(Func<PhoneBookContact, bool> filter = null) => Task.Run(() => GetContactList(filter));
        public Task<IList<PhoneBookContact>> GetUpdateContactListAsync(string timeStamp) => Task.Run(() => GetUpdatedContactList(timeStamp));
        public Task<IList<string>> GetDeletedContactIdListAsync(string timeStamp) => Task.Run(() => GetDeletedContactIdList(timeStamp));

        private IList<PhoneBookContact> GetUpdatedContactList(string timeStamp)
        {
            return GetUpdatedContacts(timeStamp).ToList();
        }
        private List<PhoneBookContact> GetContactList(Func<PhoneBookContact, bool> filter = null)
        {
            return GetContacts(filter).ToList();
        }

        private IList<string> GetDeletedContactIdList(string timeStamp)
        {
            return GetDeletedContactIDS(timeStamp).ToList();
        }

        private IEnumerable<string> GetDeletedContactIDS(string timeStamp)
        {
            String[] projection = new String[]{
      ContactsContract.Data.InterfaceConsts.ContactId,
      ContactsContract.Data.InterfaceConsts.DisplayName,
    ContactsContract.Data.InterfaceConsts.ContactLastUpdatedTimestamp};
            var uri = ContactsContract.DeletedContacts.ContentUri;
            String selection = ContactsContract.DeletedContacts.InterfaceConsts.ContactDeletedTimestamp + " > ?";
            String[] selectionArgs = new String[] { timeStamp };

            //var ctx = Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity;
            var ctx = Application.Context;
            var cursor = ctx.ApplicationContext.ContentResolver.Query(uri, null, selection, selectionArgs, null);
            if (cursor.Count == 0) yield break;
            var list = new List<String>();
            while (cursor.MoveToNext())
            {
                var contactId = GetString(cursor, ContactsContract.DeletedContacts.InterfaceConsts.ContactId);
                yield return contactId;
            }
        }

        private IEnumerable<PhoneBookContact> GetContacts(Func<PhoneBookContact, bool> filter = null)
        {
            var uri = ContactsContract.Contacts.ContentUri;
            //var ctx = Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity;
            var ctx = Application.Context;
            var cursor = ctx.ApplicationContext.ContentResolver.Query(uri, null, null, null, null);
            if (cursor.Count == 0) yield break;

            while (cursor.MoveToNext())
            {
                var contact = CreateContact(cursor, ctx);

                if (filter != null && !filter(contact))
                    continue;

                if (!string.IsNullOrWhiteSpace(contact.Name) && contact.hasPhoneNumber.Equals("1"))
                    yield return contact;
            }
        }

        private IEnumerable<PhoneBookContact> GetUpdatedContacts(string timeStamp)
        {
            var uri = ContactsContract.Contacts.ContentUri;
            String selection = ContactsContract.Contacts.InterfaceConsts.ContactLastUpdatedTimestamp + " > ?";
            String[] selectionArgs = new String[] { timeStamp };
            //var ctx = Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity;
            var ctx = Application.Context;
            var cursor = ctx.ApplicationContext.ContentResolver.Query(uri, null, selection, selectionArgs, null);
            if (cursor.Count == 0) yield break;

            while (cursor.MoveToNext())
            {
                var contact = CreateContact(cursor, ctx);

                if (!string.IsNullOrWhiteSpace(contact.Name))
                    yield return contact;
            }
        }

        private static PhoneBookContact CreateContact(ICursor cursor, Context ctx)
        {
            var contactId = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.Id);
            //            var hasNumbers = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.HasPhoneNumber) == "1";

            var numbers = GetNumbers(ctx, contactId);
            //.ToList();
            var emails = GetEmails(ctx, contactId);
            //.ToList();

            var contact = new PhoneBookContact
            {
                Id = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.Id),
                Name = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.DisplayName),
                PhotoUri = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.PhotoUri),
                PhotoUriThumbnail = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.PhotoThumbnailUri),
                hasPhoneNumber = GetString(cursor, ContactsContract.Contacts.InterfaceConsts.HasPhoneNumber),
                Emails = emails,
                Email = emails.LastOrDefault(),
                Numbers = numbers,
                Number = numbers.LastOrDefault(),
                isFavorite = (GetString(cursor, ContactsContract.Contacts.InterfaceConsts.Starred)).Equals("1") ? true : false,
            };

            return contact;
        }

        private static IList<string> GetNumbers(Context ctx, string contactId)
        {
            var key = ContactsContract.CommonDataKinds.Phone.Number;

            var cursor = ctx.ApplicationContext.ContentResolver.Query(
                ContactsContract.CommonDataKinds.Phone.ContentUri,
                null,
                ContactsContract.CommonDataKinds.Phone.InterfaceConsts.ContactId + " = ?",
                new[] { contactId },
                null
            );

            return ReadCursorItems(cursor, key).ToList();
        }

        private static IEnumerable<string> GetEmails(Context ctx, string contactId)
        {
            var key = ContactsContract.CommonDataKinds.Email.InterfaceConsts.Data;

            var cursor = ctx.ApplicationContext.ContentResolver.Query(
                ContactsContract.CommonDataKinds.Email.ContentUri,
                null,
                ContactsContract.CommonDataKinds.Email.InterfaceConsts.ContactId + " = ?",
                new[] { contactId },
                null);

            return ReadCursorItems(cursor, key);
        }

        private static IEnumerable<string> ReadCursorItems(ICursor cursor, string key)
        {
            while (cursor.MoveToNext())
            {
                var value = GetString(cursor, key);
                yield return value;
            }

            cursor.Close();
        }

        private static string GetString(ICursor cursor, string key)
        {
            return cursor.GetString(cursor.GetColumnIndex(key));
        }


    }
}
