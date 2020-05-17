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
            ladowanie2();
            ladowanie3();
            ladowanie4();
        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection10 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection10.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT Prize FROM Baza WHERE Id='" + textBox1.Text + "'", sqlConnection10);
            {
                {
                    sqlCommand.ExecuteNonQuery();
                    ladowanie2();
                    ladowanie3();
                    ladowanie4();
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void ladowanie2()
        {
           
            SqlConnection sqlConnection10 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection10.Open();
            SqlCommand cmd = new SqlCommand("select DzienWizyty from Baza where Id='" + Idtext.Text+ "'", sqlConnection10);
            SqlDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                textBox2.Text = dr.GetValue(0).ToString();   
            }
            
          

            sqlConnection10.Close();
        }

        private void ladowanie3()
        {
            SqlConnection sqlConnection10 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection10.Open();
            SqlCommand cmd1 = new SqlCommand("select MiesiacWizyty from Baza where Id='" + Idtext.Text + "'", sqlConnection10);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                textBox3.Text = dr1.GetValue(0).ToString();
            }
            sqlConnection10.Close();
           
        }
        private void ladowanie4()
        {
            SqlConnection sqlConnection10 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            sqlConnection10.Open();
            SqlCommand cmd3 = new SqlCommand("select RokWizyty from Baza where Id='" + Idtext.Text + "'", sqlConnection10);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                textBox4.Text = dr3.GetValue(0).ToString();
            }
            sqlConnection10.Close();
            
        }

        private void FormPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            logowanie.Show();
        }
    }
    
}
