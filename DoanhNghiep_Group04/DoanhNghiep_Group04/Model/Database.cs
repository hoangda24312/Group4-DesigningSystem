using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace DoanhNghiep_Group04.Model
{

    public class DbConfig
    {
        public string server { get; set; }
        public string database_name { get; set; }
        public string id { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string charset { get; set; }
    }

    internal class Database
    {
        private static string connectionString;

        static Database()
        {
            string json = File.ReadAllText("database.json");
            var db = JsonSerializer.Deserialize<DbConfig>(json);

            connectionString = $"Server={db.server};Database={db.database_name};Uid={db.id};" +
                               $"Pwd={db.password};Port={db.port};Charset={db.charset}";
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

}
