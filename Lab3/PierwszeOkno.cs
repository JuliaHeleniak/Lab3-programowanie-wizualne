using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

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
            private void button3_Click(object sender, EventArgs e)
            { 

            }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
            { 

            }
        }
    }
