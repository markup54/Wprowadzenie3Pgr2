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
using System.Windows.Shapes;

namespace Wprowadzenie3Pgr2
{
    /// <summary>
    /// Logika interakcji dla klasy KalkulatorWindow.xaml
    /// </summary>
    public partial class KalkulatorWindow : Window
    {
        public KalkulatorWindow()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(liczba1.Text, out int a) && int.TryParse(liczba2.Text, out int b) )
            {
                int wynik = a + b;
                MessageBox.Show(wynik.ToString(), "Wynik", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Information);
                liczba1.Text = String.Empty;
                liczba2.Text= String.Empty;
            }
            else
            {
                MessageBox.Show("Formularz musi być poprawnie wypełniony", 
                    "Ostrzeżenie",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
