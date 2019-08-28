using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Course_Flex
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        bool OK;
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EFContext context = new EFContext();
            try
            {
                string First_Name = FName.Text;
                string Second_Name = SName.Text;
                string email = Email.Text;
                string Password = Password1.Text;
                User New_User = new User() { FirstName = First_Name, Email = email, LastName = Second_Name, Password = Password };
                context.Users.Add(New_User);
                context.SaveChanges();
                OK = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Error, Check your data");
            }
            if(OK==true)
            {
                MainWindow MW = new MainWindow();
                MW.Show();this.Close();
            }
        }



        private void Password1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Password1.Text = "";

        }

        private void Email_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Email.Text = "";

        }

        private void SName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SName.Text = "";

        }

        private void FName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FName.Text = "";

        }
    }
}
