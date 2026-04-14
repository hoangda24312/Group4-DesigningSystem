using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace DoanhNghiep_Group04.Data
{
    internal class Database
    {
        public string server { set; get; }
        public string database_name { set; get; }
        public string id { set; get; }
        public string password { set; get; }
        public string port { set; get; }
        public string charset { set; get; }
        public string connectionString()
        {
            string file_Path = "database.json";
            string json_file = File.ReadAllText(file_Path);

            Database db = JsonSerializer.Deserialize<Database>(json_file);

            string connection_string = ("Server= {db.server}; Database = {db.database_name};Uid={db.id};" +
                "Pwd = {db.password};Port={db.port};Charset = {db.charset}");
            return connection_string;
            
        }
    }
}
