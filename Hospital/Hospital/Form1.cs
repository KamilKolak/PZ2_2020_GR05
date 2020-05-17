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

        public static string sciezka = Application.StartupPath + @"\HOSPITAL.MDF"; // deklaracja zmiennej dla sciezki

        private void Login_button_Click(object sender, EventArgs e) // przycisk logowania
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            string zapytanie = "select PermissionLvl from Baza where Login= '"+ Login_textBox.Text.Trim() +"' and Password ='"+ Password_textBox.Text.Trim() +"';";
            SqlDataAdapter sda = new SqlDataAdapter(zapytanie, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)  
            {
                if (dtbl.Rows[0]["PermissionLvl"].ToString() == "0")  // warunek dla permission level dla admina
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    FormAdmina oknoAdmina = new FormAdmina(this);
                    this.Hide();
                    oknoAdmina.Show();
                }
                else if(dtbl.Rows[0]["PermissionLvl"].ToString() == "1") // warunek dla permission level dla doktora
                {
                    findIDdoktor();
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    
                    this.Hide();
                   
                }
                else if (dtbl.Rows[0]["PermissionLvl"].ToString() == "2")  // warunek dla permission level dla recepcjonisty 
                {
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    FormReceptionist oknoRecepcionisty = new FormReceptionist(this);
                    this.Hide();
                    oknoRecepcionisty.Show();
                }
                else if (dtbl.Rows[0]["PermissionLvl"].ToString() == "3")  // dla pacjenta
                {
                    findID();  // funkcja pobiera id pacjenta ktory sie loguje
                    Login_textBox.Text = "";
                    Password_textBox.Text = "";
                    
                    this.Hide();                    
                }
                else  // warunek dla permission level dla ksiegowego
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

        private void findID() // znajdowanie Id pacjenta
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            string Id = "Select Id from Baza Where Login= '" + Login_textBox.Text.Trim() + "' and Password= '" + Password_textBox.Text.Trim() + "';";
            string Prize = "Select Prize from Baza Where Login= '" + Login_textBox.Text.Trim() + "' and Password= '" + Password_textBox.Text.Trim() + "';";
            SqlCommand comand = new SqlCommand(Id, sqlcon);
            SqlCommand comand1 = new SqlCommand(Prize, sqlcon);
            
            int identyfikator = Convert.ToInt32(comand.ExecuteScalar());
            int identyfikator1 = Convert.ToInt32(comand1.ExecuteScalar());
            
            FormPatient oknoPacjenta = new FormPatient(this);

            TextBox tb = (TextBox)oknoPacjenta.Controls["Idtext"];
            tb.Text = identyfikator.ToString();
            TextBox tb2 = (TextBox)oknoPacjenta.Controls["textbox1"];
            tb2.Text = identyfikator1.ToString();

            oknoPacjenta.Show();
            sqlcon.Close(); // konczenie polaczenia
        }


        private void findIDdoktor() // znajdowanie Id pacjenta
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            string IdLekarz = "Select Id from Baza Where Login= '" + Login_textBox.Text.Trim() + "' and Password= '" + Password_textBox.Text.Trim() + "';";
            SqlCommand comandLekarz = new SqlCommand(IdLekarz, sqlcon);
            int identyfikatorLekarz = Convert.ToInt32(comandLekarz.ExecuteScalar());
            FormDoctors oknoDoktora = new FormDoctors(this);
            TextBox tb2 = (TextBox)oknoDoktora.Controls["textbox12"];
            tb2.Text = identyfikatorLekarz.ToString();
            oknoDoktora.Show();
            sqlcon.Close(); // konczenie polaczenia
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
