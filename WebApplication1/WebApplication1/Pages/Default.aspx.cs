using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelLoginFailed.Text = "";
        }


        public static string sciezka = Directory.GetParent(HttpContext.Current.Server.MapPath(".") + "/../../../").ToString() + @"\Hospital\Hospital\bin\Debug\Hospital.mdf";

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Default.sciezka + "; Integrated Security = True; Connect Timeout = 30");
            sqlcon.Open();
            string zapytanie = "select permissionlvl from Users where username= '" + inputLogin.Text.Trim() + "' and password ='" + inputPassword.Text.Trim() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(zapytanie, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0]["permissionlvl"].ToString() == "3")
                {
                    Response.Redirect("Patient.aspx");
                }
            }
            else LabelLoginFailed.Text = "Niepoprawne dane logowania";
            sqlcon.Close();
            inputLogin.Text = "";
        }
    }
}