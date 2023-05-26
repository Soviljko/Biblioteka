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
    /// Interaction logic for DodajKnjiguWindow.xaml
    /// </summary>
    public partial class DodajKnjiguWindow : Window
    {
        public DodajKnjiguWindow()
        {
            InitializeComponent();
        }

        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            string sifra = sifraTextBox.Text;
            string naslov = naslovKnjigeTextBox.Text;
            string autor = autorTextBox.Text;
            string zanr = zanrTextBox.Text;
            bool dostupnost = dostupnostCheckBox.IsChecked ?? false;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ikonice|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                string ikonica = openFileDialog.FileName;

                Knjiga novaKnjiga = new Knjiga(sifra, naslov, autor, zanr, dostupnost, ikonica);

                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.DodajKnjigu(novaKnjiga);

                Close();
            }
        }
    }
}
