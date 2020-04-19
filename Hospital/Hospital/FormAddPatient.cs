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
    public partial class FormAddPatient : Form
    {
        FormReceptionist oknoWyboruRecepcjonisty;
        public FormAddPatient(FormReceptionist oknoWyboruRecepcjonisty)
        {
            InitializeComponent();
            this.oknoWyboruRecepcjonisty = oknoWyboruRecepcjonisty;
            oknoWyboruRecepcjonisty.Hide();
        }
        
        private void Add_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlpatient = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlpatient.Open();
            try
            {
                string pytanie = "Insert into Patient(Login,Password,Name,Surname,Age,Gender,Birthday,Prize) values('" + Login_textBox.Text + "','" + Password_textBox.Text + "','" + Name_textBox.Text + "','" + Surname_textBox.Text + "','" + Int16.Parse(Age_textBox.Text) + "','" + Gender_textBox.Text + "','" + Birthday_textBox.Text + "','" + Int16.Parse(Prize_textBox.Text) + "') ;";
                //string pytanie2 = "Insert into Users(Username, Password, permissionlvl) values('" + Login_textBox.Text + "','" + Password_textBox.Text + "','" + 3 + "') ;";
                SqlCommand sda = new SqlCommand(pytanie, sqlpatient);
                sda.ExecuteNonQuery();
                string str1 = "select max(Id) from Patient;";
                //string str2 = "select max(Id) from Users;";
                SqlCommand cmd1 = new SqlCommand(str1, sqlpatient);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("SAVED");
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    Name_textBox.Text = "";
                    Surname_textBox.Text = "";
                    Age_textBox.Text = "";
                    Gender_textBox.Text = "";
                    Birthday_textBox.Text = "";
                    Prize_textBox.Text = "";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlpatient.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            oknoWyboruRecepcjonisty.Show();
        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
