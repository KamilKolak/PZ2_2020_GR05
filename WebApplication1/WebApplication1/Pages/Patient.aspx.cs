using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class Patient : System.Web.UI.Page
    {
        public SqlConnection sqlcon;
        string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) Response.Redirect("Default.aspx");

            username = Session["username"].ToString();

            LabelWelcome.Text = "Witaj " + username;
            LabelIncorrectLoginPassword.Visible = false;
            LabelPasswordChanged.Visible = false;

            sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Default.sciezka + "; Integrated Security = True; Connect Timeout = 30");
            loadData();
        }

        protected void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        private void loadData()
        {
            sqlcon.Open();

            SqlCommand sqlCommandNameValue = new SqlCommand("Select Name from Baza Where Login= '" + username + "';", sqlcon);
            LabelNameValue.Text = sqlCommandNameValue.ExecuteScalar().ToString();

            SqlCommand sqlCommandSurnameValue = new SqlCommand("Select Surname from Baza Where Login= '" + username + "';", sqlcon);
            LabelSurnameValue.Text = sqlCommandSurnameValue.ExecuteScalar().ToString();

            SqlCommand sqlCommandToPaidValue = new SqlCommand("Select Prize from Baza Where Login= '" + username + "';", sqlcon);
            LabelToPaidValue.Text = sqlCommandToPaidValue.ExecuteScalar().ToString();

            SqlCommand sqlCommandVisitDay = new SqlCommand("Select DzienWizyty from Baza Where Login= '" + username + "';", sqlcon);
            SqlCommand sqlCommandVisitMonth = new SqlCommand("Select MiesiacWizyty from Baza Where Login= '" + username + "';", sqlcon);
            SqlCommand sqlCommandVisitDYear = new SqlCommand("Select RokWizyty from Baza Where Login= '" + username + "';", sqlcon);
            LabelVisitValue.Text = sqlCommandVisitDay.ExecuteScalar().ToString() + '.' +
                                   sqlCommandVisitMonth.ExecuteScalar().ToString() + '.' +
                                   sqlCommandVisitDYear.ExecuteScalar().ToString();

            sqlcon.Close();
        }

        protected void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SqlCommand sqlGetPassword = new SqlCommand("Select Password from Baza Where Login= '" + username + "';", sqlcon);
            sqlcon.Open();
            if (sqlGetPassword.ExecuteScalar().ToString() == inputOldPassword.Text && inputNewPassword.Text.Length > 4)
            {
                SqlCommand sqlCommandChangePassword = new SqlCommand("UPDATE Baza SET Password = '" + inputNewPassword.Text + "' WHERE Login = '" + username + "';", sqlcon);
                sqlCommandChangePassword.ExecuteNonQuery();
                LabelIncorrectLoginPassword.Visible = false; 
                LabelPasswordChanged.Visible = true;
            }
            else
            {
                LabelIncorrectLoginPassword.Visible = true;
                LabelPasswordChanged.Visible = false;
            }
            sqlcon.Close();
        }
    }
}