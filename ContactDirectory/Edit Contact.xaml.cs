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
    /// Interaction logic for Edit_Contact.xaml
    /// </summary>
    public partial class Edit_Contact : Window
    {
        Contact contact = new Contact();
        public Edit_Contact()
        {
            InitializeComponent();
            this.Top = 100;
            this.Left = 100;
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
                    this.SubmitBtn.Visibility = Visibility.Visible;
                    this.after_Search.Visibility = Visibility.Visible;
                    this.fName_Label.Visibility = Visibility.Visible;
                    this.lName_Label.Visibility = Visibility.Visible;
                    this.updatedFname.Visibility = Visibility.Visible;
                    this.updatedLname.Visibility = Visibility.Visible;
                    this.contactSearch.Text = string.Format("Contact Details\n{0}, {1}, #{2}", contact.FirstName, contact.LastName, contact.PhoneNumber);
                }

            }
            catch(Exception d)
            {
                MessageBox.Show("Please enter valid details");
                this.pNumber_Box.Clear();
                this.contactSearch.Text = "";
                this.contactSearch.Visibility = Visibility.Hidden;
                this.SubmitBtn.Visibility = Visibility.Hidden;
                this.after_Search.Visibility = Visibility.Hidden;
                this.fName_Label.Visibility = Visibility.Hidden;
                this.lName_Label.Visibility = Visibility.Hidden;
                this.updatedFname.Visibility = Visibility.Hidden;
                this.updatedLname.Visibility = Visibility.Hidden;
            }
            
        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.updatedFname.Text == "" || this.updatedLname.Text == "")
                {
                    MessageBox.Show("Please enter valid details");
                }
                else
                {
                    contact.FirstName = this.updatedFname.Text;
                    contact.LastName = this.updatedLname.Text;
                    ContactManager.EditContact(contact);
                    this.contactSearch.Text = string.Format("Contact Details\n{0}, {1}, #{2}", contact.FirstName, contact.LastName, contact.PhoneNumber);
                    MessageBox.Show("Contact updated sucessfully");
                    this.updatedFname.Clear();
                    this.updatedLname.Clear();
                }
                

            }
            catch(Exception d)
            {
                MessageBox.Show("Please enter valid details");
                this.updatedFname.Clear();
                this.updatedLname.Clear();
            }
            
        }
    }
}
