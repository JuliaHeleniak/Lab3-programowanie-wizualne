using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Lab3
{
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
            // Upewnij siê, ¿e textBoxy maj¹ poprawne nazwy
            NowyPracownik = new Pracownik(
                textBoxImie.Text,
                textBoxNazwisko.Text,
                int.Parse(textBoxWiek.Text),
                comboBoxStanowisko.SelectedItem?.ToString() ?? "Brak"
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

           }
    public class Pracownik
    {
        private static int _nextId = 1; // Automatyczne ID [cite: 82]
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Stanowisko { get; set; }

        public Pracownik(string imie, string nazwisko, int wiek, string stanowisko)
        {
            this.Id = _nextId++;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
            this.Stanowisko = stanowisko;
        }
    }
}
