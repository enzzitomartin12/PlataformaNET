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

namespace WpfBinding
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona unaPersona = new Persona();
        public MainWindow()
        {
            InitializeComponent();
            unaPersona.Nombre = "Alejo";
            DataContext = unaPersona;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.unaPersona.Nombre = "Franco";
        }
    }
}
