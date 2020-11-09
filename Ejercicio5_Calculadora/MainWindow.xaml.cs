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

            const int FILAS = 3, COLUMNAS = 3;
            int numero = 1;

            for (int i = 1; i <= FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    Button boton = new Button
                    {
                        Tag = numero,
                        Content = new Viewbox
                        {
                            Child = new TextBlock
                            {
                                Text = numero.ToString()
                            }
                        }
                    };
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);

                    numeros.Children.Add(boton);
                    numero++;
                }
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numerosPulsados.Text += (sender as Button).Tag.ToString();
        }
    }
}
