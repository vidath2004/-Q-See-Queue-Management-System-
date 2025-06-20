using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QueueSeeProject
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string server, string database, string username)
        {
            connectionString = $"Server={server};Database={database};User ID={username};";
        }

        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public bool QueueNumberExists(int queueNumber)
        {
            string query = $"SELECT COUNT(*) FROM patients WHERE queue_number = {queueNumber}";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
