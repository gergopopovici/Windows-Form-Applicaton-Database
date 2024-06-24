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

namespace adatbazis
{
    public partial class Modosit : Form
    {
        private AsztalDal asztalok;
        private FoglalasDAL foglalasDAL;
        private VendegDAL vendegek;
        private string errMess;
        private int errNumber;
        private int vegOsszeg;
        private int foglalasID;
        private int vegOss;
        private int ujErtek;
        private Felhasznalok felhasznalo;
        public Modosit(Felhasznalok felhasznalo)
        {
            InitializeComponent();
            this.felhasznalo = felhasznalo;
            string error = string.Empty;
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
        public static void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new Kezdo(felhasznalo).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modosit_Load(object sender, EventArgs e)
        {
            if (errMess == "OK")
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                button2.Enabled = false;
                FillFoglal(-1);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                string error = string.Empty;
                vegOsszeg = Convert.ToInt32(selectedRow.Cells[12].Value);
                foglalasID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                vegOss = foglalasDAL.getVegOsszeg(foglalasID, vegOsszeg, ref error);
                ujErtek = string.IsNullOrEmpty(UpdateBox1.Text) ? 0 : Convert.ToInt32(UpdateBox1.Text.Trim());
                radioButton1.Text = vegOsszeg.ToString();
                radioButton2.Text = ujErtek.ToString();
                radioButton3.Text = vegOss.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string error = string.Empty;
                foglalasDAL.updateFoglalas(foglalasID, vegOsszeg, ref error);
                FillFoglal(-1);
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Checked = false;
                button2.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string error = string.Empty;
                foglalasDAL.updateFoglalas(foglalasID, ujErtek, ref error);
                FillFoglal(-1);
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton2.Checked = false;
                button2.Enabled = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                string error = string.Empty;
                foglalasDAL.updateFoglalas(foglalasID, vegOss, ref error);
                FillFoglal(-1);
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton3.Checked = false;
                button2.Enabled = false;

            }
        }

    }
}
