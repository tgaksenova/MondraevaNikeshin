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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthPage());
        }

        private void reg_click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length > 0)
            {
                if (password.Password.Length > 0)
                {
                    if (passwordCopy.Password.Length > 0)
                    {
                        if (textBoxFIO.Text.Length > 0)
                        {
                           
                                    if (password.Password.Length >= 6)
                                    {
                                        bool en = true;
                                        bool symbol = false;
                                        bool number = false;

                                        for (int i = 0; i < password.Password.Length; i++)
                                        {
                                            if (password.Password[i] >= 'А' && password.Password[i] <= 'Я') en = false;
                                            if (password.Password[i] >= '0' && password.Password[i] <= '9') number = true;
                                           
                                        }
                                        if (!en)
                                            MessageBox.Show(" В пароле доступна только английская раскладка");
                                    
                                            MessageBox.Show("Добавьте хотя бы одну цифру в пароль");
                                        if (en && symbol && number)
                                        {
                                            if (password.Password == passwordCopy.Password)
                                            {
                                                MessageBox.Show("Пользователь зарегистрирован");
                                                Entities db = new Entities();
                                                User usersObject = new User
                                                {
                                                    Login = login.Text,
                                                    Password = password.Password,
                                                    FIO = textBoxFIO.Text,
                                                    Role = role.Text
                                                };
                                                db.User.Add(usersObject);
                                                db.SaveChanges();
                                            }
                                            else MessageBox.Show("Пароли не совподают");
                                        }
                                    }
                                    else MessageBox.Show("Пароль слишком короткий, минимум 6 символов");
                         
                        }
                        else MessageBox.Show("Введите ФИО");
                    }
                    else MessageBox.Show("Повторите пароль");
                }
                else MessageBox.Show("Укажите пароль");
            }
            else MessageBox.Show("Укажите логин");
        }


    }
}
