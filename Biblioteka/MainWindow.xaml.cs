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
            kolekcijaKnjiga.Add(new Knjiga(001, "Na Drini ćuprija", "Ivo Andrić", "Ep", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica1.png"));
            kolekcijaKnjiga.Add(new Knjiga(002, "Prokleta avlija", "Ivo Andrić", "Kratka priča", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica4.png"));
            kolekcijaKnjiga.Add(new Knjiga(003, "Seobe", "Milos Crnjanski", "Epski roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica2.png"));
            kolekcijaKnjiga.Add(new Knjiga(004, "Gorski vijenac", "Petrovic Njegos", "Epska poema", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica5.png"));
            kolekcijaKnjiga.Add(new Knjiga(005, "Zlocin i kazna", "Fjodor Dostojevski", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica3.png"));
            kolekcijaKnjiga.Add(new Knjiga(006, "Besnilo", "Borislav Pekic", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica2.png"));
            kolekcijaKnjiga.Add(new Knjiga(007, "Koreni", "Dobrica Cosic", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica1.png"));
            kolekcijaKnjiga.Add(new Knjiga(008, "Alkohol", "Milenko Jergovic", "Zbirka priča", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica4.png"));
            kolekcijaKnjiga.Add(new Knjiga(009, "Sabrana dela", "Desanka Maksimovic", "Poezija", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica3.png"));
            kolekcijaKnjiga.Add(new Knjiga(010, "Deobe", "Dobrica Cosic", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica5.png"));
            kolekcijaKnjiga.Add(new Knjiga(011, "Majstor i Margarita", "Mihail Bulgakov", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica3.png"));
            kolekcijaKnjiga.Add(new Knjiga(012, "Hari Poter i Kamen mudrosti", "J.K. Rowling", "Fantazija", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica1.png"));
            kolekcijaKnjiga.Add(new Knjiga(013, "Lolita", "Vladimir Nabokov", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica2.png"));
            kolekcijaKnjiga.Add(new Knjiga(014, "Rat i mir", "Lav Nikolajevic Tolstoj", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica4.png"));
            kolekcijaKnjiga.Add(new Knjiga(015, "Veliki Getsbi", "F. Scott Fitzgerald", "Roman", true, @"C:\Users\Ognjen\Desktop\ProjekatBiblioteka\Biblioteka\Biblioteka\bin\Debug\Ikonica3.png"));
        }

        private void knjigeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IzmeniDugme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UkloniDugme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PromenaIkoniceDugme_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
