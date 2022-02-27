using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContactDirectory
{
    /// <summary>
    /// Interaction logic for Sort_Contacts.xaml
    /// </summary>
    public partial class Sort_Contacts : Window
    {
        public Sort_Contacts()
        {
            InitializeComponent();
            DisplayContacts();
            this.Top = 100;
            this.Left = 100;
        }

        private void DisplayContacts()
        {
            List<Contact> contacts = ContactManager.displayContacts();
            string str = "Available Contacts in Directory\n";
            int i = 1;
            foreach (Contact contact in contacts)
            {

                str = str + string.Format("{0})   {1}, {2}, #{3}", i, contact.FirstName, contact.LastName, contact.PhoneNumber);
                str = str + "\n";
                i++;
            }
            this.displayContacts.Text = str;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContactManager.SortPhoneAsc();
            DisplayContacts();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ContactManager.SortPhoneDsc();
            DisplayContacts();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ContactManager.sortByFirstName();
            DisplayContacts();
        }
    }
}
