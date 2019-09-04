using Library.Entities;
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

namespace Course_Flex
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void TextBox_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            Pass.Password = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EFContext context = new EFContext();
            List<User> Users = context.Users.ToList();
            foreach(var el in Users)
            {
                if(el.FirstName==Login1.Text)
                {
                    if(el.Password==Pass.Password)
                    {
                        MainWindow Mw = new MainWindow();
                        Mw.Show();
                       
                        this.Close(); break;
                    }
                }
            }

        }

        private void Pass_GotFocus(object sender, RoutedEventArgs e)
        {
            Login1.Text = "";
        }
    }
}
