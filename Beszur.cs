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
    public partial class Beszur : Form
    {
        private Felhasznalok felhasznalo;
        string error = "";
        private FoglalasDAL foglal;
        public Beszur(Felhasznalok felhasznalo)
        {
            InitializeComponent();
            this.felhasznalo = felhasznalo;
            foglal = new FoglalasDAL(ref error);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Kezdo(felhasznalo).Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Beszur_Load(object sender, EventArgs e)
        {
            if (felhasznalo.FelCsoportID != 1)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(label1.Text=="" || label2.Text=="" || label3.Text=="" || label4.Text=="" || label5.Text =="" || label6.Text=="" || label7.Text=="" || label8.Text=="" )
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }
            if(felhasznalo.FelCsoportID == 2)
            {
                int asztal = Convert.ToInt32(textBox4.Text);
                DateTime datum = Convert.ToDateTime(textBox5.Text);
                string kezdesiIdo = textBox6.Text;
                string vegzesiIdo = textBox7.Text;
                int vendegSzam = Convert.ToInt32(textBox8.Text);
                int value = foglal.beszurFoglalas(felhasznalo.Nev,felhasznalo.Kor,felhasznalo.TelefonSzam,asztal,datum,kezdesiIdo,vegzesiIdo,vendegSzam,ref error);
                if (value == 0)
                {
                    new Kezdo(felhasznalo).Show();
                    this.Hide();
                }
                else if (value == 1)
                {
                    MessageBox.Show("Sikertelen foglalás!");
                }
                else if (value == -2)
                {
                    MessageBox.Show("Nem megfelelő asztal szám!", "Error");
                }
                else if (value == -1)
                {
                    MessageBox.Show("Nem megfelelő datum formatum!", "Error");
                }
                else if (value == -3)
                {
                    MessageBox.Show("Az asztalhoz nem fer ennyi vendeg", "Error");
                }
                else if (value == -4)
                {
                    MessageBox.Show("Mar foglalt az asztal", "Error");
                }

            }
            else
            {
                string felhasznaloNev = textBox1.Text;
                int kor = Convert.ToInt32(textBox2.Text);
                string telefonSzam = textBox3.Text;
                int asztal = Convert.ToInt32(textBox4.Text);
                DateTime datum = Convert.ToDateTime(textBox5.Text);
                string kezdesiIdo = textBox6.Text;
                string vegzesiIdo = textBox7.Text;
                int vendegSzam = Convert.ToInt32(textBox8.Text);
                int value =  foglal.beszurFoglalas(felhasznaloNev,kor,telefonSzam,asztal,datum,kezdesiIdo,vegzesiIdo,vendegSzam,ref error);
                if (value == 0)
                {
                    new Kezdo(felhasznalo).Show();
                    this.Hide();
                }
                else if (value == 1)
                {
                    MessageBox.Show("Sikertelen foglalás!");
                }
                else if (value == -2)
                {
                    MessageBox.Show("Nem megfelelő asztal szám!", "Error");
                }
                else if (value == -1)
                {
                    MessageBox.Show("Nem megfelelő datum formatum!", "Error");
                }
                else if (value == -3)
                {
                    MessageBox.Show("Az asztalhoz nem fer ennyi vendeg", "Error");
                }
                else if (value == -4)
                {
                    MessageBox.Show("Mar foglalt az asztal", "Error");
                }
            }
        }
    }
}
