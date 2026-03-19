using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public class Pracownik
    {
        private static int _nextId = 1; // Automatyczne nadawanie ID

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
    public partial class OknoDodawania : Form
       {
            public Pracownik NowyPracownik { get; private set; }

            public OknoDodawania()
            {
                 InitializeComponent();
                 comboBoxStanowisko.Items.AddRange(new string[] { "Programista", "Tester", "Manager" });
            }

       
        private void button1_Click(object sender, EventArgs e)
        {
                NowyPracownik = new Pracownik(
                textBoxImie.Text,
                textBoxNazwisko.Text,
                int.Parse(textBoxWiek.Text),
                comboBoxStanowisko.SelectedItem.ToString()
            );

            this.DialogResult = DialogResult.OK; // Informujemy, ¿e operacja siê uda³a
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
