using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContactServices
    {
        public static string filePath = "../../contacts.txt";
        public static void AddContact(Contact contact)
        {

            string str = contact.ToString() + "\n";
            File.AppendAllText(filePath, str);
        }
        public static Contact ReturnContact(ulong phoneNumber)
        {
            string[] lines = File.ReadAllLines(filePath);
            Contact contact = new Contact();
            foreach (string line in lines)
            {

                string[] parameter = line.Split(',');
                string fName = parameter[0];
                string lName = parameter[1];
                ulong pNumber = ulong.Parse(parameter[2]);

                if (pNumber == phoneNumber)
                {
                    contact.FirstName = fName;
                    contact.LastName = lName;
                    contact.PhoneNumber = pNumber;
                }

            }
            return contact;
        }
        public static void EditContact(Contact contact)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parameter = lines[i].Split(',');
                ulong phoneNumber = ulong.Parse(parameter[2]);
                if (phoneNumber == contact.PhoneNumber)
                {
                    string src = contact.ToString();
                    lines[i] = src;
                }
            }
            File.WriteAllLines(filePath, lines);

        }

        public static void DeleteContact(Contact contact)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[] updatedLines = new string[lines.Length-1];
            int j = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parameter = lines[i].Split(',');
                ulong phoneNumber = ulong.Parse(parameter[2]);
                if (phoneNumber != contact.PhoneNumber)
                {
                    updatedLines[j] = lines[i];
                    j++;
                }
            }
            File.WriteAllLines(filePath, updatedLines);

        }

        public static List<Contact> displayContacts()
        {
            List<Contact> contacts = new List<Contact>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parameter = line.Split(',');
                string fName = parameter[0];
                string lName = parameter[1];
                ulong pNumber = ulong.Parse(parameter[2]);
                Contact contact = new Contact() { FirstName = fName, LastName = lName, PhoneNumber = pNumber };
                contacts.Add(contact);
            }
            return contacts;
        }

        public static void SortPhoneAsc()
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < (lines.Length - 1); i++)
            {
               
                for (int j = i+1; j < lines.Length; j++)
                {
                    string[] parameter = lines[i].Split(',');
                    ulong pNumber = ulong.Parse(parameter[2]);
                    string[] parameter1 = lines[j].Split(',');
                    ulong pNumber1 = ulong.Parse(parameter1[2]);
                    if (pNumber > pNumber1)
                    {
                        swap(lines, i, j);
                    }
                }
                
            }
            File.WriteAllLines(filePath, lines);
        }

        public static void SortPhoneDsc()
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < (lines.Length - 1); i++)
            {
                for (int j = i + 1; j < lines.Length; j++)
                {
                    string[] parameter = lines[i].Split(',');
                    ulong pNumber = ulong.Parse(parameter[2]);
                    string[] parameter1 = lines[j].Split(',');
                    ulong pNumber1 = ulong.Parse(parameter1[2]);
                    if (pNumber < pNumber1)
                    {
                        swap(lines, i, j);
                    }
                }

            }
            File.WriteAllLines(filePath, lines);
        }

        public static void sortByFirstName()
        {
            string[] lines = File.ReadAllLines(filePath);
            Array.Sort(lines);
            File.WriteAllLines(filePath, lines);
        }

        private static void swap(string[] lines, int pos1 , int pos2)
        {
            string temp = lines[pos1];
            lines[pos1] = lines[pos2];
            lines[pos2] = temp;
        }
    }
}
