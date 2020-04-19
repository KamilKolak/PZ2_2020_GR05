using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormReceptionist : Form
    {
        Form1 logowanie;
        
        public FormReceptionist(Form1 logowanie)
        {
            InitializeComponent();
            this.logowanie = logowanie;
            logowanie.Hide();
            
        }

        private void ModifyPatient_button_Click(object sender, EventArgs e)
        {
            ModifyPatient oknomodyfikacji = new ModifyPatient(this);
            this.Hide();
            oknomodyfikacji.Show();
        }

        private void AddPatient_button_Click(object sender, EventArgs e)
        {
            FormAddPatient oknoDodawaniaPacjenta = new FormAddPatient(this);
            this.Hide();
            oknoDodawaniaPacjenta.Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 elo2 = new Form1();
            elo2.Show();
        }

        private void FormReceptionist_Load(object sender, EventArgs e)
        {

        }
    }
}
