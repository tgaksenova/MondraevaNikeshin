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
    /// Логика взаимодействия для DobSpec.xaml
    /// </summary>
    public partial class DobSpec : Page
    {

        private Specilnost2 _currentCar = new Specilnost2();


        public DobSpec(Specilnost2 selectedCar)
        {
            InitializeComponent();


            DataContext = _currentCar;

            if (selectedCar != null)
                _currentCar = selectedCar;

            DataContext = _currentCar;

        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentCar.Naimenovanie))
                errors.AppendLine("ВВедите название специальности!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentCar.ID == 0)
                Entities.GetContext().Specilnost2.Add(_currentCar);

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
    }
}
