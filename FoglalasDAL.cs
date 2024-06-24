using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace adatbazis
{

    public struct Foglalas
    {
        int foglalasID;
        Vendeg vendeg;
        Asztalok asztal;
        string datum;
        string kezdesiIdo;
        string vegzesiIdo;
        int vendegekSzama;
        int vegOsszeg;


        public int FoglalasID
        {
            get { return foglalasID; }
            set { foglalasID = value; }
        }


        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public string KezdesiIdo
        {
            get { return kezdesiIdo; }
            set { kezdesiIdo = value; }
        }

        public string VegzesiIdo
        {
            get { return vegzesiIdo; }
            set { vegzesiIdo = value; }
        }
        public int VendegekSzama
        {
            get { return vendegekSzama; }
            set { vendegekSzama = value; }
        }
        public int VegOsszeg
        {
            get { return vegOsszeg; }
            set { vegOsszeg = value; }
        }
        public Vendeg Vendeg
        {
              get { return vendeg; }
              set { vendeg = value; }
        }

        public Asztalok Asztal
        {
            get { return asztal; }
            set { asztal = value; }
        }
        public Foglalas(int FoglalID, Vendeg fvendeg ,Asztalok ftable,string fDatum, string fKezdesiIdo, string fVegzesiIdo, int fSzamlaID,int fVendegekSzama,int fVegOsszeg)
        {
            foglalasID = FoglalID;
            vendeg = fvendeg;
            asztal = ftable;
            datum = fDatum;
            kezdesiIdo= fKezdesiIdo;
            vegzesiIdo= fVegzesiIdo;
            vendegekSzama = fVendegekSzama;
            vegOsszeg = fVegOsszeg;
        }
    }

    public class FoglalasDAL : DALGen
    {
        public FoglalasDAL(ref string error)
        {
            //megpróbáljuk, hogy létrejön-e a kapcsolat            
            base.CreateConnection(ref error);
        }
        public List<Foglalas> GetFoglalasDataSet(int asztalSzam, ref string error)
        {
            string query = "SELECT F.FoglalasID,V.VendegID,V.Nev,V.Kor,V.Telefonszam,A.AsztalID,A.Kapacitas,A.Szam,F.Datum,F.KezdesiIdo,F.VegzesiIdo,F.VendegSzam,F.Vegosszeg " +
                          "FROM Foglalas as F " +
                          "JOIN Vendeg as V ON V.VendegID = F.VendegID "+
                          "JOIN Asztalok as A ON F.AsztalID = A.AsztalID";
            if (asztalSzam!=-1)
            {
                query += " WHERE A.AsztalID = @asztalSzam";

            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@asztalSzam", asztalSzam);

            //  DataSet dataSet = new DataSet();
            List<Foglalas> FoglalasList = new List<Foglalas>();
            DataSet dataSet = ExecuteDSParameterized(sqlCommand, ref error);
            if (error == "OK")
            {
                Foglalas foglal = new Foglalas();
                foreach (DataRow r in dataSet.Tables[0].Rows)
                {
                    try
                    {
                        foglal.FoglalasID = Convert.ToInt32(r["FoglalasID"]);
                        foglal.Asztal = new Asztalok(Convert.ToInt32(r["AsztalID"]), Convert.ToInt32(r["Kapacitas"]), Convert.ToInt32(r["Szam"]));
                        foglal.Vendeg = new Vendeg(Convert.ToInt32(r["VendegID"]), r["Nev"].ToString(), Convert.ToInt32(r["Kor"]), r["Telefonszam"].ToString());
                        foglal.Datum = r["Datum"].ToString();
                        foglal.KezdesiIdo = r["KezdesiIdo"].ToString();
                        foglal.VegzesiIdo = r["VegzesiIdo"].ToString();
                        foglal.VendegekSzama = Convert.ToInt32(r["VendegSzam"]);
                        foglal.VegOsszeg = Convert.ToInt32(r["Vegosszeg"]);
                    }
                    catch (Exception e)
                    {
                        error = "Nem letezo adat " + e.Message;
                    }
                    FoglalasList.Add(foglal);

                }
            }
            return FoglalasList;
        }
        public List<Foglalas> GetFoglalasNevDataSet(string Nev, ref string error)
        {
            string query = "SELECT F.FoglalasID,V.VendegID,V.Nev,V.Kor,V.Telefonszam,A.AsztalID,A.Kapacitas,A.Szam,F.Datum,F.KezdesiIdo,F.VegzesiIdo,F.VendegSzam,F.Vegosszeg " +
                          "FROM Foglalas as F " +
                          "JOIN Vendeg as V ON V.VendegID = F.VendegID " +
                          "JOIN Asztalok as A ON F.AsztalID = A.AsztalID";
            if (Nev.Length > 0 && Nev != " ")
            {
                query += " WHERE V.Nev LIKE @Nev";
            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@Nev", "%" + Nev + "%");
            DataSet dataSet = new DataSet();
            dataSet = ExecuteDSParameterized(sqlCommand, ref error);
            List<Foglalas> FoglalasList = new List<Foglalas>();
            if (error == "OK")
            {
                Foglalas foglal = new Foglalas();
                foreach (DataRow r in dataSet.Tables[0].Rows)
                {
                    try
                    {
                        foglal.FoglalasID = Convert.ToInt32(r["FoglalasID"]);
                        foglal.Asztal = new Asztalok(Convert.ToInt32(r["AsztalID"]), Convert.ToInt32(r["Kapacitas"]), Convert.ToInt32(r["Szam"]));
                        foglal.Vendeg = new Vendeg(Convert.ToInt32(r["VendegID"]), r["Nev"].ToString(), Convert.ToInt32(r["Kor"]), r["Telefonszam"].ToString());
                        foglal.Datum = r["Datum"].ToString();
                        foglal.KezdesiIdo = r["KezdesiIdo"].ToString();
                        foglal.VegzesiIdo = r["VegzesiIdo"].ToString();
                        foglal.VendegekSzama = Convert.ToInt32(r["VendegSzam"]);
                        foglal.VegOsszeg = Convert.ToInt32(r["Vegosszeg"]);
                    }
                    catch (Exception e)
                    {
                        error = "Nem letezo adat " + e.Message;
                    }
                    FoglalasList.Add(foglal);

                }
            }
            return FoglalasList;
        }
        public int getVegOsszeg(int foglalID, int vegOsszeg,ref string error)
        {
            string query = "SELECT Vegosszeg FROM Foglalas WHERE FoglalasID = @foglalID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@foglalID", foglalID);
            int vegosszeg = Convert.ToInt32(base.ExecuteScalarUsingParametrizedQuery(sqlCommand, ref error));
            return vegosszeg;
        }
        public void updateFoglalas(int foglalID, int vegOsszeg, ref string error)
        {
            string query = "UPDATE Foglalas SET Vegosszeg = @vegOsszeg WHERE FoglalasID = @foglalID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@vegOsszeg", vegOsszeg);
            sqlCommand.Parameters.AddWithValue("@foglalID", foglalID);
            ExecuteNonQueryParameterized(sqlCommand, ref error);

        }
        public int beszurFoglalas(string Nev,int Kor,string Telefonszam,int Asztalszam,DateTime dateTime,string kezdo,string veg,int vendeg,ref string error)
        {
            int returnValue = 0;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "beszuras";
            command.Parameters.Add(new SqlParameter("@pNev", Nev));
            command.Parameters.Add(new SqlParameter("@pKor", Kor));
            command.Parameters.Add(new SqlParameter("@pTelefonszam", Telefonszam));
            command.Parameters.Add(new SqlParameter("@pAsztalSzam", Asztalszam));
            command.Parameters.Add(new SqlParameter("@pDatum", dateTime));
            command.Parameters.Add(new SqlParameter("@pKezdesiIdo", kezdo));
            command.Parameters.Add(new SqlParameter("@pVegzesiIdo", veg));
            command.Parameters.Add(new SqlParameter("@pVendegSzam", vendeg));
            SqlParameter returnParameter = new SqlParameter("@ReturnValue", System.Data.SqlDbType.Int);
            returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            command.Parameters.Add(returnParameter);
            ExecuteNonQueryParameterized(command, ref error);
            returnValue = (int)returnParameter.Value;
            return returnValue;
        }
    }
}
