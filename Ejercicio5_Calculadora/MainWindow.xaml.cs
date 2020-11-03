using System.Windows;
using System.Windows.Controls;

namespace Ejercicio5_Calculadora
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numerosPulsados.Text += (sender as Button).Tag.ToString();
        }
    }
}
