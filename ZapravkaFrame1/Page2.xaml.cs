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

namespace ZapravkaFrame1
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextBox1.IsEnabled = true;
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            TextBox2.IsEnabled = true;
        }

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            TextBox3.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox4.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox5.Text) +
                +Convert.ToInt32(TextBox2.Text) * Convert.ToInt32(TextBox6.Text) +
                +Convert.ToInt32(TextBox3.Text) * Convert.ToInt32(TextBox7.Text));
        }
    }
}
