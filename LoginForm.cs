using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace adatbazis
{
    public partial class LoginForm : Form
    {
        private FelhasznalokDAL felhasznalokDal;
        public LoginForm()
        {
            InitializeComponent();
            string error = "";
            felhasznalokDal = new FelhasznalokDAL(ref error);
            if (error != "OK")
            {
                MessageBox.Show("Error" + Environment.NewLine + "A felhasznalo objektumot nem lehetett letrehozni. " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
            string felhasznaloNev = textBox1.Text;
            string jelszo = textBox2.Text;
            if (felhasznaloNev == "" || jelszo == "")
            {
                MessageBox.Show("A felhasználónév és a jelszó mezők kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Visible = true;
                label3.Text = "A felhasználónév és a jelszó mezők kitöltése kötelező!";
                return;
            }
            int check = felhasznalokDal.FelhasznaLogin(felhasznaloNev, jelszo, ref error);
            if (check == 1)
            {
                Felhasznalok felhasznalo = felhasznalokDal.GetFelhasznaloData(felhasznaloNev, ref error);
               new Kezdo(felhasznalo).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Visible = true;
                label3.Text = "Hibás felhasználónév vagy jelszó!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           string error = "";
           Felhasznalok felhasznalo = felhasznalokDal.GetFelhasznaloData("guest", ref error);
            new Kezdo(felhasznalo).Show();
            this.Hide();
        }
    }
}
