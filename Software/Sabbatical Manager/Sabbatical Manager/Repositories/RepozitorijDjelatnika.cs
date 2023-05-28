using DBLayer;
using Sabbatical_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabbatical_Manager.Repositories {
    public class RepozitorijDjelatnika {
        public static Djelatnik DohvatiDjelatnika(string username) {
            string sql = $"SELECT * FROM Djelatnik WHERE Username ='{username}'";
            return DohvatiDjelatnik(sql);
        }
        public static Djelatnik DohvatiDjelatnika(int id) {
            string sql = $"SELECT * FROM Djelatnik WHERE Id = {id}";
            return DohvatiDjelatnik(sql);
        }

        private static Djelatnik DohvatiDjelatnik(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Djelatnik djelatnik = null;
            if (reader.HasRows == true) {
                reader.Read();
                djelatnik = KreirajObjekt(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return djelatnik;
        }

        private static Djelatnik KreirajObjekt(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var djelatnik = new Djelatnik {
                Id = id,
                Username = username,
                Password = password
            };
            return djelatnik;
        }

        public static Zahtjev DohvatiZahtjev(int id) {
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjev WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;
        }

        public static List<Zahtjev> DohvatiZahtjevString(string vrsta) {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjev WHERE Vrsta LIKE '%{vrsta}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }



        public static List<Zahtjev> DohvatiZahtjeve() {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        private static Zahtjev CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string vrsta = reader["Vrsta"].ToString();
            DateTime datumOdlaska = Convert.ToDateTime(reader["DatumOdlaska"]);
            DateTime doDatuma = Convert.ToDateTime(reader["DoDatuma"]);
            string obrazloženje = reader["Obrazloženje"].ToString();
            string status = reader["Status"].ToString();
            var zahtjev = new Zahtjev {
                Id = id,
                Vrsta = vrsta,
                DatumOdlaska = datumOdlaska,
                DoDatuma = doDatuma,
                Obrazloženje = obrazloženje,
                Status = status
            };
            return zahtjev;
        }


        public static void SpremiZahtjev(Zahtjev zahtjev) {
            string sql = $"INSERT INTO Zahtjev (Vrsta, DatumOdlaska, DoDatuma, Obrazloženje, Status) VALUES ('{zahtjev.Vrsta}','{zahtjev.DatumOdlaska}','{zahtjev.DoDatuma}','{zahtjev.Obrazloženje}','{zahtjev.Status}')";

            DB.OpenConnection();
            DB.GetDataReader(sql);
            DB.CloseConnection();
        }

        public static void UrediZahtjev(Zahtjev zahtjev, int id) {
            
            string sql = $"UPDATE Zahtjev SET Vrsta= '{zahtjev.Vrsta}', DatumOdlaska= '{zahtjev.DatumOdlaska}', DoDatuma= '{zahtjev.DoDatuma}', Obrazloženje= '{zahtjev.Obrazloženje}', Status= '{zahtjev.Status}' WHERE Id= {id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
