using adatbazis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace adatbazis
{
    /// <summary>
    ///  Data structure for storing owner's information
    /// </summary>
    public struct Asztalok
    {
        int asztalID;
        int kapacitas;
        int szam;

        public int AsztalID
        {
            get { return asztalID; }
            set { asztalID = value; }
        }

        public int Kapacitas
        {
            get { return kapacitas; }
            set { kapacitas = value; }
        }

        public int Szam
        {
            get { return szam; }
            set { szam = value; }
        }

        public Asztalok(int aasztalID, int aakapacitas,int aaEmail)
        {
            asztalID= aasztalID;
            kapacitas = aakapacitas;
            szam = aaEmail;
        }
    }
    public class AsztalDal : DALGen
    {

        public List<Asztalok> GetAsztal(ref string error)
        {
            string query = "SELECT * FROM Asztalok";
            SqlDataReader dataReader = ExecuteReader(query, ref error);

            List<Asztalok> asztalList = new List<Asztalok>();

            if (error == "OK")
            {
                Asztalok item = new Asztalok();
                while (dataReader.Read())
                {
                    try
                    {
                        item.AsztalID = Convert.ToInt32(dataReader[0]);
                        item.Kapacitas = Convert.ToInt32(dataReader[1]);
                        item.Szam = Convert.ToInt32(dataReader[2]);
                        asztalList.Add(item);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }
                }
            }
            CloseDataReader(dataReader);

            return asztalList;
        }
    }
}
