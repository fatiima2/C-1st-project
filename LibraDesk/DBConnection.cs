using MySql.Data.MySqlClient;

namespace LibraDesk
{
    internal static class DBConnection
    {
        private static string connectionString = "server=localhost;user=root;database=librarymanagementsystem;port=3306;password=";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
