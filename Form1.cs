using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerD
{
    public partial class Form1 : Form
    {
        public Cdb baza;

        public Form1()
        {
            InitializeComponent();
        }

        private void getter_Click(object sender, EventArgs e)
        {
            try
            {
                widokDanych.DataSource = baza.pobierzDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void widokDanych_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                string message = "Czy na pewno chcesz usunąć wiersz?";
                string caption = "Usuwanie wiersza";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    string i = e.Row.Cells[0].Value.ToString();
                    baza.usunWiersz(i);
                }
                else
                {
                    e.Cancel = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void widokDanych_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (widokDanych.Rows[e.RowIndex].IsNewRow)
                {
                    //odczytuję dane z nowego wiersza
                    string name = widokDanych.Rows[e.RowIndex - 1].Cells[1].Value.ToString();
                    string surname = widokDanych.Rows[e.RowIndex - 1].Cells[2].Value.ToString();
                    string nt = widokDanych.Rows[e.RowIndex - 1].Cells[3].Value.ToString();
                    string a = widokDanych.Rows[e.RowIndex - 1].Cells[4].Value.ToString();

                    //dodaje nowy wiersz do bazy
                    baza.dodajWiersz(name, surname, nt, a);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void widokDanych_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < widokDanych.Rows.Count - 2)
                {

                    string message = "Czy na pewno chcesz zmienić wiersz?";
                    string caption = "Zmiana wiersza";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == DialogResult.Yes)
                    {
                        //odczytuje dane zmienionej komórki
                        string colname = widokDanych.Columns[e.ColumnIndex].HeaderText;
                        string newValue = widokDanych.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        string id = widokDanych.Rows[e.RowIndex].Cells[0].Value.ToString();

                        //aktualizuje dane w bazie
                        baza.updateData(colname, newValue, id);
                    }
                    else
                    {
                        widokDanych.CancelEdit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            baza.closeConnection();
        }
    }
}
