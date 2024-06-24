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
    public partial class Torol : Form
    {
        private VendegDAL vendegek;
        private string errMess;
        private int errNumber;
        private Felhasznalok felhasznalok;
        public Torol(Felhasznalok felhasznalok)
        {
            InitializeComponent();
            vendegek = new VendegDAL();
            this.felhasznalok = felhasznalok;
        }
        public static void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillVendegNev()
        {

            string error = string.Empty;
            List<Vendeg> vendegList = vendegek.GetVendeg(ref error);
            if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK")
                    errMess = string.Empty;
                errMess += Environment.NewLine + "Error" + errNumber + Environment.NewLine + "Hiba a ComboBox feltoltesenel." + error;
                ShowError(errMess);
            }
            else
            {
                FilterBox2.DataSource = vendegList;
                FilterBox2.DisplayMember = "DisplayNevTelefonszam";
                FilterBox2.ValueMember = "VendegID";
            }

        }
        private void Torol_Load(object sender, EventArgs e)
        {
            FillVendegNev();

        }

        private void TorolButton_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            /*string[] parts = selectedVendeg.Split(' ');
            string selectedNev = parts[0];
            string error = string.Empty;
            string selectedTelefonszam = parts[1];*/
            DialogResult result = MessageBox.Show("Biztosan törölni szeretné ezt a vendéget?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                vendegek.deleteVendeg(Convert.ToInt32(FilterBox2.SelectedValue), ref error);
                new Kezdo(felhasznalok).Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Kezdo(felhasznalok).Show();
            this.Hide();
        }

        private void FilterBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
