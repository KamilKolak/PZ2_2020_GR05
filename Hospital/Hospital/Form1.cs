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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sciezka = @"F:\NAJNOWSZE\Hospital\Hospital\bin\Debug\HOSPITAL.MDF";

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            string zapytanie = "select permissionlvl from Users where username= '"+ Login_textBox.Text.Trim() +"' and password ='"+ Password_textBox.Text.Trim() +"';";
            SqlDataAdapter sda = new SqlDataAdapter(zapytanie, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0]["permissionlvl"].ToString() == "0")
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    FormAdmina oknoAdmina = new FormAdmina(this);
                    this.Hide();
                    oknoAdmina.Show();
                }
                else if(dtbl.Rows[0]["permissionlvl"].ToString() == "1")
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    FormDoctors oknoDoktora = new FormDoctors(this);
                    this.Hide();
                    oknoDoktora.Show();
                }
                else if (dtbl.Rows[0]["permissionlvl"].ToString() == "2")
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    FormReceptionist oknoRecepcionisty = new FormReceptionist(this);
                    this.Hide();
                    oknoRecepcionisty.Show();
                }
                else if (dtbl.Rows[0]["permissionlvl"].ToString() == "3")
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    findID();
                    this.Hide();                    
                }
                else
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    Formksiegowy oknoKsiegowego = new Formksiegowy(this);                    
                    this.Hide();
                    oknoKsiegowego.Show();
                }
            }
            else MessageBox.Show("Check your username or password");
            sqlcon.Close();
        }

        private void findID()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            string Id = "Select Id from Patient Where Login= '" + Login_textBox.Text.Trim() + "' and Password= '" + Password_textBox.Text.Trim() + "';";
            SqlCommand comand = new SqlCommand(Id, sqlcon);
            int identyfikator = Convert.ToInt32(comand.ExecuteScalar());
            FormPatient oknoPacjenta = new FormPatient(this);
            TextBox tb = (TextBox)oknoPacjenta.Controls["Idtext"];
            tb.Text = "5";
            TextBox tb2 = (TextBox)oknoPacjenta.Controls["textbox1"];
            tb2.Text = "300";
            oknoPacjenta.Show();
            sqlcon.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = '*';
        }
    }
}
