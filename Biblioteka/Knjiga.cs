﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Knjiga : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string sifra;
        private string naslovKnjige;
        private string autor;
        private string zanr;
        private bool dostupnost;
        private string ikonica;

        public string Sifra
        {
            get { return sifra; }
            set
            {
                if(value != sifra)
                {
                    sifra = value;
                    OnPropertyChanged("Sifra");
                }
            }
        }

        public string NaslovKnjige
        {
            get { return naslovKnjige; }
            set
            {
                if (value != naslovKnjige)
                {
                    naslovKnjige = value;
                    OnPropertyChanged("NaslovKnjige");
                }
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (value != autor)
                {
                    autor = value;
                    OnPropertyChanged("Autor");
                }
            }
        }

        public string Zanr
        {
            get { return zanr; }
            set
            {
                if (value != zanr)
                {
                    zanr = value;
                    OnPropertyChanged("Zanr");
                }
            }
        }

        public bool Dostupnost
        {
            get { return dostupnost; }
            set
            {
                if (value != dostupnost)
                {
                    dostupnost = value;
                    OnPropertyChanged("Dostupnost");
                }
            }
        }

        public string Ikonica
        {
            get { return ikonica; }
            set
            {
                if (value != ikonica)
                {
                    ikonica = value;
                    OnPropertyChanged("Ikonica");
                }
            }
        }

        public Knjiga(string s, string n, string a, string z, bool d)
        {
            this.sifra = s;
            this.naslovKnjige = n;
            this.autor = a;
            this.zanr = z;
            this.dostupnost = d;
            this.ikonica = string.Empty;

        }

        public Knjiga(string s, string n, string a, string z, bool d, string i)
        {
            this.sifra = s;
            this.naslovKnjige = n;
            this.autor = a;
            this.zanr = z;
            this.dostupnost = d;
            this.ikonica = i;

        }
    }
}
