using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace adatbazis
{
    public partial class Kezdo : Form
    {
        private AsztalDal asztalok;
        private FoglalasDAL foglalasDAL;
        private VendegDAL vendegek;
        Felhasznalok Felhasznalo;
        private string errMess;
        private int errNumber;
        // private int vegOsszeg;
        //private int foglalasID;
        //private int vegOss;
        //private int ujErtek;
        public Kezdo(Felhasznalok felhasznalo)
        {
            InitializeComponent();
            string error = string.Empty;
            Felhasznalo = felhasznalo;
            foglalasDAL = new FoglalasDAL(ref error);
            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine + "Foglalas objektumot nem lehetett letrehozni. " + error;
                ShowError(errMess);
            }
            else
            {
                errMess = "OK";
                asztalok = new AsztalDal();
                vendegek = new VendegDAL();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kezdo_Load(object sender, EventArgs e)
        {
            if (errMess == "OK")
            {
                label2.Visible = true;
                label3.Visible = true;
                FillAsztalSzam();
                FillFoglal(-1);
            }
        }
        public static void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void dataGridView1_Load(object sender, EventArgs e)
        {
        }
        private void FillAsztalSzam()
        {

            string error = string.Empty;
            List<Asztalok> AsztalokList = asztalok.GetAsztal(ref error);

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
                Asztalok defaultOption = new Asztalok { Szam = 0, AsztalID = -1 };
                AsztalokList.Insert(0, defaultOption);

                FilterBox1.DataSource = AsztalokList;
                FilterBox1.DisplayMember = "Szam";
                FilterBox1.ValueMember = "AsztalID";
            }
        }

        public void FillFoglal(int Nev)
        {
            string error = string.Empty;
            List<Foglalas> foglalList = foglalasDAL.GetFoglalasDataSet(Nev, ref error);
            dataGridView1.Rows.Clear();
            if ((foglalList.Count != 0) && error == "OK")
            {
                foreach (Foglalas f in foglalList)
                {
                    try
                    {
                        dataGridView1.Rows.Add(f.FoglalasID,
                                               f.Vendeg.VendegID,
                                               f.Vendeg.Nev,
                                               f.Vendeg.Kor,
                                               f.Vendeg.Telefonszam,
                                               f.Asztal.AsztalID,
                                               f.Asztal.Kapacitas,
                                               f.Asztal.Szam,
                                               f.Datum,
                                               f.KezdesiIdo,
                                               f.VegzesiIdo,
                                               f.VendegekSzama,
                                               f.VegOsszeg);
                    }
                    catch (Exception e)
                    {
                        errNumber++;
                        if (errMess == "OK")
                            errMess = string.Empty;
                        errMess = errMess + Environment.NewLine + "Error" + errNumber + Environment.NewLine + "Nem letezo adat" + e.Message;
                        ShowError(errMess);

                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Filterbutton_Click(object sender, EventArgs e)
        {
            FillFoglal(Convert.ToInt32(FilterBox1.SelectedValue));

        }

        private void textSzuro_TextChanged(object sender, EventArgs e)
        {

            string bemenet = textSzuro.Text.Trim();
            string error = string.Empty;
            List<Foglalas> foglalasList = foglalasDAL.GetFoglalasNevDataSet(bemenet, ref error);
            dataGridView1.Rows.Clear();
            if ((foglalasList.Count != 0) && error == "OK")
            {
                foreach (Foglalas f in foglalasList)
                {
                    try
                    {
                        dataGridView1.Rows.Add(f.FoglalasID,
                                               f.Vendeg.VendegID,
                                               f.Vendeg.Nev,
                                               f.Vendeg.Kor,
                                               f.Vendeg.Telefonszam,
                                               f.Asztal.AsztalID,
                                               f.Asztal.Kapacitas,
                                               f.Asztal.Szam,
                                               f.Datum,
                                               f.KezdesiIdo,
                                               f.VegzesiIdo,
                                               f.VendegekSzama,
                                               f.VegOsszeg);
                    }
                    catch (Exception ex)
                    {
                        errNumber++;
                        if (errMess == "OK")
                            errMess = string.Empty;
                        errMess = errMess + Environment.NewLine + "Error" + errNumber + Environment.NewLine + "Nem letezo adat" + ex.Message;
                        ShowError(errMess);

                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kilépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void müveltekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Felhasznalo.FelCsoportID == 3)
            {
                törölToolStripMenuItem.Enabled = false;
                hozzáadToolStripMenuItem.Enabled = false;
                modositToolStripMenuItem.Enabled = false;
            }
            if (Felhasznalo.FelCsoportID == 2)
            {
                törölToolStripMenuItem.Enabled = false;
                modositToolStripMenuItem.Enabled = false;


            }
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Torol(Felhasznalo).Show();
            this.Hide();
        }

        private void hozzáadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Beszur(Felhasznalo).Show();
            this.Hide();
        }

        private void modositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Modosit(Felhasznalo).Show();
            this.Hide();
        }
    }
}
