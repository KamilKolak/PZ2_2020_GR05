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
    public partial class FormPatient : Form
    {
        Form1 logowanie;
        public FormPatient(Form1 logowanie)
        {
            InitializeComponent();
            this.logowanie = logowanie;
            logowanie.Hide();
        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*SqlConnection sqlConnection10 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection10.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT Prize FROM Patient WHERE Id='" + textBox1.Text + "'", sqlConnection10);
            {
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }*/
            int a = 300;
            textBox1.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            logowanie.Show();
        }
    }
}
