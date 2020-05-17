using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace Hospital
{
    public partial class FormDoctors : Form
    {
        Form1 logowanie;
        public FormDoctors(Form1 logowanie)
        {
            InitializeComponent();
            this.logowanie = logowanie;
            logowanie.Hide();
            ladowanie();
            ladowanie2();

            textBox11.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox13.Text = DateTime.Now.Day.ToString();
            textBox14.Text = DateTime.Now.Month.ToString();
            textBox15.Text = DateTime.Now.Year.ToString();
            



        }  
        private void FormDoctors_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'hospitalDataSet4.Baza' . Możesz go przenieść lub usunąć.
            this.bazaTableAdapter3.Fill(this.hospitalDataSet4.Baza);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'hospitalDataSet3.Baza' . Możesz go przenieść lub usunąć.
          
            this.bazaTableAdapter2.Fill(this.hospitalDataSet3.Baza);
            

        }

        
        private void ladowanie()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand cmdDataBase = new SqlCommand("SELECT Name, Surname, Wiek, Plec, DataUrodzenia FROM Baza where PermissionLvl=3;", conDataBase);
                try
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = cmdDataBase;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTable;
                    dataGridView1.DataSource = bSource;
                    sqlDataAdapter.Update(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void ladowanie2()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase1 = new SqlConnection(constring))
            {
                // SqlCommand cmdDataBase1 = new SqlCommand("SELECT Name, Surname, Wiek, Plec, DataUrodzenia FROM Baza where PermissionLvl=3, IdLekarza=" + textBox12.Text + ",RokWizyty=" + textBox15.Text + ",DzienWizyty >=" + textBox13.Text + " AND MiesiacWizyty >=" + textBox14.Text + ";", conDataBase1);
                SqlCommand cmdDataBase1 = new SqlCommand("SELECT Name, Surname, Wiek, Plec, DataUrodzenia FROM Baza where PermissionLvl=3 AND RokWizyty ='"+ DateTime.Now.Year + "' AND DzienWizyty ='" + DateTime.Now.Day + "'AND MiesiacWizyty ='" + DateTime.Now.Month + "';", conDataBase1);
                try
                {

                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                    sqlDataAdapter1.SelectCommand = cmdDataBase1;
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);
                    BindingSource bSource1 = new BindingSource();
                    bSource1.DataSource = dataTable1;
                    dataGridView2.DataSource = bSource1;
                    sqlDataAdapter1.Update(dataTable1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

      

        private void button2_Click(object sender, EventArgs e) // wczytanie
        {
            ladowanie();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox8.Text = row.Cells[1].Value.ToString();
                textBox9.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
           Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Test\\documentt.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
           x.Columns.AutoFit();
            DateTime localDate = DateTime.Now;
            x.Range["D2"].Value = textBox9.Text;            // imie pacjenta
            x.Range["E2"].Value = textBox8.Text;           // nazwisko pacjenta
            x.Range["C2"].Value = localDate;               // data
            x.Range["B2"].Value = textBox10.Text;         // recepta


            sheet.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
            MessageBox.Show("Pomyslnie zapisano receptę");
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand cmdDataBase = new SqlCommand("SELECT * FROM Baza WHERE username=  '" + textBox16.Text + "';", conDataBase);
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    System.Data.DataTable dbdataset = new System.Data.DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormDoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            logowanie.Show();
        }
    }
}
