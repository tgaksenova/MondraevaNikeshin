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
    /// Логика взаимодействия для DobNas.xaml
    /// </summary>
    public partial class DobNas : Page
    {
        private Nas_pynkt2 _currentCar = new Nas_pynkt2();

        public DobNas(Nas_pynkt2 selectedCar)
        {
            InitializeComponent();


            if (selectedCar != null)
                _currentCar = selectedCar;
            DataContext = _currentCar;
            CmbCat.ItemsSource = Entities.GetContext().Oblast_2.ToList();

        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentCar.Naimenovanie))
                errors.AppendLine("ВВедите название города!");
            if (string.IsNullOrWhiteSpace(_currentCar.Vid_nas_pynkta))
                errors.AppendLine("Укажите название населенного пункта!");
            if ( _currentCar.Oblast_2 == null)
                errors.AppendLine("Укажите название области!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }



            if (_currentCar.ID == 0)
            {
                Entities.GetContext().Nas_pynkt2.Add(_currentCar);
         

            }
            

            try
            {
                Entities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CmbCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
