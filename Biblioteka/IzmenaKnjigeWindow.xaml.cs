using Microsoft.Win32;
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

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for IzmenaKnjigeWindow.xaml
    /// </summary>
    public partial class IzmenaKnjigeWindow : Window
    {
        private Knjiga izmenjenaKnjiga;
        public IzmenaKnjigeWindow(Knjiga knjiga)
        {
            InitializeComponent();
            izmenjenaKnjiga = knjiga;

            sifraTextBox.Text = izmenjenaKnjiga.Sifra;
            naslovKnjigeTextBox.Text = izmenjenaKnjiga.NaslovKnjige;
            autorTextBox.Text = izmenjenaKnjiga.Autor;
            zanrTextBox.Text = izmenjenaKnjiga.Zanr;
            dostupnostCB.IsChecked = izmenjenaKnjiga.Dostupnost;
        }

        private void SacuvajIzmene_Click(object sender, RoutedEventArgs e)
        {
            string originalnaSifra = izmenjenaKnjiga.Sifra;
            string originalniNaslov = izmenjenaKnjiga.NaslovKnjige;
            string originalniAutor = izmenjenaKnjiga.Autor;
            string originalniZanr = izmenjenaKnjiga.Zanr;
            bool originalnaDostupnost = izmenjenaKnjiga.Dostupnost;
            string originalnaIkonica = izmenjenaKnjiga.Ikonica;

            izmenjenaKnjiga.Sifra = sifraTextBox.Text;
            izmenjenaKnjiga.NaslovKnjige = naslovKnjigeTextBox.Text;
            izmenjenaKnjiga.Autor = autorTextBox.Text;
            izmenjenaKnjiga.Zanr = zanrTextBox.Text;
            izmenjenaKnjiga.Dostupnost = dostupnostCB.IsChecked ?? false;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ikonice|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                string ikonica = openFileDialog.FileName;
                izmenjenaKnjiga.Ikonica = ikonica;
            }

            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izvršite izmene?", "Potvrda izmene", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                DialogResult = true;
            }
            else
            {
                DialogResult = false;

                izmenjenaKnjiga.Sifra = originalnaSifra;
                izmenjenaKnjiga.NaslovKnjige = originalniNaslov;
                izmenjenaKnjiga.Autor = originalniAutor;
                izmenjenaKnjiga.Zanr = originalniZanr;
                izmenjenaKnjiga.Dostupnost = originalnaDostupnost;
                izmenjenaKnjiga.Ikonica = originalnaIkonica;

                sifraTextBox.Text = originalnaSifra;
                naslovKnjigeTextBox.Text = originalniNaslov;
                autorTextBox.Text = originalniAutor;
                zanrTextBox.Text = originalniZanr;
                dostupnostCB.IsChecked = originalnaDostupnost;

            }

        }
    }
}

