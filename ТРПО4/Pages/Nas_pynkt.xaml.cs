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
    /// Логика взаимодействия для Nas_pynkt.xaml
    /// </summary>
    public partial class Nas_pynkt : Page
    {
        public Nas_pynkt()
        {
            InitializeComponent();
            DataGridCar.ItemsSource = Entities.GetContext().Nas_pynkt2.ToList();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new DobNas());
        }

        private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void DataGridCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
