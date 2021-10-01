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
    /// Логика взаимодействия для Special_nost_.xaml
    /// </summary>
    public partial class Special_nost_ : Page
    {
        public Special_nost_()
        {
            InitializeComponent();
            DataGridCar.ItemsSource = Entities.GetContext().Specilnost2.ToList();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Pages.DobSpec(null));
        }

        private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
        {
            var carsForRemoving = DataGridCar.SelectedItems.Cast<Specilnost2>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить записи в количестве {carsForRemoving.Count()} элементов?", "Внимание",
                            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)

                try
                {
                    Entities.GetContext().Specilnost2.RemoveRange(carsForRemoving);
                    Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DataGridCar.ItemsSource = Entities.GetContext().Specilnost2.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DobSpec((sender as Button).DataContext as Specilnost2));
        }





        private void Nationality_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DataGridCar.ItemsSource = Entities.GetContext().Specilnost2.ToList();
            }
        }
    }
}

