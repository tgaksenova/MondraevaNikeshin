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
    /// Логика взаимодействия для Nationality.xaml
    /// </summary>
    public partial class Nationality : Page
    {
        public Nationality()
        {
            InitializeComponent();

            DataGridCar.ItemsSource = Entities.GetContext().Nationality2.ToList();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DobNati(null));
        }

        private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
        {
            var carsForRemoving = DataGridCar.SelectedItems.Cast<Nationality2>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить записи в количестве {carsForRemoving.Count()} элементов?", "Внимание",
                            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)

                try
                {
                    Entities.GetContext().Nationality2.RemoveRange(carsForRemoving);
                    Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DataGridCar.ItemsSource = Entities.GetContext().Nationality2.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }



        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DobNati((sender as Button).DataContext as Nationality2));
        }





        private void Nationality_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DataGridCar.ItemsSource = Entities.GetContext().Nationality2.ToList();
            }
        }

    }
}
