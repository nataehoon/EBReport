using Microsoft.Data.SqlClient;
using System.Data;

namespace Report_Web.Database
{
    public class SQLServer
    {
        public static string LoadServerInfo()
        {
            string serverInfo = "172.30.1.102";
            string dbName = "EBReport";
            string dbID = "sa";
            string dbPW = "dlqlthvmxm1!";

            return $"server={serverInfo};database={dbName};uid={dbID};pwd={dbPW};Encrypt=True;TrustServerCertificate=True";
        }

        public static void SQLServerCreateTable(string sql)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = LoadServerInfo();
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public static DataTable SQLServerSelect(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = LoadServerInfo();
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);

                cmd.Dispose();
                da.Dispose();

                sqlCon.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }

        public static void SQLServerUpdate(string sql)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = LoadServerInfo();
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SQLServerDelete(string sql)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = LoadServerInfo();
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
