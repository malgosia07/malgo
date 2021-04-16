using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Wypożyczalnia_sprzętu_narciarskiego
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if (String.IsNullOrEmpty(textDni.Text) && String.IsNullOrEmpty(textNazwisko.Text) && String.IsNullOrEmpty(textImie.Text) && String.IsNullOrEmpty(textCena.Text) )
            {

                MessageBox.Show("Presze wpisać wszystkie dane");
            }
            else
            {
                
                DateTime poczatek = DataPoc.SelectedDate.Value.Date;
                DateTime koniec = DataKon.SelectedDate.Value.Date;
                TimeSpan difference = koniec.Subtract(poczatek);
                textDni.Text = difference.TotalDays.ToString();
                String suma;
                
                SumaCeny.Text = (Convert.ToInt32(textDni.Text) * Convert.ToInt32(textCena.Text)).ToString();
                suma = SumaCeny.Text;
                Lista.Items.Add(DataPoc.Text + " " + DataKon.Text + " " + textImie.Text + " " + textNazwisko.Text + " " + textDni.Text +" "+ "dni" + " " + textCena.Text + " " + "zl/24h" + " " + suma + " " + "zl");  
                  
            }
        }

        private void textNazwisko_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textDni_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
