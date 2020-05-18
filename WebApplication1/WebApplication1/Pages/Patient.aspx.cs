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
        string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) Response.Redirect("Default.aspx");

            username = Session["username"].ToString();

            LabelWelcome.Text = "Witaj " + username;
            loadData();
        }

        protected void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        private void loadData()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Default.sciezka + "; Integrated Security = True; Connect Timeout = 30");
            sqlcon.Open();

            SqlCommand sqlCommandIdValue = new SqlCommand("Select Id from Baza Where Login= '" + username + "';", sqlcon);
            LabelIdValue.Text = sqlCommandIdValue.ExecuteScalar().ToString();

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

    }
}