using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{

    public class DatabaseConnection
    {

        private SqlConnection conn = new SqlConnection();
        private SqlDataReader dr;



        public DatabaseConnection() {

            dr = null;
            conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";


        }


        public DataTable GetArtikujt(string kategoriID) {

            DataTable tb = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand("GetArtikujWithKategoriId", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("kategoria", kategoriID);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            conn.Close();
            return tb;

        }


        public int CHECKMagazinaGjendje(int magazina, int artikulli) {


            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("CHECKMagazinaGjendje", conn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);


            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("magazina", magazina);
            cmd.Parameters.Add("artikulli", artikulli);
           

            ad.Fill(tb);
            conn.Close();

            return Convert.ToInt32(tb.Rows[0][0].ToString());


        }

        public void InsertFletehyrjeArtikull(int artikulli, int fletehyrja, int sasia) {



            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertFletehyrjeArtikull", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("ID_artikulli", artikulli);
            cmd.Parameters.Add("ID_fletehyrje", fletehyrja);
            cmd.Parameters.Add("sasia", sasia);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public int RemoveOrUpdateMagazinaGjendje(int magazina, int artikulli, int sasia) {

            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("RemoveOrUpdateMagazinaGjendje", conn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("magazina", magazina);
            cmd.Parameters.Add("artikulli", artikulli);
            cmd.Parameters.Add("sasia", sasia);

            ad.Fill(tb);
            conn.Close();

            return Convert.ToInt32(tb.Rows[0][0].ToString());
        }

        public void InsertOrUpdateMagazinaGjendje(int magazina, int artikulli, int sasia) {


            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertOrUpdateMagazinaGjendje", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("magazina", magazina);
            cmd.Parameters.Add("artikulli", artikulli);
            cmd.Parameters.Add("sasia", sasia);
            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public int InsertFleteHyrje(int furnitori, int magazina, int perdoruesi, string _data) {

            int fletehyrjeID;
            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertFleteHyrje", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("ID_furnitori", furnitori);
            cmd.Parameters.Add("ID_magazina", magazina);
            cmd.Parameters.Add("ID_Perdorues", perdoruesi);
            cmd.Parameters.Add("_Data", _data);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            fletehyrjeID = Convert.ToInt16(tb.Rows[0][0].ToString());
            conn.Close();
            return fletehyrjeID;

        }


        public DataTable getArtikulliCmimi(string ID)
        {

            DataTable tb = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand("getArtikulliCmimi", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("ID", ID);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            conn.Close();
            return tb;

        }

        public DataTable getIDCmimiFromArtikulli(string artikulli)
        {

            DataTable tb = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand("getIDCmimiFromArtikulli", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("artikulli", artikulli);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            conn.Close();
            return tb;

        }

        public DataTable getFletehyrje(int id) {
            DataTable tb = new DataTable();

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT  ID, ID_Furnitori, ID_Magazina, ID_Perdorues, Data FROM FLETEHYRJE Where ID = '" + id + "'", conn);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(tb);

            conn.Close();

            return tb;
        }


        public DataTable GETFletehyrje(int id) {
            DataTable tb = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand("GETFletehyrje", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("id", id);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            conn.Close();
            return tb;

        }


        public void CancelFleteDalje(int fletedalje) {


            conn.Open();
            SqlCommand cmd = new SqlCommand("CancelFleteDalje", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("fletedalje", fletedalje);
            
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public int GetIdKlienti(string klienti) {

            if (klienti == "")
            {

                return 0;

            }
            else
            {
                DataTable tb = new DataTable();

                conn.Open();
                SqlCommand cmd = new SqlCommand("GetIdKlienti", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("klienti", klienti);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                ad.Fill(tb);

                conn.Close();
                return Convert.ToInt16(tb.Rows[0][0].ToString());
            }
        }


        public DataTable LoginProc(string username, string password) {

            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("LoginProc", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("password", password);

          
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            
            ad.Fill(tb);
            conn.Close();

            return tb;


        }

        public DataTable GETFleteDalje(int id) {

            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GETFleteDalje", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("id", id);
        
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);         
            conn.Close();

            return tb;


        }


        public DataTable GETFleteDalje_Artikull(int id) {


            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GETFleteDalje_Artikull", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("id", id);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);
            conn.Close();

            return tb;

        }
        public int InsertFleteDalje(int klienti, int sporteli, int perdoruesi, string _data, int statusi) {

            int fletedaljeID;
            DataTable tb = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertFleteDalje", conn);

            cmd.CommandType = CommandType.StoredProcedure;
      
            cmd.Parameters.Add("ID_klienti", klienti);
            cmd.Parameters.Add("ID_sporteli", sporteli);
            cmd.Parameters.Add("ID_Perdorues", perdoruesi);
            cmd.Parameters.Add("_Data", _data);
            cmd.Parameters.Add("_Statusi", statusi);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            fletedaljeID = Convert.ToInt16(tb.Rows[0][0].ToString());
            conn.Close();

            return fletedaljeID;


        }


        public int GetMagazinaFromSporteli(int sporteli ) {

            DataTable tb = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand("GetMagazinaFromSporteli", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("sporteli", sporteli);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            conn.Close();
            return Convert.ToInt16( tb.Rows[0][0].ToString());
        }


        public void InsertFleteDalje_Artikull(int artikull, int fletedalje, int sasia) {

            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertFleteDalje_Artikull", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("artikulli", artikull);
            cmd.Parameters.Add("fletedalje", fletedalje);
            cmd.Parameters.Add("sasi", sasia);

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public DataTable GETFletehyrje_Artikull(int id) {

            DataTable tb = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand("GETFletehyrje_Artikull", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("id", id);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ad.Fill(tb);

            conn.Close();
            return tb;

        }

    }
}
