using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private DataTable dataTable = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            InicjalizujDane();
        }

        private void InicjalizujDane()
        {

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Imie", typeof(string));
            dataTable.Columns.Add("Nazwisko", typeof(string));
            dataTable.Columns.Add("Wiek", typeof(int));
            dataTable.Columns.Add("Stanowisko", typeof(string));

            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Otwieramy drugie okno jako dialog
            using (var oknoDodawania = new OknoDodawania())
            {
                if (oknoDodawania.ShowDialog() == DialogResult.OK)
                {
                    // Pobieramy dane z drugiego okna i dodajemy do tabeli
                    var p = oknoDodawania.NowyPracownik;
                    dataTable.Rows.Add(p.Id, p.Imie, p.Nazwisko, p.Wiek, p.Stanowisko);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (!dataGridView1.CurrentRow.IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Nie mo¿na usun¹æ pustego wiersza.");
                }
            }
            else
            {
                MessageBox.Show("Proszê najpierw zaznaczyæ wiersz do usuniêcia.");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            
            string csvContent = "ID, Imie, Nazwisko, Wiek, Stanowisko" + Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    csvContent += string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString())) + Environment.NewLine;
                }
            }
            File.WriteAllText(filePath, csvContent);
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku CSV";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }
        }
        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            DataTable dataTable = new DataTable();

            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataTable.Rows.Add(values);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
    
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }
        }
    }
}
