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

namespace ТРПО4.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomerMenu.xaml
    /// </summary>
    public partial class CustomerMenu : Page
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }
        private void Переход_1_OnClick(object sender, RoutedEventArgs e)
        {
           NavigationService?.Navigate(new Nationality());
        }

        private void Переход_2_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Special_nost_());
        }

        private void Переход_3_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Nas_pynkt());
        }

      
    }
}
