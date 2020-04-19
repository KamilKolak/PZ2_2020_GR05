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
            textBox11.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }
        int selectedRow;
        private void FormDoctors_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'hospitalDataSet.Patient' . Możesz go przenieść lub usunąć.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            selectedRow = e.RowIndex;
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();
            textBox8.Text = row.Cells[1].Value.ToString();
            textBox9.Text = row.Cells[2].Value.ToString();

        }
        private void ladowanie()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand cmdDataBase = new SqlCommand("SELECT Id, Name, Surname, Age, Gender, Birthday, Prize FROM Patient;", conDataBase);
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection2.Open();
            SqlCommand sqlCommand2 = new SqlCommand("UPDATE Patient SET Name="+textBox2+" ,  Surname="+textBox3+" , Age="+textBox4+", Gender="+textBox5+", Birthday="+textBox6+" , Prize="+textBox7+"    WHERE Id="+textBox1+";", sqlConnection2);
            sqlCommand2.ExecuteNonQuery();
            MessageBox.Show("UPDATED!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ladowanie();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            logowanie.Show();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
