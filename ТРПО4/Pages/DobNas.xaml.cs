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
        public DobNas()
        {
            InitializeComponent();
            //CmbCat.ItemsSource = Entities.GetContext().Nas_pynkt2.ToList();


        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
