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

namespace WpfLab021
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Textbox");
            e.Handled = (bool)RadioButton1.IsChecked;
        }

        private void Grid_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Grid");
            e.Handled = (bool)RadioButton2.IsChecked;
        }

        private void Window_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Window");
            e.Handled = (bool)RadioButton3.IsChecked;
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
