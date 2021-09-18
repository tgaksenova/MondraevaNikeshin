﻿using System;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void ButtonEnter_OnClick(object sender, RoutedEventArgs e)
        {
            using (var db = new Entities())
            {
                var users = db.User.AsNoTracking().ToList();
            }
            using (var db = new Entities())
            {
                var users = db.User.AsNoTracking().Where(u => u.Login.StartsWith("max")).ToList();
            }
            using (var db = new Entities())
            {
                var user = db.User.AsNoTracking().FirstOrDefault(u => u.Login == "max" && u.Password == "test");
            }
            if (string.IsNullOrEmpty(TextBoxLogin.Text) || string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            using (var db = new Entities())
            {
                var user = db.User
                .AsNoTracking()
                .FirstOrDefault(u => u.Login == TextBoxLogin.Text && u.Password == PasswordBox.Password);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }

                MessageBox.Show("Пользователь успешно найден!\n"  +user.FIO);
                switch (user.Role)
                {
                    case "Админ":
                        NavigationService?.Navigate(new Menu());
                        break;
                    case "Абитуриент":
                        NavigationService?.Navigate(new Menu());
                        break;
                }


            }
        }


        private void ButtonRegistration_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Page2());
        }
    }

}
