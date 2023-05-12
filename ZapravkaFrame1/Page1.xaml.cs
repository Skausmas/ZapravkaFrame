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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            ComboBox1.Items.Add("АИ-92");
            ComboBox1.Items.Add("АИ-95");
            ComboBox1.Items.Add("АИ-95 Премиум");
            ComboBox1.Items.Add("ДТ");
            TextBox3.Text = "00,00";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Litr.IsChecked == true)
            {
                if (TextBox1.Text != "")
                {
                    TextBox3.Text = Convert.ToString(Math.Round(double.Parse(Price.Text) * double.Parse(TextBox1.Text), 2));
                }
                else
                {
                    MessageBox.Show("Введите количество литров");
                }

            }
            else
            {
                if (TextBox2.Text != "")
                {
                    TextBox3.Text = TextBox2.Text;
                }
                else
                {
                    MessageBox.Show("Введите необходимую сумму!");
                }
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ComboBox1.SelectedItem.ToString() == "АИ-92")
            {
                Price.Text = "45,30";
            }
            else if (ComboBox1.SelectedItem.ToString() == "АИ-95")
            {
                Price.Text = "48,55";
            }
            else if (ComboBox1.SelectedItem.ToString() == "АИ-95 Премиум")
            {
                Price.Text = "50,12";
            }
            else if (ComboBox1.SelectedItem.ToString() == "ДТ")
            {
                Price.Text = "56,27";
            }

        }
        private void Litr_Checked(object sender, RoutedEventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                TextBox1.IsEnabled = true;
                TextBox2.IsEnabled = false;
                TextBox2.Text = "";



            }
            else
            {
                MessageBox.Show("Выберите вид топлива!");
                Litr.IsChecked = false;

            }

        }

        private void Summ_Checked(object sender, RoutedEventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                TextBox2.IsEnabled = true;
                TextBox1.IsEnabled = false;
                TextBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Выберите вид топлива!");
                Summ.IsChecked = false;
            }
        }
    }
}
