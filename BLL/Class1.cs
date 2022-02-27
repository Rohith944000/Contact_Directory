using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContactManager
    {
        public static void AddContact(Contact contact)
        {
            ContactServices.AddContact(contact);
        }
        public static Contact ReturnContact(ulong phoneNumber)
        {
            Contact contact = ContactServices.ReturnContact(phoneNumber);
            return contact;
        }
        public static void EditContact(Contact contact)
        {
            ContactServices.EditContact(contact);
        }
        public static void DeleteContact(Contact contact)
        {
            ContactServices.DeleteContact(contact);
        }

        public static List<Contact> displayContacts()
        {
            List<Contact> contacts = ContactServices.displayContacts();
            return contacts;
        }
        public static void SortPhoneAsc()
        {
            ContactServices.SortPhoneAsc();
        }

        public static void SortPhoneDsc()
        {
            ContactServices.SortPhoneDsc();
        }

        public static void sortByFirstName()
        {
            ContactServices.sortByFirstName();
        }

    }
}
