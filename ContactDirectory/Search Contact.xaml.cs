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
    /// Interaction logic for Search_Contact.xaml
    /// </summary>
    public partial class Search_Contact : Window
    {
        Contact contact = new Contact();
        public Search_Contact()
        {
            InitializeComponent();
            this.Top = 100;
            this.Left = 100;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ulong pNumber = ulong.Parse(this.pNumber_Box.Text);
                contact = ContactManager.ReturnContact(pNumber);

                if (contact.PhoneNumber == 0)
                {
                    MessageBox.Show("Please enter valid contact number");
                    this.pNumber_Box.Clear();

                }
                else
                {
                    this.contactSearch.Visibility = Visibility.Visible;
                    this.contactSearch.Text = string.Format("Contact Details\n{0}, {1}, #{2}", contact.FirstName, contact.LastName, contact.PhoneNumber);
                    this.pNumber_Box.Clear();
                }

            }
            catch (Exception d)
            {
                MessageBox.Show("Please enter valid details");
                this.pNumber_Box.Clear();
                this.contactSearch.Text = "";
                this.contactSearch.Visibility = Visibility.Hidden;

            }
        }
    }
}
