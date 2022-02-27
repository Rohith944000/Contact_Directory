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
    /// Interaction logic for Add_Contact.xaml
    /// </summary>
    public partial class Add_Contact : Window
    {
        public Add_Contact()
        {
            InitializeComponent();
            this.Top = 100;
            this.Left = 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void fName_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lName_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pNumber_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.fName_Box.Text == "" || this.lName_Box.Text == "" || this.pNumber_Box.Text == "")
                {
                    MessageBox.Show("Please enter valid details");
                    this.fName_Box.Clear();
                    this.lName_Box.Clear();
                    this.pNumber_Box.Clear();
                }
                else
                {
                    string fName = this.fName_Box.Text;
                    string lName = this.lName_Box.Text;
                    ulong pNumber = ulong.Parse(this.pNumber_Box.Text);
                    Contact contact = ContactManager.ReturnContact(pNumber);

                    if (contact.PhoneNumber != 0)
                    {
                        MessageBox.Show("Phone number alreay exits in the directory");
                        this.fName_Box.Clear();
                        this.lName_Box.Clear();
                        this.pNumber_Box.Clear();
                        //return;
                    }
                    else
                    {
                        Contact tempContact = new Contact() { FirstName = fName, LastName = lName, PhoneNumber = pNumber };
                        ContactManager.AddContact(tempContact);
                        MessageBox.Show("Contact Succefully added in the Database");
                        this.fName_Box.Clear();
                        this.lName_Box.Clear();
                        this.pNumber_Box.Clear();
                    }
                }  

            }
            catch(Exception d)
            {
                MessageBox.Show("Please enter valid details");
                this.fName_Box.Clear();
                this.lName_Box.Clear();
                this.pNumber_Box.Clear();
            }

        }
    }
}
