using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using Dapper;

namespace db_lib.db_conn
{
    public class db_connection
    {
        private string db_file_name = "My_admin_db.db";
        public string Db_file_name
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + db_file_name; }
        }




        public SQLiteConnection db_connect()
        {
            if (System.IO.File.Exists(Db_file_name))
            {
                return new SQLiteConnection($"Data Source={Db_file_name};Version=3;Compress=True;"); 
            }
            else
            {
                CreateDatabase();
                 return new SQLiteConnection($"Data Source={Db_file_name};Version=3;Compress=True;");
            }

            
        }

        private void CreateDatabase()
        {
            SQLiteConnection.CreateFile(Db_file_name);
            using (var cnn = db_connect())
            {
                cnn.Open();
                cnn.Execute(
                    
                @"CREATE TABLE employees (
                id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                code  INTEGER NOT NULL UNIQUE,
                name  TEXT NOT NULL,
                job   TEXT NOT NULL,
                dept  TEXT NOT NULL);");
            }
        }

    }


}

