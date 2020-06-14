using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class ModifyPatient : Form
    {
        FormReceptionist oknoWyboruRecepcjonisty;
        public ModifyPatient(FormReceptionist oknoWyboruRecepcjonisty)
        {
            InitializeComponent();
            this.oknoWyboruRecepcjonisty = oknoWyboruRecepcjonisty;
            oknoWyboruRecepcjonisty.Hide();
            wyswietl();
        }

        private string connectionSQL = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30";
        private void Delete_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            try
            {
                SqlConnection TablePatient = new SqlConnection(connectionSQL);
                using (TablePatient)
                {
                    TablePatient.Open();
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM Baza WHERE " + " Id  " + " = '" + ID_textBox.Text + "'", TablePatient))
                        {
                            {
                                command.ExecuteNonQuery();
                            }
                            TablePatient.Close();
                        }
                    }
                }
                ID_textBox.Text = "";
                Login_textBox.Text = "";
                Password_textBox.Text = "";
                Name_textBox.Text = "";
                Surname_textBox.Text = "";
                Age_textBox.Text = "";
                Gender_textBox.Text = "";
                Birthday_textBox.Text = "";
                Prize_textBox.Text = "";
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            wyswietl();
        }

        private void wyswietl()
        {
            string constring = (connectionSQL);
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand cmdDataBase = new SqlCommand("SELECT * FROM Baza;", conDataBase);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
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
                
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            ID_textBox.Text = selectedRow.Cells[0].Value.ToString();
            Login_textBox.Text = selectedRow.Cells[1].Value.ToString();
            Password_textBox.Text = selectedRow.Cells[2].Value.ToString();
            Name_textBox.Text = selectedRow.Cells[3].Value.ToString();
            Surname_textBox.Text = selectedRow.Cells[4].Value.ToString();
            Age_textBox.Text = selectedRow.Cells[5].Value.ToString();
            Gender_textBox.Text = selectedRow.Cells[6].Value.ToString();
            Birthday_textBox.Text = selectedRow.Cells[7].Value.ToString();
            Prize_textBox.Text = selectedRow.Cells[8].Value.ToString();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlTable = new SqlConnection(connectionSQL);
            sqlTable.Open();
            SqlCommand komand = new SqlCommand("UPDATE Baza SET Login=@a1 , Password=@a2,  Name=@a3 , Surname=@a4 , Wiek=@a5 , Plec=@a6 , Dataurodzenia=@a7 , Prize=@a8 WHERE Id =@a9", sqlTable);
            komand.Parameters.AddWithValue("a1", Login_textBox.Text);
            komand.Parameters.AddWithValue("a2", Password_textBox.Text);
            komand.Parameters.AddWithValue("a3", Name_textBox.Text);
            komand.Parameters.AddWithValue("a4", Surname_textBox.Text);
            komand.Parameters.AddWithValue("a5", Int16.Parse(Age_textBox.Text));
            komand.Parameters.AddWithValue("a6", Gender_textBox.Text);
            komand.Parameters.AddWithValue("a7", Birthday_textBox.Text);
            komand.Parameters.AddWithValue("a8", Int16.Parse(Prize_textBox.Text));
            komand.Parameters.AddWithValue("a9", Int16.Parse(ID_textBox.Text));


            komand.ExecuteNonQuery();
            MessageBox.Show("The database is UPDATED!");
            wyswietl();
        }

        private void ModifyPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            oknoWyboruRecepcjonisty.Show();
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Birthday_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
