using System.Runtime.CompilerServices;
using System.Text;

namespace adatbazis
{
    public partial class FormAdmin : Form
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

        public FormAdmin()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            if (errMess == "OK")
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                button2.Enabled = false;
                FillAsztalSzam();
                FillFoglal(-1);
                FillVendegNev();
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Visible = true;
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

        private void FilterBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                FillFoglal(-1);
                FillVendegNev();
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                string error = string.Empty;
                 vegOsszeg = Convert.ToInt32(selectedRow.Cells[12].Value);
                 foglalasID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                 vegOss = foglalasDAL.getVegOsszeg(foglalasID,vegOsszeg,ref error);
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
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
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
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
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
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton3.Checked = false;
                button2.Enabled = false;

            }
        }

    }

}