using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Course_Flex
{
  
    public partial class MainWindow : Window
    {
          EFContext context = new EFContext();
       public string username { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            

            

        }
        class tmp
        {
            public BitmapImage image { get; set; }
            public string header { get; set; }
            public string desc { get; set; }
        }
        private void Sand_Click(object sender, RoutedEventArgs e)
        {
            web.Visibility = Visibility.Hidden;


            Set_Dishes(1);



        }

        private void Drinks_Click(object sender, RoutedEventArgs e)
        {
            Set_Dishes(3);


        }
        public void Set_Dishes(int id)
        {

            web.Visibility = Visibility.Hidden;


            EFContext context = new EFContext();
            List<Dish> dishes = context.Dishes.Where(t => t.Type_Id == id).ToList();
            List<tmp> tmps = new List<tmp>();
            foreach (var el in dishes)
            {
                tmp t = new tmp();
                t.header = el.Header;
                t.desc = el.Description;
                BitmapImage im = new BitmapImage(new Uri(Environment.CurrentDirectory + ($"../../../Pics/{el.Image_Name}")));
                t.image = im;
                tmps.Add(t);

            }
            ListView.ItemsSource = tmps;
            Combik.IsDropDownOpen = false;
        }
        private void Chicken_Click(object sender, RoutedEventArgs e)
        {
            Set_Dishes(2);


        }
        private void MainClick(object sender, RoutedEventArgs e)
        {

        }
            private void Dess_Click(object sender, RoutedEventArgs e)
        {
            Set_Dishes(4);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            web.Visibility = Visibility.Visible;
            web.Navigate("https://www.google.com.ua/maps/search/kfc");
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }


    }
}
