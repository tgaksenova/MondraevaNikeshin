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
    /// Логика взаимодействия для Special_nost_.xaml
    /// </summary>
    public partial class Special_nost_ : Page
    {
        public Special_nost_()
        {
            InitializeComponent();
            DataGridCar.ItemsSource = Entities.GetContext().Specil_nost_2.ToList();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {

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
