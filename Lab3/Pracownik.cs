using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Pracownik
    {
        private static int _nextId = 1; 

        public int Id { get; private set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Stanowisko { get; set; }

        public Pracownik(string imie, string nazwisko, int wiek, string stanowisko)
        {
            Id = _nextId++;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Stanowisko = stanowisko;
        }
    }
}
