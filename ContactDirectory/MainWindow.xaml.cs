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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactDirectory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Top = 100;
            this.Left = 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add_Contact add_Contact = new Add_Contact();
            add_Contact.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Edit_Contact edit_Contact = new Edit_Contact();
            edit_Contact.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Delete_Contact delete_Contact = new Delete_Contact();
            delete_Contact.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Search_Contact search_Contact = new Search_Contact();
            search_Contact.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Sort_Contacts sort_Contacts = new Sort_Contacts();
            sort_Contacts.Show();
            this.Close();
        }
    }
}
