using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Knjiga> kolekcijaKnjiga;
        public MainWindow()
        {
            InitializeComponent();
            kolekcijaKnjiga = new ObservableCollection<Knjiga>();
            knjigeListView.ItemsSource = kolekcijaKnjiga;
            kolekcijaKnjiga.Add(new Knjiga("1", "Na Drini ćuprija", "Ivo Andrić", "Ep", true, System.IO.Path.Combine(Environment.CurrentDirectory,"Ikonica1.png")));
            kolekcijaKnjiga.Add(new Knjiga("2", "Prokleta avlija", "Ivo Andrić", "Kratka priča", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica4.png")));
            kolekcijaKnjiga.Add(new Knjiga("3", "Seobe", "Milos Crnjanski", "Epski roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica2.png")));
            kolekcijaKnjiga.Add(new Knjiga("4", "Gorski vijenac", "Petrovic Njegos", "Epska poema", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica5.png")));
            kolekcijaKnjiga.Add(new Knjiga("5", "Zlocin i kazna", "Fjodor Dostojevski", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica3.png")));
            kolekcijaKnjiga.Add(new Knjiga("6", "Besnilo", "Borislav Pekic", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica2.png")));
            kolekcijaKnjiga.Add(new Knjiga("7", "Koreni", "Dobrica Cosic", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica1.png")));
            kolekcijaKnjiga.Add(new Knjiga("8", "Alkohol", "Milenko Jergovic", "Zbirka priča", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica4.png")));
            kolekcijaKnjiga.Add(new Knjiga("9", "Sabrana dela", "Desanka Maksimovic", "Poezija", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica3.png")));
            kolekcijaKnjiga.Add(new Knjiga("10", "Deobe", "Dobrica Cosic", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica5.png")));
            kolekcijaKnjiga.Add(new Knjiga("11", "Majstor i Margarita", "Mihail Bulgakov", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica3.png")));
            kolekcijaKnjiga.Add(new Knjiga("12", "Hari Poter i Kamen mudrosti", "J.K. Rowling", "Fantazija", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica1.png")));
            kolekcijaKnjiga.Add(new Knjiga("13", "Lolita", "Vladimir Nabokov", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica2.png")));
            kolekcijaKnjiga.Add(new Knjiga("14", "Rat i mir", "Lav Nikolajevic Tolstoj", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica4.png")));
            kolekcijaKnjiga.Add(new Knjiga("15", "Veliki Getsbi", "F. Scott Fitzgerald", "Roman", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica5.png")));
        }

        private void knjigeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {
                sifraTextBox.Text = izabranaKnjiga.Sifra;
                naslovTextBox.Text = izabranaKnjiga.NaslovKnjige;
                autorTextBox.Text = izabranaKnjiga.Autor;
                zanrTextBox.Text = izabranaKnjiga.Zanr;
                dostupnostCB.IsChecked = izabranaKnjiga.Dostupnost;
            }
        }

        public void DodajKnjigu(Knjiga novaKnjiga)
        {
            kolekcijaKnjiga.Add(novaKnjiga);
            knjigeListView.Items.Refresh();
        }
        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            DodajKnjiguWindow dodajKnjiguWindow = new DodajKnjiguWindow();
            dodajKnjiguWindow.ShowDialog();
        }

        private void IzmeniDugme_Click(object sender, RoutedEventArgs e)
        {
            /*if(knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {

                string originalnaSifra = izabranaKnjiga.Sifra;
                string originalniNaslov = izabranaKnjiga.NaslovKnjige;
                string originalniAutor = izabranaKnjiga.Autor;
                string originalniZanr = izabranaKnjiga.Zanr;
                bool originalnaDostupnost = izabranaKnjiga.Dostupnost;
                string originalnaIkonica = izabranaKnjiga.Ikonica;

                izabranaKnjiga.Sifra = sifraTextBox.Text;
                izabranaKnjiga.NaslovKnjige = naslovTextBox.Text;
                izabranaKnjiga.Autor = autorTextBox.Text;
                izabranaKnjiga.Zanr = zanrTextBox.Text;
                izabranaKnjiga.Dostupnost = dostupnostCB.IsChecked ?? false;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Ikonice|*.jpg;*.jpeg;*.png";

                if(openFileDialog.ShowDialog() == true)
                {
                    string ikonica = openFileDialog.FileName;
                    izabranaKnjiga.Ikonica = ikonica;
                }

                MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izvršite izmene?", "Potvrda izmene", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    knjigeListView.Items.Refresh();
                }
                else
                {
                    izabranaKnjiga.Sifra = originalnaSifra;
                    izabranaKnjiga.NaslovKnjige = originalniNaslov;
                    izabranaKnjiga.Autor = originalniAutor;
                    izabranaKnjiga.Zanr = originalniZanr;
                    izabranaKnjiga.Dostupnost = originalnaDostupnost;
                    izabranaKnjiga.Ikonica = originalnaIkonica;

                    sifraTextBox.Text = originalnaSifra;
                    naslovTextBox.Text = originalniNaslov;
                    autorTextBox.Text = originalniAutor;
                    zanrTextBox.Text = originalniZanr;
                    dostupnostCB.IsChecked = originalnaDostupnost;

                }

            }*/

            if (knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {
                string originalnaSifra = izabranaKnjiga.Sifra;
                string originalniNaslov = izabranaKnjiga.NaslovKnjige;
                string originalniAutor = izabranaKnjiga.Autor;
                string originalniZanr = izabranaKnjiga.Zanr;
                bool originalnaDostupnost = izabranaKnjiga.Dostupnost;
                string originalnaIkonica = izabranaKnjiga.Ikonica;

                IzmenaKnjigeWindow izmenaWindow = new IzmenaKnjigeWindow(izabranaKnjiga);

                bool? rezultat = izmenaWindow.ShowDialog();

                if (izmenaWindow.DialogResult == true)
                {
                    // Ažuriranje knjige na osnovu rezultata izmene
                    sifraTextBox.Text = izabranaKnjiga.Sifra;
                    naslovTextBox.Text = izabranaKnjiga.NaslovKnjige;
                    autorTextBox.Text = izabranaKnjiga.Autor;
                    zanrTextBox.Text = izabranaKnjiga.Zanr;
                    dostupnostCB.IsChecked = izabranaKnjiga.Dostupnost;
                    knjigeListView.Items.Refresh();
                }
                else if (izmenaWindow.DialogResult == false)
                {
                    sifraTextBox.Text = originalnaSifra;
                    naslovTextBox.Text = originalniNaslov;
                    autorTextBox.Text = originalniAutor;
                    zanrTextBox.Text = originalniZanr;
                    dostupnostCB.IsChecked = originalnaDostupnost;
                    // Odbijanje izmena - ne preduzima se ništa
                }
            }
        }
        

        private void UkloniDugme_Click(object sender, RoutedEventArgs e)
        {
            if (knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {
                MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete knjigu?", "Potvrda brisanja", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

                if(result == MessageBoxResult.Yes)
                {
                    kolekcijaKnjiga.Remove(izabranaKnjiga);

                    sifraTextBox.Text = string.Empty;
                    naslovTextBox.Text = string.Empty;
                    autorTextBox.Text = string.Empty;
                    zanrTextBox.Text = string.Empty;
                    dostupnostCB.IsChecked = false;

                }
            }
        }

        private void PretraziListuKnjiga_Click(object sender, RoutedEventArgs e)
        {
            if (dostupnostPretragaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Izaberite dostupnost knjige.");
                return;
            }

            string naslov = naslovPretragaTextBox.Text;
            string autor = autorPretragaTextBox.Text;

            string dostupnostPretraga = ((ComboBoxItem)dostupnostPretragaComboBox.SelectedItem)?.Content.ToString();

            List<Knjiga> rezultatiPretrage = kolekcijaKnjiga
                .Where(k =>
                    (string.IsNullOrEmpty(naslov) || k.NaslovKnjige.ToLower().Contains(naslov.ToLower())) &&
                    (string.IsNullOrEmpty(autor) || k.Autor.ToLower().Contains(autor.ToLower())) &&
                    (dostupnostPretraga == "Sve" || (dostupnostPretraga == "Dostupne" && k.Dostupnost) || (dostupnostPretraga == "Nedostupne" && !k.Dostupnost)))
                .ToList();

            knjigeListView.ItemsSource = rezultatiPretrage;
        }
    }
}
