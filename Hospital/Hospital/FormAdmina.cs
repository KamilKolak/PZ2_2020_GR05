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
    public partial class FormAdmina : Form
    {
        Form1 logowanie;
        public FormAdmina(Form1 logowanie)
        {
            InitializeComponent();
            this.logowanie = logowanie;
            logowanie.Hide();
            if(Receptionist_checkBox.Checked)
            {
                Admin_checkBox.Enabled =false;
                Doctor_checkBox.Enabled = false;
                checkBox1.Enabled = false;
            }
            else if( Admin_checkBox.Checked)
            {
                Receptionist_checkBox.Enabled = false;
                Doctor_checkBox.Enabled = false;
                checkBox1.Enabled = false;
            }
            else if(Doctor_checkBox.Checked)
            {
                Receptionist_checkBox.Enabled = false;
                Admin_checkBox.Enabled = false;
                checkBox1.Enabled = false;
            }else if (checkBox1.Checked)
            {
                Receptionist_checkBox.Enabled = false;
                Admin_checkBox.Enabled = false;
                Doctor_checkBox.Enabled = false;
            }
            ladowaniedoktor();
            ladowaniepatient();
            ladowanierecepcja();
            ladowanieksiegowy();


        }

        private int checkcheckbox()
        {
            if (Admin_checkBox.Checked == true) return 0;
            else if (Doctor_checkBox.Checked == true) return 1;
            else if (Receptionist_checkBox.Checked == true) return 2;
            else return 4;
            
        }

        private void AddUser_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlUsers = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Form1.sciezka + ";Integrated Security=True;Connect Timeout=30");
            sqlUsers.Open();

            try
            {
                string pytanie = "Insert into Baza(Login,Password,PermissionLvl) values('" + Username_textBox.Text + "','" + Password_textBox.Text + "','" + checkcheckbox() + "') ;";
                SqlCommand sda = new SqlCommand(pytanie, sqlUsers);
                sda.ExecuteNonQuery();
                string str1 = "select max(Id) from Baza;";
                SqlCommand cmd1 = new SqlCommand(str1, sqlUsers);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("SAVED");
                    Username_textBox.Text = "";
                    Password_textBox.Text = "";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlUsers.Close();
        }

        private void Admin_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Admin_checkBox.Checked)
            {
                Receptionist_checkBox.Enabled = false;
                Doctor_checkBox.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                Receptionist_checkBox.Enabled = true;
                Doctor_checkBox.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void Receptionist_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Receptionist_checkBox.Checked)
            {
                Admin_checkBox.Enabled = false;
                Doctor_checkBox.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                Admin_checkBox.Enabled = true;
                Doctor_checkBox.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void Doctor_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Doctor_checkBox.Checked)
            {
                Receptionist_checkBox.Enabled = false;
                Admin_checkBox.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                Receptionist_checkBox.Enabled = true;
                Admin_checkBox.Enabled = true;
                checkBox1.Enabled = true;
            }
            
        }

        private void FormAdmina_Load(object sender, EventArgs e)
        {
            //Ten wiersz kodu wczytuje dane do tabeli 'hospitalDataSet.Patient' 
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

        }

        private void ladowaniedoktor()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename="+Form1.sciezka);
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id, Login, Password FROM Baza where PermissionLvl=1;", conDataBase);
                try
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
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

        private void ladowanierecepcja()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename="+Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id, Login, Password FROM Baza where PermissionLvl=2;", conDataBase);
                try
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTable;
                    dataGridView2.DataSource = bSource;
                    sqlDataAdapter.Update(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ladowaniepatient()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id, Login, Password FROM Baza where PermissionLvl=3;", conDataBase);
                try
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTable;
                    dataGridView3.DataSource = bSource;
                    sqlDataAdapter.Update(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void ladowanieksiegowy()
        {
            string constring = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + Form1.sciezka + ";Integrated Security=True");
            using (SqlConnection conDataBase = new SqlConnection(constring))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id, Login, Password FROM Baza where PermissionLvl=4;", conDataBase);
                try
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTable;
                    dataGridView4.DataSource = bSource;
                    sqlDataAdapter.Update(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {

                dataGridView2.Rows.RemoveAt(item.Index);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
            {

                dataGridView3.Rows.RemoveAt(item.Index);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ladowaniedoktor();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            ladowaniepatient();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            ladowanierecepcja();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Receptionist_checkBox.Enabled = false;
                Doctor_checkBox.Enabled = false;
                Admin_checkBox.Enabled = false;
            }
            else
            {
                Receptionist_checkBox.Enabled = true;
                Doctor_checkBox.Enabled = true;
                Admin_checkBox.Enabled = true;
            }
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ladowanieksiegowy();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
            {

                dataGridView4.Rows.RemoveAt(item.Index);

            }
        }

        private void FormAdmina_FormClosed(object sender, FormClosedEventArgs e)
        {
            logowanie.Show();
        }
    }
}
