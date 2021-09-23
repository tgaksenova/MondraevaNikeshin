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
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;



namespace ТРПО4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page)) return;
            this.Title = $"Никешин_и_Мондраева - {page.Title}";
            if (page is Pages.AuthPage)
            {
                ButtonBack.Visibility = Visibility.Hidden;
            }
            else
            {
                ButtonBack.Visibility = Visibility.Visible;
            }
            if (page is Pages.Calculator)
            {
                ButtonCalc.Visibility = Visibility.Hidden;
            }
            else
            {
                ButtonCalc.Visibility = Visibility.Visible;
            }
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack) MainFrame.GoBack();
        }

        private void КалькуляторButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService?.Navigate(new Pages.Calculator());

          

            var uri = new Uri( "Dictionary.xaml", UriKind.Relative);

            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

            Application.Current.Resources.Clear();
         
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        static void Export()
        {

            SaveFileDialog ofd = new SaveFileDialog();
            string path = "export.txt";
            StreamWriter sw = new StreamWriter(path);

            using (var db = new Entities())
            {
                var User = db.User.AsNoTracking().ToList();

                string IDline = String.Join(":", db.User.Select(x => x.ID));
                sw.WriteLine(IDline);
                string Loginline = String.Join(":", db.User.Select(x => x.Login));
                sw.WriteLine(Loginline);
                string Passwordline = String.Join(":", db.User.Select(x => x.Password));
                sw.WriteLine(Passwordline);
                string FIOline = String.Join(":", db.User.Select(x => x.FIO));
                sw.WriteLine(FIOline);
                string Roleline = String.Join(":", db.User.Select(x => x.Role));
                sw.WriteLine(Roleline);
                sw.Close();
                Process.Start("notepad.exe", path);
            }
        }

        private void export_click(object sender, RoutedEventArgs e)
        {
            Export();
        }

        void Import()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                while (!sr.EndOfStream)
                {
                    string[] lines = new string[5];
                    for (int i = 0; i < 5; i++)
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(':');
                        line = "";
                        if (data.Length >= 2)
                        {
                            for (int j = 0; j < data.Length; j++)
                            {
                                line += data[j];
                            }
                        }
                        lines[i] = line;
                    }
                    MessageBox.Show("Данные в файле: \nID: " + lines[0] + "\nЛогин: " + lines[1] + "\nПароль: " + lines[2] + "\nРоль: " + lines[3] + "\nФИО: " + lines[4]);
                }
            }
            else MessageBox.Show("Файл не выбран");
        }

        private void import_click(object sender, RoutedEventArgs e)
        {
            Import();
        }
    }
}
