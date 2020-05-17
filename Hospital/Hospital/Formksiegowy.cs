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

namespace Hospital
{
    public partial class Formksiegowy : Form
    {
        Form1 oknoKsiegowego;

        public Formksiegowy(Form1 oknoKsiegowego)
        {
            InitializeComponent();
            ladowanie();
            this.oknoKsiegowego = oknoKsiegowego;

        }

        private void Formksiegowy_Load(object sender, EventArgs e)
        {

        }
        private void ladowanie()  
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection sqlConnection = new SqlConnection(constring))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id, Name,Surname,Prize FROM Baza where PermissionLvl= 3;", sqlConnection);
                try
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();

                    bindingSource.DataSource = dataTable;
                    dataGridView1.DataSource = bindingSource;
                    sqlDataAdapter.Update(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // przycisk wczytaj
        {
            ladowanie();
        }

        private void button2_Click(object sender, EventArgs e) // dla przycisku zapisz
        {
            SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection2.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Baza SET Prize="+ Int16.Parse(textBox4.Text) + " WHERE Id ="+ Int16.Parse(textBox1.Text) +";", sqlConnection2);


            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("UPDATED");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // dla przycisku powrot 
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // przeskoczenie do textboxow zaznaczonego wiersza
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void Formksiegowy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 logowanie = new Form1();
            logowanie.Show();
        }
    }
}
