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

namespace ZapravkaFrame1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            Frame1.Content = new Page3();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page1();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page2();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page3();

        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {



        }
    }
}
