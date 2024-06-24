using adatbazis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace adatbazis
{
    public struct Vendeg
    {
        int vendegID;
        string nev;
        int kor;
        string telefonszam;
        public int VendegID
        {
            get { return vendegID; }
            set { vendegID = value; }
        }


        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        public string Telefonszam
        {
            get { return telefonszam; }
            set { telefonszam = value; }
        }
        public string DisplayNevTelefonszam
        {
            get { return $"{Nev} {Telefonszam}"; }
        }
        public Vendeg(int vID, string vNev, int vKor, string vTelefonszam)
        {
            vendegID = vID;
            nev = vNev;
            kor = vKor;
            telefonszam = vTelefonszam;
        }
    }
    public class VendegDAL : DALGen
    {
        public List<Vendeg> GetVendeg(ref string error)
        {
            string query = "SELECT * FROM Vendeg";
            SqlDataReader dataReader = ExecuteReader(query, ref error);

            List<Vendeg> vendegList = new List<Vendeg>();

            if (error == "OK")
            {
                Vendeg item = new Vendeg();
                while (dataReader.Read())
                {
                    try
                    {
                        item.VendegID = Convert.ToInt32(dataReader[0]);
                        item.Nev = dataReader[1].ToString();
                        item.Kor = Convert.ToInt32(dataReader[2]);
                        item.Telefonszam = dataReader[3].ToString();
                        vendegList.Add(item);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }
                }
            }
            CloseDataReader(dataReader);

            return vendegList;
        }
        public void deleteVendeg(int vendegID, ref string error)
        {
            string query = "DELETE FROM Vendeg WHERE VendegID = @vendegID";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@vendegID",vendegID);
            DialogResult result = MessageBox.Show("Figyelem! A törlés során más adatok is törölve lesznek.", "Törlés előtti tájékoztatás", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                ExecuteNonQueryParameterized(sqlCommand, ref error);
            }
        }
    }
}
