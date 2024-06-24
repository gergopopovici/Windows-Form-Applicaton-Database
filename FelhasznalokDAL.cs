using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis
{
    public struct Felhasznalok
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string TelefonSzam { get; set; }
        public string FelhasznaloNev { get; set; }
        public string Jelszo { get; set; }
        public string Salt { get;set; }
        public int VendegID { get; set; }
        public int FelCsoportID { get; set; }   

        public Felhasznalok(string nev, int kor, string telefonSzam, string felhasznaloNev, string jelszo,string salt,int vendegID,int felCsoportID)
        {
            Nev = nev;
            Kor = kor;
            TelefonSzam = telefonSzam;
            FelhasznaloNev = felhasznaloNev;
            Jelszo = jelszo;
            Salt = salt;
            VendegID = vendegID;
            FelCsoportID = felCsoportID;
        }
    }
    public class FelhasznalokDAL : DALGen
    {
        public FelhasznalokDAL(ref string error)
        {
             base.CreateConnection(ref error);
        }
        public int FelhasznaloBeszurasa(string Nev,int Kor,string TelefonSzam,string FelhasznaloNev,string Jelszo,string Salt, ref string error)
        {
            int returnValue = 0;
            SqlCommand command = new SqlCommand();
           command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "Registration";
            command.Parameters.Add(new SqlParameter("@pNev",Nev));
            command.Parameters.Add(new SqlParameter("@pKor",Kor));
            command.Parameters.Add(new SqlParameter("@pTelefonSzam",TelefonSzam));
            command.Parameters.Add(new SqlParameter("@pFelhasznaloNev",FelhasznaloNev));
            command.Parameters.Add(new SqlParameter("@pJelszo", Jelszo));
            command.Parameters.Add(new SqlParameter("@pSalt", Salt));
            SqlParameter returnParameter = new SqlParameter("@ReturnValue", System.Data.SqlDbType.Int);
            returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            command.Parameters.Add(returnParameter);
            ExecuteNonQueryParameterized(command, ref error);
            returnValue = (int)returnParameter.Value;
            return returnValue;
        }
        public int FelhasznaLogin(string FelhasznaloNev,string Jelszo, ref string error)
        {
            String query = "SELECT Salt, Jelszo FROM Felhasznalok WHERE FelhNev = @FelhasznaloNev";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@FelhasznaloNev", FelhasznaloNev);
            DataSet dataSet = ExecuteDSParameterized(command, ref error);
            if (error == "OK")
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables[0].Rows[0];
                    string salt = row["Salt"].ToString();
                    string hashedPassword = row["Jelszo"].ToString();
                    byte[] saltBytes = Convert.FromBase64String(salt);
                    byte[] passwordBytes = SaltHash.Hashpassword(Jelszo, saltBytes);
                    string passwordBase64 = SaltHash.ByteArrayToBase64String(passwordBytes);

                    if (hashedPassword == passwordBase64)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }   
        }
        public Felhasznalok GetFelhasznaloData(String felhasznaloNev,ref string error)
        {
            string query = "SELECT F.*, V.* FROM Felhasznalok AS F JOIN Vendeg AS V ON V.VendegID = F.VendegID WHERE F.FelhNev = @FelhasznaloNev";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@FelhasznaloNev", felhasznaloNev);
            DataSet dataSet = ExecuteDSParameterized(command, ref error);
            Felhasznalok felhasznalo = new Felhasznalok();
            if (error == "OK")
            {
                foreach (DataRow r in dataSet.Tables[0].Rows)
                {
                    try
                    {
                       felhasznalo.Nev= r["FelhNev"].ToString();
                        felhasznalo.Nev = r["Nev"].ToString();
                        if (felhasznaloNev != "admin" && felhasznaloNev != "guest")
                        {
                            felhasznalo.VendegID = Convert.ToInt32(r["VendegID"]);
                            felhasznalo.Salt = r["Salt"].ToString();
                            felhasznalo.Jelszo = r["Jelszo"].ToString();
                            felhasznalo.Nev = r["Nev"].ToString();
                            felhasznalo.Kor = Convert.ToInt32(r["Kor"]);
                            felhasznalo.TelefonSzam = r["Telefonszam"].ToString();
                        }
                        felhasznalo.FelCsoportID = Convert.ToInt32(r["FelhCsopID"]);
                    
                    }
                    catch (Exception e)
                    {
                        error = "Nem letezo adat " + e.Message;
                    }

                }
            }
            return felhasznalo;
           
        }
    }
}
