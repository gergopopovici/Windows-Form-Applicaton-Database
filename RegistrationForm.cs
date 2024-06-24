using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatbazis
{
    public partial class RegistrationForm : Form
    {
        private FelhasznalokDAL felhasznalokDal;
        private string errMess;
        private int errNumber;
        public RegistrationForm()
        {
            InitializeComponent();
            string error = "";
            felhasznalokDal = new FelhasznalokDAL(ref error);
            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine + "A felhasznalo objektumot nem lehetett letrehozni. " + error;
                ShowError(errMess);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            string error = "";
            string nev = textBox1.Text;
            int kor = Convert.ToInt32(textBox2.Text);
            string telefonSzam = textBox3.Text;
            string felhasznaloNev = textBox4.Text;
            string jelszo = textBox5.Text;
            string jelszoUjra = textBox6.Text;
            if(jelszo != jelszoUjra)
            {
                label7.Visible = true;
                label7.Text = "A két jelszó nem egyezik meg!";
                return;
            }
            string salt = SaltHash.ByteArrayToBase64String(SaltHash.GenerateSalt(20));
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] hashedPassword = SaltHash.Hashpassword(jelszo, saltBytes);
            string hashedPasswordString = SaltHash.ByteArrayToBase64String(hashedPassword);
            int beszur = felhasznalokDal.FelhasznaloBeszurasa(nev, kor, telefonSzam, felhasznaloNev, hashedPasswordString, salt,ref error);

            if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK")
                    errMess = string.Empty;
                errMess += Environment.NewLine + "Error" + errNumber + Environment.NewLine + "Hiba a Felhasznalo beszurasanal." + error;
                ShowError(errMess);

            }
            if(beszur == -1)
            {
                label7.Visible = true;
                label7.Text = "Hiba a beszurasnal!";
            }
            if(beszur == -2)
            {
                label7.Visible = true;
                label7.Text = "A telefonSzam csak szam lehet";
            }
            if(beszur == -3)
            {
                label7.Visible = true;
                label7.Text = "A felhasznalo nev mar foglalt";
            }
            if(beszur == 0)
            {
                new LoginForm().Show();
                this.Hide();
            }
        }
        public static void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
